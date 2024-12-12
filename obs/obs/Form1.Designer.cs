namespace obs
{
    partial class AnaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewOgrenciler = new System.Windows.Forms.DataGridView();
            this.dataGridViewDersler = new System.Windows.Forms.DataGridView();
            this.textBoxDersAdi = new System.Windows.Forms.TextBox();
            this.textBoxKredi = new System.Windows.Forms.TextBox();
            this.textBoxKontenjan = new System.Windows.Forms.TextBox();
            this.buttonDersEkle = new System.Windows.Forms.Button();
            this.textBoxOgrenciID = new System.Windows.Forms.TextBox();
            this.textBoxDersID = new System.Windows.Forms.TextBox();
            this.buttonDersSec = new System.Windows.Forms.Button();
            this.textBoxDersSecimID = new System.Windows.Forms.TextBox();
            this.buttonOnayla = new System.Windows.Forms.Button();
            this.ogrenciDersSecimDataSet = new obs.OgrenciDersSecimDataSet();
            this.ogrenciDersSecimDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.derslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.derslerTableAdapter = new obs.OgrenciDersSecimDataSetTableAdapters.DerslerTableAdapter();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciDanismanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciDanismanTableAdapter = new obs.OgrenciDersSecimDataSetTableAdapters.OgrenciDanismanTableAdapter();
            this.danismanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danismanlarTableAdapter = new obs.OgrenciDersSecimDataSetTableAdapters.DanismanlarTableAdapter();
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrencilerTableAdapter = new obs.OgrenciDersSecimDataSetTableAdapters.OgrencilerTableAdapter();
            this.ogrenciDanismanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dersIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krediDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontenjanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayıtlıSayısıDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derslerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dersSecimleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersSecimleriTableAdapter = new obs.OgrenciDersSecimDataSetTableAdapters.DersSecimleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersSecimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersSecimDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDanismanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danismanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDanismanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersSecimleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOgrenciler
            // 
            this.dataGridViewOgrenciler.AutoGenerateColumns = false;
            this.dataGridViewOgrenciler.ColumnHeadersHeight = 29;
            this.dataGridViewOgrenciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersIDDataGridViewTextBoxColumn});
            this.dataGridViewOgrenciler.DataSource = this.dersSecimleriBindingSource;
            this.dataGridViewOgrenciler.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            this.dataGridViewOgrenciler.RowHeadersWidth = 51;
            this.dataGridViewOgrenciler.Size = new System.Drawing.Size(181, 150);
            this.dataGridViewOgrenciler.TabIndex = 0;
            // 
            // dataGridViewDersler
            // 
            this.dataGridViewDersler.AutoGenerateColumns = false;
            this.dataGridViewDersler.ColumnHeadersHeight = 29;
            this.dataGridViewDersler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersIDDataGridViewTextBoxColumn1,
            this.dersAdiDataGridViewTextBoxColumn1,
            this.krediDataGridViewTextBoxColumn1,
            this.kontenjanDataGridViewTextBoxColumn1,
            this.kayıtlıSayısıDataGridViewTextBoxColumn1});
            this.dataGridViewDersler.DataSource = this.derslerBindingSource;
            this.dataGridViewDersler.Location = new System.Drawing.Point(-53, 250);
            this.dataGridViewDersler.Name = "dataGridViewDersler";
            this.dataGridViewDersler.RowHeadersWidth = 51;
            this.dataGridViewDersler.Size = new System.Drawing.Size(678, 150);
            this.dataGridViewDersler.TabIndex = 1;
            // 
            // textBoxDersAdi
            // 
            this.textBoxDersAdi.Location = new System.Drawing.Point(285, 21);
            this.textBoxDersAdi.Name = "textBoxDersAdi";
            this.textBoxDersAdi.Size = new System.Drawing.Size(150, 22);
            this.textBoxDersAdi.TabIndex = 2;
            // 
            // textBoxKredi
            // 
            this.textBoxKredi.Location = new System.Drawing.Point(285, 49);
            this.textBoxKredi.Name = "textBoxKredi";
            this.textBoxKredi.Size = new System.Drawing.Size(150, 22);
            this.textBoxKredi.TabIndex = 3;
            // 
            // textBoxKontenjan
            // 
            this.textBoxKontenjan.Location = new System.Drawing.Point(285, 77);
            this.textBoxKontenjan.Name = "textBoxKontenjan";
            this.textBoxKontenjan.Size = new System.Drawing.Size(150, 22);
            this.textBoxKontenjan.TabIndex = 4;
            // 
            // buttonDersEkle
            // 
            this.buttonDersEkle.Location = new System.Drawing.Point(285, 105);
            this.buttonDersEkle.Name = "buttonDersEkle";
            this.buttonDersEkle.Size = new System.Drawing.Size(150, 30);
            this.buttonDersEkle.TabIndex = 5;
            this.buttonDersEkle.Text = "Ders Ekle";
            this.buttonDersEkle.UseVisualStyleBackColor = true;
            this.buttonDersEkle.Click += new System.EventHandler(this.buttonDersEkle_Click);
            // 
            // textBoxOgrenciID
            // 
            this.textBoxOgrenciID.Location = new System.Drawing.Point(669, 227);
            this.textBoxOgrenciID.Name = "textBoxOgrenciID";
            this.textBoxOgrenciID.Size = new System.Drawing.Size(150, 22);
            this.textBoxOgrenciID.TabIndex = 6;
            // 
            // textBoxDersID
            // 
            this.textBoxDersID.Location = new System.Drawing.Point(669, 250);
            this.textBoxDersID.Name = "textBoxDersID";
            this.textBoxDersID.Size = new System.Drawing.Size(150, 22);
            this.textBoxDersID.TabIndex = 7;
            // 
            // buttonDersSec
            // 
            this.buttonDersSec.Location = new System.Drawing.Point(669, 278);
            this.buttonDersSec.Name = "buttonDersSec";
            this.buttonDersSec.Size = new System.Drawing.Size(150, 30);
            this.buttonDersSec.TabIndex = 8;
            this.buttonDersSec.Text = "Ders Seç";
            this.buttonDersSec.UseVisualStyleBackColor = true;
            this.buttonDersSec.Click += new System.EventHandler(this.buttonDersSec_Click);
            // 
            // textBoxDersSecimID
            // 
            this.textBoxDersSecimID.Location = new System.Drawing.Point(669, 326);
            this.textBoxDersSecimID.Name = "textBoxDersSecimID";
            this.textBoxDersSecimID.Size = new System.Drawing.Size(150, 22);
            this.textBoxDersSecimID.TabIndex = 9;
            // 
            // buttonOnayla
            // 
            this.buttonOnayla.Location = new System.Drawing.Point(669, 354);
            this.buttonOnayla.Name = "buttonOnayla";
            this.buttonOnayla.Size = new System.Drawing.Size(150, 30);
            this.buttonOnayla.TabIndex = 10;
            this.buttonOnayla.Text = "Ders Onayla";
            this.buttonOnayla.UseVisualStyleBackColor = true;
            this.buttonOnayla.Click += new System.EventHandler(this.buttonOnayla_Click);
            // 
            // ogrenciDersSecimDataSet
            // 
            this.ogrenciDersSecimDataSet.DataSetName = "OgrenciDersSecimDataSet";
            this.ogrenciDersSecimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciDersSecimDataSetBindingSource
            // 
            this.ogrenciDersSecimDataSetBindingSource.DataSource = this.ogrenciDersSecimDataSet;
            this.ogrenciDersSecimDataSetBindingSource.Position = 0;
            // 
            // derslerBindingSource
            // 
            this.derslerBindingSource.DataMember = "Dersler";
            this.derslerBindingSource.DataSource = this.ogrenciDersSecimDataSetBindingSource;
            // 
            // derslerTableAdapter
            // 
            this.derslerTableAdapter.ClearBeforeFill = true;
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            this.dersIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dersIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciDanismanBindingSource
            // 
            this.ogrenciDanismanBindingSource.DataMember = "OgrenciDanisman";
            this.ogrenciDanismanBindingSource.DataSource = this.ogrenciDersSecimDataSetBindingSource;
            // 
            // ogrenciDanismanTableAdapter
            // 
            this.ogrenciDanismanTableAdapter.ClearBeforeFill = true;
            // 
            // danismanlarBindingSource
            // 
            this.danismanlarBindingSource.DataMember = "Danismanlar";
            this.danismanlarBindingSource.DataSource = this.ogrenciDersSecimDataSetBindingSource;
            // 
            // danismanlarTableAdapter
            // 
            this.danismanlarTableAdapter.ClearBeforeFill = true;
            // 
            // ogrencilerBindingSource
            // 
            this.ogrencilerBindingSource.DataMember = "Ogrenciler";
            this.ogrencilerBindingSource.DataSource = this.ogrenciDersSecimDataSetBindingSource;
            // 
            // ogrencilerTableAdapter
            // 
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciDanismanBindingSource1
            // 
            this.ogrenciDanismanBindingSource1.DataMember = "OgrenciDanisman";
            this.ogrenciDanismanBindingSource1.DataSource = this.ogrenciDersSecimDataSetBindingSource;
            // 
            // dersIDDataGridViewTextBoxColumn1
            // 
            this.dersIDDataGridViewTextBoxColumn1.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn1.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dersIDDataGridViewTextBoxColumn1.Name = "dersIDDataGridViewTextBoxColumn1";
            this.dersIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dersIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dersAdiDataGridViewTextBoxColumn1
            // 
            this.dersAdiDataGridViewTextBoxColumn1.DataPropertyName = "DersAdi";
            this.dersAdiDataGridViewTextBoxColumn1.HeaderText = "DersAdi";
            this.dersAdiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dersAdiDataGridViewTextBoxColumn1.Name = "dersAdiDataGridViewTextBoxColumn1";
            this.dersAdiDataGridViewTextBoxColumn1.Width = 125;
            // 
            // krediDataGridViewTextBoxColumn1
            // 
            this.krediDataGridViewTextBoxColumn1.DataPropertyName = "Kredi";
            this.krediDataGridViewTextBoxColumn1.HeaderText = "Kredi";
            this.krediDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.krediDataGridViewTextBoxColumn1.Name = "krediDataGridViewTextBoxColumn1";
            this.krediDataGridViewTextBoxColumn1.Width = 125;
            // 
            // kontenjanDataGridViewTextBoxColumn1
            // 
            this.kontenjanDataGridViewTextBoxColumn1.DataPropertyName = "Kontenjan";
            this.kontenjanDataGridViewTextBoxColumn1.HeaderText = "Kontenjan";
            this.kontenjanDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kontenjanDataGridViewTextBoxColumn1.Name = "kontenjanDataGridViewTextBoxColumn1";
            this.kontenjanDataGridViewTextBoxColumn1.Width = 125;
            // 
            // kayıtlıSayısıDataGridViewTextBoxColumn1
            // 
            this.kayıtlıSayısıDataGridViewTextBoxColumn1.DataPropertyName = "KayıtlıSayısı";
            this.kayıtlıSayısıDataGridViewTextBoxColumn1.HeaderText = "KayıtlıSayısı";
            this.kayıtlıSayısıDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kayıtlıSayısıDataGridViewTextBoxColumn1.Name = "kayıtlıSayısıDataGridViewTextBoxColumn1";
            this.kayıtlıSayısıDataGridViewTextBoxColumn1.Width = 125;
            // 
            // derslerBindingSource1
            // 
            this.derslerBindingSource1.DataMember = "Dersler";
            this.derslerBindingSource1.DataSource = this.ogrenciDersSecimDataSetBindingSource;
            // 
            // dersSecimleriBindingSource
            // 
            this.dersSecimleriBindingSource.DataMember = "DersSecimleri";
            this.dersSecimleriBindingSource.DataSource = this.ogrenciDersSecimDataSetBindingSource;
            // 
            // dersSecimleriTableAdapter
            // 
            this.dersSecimleriTableAdapter.ClearBeforeFill = true;
            // 
            // AnaForm
            // 
            this.ClientSize = new System.Drawing.Size(1198, 450);
            this.Controls.Add(this.buttonOnayla);
            this.Controls.Add(this.textBoxDersSecimID);
            this.Controls.Add(this.buttonDersSec);
            this.Controls.Add(this.textBoxDersID);
            this.Controls.Add(this.textBoxOgrenciID);
            this.Controls.Add(this.buttonDersEkle);
            this.Controls.Add(this.textBoxKontenjan);
            this.Controls.Add(this.textBoxKredi);
            this.Controls.Add(this.textBoxDersAdi);
            this.Controls.Add(this.dataGridViewDersler);
            this.Controls.Add(this.dataGridViewOgrenciler);
            this.Name = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersSecimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDersSecimDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDanismanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danismanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDanismanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersSecimleriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewOgrenciler;
        private System.Windows.Forms.DataGridView dataGridViewDersler;
        private System.Windows.Forms.TextBox textBoxDersAdi;
        private System.Windows.Forms.TextBox textBoxKredi;
        private System.Windows.Forms.TextBox textBoxKontenjan;
        private System.Windows.Forms.Button buttonDersEkle;
        private System.Windows.Forms.TextBox textBoxOgrenciID;
        private System.Windows.Forms.TextBox textBoxDersID;
        private System.Windows.Forms.Button buttonDersSec;
        private System.Windows.Forms.TextBox textBoxDersSecimID;
        private System.Windows.Forms.Button buttonOnayla;
        private System.Windows.Forms.BindingSource ogrenciDersSecimDataSetBindingSource;
        private OgrenciDersSecimDataSet ogrenciDersSecimDataSet;
        private System.Windows.Forms.BindingSource derslerBindingSource;
        private OgrenciDersSecimDataSetTableAdapters.DerslerTableAdapter derslerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ogrenciDanismanBindingSource;
        private OgrenciDersSecimDataSetTableAdapters.OgrenciDanismanTableAdapter ogrenciDanismanTableAdapter;
        private System.Windows.Forms.BindingSource danismanlarBindingSource;
        private OgrenciDersSecimDataSetTableAdapters.DanismanlarTableAdapter danismanlarTableAdapter;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private OgrenciDersSecimDataSetTableAdapters.OgrencilerTableAdapter ogrencilerTableAdapter;
        private System.Windows.Forms.BindingSource derslerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn krediDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontenjanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayıtlıSayısıDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource ogrenciDanismanBindingSource1;
        private System.Windows.Forms.BindingSource dersSecimleriBindingSource;
        private OgrenciDersSecimDataSetTableAdapters.DersSecimleriTableAdapter dersSecimleriTableAdapter;
    }
}
