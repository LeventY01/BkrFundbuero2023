using System.Security.Cryptography;
using System.Text;


namespace Yaktemur_Levent_bkrFundbuero2023
{
    public partial class Form1 : Form
    {

        string servername = "localhost";
        string database = "bkr_fundbuero";
        string uid = "root";
        string passwd = ";";
        Dbase dbase;
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tPVermittlung);
            tabControl1.TabPages.Remove(tPStatistik);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbase = new Dbase(servername, database, uid, passwd);

            Fill_Combobox();
            FillFundortComboBox();


        }

        private void Fill_Combobox()
        {
            cBKatAuswahl.Items.Clear();
            List<string> listData = dbase.QueryToList("SELECT Bezeichnung FROM kategorie;");
            foreach (string item in listData)
            {
                cBKatAuswahl.Items.Add(item);
            }

            // fill the comboBox3 with fundort data
            comboBox3.Items.Clear();
            listData = dbase.QueryToList("SELECT Bezeichnung FROM fundort;");
            foreach (string item in listData)
            {
                comboBox3.Items.Add(item);
            }

        }

        private void Fill_Daten()
        {
            dGVFundgegenstand.Rows.Clear();
            dGVFundgegenstand.ColumnCount = 2;
            dGVFundgegenstand.Columns[0].Name = "Beschreibung";
            dGVFundgegenstand.Columns[1].Name = "Funddatum";
            List<string[]> listData = dbase.QueryToArrayList($"""
                SELECT Beschreibung, DATE_FORMAT(Funddatum, '%d.%m.%Y') as Funddatum 
                FROM fundgegenstand
                WHERE KatID = '{cBKatAuswahl.SelectedIndex + 1}';

                """);
            foreach (string[] item in listData)
            {
                dGVFundgegenstand.Rows.Add(item);
            }
            lblCount.Text = dbase.QueryToCell($"SELECT COUNT(*) FROM fundgegenstand" +
                $" WHERE KatID = '{cBKatAuswahl.SelectedIndex + 1}';");
        }



        private void cBKatAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill_Daten();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (dbase.QueryToBool($"SELECT * FROM login WHERE User = '{tBUsername.Text}' AND Pass = '{SHA256(tBPassword.Text)}';"))
            {
                tabControl1.TabPages.Add(tPVermittlung);
                tabControl1.TabPages.Add(tPStatistik);
                tabControl1.TabPages.Remove(tPLogin);
                tBUsername.Clear();
                tBPassword.Clear();
            }
        }
        private static string SHA256(string clearText)
        {
            var sb = new StringBuilder();
            var bytes = Encoding.UTF8.GetBytes(clearText);
            var algo = HashAlgorithm.Create(nameof(SHA256));
            var hash = algo.ComputeHash(bytes);
            foreach (var byt in hash)
                sb.Append(byt.ToString("x2"));
            return sb.ToString();
        }

        private void btnAbmelden_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tPVermittlung);
            tabControl1.TabPages.Remove(tPStatistik);
            tabControl1.TabPages.Add(tPLogin);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (dbase.QueryToBool($"SELECT * FROM login WHERE User = '{tBUsername.Text}' AND Pass = '{SHA256(tBPassword.Text)}';"))
            {
                tabControl1.TabPages.Add(tPVermittlung);
                tabControl1.TabPages.Add(tPStatistik);
                tabControl1.TabPages.Remove(tPLogin);
                tBUsername.Clear();
                tBPassword.Clear();
            }
        }

        private void dGVFundgegenstand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FillFundortComboBox()
        {
            comboBox3.Items.Clear();
            List<string> fundortList = dbase.QueryToList("SELECT Bezeichnung FROM fundort");
            foreach (string fundort in fundortList)
            {
                comboBox3.Items.Add(fundort);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string beschreibung = textBox3.Text;
            string fundort = comboBox3.SelectedItem.ToString();
            DateTime verlustdatum = dTPDatum.Value;
            string telefonnummer = textBox2.Text;
            string email = textBox1.Text;
            string eigentumNr = tBFundgegenstand.Text;


            string fundortID = dbase.QueryToCell($"SELECT FundortID FROM fundort WHERE Bezeichnung = '{fundort}'");

            dbase.QueryToList($"INSERT INTO verlustmeldung (Beschreibung, VerlustOrt, Verlustdatum, Telefonnummer, EMail, EigentumNr) " +
       $"VALUES ('{beschreibung}', '{fundortID}', '{verlustdatum:yyyy-MM-dd}', '{telefonnummer}', '{email}', '{eigentumNr}');");

            MessageBox.Show("Erfolgreich Aufgegeben!");


            textBox3.Clear();
            comboBox3.SelectedIndex = -1;
            dTPDatum.Value = DateTime.Now;
            tBFundgegenstand.Clear();
            textBox2.Clear();
            textBox1.Clear();
        }
    }
}