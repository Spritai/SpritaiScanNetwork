using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpritaiScanNetwork
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialisation si nécessaire
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Event inutile sauf si tu veux validation automatique
        }

        private void portEnd_ValueChanged(object sender, EventArgs e)
        {
            // Event inutile sauf si tu veux validation automatique
        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            int startPort = (int)portStart.Value;
            int endPort = (int)portEnd.Value;

            if (startPort > endPort)
            {
                MessageBox.Show("Le port de début doit être inférieur ou égal au port de fin.");
                return;
            }

            btnScan.Enabled = false;
            listBoxResults.Items.Clear();
            progressBar.Value = 0;
            progressBar.Maximum = endPort - startPort + 1;

            for (int port = startPort; port <= endPort; port++)
            {
                int currentPort = port;

                await Task.Run(() =>
                {
                    try
                    {
                        using (TcpClient tcpClient = new TcpClient())
                        {
                            var task = tcpClient.ConnectAsync("127.0.0.1", currentPort);
                            if (task.Wait(100)) // Timeout de 100ms
                            {
                                Invoke(new Action(() =>
                                {
                                    listBoxResults.Items.Add(new MaterialListBoxItem($"Port {currentPort} : OUVERT"));
                                }));
                            }
                        }
                    }
                    catch
                    {
                        // Port fermé ou non accessible – on ignore
                    }

                    Invoke(new Action(() =>
                    {
                        progressBar.Value++;
                    }));
                });
            }

            btnScan.Enabled = true;
            MessageBox.Show("Scan terminé !");
        }

        private void listBoxResults_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            // Optionnel : afficher plus d'infos ou copier
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            // Rien ici non plus
        }

        private void txtBaseIP_Click(object sender, EventArgs e)
        {

        }

        private void numericIpStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericIpEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}