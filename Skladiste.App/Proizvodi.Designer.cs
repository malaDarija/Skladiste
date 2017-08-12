namespace Skladiste.App
{
    partial class Proizvodi
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
            this.sifraProizvodaLabel = new System.Windows.Forms.Label();
            this.sifraProizvodaTextBox = new System.Windows.Forms.TextBox();
            this.nazivProizvodaLabel = new System.Windows.Forms.Label();
            this.nazivProizvodaTextBox = new System.Windows.Forms.TextBox();
            this.statusProizvodaLabel = new System.Windows.Forms.Label();
            this.statusProizvodaComboBox = new System.Windows.Forms.ComboBox();
            this.izbrisiButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.prikazProizvoda = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prikazProizvoda)).BeginInit();
            this.SuspendLayout();
            // 
            // sifraProizvodaLabel
            // 
            this.sifraProizvodaLabel.AutoSize = true;
            this.sifraProizvodaLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifraProizvodaLabel.Location = new System.Drawing.Point(53, 81);
            this.sifraProizvodaLabel.Name = "sifraProizvodaLabel";
            this.sifraProizvodaLabel.Size = new System.Drawing.Size(96, 16);
            this.sifraProizvodaLabel.TabIndex = 0;
            this.sifraProizvodaLabel.Text = "Šifra proizvoda:";
            // 
            // sifraProizvodaTextBox
            // 
            this.sifraProizvodaTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifraProizvodaTextBox.Location = new System.Drawing.Point(157, 78);
            this.sifraProizvodaTextBox.Name = "sifraProizvodaTextBox";
            this.sifraProizvodaTextBox.Size = new System.Drawing.Size(121, 22);
            this.sifraProizvodaTextBox.TabIndex = 1;
            // 
            // nazivProizvodaLabel
            // 
            this.nazivProizvodaLabel.AutoSize = true;
            this.nazivProizvodaLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivProizvodaLabel.Location = new System.Drawing.Point(48, 126);
            this.nazivProizvodaLabel.Name = "nazivProizvodaLabel";
            this.nazivProizvodaLabel.Size = new System.Drawing.Size(101, 16);
            this.nazivProizvodaLabel.TabIndex = 2;
            this.nazivProizvodaLabel.Text = "Naziv proizvoda:";
            // 
            // nazivProizvodaTextBox
            // 
            this.nazivProizvodaTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivProizvodaTextBox.Location = new System.Drawing.Point(157, 123);
            this.nazivProizvodaTextBox.Name = "nazivProizvodaTextBox";
            this.nazivProizvodaTextBox.Size = new System.Drawing.Size(121, 22);
            this.nazivProizvodaTextBox.TabIndex = 3;
            // 
            // statusProizvodaLabel
            // 
            this.statusProizvodaLabel.AutoSize = true;
            this.statusProizvodaLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusProizvodaLabel.Location = new System.Drawing.Point(41, 167);
            this.statusProizvodaLabel.Name = "statusProizvodaLabel";
            this.statusProizvodaLabel.Size = new System.Drawing.Size(108, 16);
            this.statusProizvodaLabel.TabIndex = 5;
            this.statusProizvodaLabel.Text = "Status proizvoda:";
            // 
            // statusProizvodaComboBox
            // 
            this.statusProizvodaComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusProizvodaComboBox.FormattingEnabled = true;
            this.statusProizvodaComboBox.Items.AddRange(new object[] {
            "Aktivan",
            "Neaktivan"});
            this.statusProizvodaComboBox.Location = new System.Drawing.Point(157, 167);
            this.statusProizvodaComboBox.Name = "statusProizvodaComboBox";
            this.statusProizvodaComboBox.Size = new System.Drawing.Size(121, 24);
            this.statusProizvodaComboBox.TabIndex = 6;
            // 
            // izbrisiButton
            // 
            this.izbrisiButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izbrisiButton.Location = new System.Drawing.Point(56, 222);
            this.izbrisiButton.Name = "izbrisiButton";
            this.izbrisiButton.Size = new System.Drawing.Size(93, 33);
            this.izbrisiButton.TabIndex = 7;
            this.izbrisiButton.Text = "Izbriši";
            this.izbrisiButton.UseVisualStyleBackColor = true;
            // 
            // dodajButton
            // 
            this.dodajButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajButton.Location = new System.Drawing.Point(185, 222);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(93, 33);
            this.dodajButton.TabIndex = 8;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // prikazProizvoda
            // 
            this.prikazProizvoda.AllowUserToAddRows = false;
            this.prikazProizvoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazProizvoda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.prikazProizvoda.Location = new System.Drawing.Point(309, 26);
            this.prikazProizvoda.Name = "prikazProizvoda";
            this.prikazProizvoda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prikazProizvoda.Size = new System.Drawing.Size(592, 283);
            this.prikazProizvoda.TabIndex = 9;
            this.prikazProizvoda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.prikazProizvoda_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Šifra";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Naziv";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            // 
            // Proizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 341);
            this.Controls.Add(this.prikazProizvoda);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.izbrisiButton);
            this.Controls.Add(this.statusProizvodaComboBox);
            this.Controls.Add(this.statusProizvodaLabel);
            this.Controls.Add(this.nazivProizvodaTextBox);
            this.Controls.Add(this.nazivProizvodaLabel);
            this.Controls.Add(this.sifraProizvodaTextBox);
            this.Controls.Add(this.sifraProizvodaLabel);
            this.Name = "Proizvodi";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.Proizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazProizvoda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sifraProizvodaLabel;
        private System.Windows.Forms.TextBox sifraProizvodaTextBox;
        private System.Windows.Forms.Label nazivProizvodaLabel;
        private System.Windows.Forms.TextBox nazivProizvodaTextBox;
        private System.Windows.Forms.Label statusProizvodaLabel;
        private System.Windows.Forms.ComboBox statusProizvodaComboBox;
        private System.Windows.Forms.Button izbrisiButton;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.DataGridView prikazProizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}