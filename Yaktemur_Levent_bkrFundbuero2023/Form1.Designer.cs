namespace Yaktemur_Levent_bkrFundbuero2023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPFundgegenstand = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dGVFundgegenstand = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBKatAuswahl = new System.Windows.Forms.ComboBox();
            this.lblKategorie1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.tPVerlustmeldung = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dTPDatum = new System.Windows.Forms.DateTimePicker();
            this.tBFundgegenstand = new System.Windows.Forms.TextBox();
            this.lblFundgegenstand = new System.Windows.Forms.Label();
            this.lblKategorie2 = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblFundort = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tPLogin = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.tPVermittlung = new System.Windows.Forms.TabPage();
            this.tPStatistik = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tPFundgegenstand.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFundgegenstand)).BeginInit();
            this.panel1.SuspendLayout();
            this.tPVerlustmeldung.SuspendLayout();
            this.tPLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tPStatistik.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.24207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.757932F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.555555F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tPFundgegenstand);
            this.tabControl1.Controls.Add(this.tPVerlustmeldung);
            this.tabControl1.Controls.Add(this.tPLogin);
            this.tabControl1.Controls.Add(this.tPVermittlung);
            this.tabControl1.Controls.Add(this.tPStatistik);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 410);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tPFundgegenstand
            // 
            this.tPFundgegenstand.Controls.Add(this.tableLayoutPanel2);
            this.tPFundgegenstand.Location = new System.Drawing.Point(4, 32);
            this.tPFundgegenstand.Name = "tPFundgegenstand";
            this.tPFundgegenstand.Padding = new System.Windows.Forms.Padding(3);
            this.tPFundgegenstand.Size = new System.Drawing.Size(835, 374);
            this.tPFundgegenstand.TabIndex = 0;
            this.tPFundgegenstand.Text = "Fundgegenstände";
            this.tPFundgegenstand.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.57901F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.42099F));
            this.tableLayoutPanel2.Controls.Add(this.dGVFundgegenstand, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCount, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.03261F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.967391F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(829, 368);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dGVFundgegenstand
            // 
            this.dGVFundgegenstand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFundgegenstand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVFundgegenstand.Location = new System.Drawing.Point(3, 3);
            this.dGVFundgegenstand.Name = "dGVFundgegenstand";
            this.dGVFundgegenstand.RowHeadersWidth = 51;
            this.dGVFundgegenstand.RowTemplate.Height = 29;
            this.dGVFundgegenstand.Size = new System.Drawing.Size(662, 329);
            this.dGVFundgegenstand.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cBKatAuswahl);
            this.panel1.Controls.Add(this.lblKategorie1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(671, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 329);
            this.panel1.TabIndex = 3;
            // 
            // cBKatAuswahl
            // 
            this.cBKatAuswahl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBKatAuswahl.FormattingEnabled = true;
            this.cBKatAuswahl.Location = new System.Drawing.Point(0, 23);
            this.cBKatAuswahl.Name = "cBKatAuswahl";
            this.cBKatAuswahl.Size = new System.Drawing.Size(151, 28);
            this.cBKatAuswahl.TabIndex = 3;
            // 
            // lblKategorie1
            // 
            this.lblKategorie1.AutoSize = true;
            this.lblKategorie1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKategorie1.Location = new System.Drawing.Point(0, 0);
            this.lblKategorie1.Name = "lblKategorie1";
            this.lblKategorie1.Size = new System.Drawing.Size(77, 20);
            this.lblKategorie1.TabIndex = 2;
            this.lblKategorie1.Text = "Kategorie:";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(310, 341);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(48, 20);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Count";
            // 
            // tPVerlustmeldung
            // 
            this.tPVerlustmeldung.Controls.Add(this.textBox2);
            this.tPVerlustmeldung.Controls.Add(this.textBox1);
            this.tPVerlustmeldung.Controls.Add(this.lblTelefon);
            this.tPVerlustmeldung.Controls.Add(this.lblEmail);
            this.tPVerlustmeldung.Controls.Add(this.button1);
            this.tPVerlustmeldung.Controls.Add(this.dTPDatum);
            this.tPVerlustmeldung.Controls.Add(this.tBFundgegenstand);
            this.tPVerlustmeldung.Controls.Add(this.lblFundgegenstand);
            this.tPVerlustmeldung.Controls.Add(this.lblKategorie2);
            this.tPVerlustmeldung.Controls.Add(this.lblDatum);
            this.tPVerlustmeldung.Controls.Add(this.lblFundort);
            this.tPVerlustmeldung.Controls.Add(this.comboBox3);
            this.tPVerlustmeldung.Controls.Add(this.comboBox2);
            this.tPVerlustmeldung.Location = new System.Drawing.Point(4, 32);
            this.tPVerlustmeldung.Name = "tPVerlustmeldung";
            this.tPVerlustmeldung.Padding = new System.Windows.Forms.Padding(3);
            this.tPVerlustmeldung.Size = new System.Drawing.Size(835, 374);
            this.tPVerlustmeldung.TabIndex = 1;
            this.tPVerlustmeldung.Text = "Verlustmeldung";
            this.tPVerlustmeldung.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(56, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 27);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(56, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 27);
            this.textBox1.TabIndex = 14;
            // 
            // lblTelefon
            // 
            this.lblTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(56, 155);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(113, 20);
            this.lblTelefon.TabIndex = 13;
            this.lblTelefon.Text = "Telefonnummer";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(56, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(309, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Verlust melden";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dTPDatum
            // 
            this.dTPDatum.Location = new System.Drawing.Point(370, 51);
            this.dTPDatum.Name = "dTPDatum";
            this.dTPDatum.Size = new System.Drawing.Size(250, 27);
            this.dTPDatum.TabIndex = 10;
            // 
            // tBFundgegenstand
            // 
            this.tBFundgegenstand.Location = new System.Drawing.Point(630, 51);
            this.tBFundgegenstand.Name = "tBFundgegenstand";
            this.tBFundgegenstand.Size = new System.Drawing.Size(185, 27);
            this.tBFundgegenstand.TabIndex = 9;
            // 
            // lblFundgegenstand
            // 
            this.lblFundgegenstand.AutoSize = true;
            this.lblFundgegenstand.Location = new System.Drawing.Point(630, 27);
            this.lblFundgegenstand.Name = "lblFundgegenstand";
            this.lblFundgegenstand.Size = new System.Drawing.Size(119, 20);
            this.lblFundgegenstand.TabIndex = 8;
            this.lblFundgegenstand.Text = "Fundgegenstand";
            // 
            // lblKategorie2
            // 
            this.lblKategorie2.AutoSize = true;
            this.lblKategorie2.Location = new System.Drawing.Point(56, 27);
            this.lblKategorie2.Name = "lblKategorie2";
            this.lblKategorie2.Size = new System.Drawing.Size(74, 20);
            this.lblKategorie2.TabIndex = 5;
            this.lblKategorie2.Text = "Kategorie";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(370, 27);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(54, 20);
            this.lblDatum.TabIndex = 4;
            this.lblDatum.Text = "Datum";
            // 
            // lblFundort
            // 
            this.lblFundort.AutoSize = true;
            this.lblFundort.Location = new System.Drawing.Point(213, 27);
            this.lblFundort.Name = "lblFundort";
            this.lblFundort.Size = new System.Drawing.Size(60, 20);
            this.lblFundort.TabIndex = 3;
            this.lblFundort.Text = "Fundort";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(213, 50);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 28);
            this.comboBox3.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(56, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 0;
            // 
            // tPLogin
            // 
            this.tPLogin.Controls.Add(this.panel2);
            this.tPLogin.Location = new System.Drawing.Point(4, 32);
            this.tPLogin.Name = "tPLogin";
            this.tPLogin.Size = new System.Drawing.Size(835, 374);
            this.tPLogin.TabIndex = 2;
            this.tPLogin.Text = "Admin login";
            this.tPLogin.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tBPassword);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.tBUsername);
            this.panel2.Location = new System.Drawing.Point(86, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 301);
            this.panel2.TabIndex = 5;
            // 
            // tBPassword
            // 
            this.tBPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBPassword.Location = new System.Drawing.Point(136, 107);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(366, 27);
            this.tBPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(219, 269);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(210, 29);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(131, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(136, 84);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // tBUsername
            // 
            this.tBUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBUsername.Location = new System.Drawing.Point(136, 54);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(366, 27);
            this.tBUsername.TabIndex = 1;
            // 
            // tPVermittlung
            // 
            this.tPVermittlung.Location = new System.Drawing.Point(4, 32);
            this.tPVermittlung.Name = "tPVermittlung";
            this.tPVermittlung.Size = new System.Drawing.Size(835, 374);
            this.tPVermittlung.TabIndex = 3;
            this.tPVermittlung.Text = "Vermittlung";
            this.tPVermittlung.UseVisualStyleBackColor = true;
            // 
            // tPStatistik
            // 
            this.tPStatistik.Controls.Add(this.tableLayoutPanel3);
            this.tPStatistik.Location = new System.Drawing.Point(4, 32);
            this.tPStatistik.Name = "tPStatistik";
            this.tPStatistik.Size = new System.Drawing.Size(835, 374);
            this.tPStatistik.TabIndex = 4;
            this.tPStatistik.Text = "Statistik";
            this.tPStatistik.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.02538F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.97462F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.59416F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.40584F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(835, 374);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tPFundgegenstand.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFundgegenstand)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tPVerlustmeldung.ResumeLayout(false);
            this.tPVerlustmeldung.PerformLayout();
            this.tPLogin.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tPStatistik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tPFundgegenstand;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dGVFundgegenstand;
        private Panel panel1;
        private ComboBox cBKatAuswahl;
        private Label lblKategorie1;
        private TabPage tPVerlustmeldung;
        private TextBox tBFundgegenstand;
        private Label lblFundgegenstand;
        private Label lblKategorie2;
        private Label lblDatum;
        private Label lblFundort;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private TabPage tPLogin;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox tBPassword;
        private TextBox tBUsername;
        private Button btnLogin;
        private TabPage tPVermittlung;
        private TabPage tPStatistik;
        private TableLayoutPanel tableLayoutPanel3;
        private DateTimePicker dTPDatum;
        private Panel panel2;
        private Button button1;
        private Label lblCount;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblTelefon;
        private Label lblEmail;
    }
}