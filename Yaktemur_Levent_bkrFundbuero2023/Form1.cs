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
            dbase = new Dbase(servername, database, uid, passwd);
            Fill_Combobox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Fill_Combobox()
        {
            List<string> listCombobox = new List<string>();
            listCombobox = dbase.QueryToList("Select bezeichnung from kategorie;");
            cBKatAuswahl.DataSource = listCombobox;
        }

        private void Fill_Daten()
        {
            dGVFundgegenstand.DataSource = dbase.TableToDataTable2(cBKatAuswahl.Text);
            //lblCount.Text = dbase.QueryToCell($"SELECT COUNT(*) from {cBKatAuswahl.Text}");
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
        
    }
}