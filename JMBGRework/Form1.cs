using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace JMBGRework
{
    public partial class Form1 : Form
    {
        private string bazaPath;
        private string uid;
        private string cifra;
        private string mestorodjenja;
        public Form1()
        {
            InitializeComponent();
        }

        private void izracunajButton_Click(object sender, EventArgs e)
        {
            DateTime datumRodjenja = dateTimePicker1.Value;
            int godinaZadnjeTri = datumRodjenja.Year % 1000;
            string datum = datumRodjenja.ToString("ddMM") + godinaZadnjeTri.ToString("D3");
            string pol;
            if (drzComboBox.SelectedItem == null)
            {
                MessageBox.Show("Izaberite drzavu/region.");
                return;
            }
            if (regComboBox.SelectedItem == null)
            {
                MessageBox.Show("Izaberite region.");
                return;
            }

            if (checkBoxM.Checked)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 500);
                string randomString = randomNumber.ToString("D3");
                pol = randomString;
            }
            else if (checkBoxZ.Checked)
            {
                Random random = new Random();
                int randomNumber = random.Next(501, 1000);
                string randomString = randomNumber.ToString("D3");
                pol = randomString;
            }
            else
            {
                MessageBox.Show("Izaberite pol.");
                return;
            }
            string jmbg = datum + mestorodjenja + pol;
            int checksum = IzracunajChecksum(jmbg);
            string checksumfilterovan = "";
            if (checksum >= 1 && checksum <= 9)
            { 
                checksumfilterovan = checksum.ToString();
            }
            else if (checksum == 10 || checksum == 11)
            {
            checksumfilterovan = "0"; 
            }

            textBoxOutput.Text = jmbg + checksumfilterovan;
        }
        private int IzracunajChecksum(string jmbg)
        {
            int a = int.Parse(jmbg[0].ToString());
            int b = int.Parse(jmbg[1].ToString());
            int c = int.Parse(jmbg[2].ToString());
            int d = int.Parse(jmbg[3].ToString());
            int e = int.Parse(jmbg[4].ToString());
            int f = int.Parse(jmbg[5].ToString());
            int g = int.Parse(jmbg[6].ToString());
            int h = int.Parse(jmbg[7].ToString());
            int i = int.Parse(jmbg[8].ToString());
            int j = int.Parse(jmbg[9].ToString());
            int k = int.Parse(jmbg[10].ToString());
            int l = int.Parse(jmbg[11].ToString());

            int checksum = 11 - ((7 * (a + g) + 6 * (b + h) + 5 * (c + i) + 4 * (d + j) + 3 * (e + k) + 2 * (f + l)) % 11);
            return checksum;
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog otvoriBazu = new OpenFileDialog();

            otvoriBazu.Title = "Selektuj bazu";
            otvoriBazu.Filter = "Access Baza fajl|*.accdb";
            otvoriBazu.FilterIndex = 1;

            DialogResult result = otvoriBazu.ShowDialog();
            if (result == DialogResult.OK)
            {
                bazaPath = otvoriBazu.FileName;
                UcitajRegioneBaza(bazaPath);
                buttonSelect.Text = "BAZA UCITANA!";
                buttonSelect.ForeColor = Color.Red;
                buttonSelect.Font = new Font(buttonSelect.Font, FontStyle.Bold);
                buttonSelect.UseVisualStyleBackColor = false;
            }
        }
        private void UcitajRegioneBaza(string bazaPath)
        {
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={bazaPath};";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    DataTable schema = connection.GetSchema("Tables");
                    foreach (DataRow row in schema.Rows)
                    {
                        string izabranaTabela = (string)row["TABLE_NAME"];
                        if (!izabranaTabela.StartsWith("MSys"))
                        {
                            drzComboBox.Items.Add(izabranaTabela);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void drzComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string izabranaTabela = drzComboBox.SelectedItem.ToString();
            List<string> regionData = RegionIzTabele(izabranaTabela, bazaPath);
            regComboBox.Items.Clear();
            foreach (string region in regionData)
            {
                regComboBox.Items.Add(region);
            }
        }
        private void regComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selektovanRegion = regComboBox.SelectedItem.ToString();
            string izabranaTabela = drzComboBox.SelectedItem.ToString();
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={bazaPath};";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
                try
            {
                connection.Open();
                string query = $"SELECT UID, Cifra FROM {izabranaTabela} WHERE Region = @region";
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@region", selektovanRegion);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    uid = reader["UID"].ToString();
                    cifra = reader["Cifra"].ToString();
                    mestorodjenja = uid + cifra;
                }
                else
                {
                        MessageBox.Show("Error Ne pronadjeno");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private List<string> RegionIzTabele(string tableName, string bazaPath)
        {
            List<string> regionData = new List<string>();

            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={bazaPath};";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT Region FROM {tableName}";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string region = reader["Region"].ToString();
                                regionData.Add(region);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return regionData;
            }
        }

        private void checkBoxM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxM.Checked)
            {
                checkBoxZ.Checked = false;
            }
        }
        private void checkBoxZ_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxZ.Checked)
            {
                checkBoxM.Checked = false;
            }
        }
    }
}
