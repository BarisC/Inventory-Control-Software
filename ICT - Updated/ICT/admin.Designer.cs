namespace ICT
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.olcuBox = new System.Windows.Forms.ComboBox();
            this.ondalikBox = new System.Windows.Forms.ComboBox();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.paraBox2 = new System.Windows.Forms.ComboBox();
            this.kolonText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.projeSahibi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.projeAdi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sifreTxtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.path = new MaterialSkin.Controls.MaterialLabel();
            this.pathEk = new MaterialSkin.Controls.MaterialLabel();
            this.encText = new MaterialSkin.Controls.MaterialLabel();
            this.kolonLabel = new MaterialSkin.Controls.MaterialLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(502, 386);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(72, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Oluştur";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Projenin Sahibi : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.materialLabel2.Location = new System.Drawing.Point(498, 323);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Şifre Giriniz !";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 35);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(122, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Projenin Adı      : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.olcuBox);
            this.groupBox1.Controls.Add(this.ondalikBox);
            this.groupBox1.Controls.Add(this.materialFlatButton2);
            this.groupBox1.Controls.Add(this.paraBox2);
            this.groupBox1.Controls.Add(this.kolonText);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(16, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 208);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kolon Bilgileri";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 87);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(89, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Kolon Tipi : ";
            // 
            // olcuBox
            // 
            this.olcuBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.olcuBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.olcuBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.olcuBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.olcuBox.FormattingEnabled = true;
            this.olcuBox.Items.AddRange(new object[] {
            "km",
            "m",
            "cm",
            "mm",
            "dm2",
            "km2",
            "m2",
            "cm2",
            "m3/dak",
            "m3"});
            this.olcuBox.Location = new System.Drawing.Point(246, 85);
            this.olcuBox.Name = "olcuBox";
            this.olcuBox.Size = new System.Drawing.Size(121, 21);
            this.olcuBox.TabIndex = 17;
            // 
            // ondalikBox
            // 
            this.ondalikBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ondalikBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ondalikBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ondalikBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ondalikBox.FormattingEnabled = true;
            this.ondalikBox.Items.AddRange(new object[] {
            "Ondalıklı",
            "Ondalıksız"});
            this.ondalikBox.Location = new System.Drawing.Point(246, 85);
            this.ondalikBox.Name = "ondalikBox";
            this.ondalikBox.Size = new System.Drawing.Size(121, 21);
            this.ondalikBox.TabIndex = 16;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(305, 163);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(118, 36);
            this.materialFlatButton2.TabIndex = 15;
            this.materialFlatButton2.Text = "Sonraki Kolon";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2_Click);
            // 
            // paraBox2
            // 
            this.paraBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paraBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paraBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paraBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paraBox2.FormattingEnabled = true;
            this.paraBox2.Items.AddRange(new object[] {
            "TRY",
            "EURO",
            "DOLAR",
            "YEN",
            "STERLIN"});
            this.paraBox2.Location = new System.Drawing.Point(246, 85);
            this.paraBox2.Name = "paraBox2";
            this.paraBox2.Size = new System.Drawing.Size(121, 21);
            this.paraBox2.TabIndex = 14;
            // 
            // kolonText
            // 
            this.kolonText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kolonText.Depth = 0;
            this.kolonText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolonText.Hint = "";
            this.kolonText.Location = new System.Drawing.Point(107, 37);
            this.kolonText.MouseState = MaterialSkin.MouseState.HOVER;
            this.kolonText.Name = "kolonText";
            this.kolonText.PasswordChar = '\0';
            this.kolonText.SelectedText = "";
            this.kolonText.SelectionLength = 0;
            this.kolonText.SelectionStart = 0;
            this.kolonText.Size = new System.Drawing.Size(201, 23);
            this.kolonText.TabIndex = 11;
            this.kolonText.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 39);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(86, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Kolon Adı : ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Metin",
            "Sayı",
            "Para Birimi",
            "Ölçü Birimi",
            "Koordinat"});
            this.comboBox1.Location = new System.Drawing.Point(103, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // projeSahibi
            // 
            this.projeSahibi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.projeSahibi.Depth = 0;
            this.projeSahibi.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projeSahibi.Hint = "";
            this.projeSahibi.Location = new System.Drawing.Point(150, 7);
            this.projeSahibi.MouseState = MaterialSkin.MouseState.HOVER;
            this.projeSahibi.Name = "projeSahibi";
            this.projeSahibi.PasswordChar = '\0';
            this.projeSahibi.SelectedText = "";
            this.projeSahibi.SelectionLength = 0;
            this.projeSahibi.SelectionStart = 0;
            this.projeSahibi.Size = new System.Drawing.Size(136, 23);
            this.projeSahibi.TabIndex = 13;
            this.projeSahibi.UseSystemPasswordChar = false;
            // 
            // projeAdi
            // 
            this.projeAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.projeAdi.Depth = 0;
            this.projeAdi.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projeAdi.Hint = "";
            this.projeAdi.Location = new System.Drawing.Point(150, 36);
            this.projeAdi.MouseState = MaterialSkin.MouseState.HOVER;
            this.projeAdi.Name = "projeAdi";
            this.projeAdi.PasswordChar = '\0';
            this.projeAdi.SelectedText = "";
            this.projeAdi.SelectionLength = 0;
            this.projeAdi.SelectionStart = 0;
            this.projeAdi.Size = new System.Drawing.Size(136, 23);
            this.projeAdi.TabIndex = 14;
            this.projeAdi.UseSystemPasswordChar = false;
            // 
            // sifreTxtBox
            // 
            this.sifreTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifreTxtBox.Depth = 0;
            this.sifreTxtBox.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxtBox.Hint = "";
            this.sifreTxtBox.Location = new System.Drawing.Point(477, 354);
            this.sifreTxtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.sifreTxtBox.Name = "sifreTxtBox";
            this.sifreTxtBox.PasswordChar = '\0';
            this.sifreTxtBox.SelectedText = "";
            this.sifreTxtBox.SelectionLength = 0;
            this.sifreTxtBox.SelectionStart = 0;
            this.sifreTxtBox.Size = new System.Drawing.Size(136, 23);
            this.sifreTxtBox.TabIndex = 14;
            this.sifreTxtBox.UseSystemPasswordChar = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(452, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 200);
            this.listBox1.TabIndex = 26;
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Depth = 0;
            this.path.Font = new System.Drawing.Font("Roboto", 11F);
            this.path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.path.Location = new System.Drawing.Point(498, 209);
            this.path.MouseState = MaterialSkin.MouseState.HOVER;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(108, 19);
            this.path.TabIndex = 27;
            this.path.Text = "materialLabel6";
            // 
            // pathEk
            // 
            this.pathEk.AutoSize = true;
            this.pathEk.Depth = 0;
            this.pathEk.Font = new System.Drawing.Font("Roboto", 11F);
            this.pathEk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pathEk.Location = new System.Drawing.Point(530, 121);
            this.pathEk.MouseState = MaterialSkin.MouseState.HOVER;
            this.pathEk.Name = "pathEk";
            this.pathEk.Size = new System.Drawing.Size(15, 19);
            this.pathEk.TabIndex = 28;
            this.pathEk.Text = "\\";
            // 
            // encText
            // 
            this.encText.AutoSize = true;
            this.encText.Depth = 0;
            this.encText.Font = new System.Drawing.Font("Roboto", 11F);
            this.encText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.encText.Location = new System.Drawing.Point(498, 153);
            this.encText.MouseState = MaterialSkin.MouseState.HOVER;
            this.encText.Name = "encText";
            this.encText.Size = new System.Drawing.Size(108, 19);
            this.encText.TabIndex = 29;
            this.encText.Text = "materialLabel6";
            // 
            // kolonLabel
            // 
            this.kolonLabel.AutoSize = true;
            this.kolonLabel.Depth = 0;
            this.kolonLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.kolonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kolonLabel.Location = new System.Drawing.Point(513, 59);
            this.kolonLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.kolonLabel.Name = "kolonLabel";
            this.kolonLabel.Size = new System.Drawing.Size(65, 19);
            this.kolonLabel.TabIndex = 30;
            this.kolonLabel.Text = "Kolonlar";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 443);
            this.Controls.Add(this.kolonLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pathEk);
            this.Controls.Add(this.sifreTxtBox);
            this.Controls.Add(this.projeAdi);
            this.Controls.Add(this.projeSahibi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.encText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "admin";
            this.Text = " Inventory Collection Tool - Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField kolonText;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField projeSahibi;
        private MaterialSkin.Controls.MaterialSingleLineTextField projeAdi;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField sifreTxtBox;
        private System.Windows.Forms.ComboBox paraBox2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.ComboBox ondalikBox;
        private System.Windows.Forms.ComboBox olcuBox;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MaterialSkin.Controls.MaterialLabel path;
        private MaterialSkin.Controls.MaterialLabel pathEk;
        private MaterialSkin.Controls.MaterialLabel encText;
        private MaterialSkin.Controls.MaterialLabel kolonLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}