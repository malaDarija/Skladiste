namespace Skladiste.App
{
    partial class Prijava
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
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.korisnickoImeLabel = new System.Windows.Forms.Label();
            this.lozinkaLabel = new System.Windows.Forms.Label();
            this.ocistiButton = new System.Windows.Forms.Button();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.zaboravljenaLozinkaLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(142, 36);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(153, 22);
            this.korisnickoImeTextBox.TabIndex = 0;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkaTextBox.Location = new System.Drawing.Point(142, 76);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.PasswordChar = '*';
            this.lozinkaTextBox.Size = new System.Drawing.Size(153, 22);
            this.lozinkaTextBox.TabIndex = 1;
            // 
            // korisnickoImeLabel
            // 
            this.korisnickoImeLabel.AutoSize = true;
            this.korisnickoImeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnickoImeLabel.Location = new System.Drawing.Point(38, 39);
            this.korisnickoImeLabel.Name = "korisnickoImeLabel";
            this.korisnickoImeLabel.Size = new System.Drawing.Size(98, 16);
            this.korisnickoImeLabel.TabIndex = 2;
            this.korisnickoImeLabel.Text = "Korisničko ime:";
            // 
            // lozinkaLabel
            // 
            this.lozinkaLabel.AutoSize = true;
            this.lozinkaLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinkaLabel.Location = new System.Drawing.Point(79, 79);
            this.lozinkaLabel.Name = "lozinkaLabel";
            this.lozinkaLabel.Size = new System.Drawing.Size(57, 16);
            this.lozinkaLabel.TabIndex = 3;
            this.lozinkaLabel.Text = "Lozinka:";
            // 
            // ocistiButton
            // 
            this.ocistiButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocistiButton.Location = new System.Drawing.Point(66, 152);
            this.ocistiButton.Name = "ocistiButton";
            this.ocistiButton.Size = new System.Drawing.Size(75, 29);
            this.ocistiButton.TabIndex = 4;
            this.ocistiButton.Text = "Očisti";
            this.ocistiButton.UseVisualStyleBackColor = true;
            this.ocistiButton.Click += new System.EventHandler(this.ocistiButton_Click);
            // 
            // prijavaButton
            // 
            this.prijavaButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijavaButton.Location = new System.Drawing.Point(220, 152);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(75, 29);
            this.prijavaButton.TabIndex = 5;
            this.prijavaButton.Text = "Prijava";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // zaboravljenaLozinkaLink
            // 
            this.zaboravljenaLozinkaLink.AutoSize = true;
            this.zaboravljenaLozinkaLink.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaboravljenaLozinkaLink.Location = new System.Drawing.Point(169, 111);
            this.zaboravljenaLozinkaLink.Name = "zaboravljenaLozinkaLink";
            this.zaboravljenaLozinkaLink.Size = new System.Drawing.Size(126, 15);
            this.zaboravljenaLozinkaLink.TabIndex = 6;
            this.zaboravljenaLozinkaLink.TabStop = true;
            this.zaboravljenaLozinkaLink.Text = "Zaboravljena lozinka?";
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 207);
            this.Controls.Add(this.zaboravljenaLozinkaLink);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.ocistiButton);
            this.Controls.Add(this.lozinkaLabel);
            this.Controls.Add(this.korisnickoImeLabel);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Label korisnickoImeLabel;
        private System.Windows.Forms.Label lozinkaLabel;
        private System.Windows.Forms.Button ocistiButton;
        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.LinkLabel zaboravljenaLozinkaLink;
    }
}