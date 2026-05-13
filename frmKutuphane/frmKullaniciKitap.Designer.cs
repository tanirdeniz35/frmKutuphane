namespace frmKutuphane
{
    partial class frmKullaniciKitap
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
            dgwKullaniciKitaplar = new DataGridView();
            btnOduncAl = new Button();
            cmbKitaplar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgwKullaniciKitaplar).BeginInit();
            SuspendLayout();
            // 
            // dgwKullaniciKitaplar
            // 
            dgwKullaniciKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwKullaniciKitaplar.Location = new Point(32, 121);
            dgwKullaniciKitaplar.MultiSelect = false;
            dgwKullaniciKitaplar.Name = "dgwKullaniciKitaplar";
            dgwKullaniciKitaplar.Size = new Size(662, 150);
            dgwKullaniciKitaplar.TabIndex = 10;
            dgwKullaniciKitaplar.SelectionChanged += dgwKullaniciKitaplar_SelectionChanged;
            // 
            // btnOduncAl
            // 
            btnOduncAl.Location = new Point(56, 59);
            btnOduncAl.Name = "btnOduncAl";
            btnOduncAl.Size = new Size(75, 23);
            btnOduncAl.TabIndex = 9;
            btnOduncAl.Text = "Ödünç Al";
            btnOduncAl.UseVisualStyleBackColor = true;
            btnOduncAl.Click += btnOduncAl_Click;
            // 
            // cmbKitaplar
            // 
            cmbKitaplar.FormattingEnabled = true;
            cmbKitaplar.Location = new Point(56, 24);
            cmbKitaplar.Name = "cmbKitaplar";
            cmbKitaplar.Size = new Size(121, 23);
            cmbKitaplar.TabIndex = 8;
            // 
            // frmKullaniciKitap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgwKullaniciKitaplar);
            Controls.Add(btnOduncAl);
            Controls.Add(cmbKitaplar);
            Name = "frmKullaniciKitap";
            Text = "frmKullaniciKitap";
            Load += frmKullaniciKitap_Load;
            ((System.ComponentModel.ISupportInitialize)dgwKullaniciKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwKullaniciKitaplar;
        private Button btnOduncAl;
        private ComboBox cmbKitaplar;
    }
}