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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbase = new Dbase(servername, database, uid, passwd);
            Fill_Combobox();
        }

        private void Fill_Combobox()
        {
            List<string> listCombobox = new List<string>();
            listCombobox = dbase.QueryToList("show tables;");
            cBKatAuswahl.DataSource = listCombobox;
        }

        private void Fill_Daten()
        {
            dGVFundgegenstand.DataSource = dbase.TableToDataTable(cBKatAuswahl.Text);
            lblCount.Text = dbase.QueryToCell($"SELECT COUNT(*) from {cBKatAuswahl.Text}");
        }

        private void cBKatAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill_Daten();
        }
    }
}