namespace Poekedex
{
    partial class RegistroAltaPokemonForms
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
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.NumeroLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.TipoLabel = new System.Windows.Forms.Label();
            this.DebilidadLabel = new System.Windows.Forms.Label();
            this.TipoComboBox = new System.Windows.Forms.ComboBox();
            this.DebilidadComboBox = new System.Windows.Forms.ComboBox();
            this.urlImagenTextBox = new System.Windows.Forms.TextBox();
            this.urlImagenLabel = new System.Windows.Forms.Label();
            this.PokemonPictureBox = new System.Windows.Forms.PictureBox();
            this.CargarImgLocalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(70, 354);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 6;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(294, 354);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 7;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.AutoSize = true;
            this.NumeroLabel.Location = new System.Drawing.Point(93, 78);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(44, 13);
            this.NumeroLabel.TabIndex = 2;
            this.NumeroLabel.Text = "Número";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(93, 117);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(44, 13);
            this.NombreLabel.TabIndex = 3;
            this.NombreLabel.Text = "Nombre";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(93, 156);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescripcionLabel.TabIndex = 4;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(189, 75);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(121, 20);
            this.NumeroTextBox.TabIndex = 0;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(189, 153);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(121, 20);
            this.DescripcionTextBox.TabIndex = 2;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(189, 114);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(121, 20);
            this.NombreTextBox.TabIndex = 1;
            // 
            // TipoLabel
            // 
            this.TipoLabel.AutoSize = true;
            this.TipoLabel.Location = new System.Drawing.Point(93, 234);
            this.TipoLabel.Name = "TipoLabel";
            this.TipoLabel.Size = new System.Drawing.Size(28, 13);
            this.TipoLabel.TabIndex = 8;
            this.TipoLabel.Text = "Tipo";
            // 
            // DebilidadLabel
            // 
            this.DebilidadLabel.AutoSize = true;
            this.DebilidadLabel.Location = new System.Drawing.Point(93, 273);
            this.DebilidadLabel.Name = "DebilidadLabel";
            this.DebilidadLabel.Size = new System.Drawing.Size(51, 13);
            this.DebilidadLabel.TabIndex = 9;
            this.DebilidadLabel.Text = "Debilidad";
            // 
            // TipoComboBox
            // 
            this.TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoComboBox.FormattingEnabled = true;
            this.TipoComboBox.Location = new System.Drawing.Point(189, 231);
            this.TipoComboBox.Name = "TipoComboBox";
            this.TipoComboBox.Size = new System.Drawing.Size(121, 21);
            this.TipoComboBox.TabIndex = 4;
            // 
            // DebilidadComboBox
            // 
            this.DebilidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DebilidadComboBox.FormattingEnabled = true;
            this.DebilidadComboBox.Location = new System.Drawing.Point(189, 271);
            this.DebilidadComboBox.Name = "DebilidadComboBox";
            this.DebilidadComboBox.Size = new System.Drawing.Size(121, 21);
            this.DebilidadComboBox.TabIndex = 5;
            // 
            // urlImagenTextBox
            // 
            this.urlImagenTextBox.Location = new System.Drawing.Point(189, 192);
            this.urlImagenTextBox.Name = "urlImagenTextBox";
            this.urlImagenTextBox.Size = new System.Drawing.Size(121, 20);
            this.urlImagenTextBox.TabIndex = 3;
            this.urlImagenTextBox.Leave += new System.EventHandler(this.urlImagenTextBox_Leave);
            // 
            // urlImagenLabel
            // 
            this.urlImagenLabel.AutoSize = true;
            this.urlImagenLabel.Location = new System.Drawing.Point(93, 195);
            this.urlImagenLabel.Name = "urlImagenLabel";
            this.urlImagenLabel.Size = new System.Drawing.Size(58, 13);
            this.urlImagenLabel.TabIndex = 11;
            this.urlImagenLabel.Text = "Url Imagen";
            // 
            // PokemonPictureBox
            // 
            this.PokemonPictureBox.Location = new System.Drawing.Point(358, 75);
            this.PokemonPictureBox.Name = "PokemonPictureBox";
            this.PokemonPictureBox.Size = new System.Drawing.Size(227, 226);
            this.PokemonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PokemonPictureBox.TabIndex = 12;
            this.PokemonPictureBox.TabStop = false;
            // 
            // CargarImgLocalButton
            // 
            this.CargarImgLocalButton.Location = new System.Drawing.Point(316, 192);
            this.CargarImgLocalButton.Name = "CargarImgLocalButton";
            this.CargarImgLocalButton.Size = new System.Drawing.Size(23, 20);
            this.CargarImgLocalButton.TabIndex = 13;
            this.CargarImgLocalButton.Text = "+";
            this.CargarImgLocalButton.UseVisualStyleBackColor = true;
            this.CargarImgLocalButton.Click += new System.EventHandler(this.CargarImgLocalButton_Click);
            // 
            // RegistroAltaPokemonForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 437);
            this.Controls.Add(this.CargarImgLocalButton);
            this.Controls.Add(this.PokemonPictureBox);
            this.Controls.Add(this.urlImagenTextBox);
            this.Controls.Add(this.urlImagenLabel);
            this.Controls.Add(this.DebilidadComboBox);
            this.Controls.Add(this.TipoComboBox);
            this.Controls.Add(this.DebilidadLabel);
            this.Controls.Add(this.TipoLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.NumeroLabel);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Name = "RegistroAltaPokemonForms";
            this.Text = "Alta Pokemon";
            this.Load += new System.EventHandler(this.RegistroAltaPokemonForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label NumeroLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label TipoLabel;
        private System.Windows.Forms.Label DebilidadLabel;
        private System.Windows.Forms.ComboBox TipoComboBox;
        private System.Windows.Forms.ComboBox DebilidadComboBox;
        private System.Windows.Forms.TextBox urlImagenTextBox;
        private System.Windows.Forms.Label urlImagenLabel;
        private System.Windows.Forms.PictureBox PokemonPictureBox;
        private System.Windows.Forms.Button CargarImgLocalButton;
    }
}