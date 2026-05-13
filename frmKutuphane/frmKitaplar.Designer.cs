namespace frmKutuphane
{
    partial class frmKitaplar
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKitapAdi = new TextBox();
            txtISSN = new TextBox();
            txtYazar = new TextBox();
            btnEkle = new Button();
            kullaniciKitapBindingSource = new BindingSource(components);
            kutuphaneContextBindingSource = new BindingSource(components);
            lbtnOduncAl = new LinkLabel();
            dgwKitaplar = new DataGridView();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kitapAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yazarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ıSSNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Durum = new DataGridViewTextBoxColumn();
            kitapBindingSource1 = new BindingSource(components);
            kitapBindingSource = new BindingSource(components);
            btnSil = new Button();
            label4 = new Label();
            rdnMevcutDegil = new RadioButton();
            rdnMevcut = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)kullaniciKitapBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kutuphaneContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwKitaplar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kitapBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kitapBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 67);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "ISSN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 99);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Yazar";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(144, 23);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(100, 23);
            txtKitapAdi.TabIndex = 3;
            // 
            // txtISSN
            // 
            txtISSN.Location = new Point(144, 59);
            txtISSN.Name = "txtISSN";
            txtISSN.Size = new Size(100, 23);
            txtISSN.TabIndex = 3;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(144, 96);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(100, 23);
            txtYazar.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(150, 185);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(97, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Kitap Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // kullaniciKitapBindingSource
            // 
            kullaniciKitapBindingSource.DataSource = typeof(Entities.KullaniciKitap);
            // 
            // kutuphaneContextBindingSource
            // 
            kutuphaneContextBindingSource.DataSource = typeof(Context.KutuphaneContext);
            // 
            // lbtnOduncAl
            // 
            lbtnOduncAl.AutoSize = true;
            lbtnOduncAl.Location = new Point(50, 193);
            lbtnOduncAl.Name = "lbtnOduncAl";
            lbtnOduncAl.Size = new Size(57, 15);
            lbtnOduncAl.TabIndex = 5;
            lbtnOduncAl.TabStop = true;
            lbtnOduncAl.Text = "Ödünç Al";
            lbtnOduncAl.LinkClicked += lbtnOduncAl_LinkClicked;
            // 
            // dgwKitaplar
            // 
            dgwKitaplar.AllowUserToOrderColumns = true;
            dgwKitaplar.AutoGenerateColumns = false;
            dgwKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwKitaplar.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, kitapAdiDataGridViewTextBoxColumn, yazarDataGridViewTextBoxColumn, ıSSNDataGridViewTextBoxColumn, Durum });
            dgwKitaplar.DataSource = kitapBindingSource1;
            dgwKitaplar.Location = new Point(40, 224);
            dgwKitaplar.Name = "dgwKitaplar";
            dgwKitaplar.Size = new Size(516, 150);
            dgwKitaplar.TabIndex = 6;
            dgwKitaplar.CellContentClick += dgwKitaplar_CellContentClick;
            dgwKitaplar.RowEnter += dgwKitaplar_RowEnter;
            dgwKitaplar.SelectionChanged += dgwKitaplar_SelectionChanged;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            kitapAdiDataGridViewTextBoxColumn.HeaderText = "KitapAdi";
            kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            yazarDataGridViewTextBoxColumn.DataPropertyName = "Yazar";
            yazarDataGridViewTextBoxColumn.HeaderText = "Yazar";
            yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            // 
            // ıSSNDataGridViewTextBoxColumn
            // 
            ıSSNDataGridViewTextBoxColumn.DataPropertyName = "ISSN";
            ıSSNDataGridViewTextBoxColumn.HeaderText = "ISSN";
            ıSSNDataGridViewTextBoxColumn.Name = "ıSSNDataGridViewTextBoxColumn";
            // 
            // Durum
            // 
            Durum.DataPropertyName = "Durum";
            Durum.HeaderText = "Durum";
            Durum.Name = "Durum";
            // 
            // kitapBindingSource1
            // 
            kitapBindingSource1.DataSource = typeof(Entities.Kitap);
            // 
            // kitapBindingSource
            // 
            kitapBindingSource.DataSource = typeof(Entities.Kitap);
            // 
            // btnSil
            // 
            btnSil.Location = new Point(278, 185);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Visible = false;
            btnSil.Click += btnSil_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 139);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 8;
            label4.Text = "Durum";
            // 
            // rdnMevcutDegil
            // 
            rdnMevcutDegil.AutoSize = true;
            rdnMevcutDegil.Location = new Point(146, 139);
            rdnMevcutDegil.Name = "rdnMevcutDegil";
            rdnMevcutDegil.Size = new Size(95, 19);
            rdnMevcutDegil.TabIndex = 9;
            rdnMevcutDegil.TabStop = true;
            rdnMevcutDegil.Text = "Mevcut Değil";
            rdnMevcutDegil.UseVisualStyleBackColor = true;
            rdnMevcutDegil.CheckedChanged += rdnMevcutDegil_CheckedChanged;
            // 
            // rdnMevcut
            // 
            rdnMevcut.AutoSize = true;
            rdnMevcut.Location = new Point(247, 137);
            rdnMevcut.Name = "rdnMevcut";
            rdnMevcut.Size = new Size(65, 19);
            rdnMevcut.TabIndex = 9;
            rdnMevcut.TabStop = true;
            rdnMevcut.Text = "Mevcut";
            rdnMevcut.UseVisualStyleBackColor = true;
            rdnMevcut.CheckedChanged += rdnMevcut_CheckedChanged;
            // 
            // frmKitaplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdnMevcut);
            Controls.Add(rdnMevcutDegil);
            Controls.Add(label4);
            Controls.Add(btnSil);
            Controls.Add(dgwKitaplar);
            Controls.Add(lbtnOduncAl);
            Controls.Add(btnEkle);
            Controls.Add(txtYazar);
            Controls.Add(txtISSN);
            Controls.Add(txtKitapAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKitaplar";
            Text = "frmKitaplar";
            Load += frmKitaplar_Load;
            ((System.ComponentModel.ISupportInitialize)kullaniciKitapBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)kutuphaneContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwKitaplar).EndInit();
            ((System.ComponentModel.ISupportInitialize)kitapBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kitapBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKitapAdi;
        private TextBox txtISSN;
        private TextBox txtYazar;
        private Button btnEkle;
        private BindingSource kullaniciKitapBindingSource;
        private BindingSource kutuphaneContextBindingSource;
        private LinkLabel lbtnOduncAl;
        private DataGridView dgwKitaplar;
        private BindingSource kitapBindingSource;
        private Button btnSil;
        private Label label4;
        private RadioButton rdnMevcutDegil;
        private RadioButton rdnMevcut;
        private BindingSource kitapBindingSource1;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ıSSNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Durum;
    }
}