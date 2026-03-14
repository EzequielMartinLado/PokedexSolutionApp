namespace Pokedex
{
    partial class PokedexForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PokemonPictureBox = new System.Windows.Forms.PictureBox();
            this.PokemonDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.EliminarFisicoButton = new System.Windows.Forms.Button();
            this.EliminarLogicoButton = new System.Windows.Forms.Button();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.FiltroTextBox = new System.Windows.Forms.TextBox();
            this.CriterioComboBox = new System.Windows.Forms.ComboBox();
            this.CampoComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroBDTextBox = new System.Windows.Forms.TextBox();
            this.FiltroBDLabel = new System.Windows.Forms.Label();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.CampoLabel = new System.Windows.Forms.Label();
            this.FiltroButton = new System.Windows.Forms.Button();
            this.FiltroTituloLabel = new System.Windows.Forms.Label();
            this.FiltroTituloAvanzadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PokemonPictureBox
            // 
            this.PokemonPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PokemonPictureBox.Location = new System.Drawing.Point(576, 130);
            this.PokemonPictureBox.Name = "PokemonPictureBox";
            this.PokemonPictureBox.Size = new System.Drawing.Size(227, 226);
            this.PokemonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PokemonPictureBox.TabIndex = 0;
            this.PokemonPictureBox.TabStop = false;
            // 
            // PokemonDataGridView
            // 
            this.PokemonDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PokemonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PokemonDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PokemonDataGridView.Location = new System.Drawing.Point(12, 130);
            this.PokemonDataGridView.MultiSelect = false;
            this.PokemonDataGridView.Name = "PokemonDataGridView";
            this.PokemonDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PokemonDataGridView.Size = new System.Drawing.Size(557, 226);
            this.PokemonDataGridView.TabIndex = 1;
            this.PokemonDataGridView.TabStop = false;
            this.PokemonDataGridView.SelectionChanged += new System.EventHandler(this.PokemonDataGridView_SelectionChanged);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AgregarButton.Location = new System.Drawing.Point(12, 365);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 5;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModificarButton.Location = new System.Drawing.Point(112, 365);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 6;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // EliminarFisicoButton
            // 
            this.EliminarFisicoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EliminarFisicoButton.Location = new System.Drawing.Point(212, 365);
            this.EliminarFisicoButton.Name = "EliminarFisicoButton";
            this.EliminarFisicoButton.Size = new System.Drawing.Size(93, 23);
            this.EliminarFisicoButton.TabIndex = 7;
            this.EliminarFisicoButton.Text = "Eliminar físico";
            this.EliminarFisicoButton.UseVisualStyleBackColor = true;
            this.EliminarFisicoButton.Click += new System.EventHandler(this.EliminarFisicoButton_Click);
            // 
            // EliminarLogicoButton
            // 
            this.EliminarLogicoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EliminarLogicoButton.Location = new System.Drawing.Point(329, 365);
            this.EliminarLogicoButton.Name = "EliminarLogicoButton";
            this.EliminarLogicoButton.Size = new System.Drawing.Size(93, 23);
            this.EliminarLogicoButton.TabIndex = 8;
            this.EliminarLogicoButton.Text = "Eliminar lógico";
            this.EliminarLogicoButton.UseVisualStyleBackColor = true;
            this.EliminarLogicoButton.Click += new System.EventHandler(this.EliminarLogicoButton_Click);
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Location = new System.Drawing.Point(19, 42);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(29, 13);
            this.FiltroLabel.TabIndex = 6;
            this.FiltroLabel.Text = "Filtro";
            // 
            // FiltroTextBox
            // 
            this.FiltroTextBox.Location = new System.Drawing.Point(66, 39);
            this.FiltroTextBox.Name = "FiltroTextBox";
            this.FiltroTextBox.Size = new System.Drawing.Size(121, 20);
            this.FiltroTextBox.TabIndex = 0;
            this.FiltroTextBox.TextChanged += new System.EventHandler(this.FiltroTextBox_TextChanged);
            // 
            // CriterioComboBox
            // 
            this.CriterioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CriterioComboBox.FormattingEnabled = true;
            this.CriterioComboBox.Location = new System.Drawing.Point(250, 90);
            this.CriterioComboBox.Name = "CriterioComboBox";
            this.CriterioComboBox.Size = new System.Drawing.Size(121, 21);
            this.CriterioComboBox.TabIndex = 2;
            // 
            // CampoComboBox
            // 
            this.CampoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CampoComboBox.FormattingEnabled = true;
            this.CampoComboBox.Location = new System.Drawing.Point(66, 90);
            this.CampoComboBox.Name = "CampoComboBox";
            this.CampoComboBox.Size = new System.Drawing.Size(121, 21);
            this.CampoComboBox.TabIndex = 1;
            this.CampoComboBox.SelectedIndexChanged += new System.EventHandler(this.CampoComboBox_SelectedIndexChanged);
            // 
            // FiltroBDTextBox
            // 
            this.FiltroBDTextBox.Location = new System.Drawing.Point(424, 90);
            this.FiltroBDTextBox.Name = "FiltroBDTextBox";
            this.FiltroBDTextBox.Size = new System.Drawing.Size(124, 20);
            this.FiltroBDTextBox.TabIndex = 3;
            // 
            // FiltroBDLabel
            // 
            this.FiltroBDLabel.AutoSize = true;
            this.FiltroBDLabel.Location = new System.Drawing.Point(383, 94);
            this.FiltroBDLabel.Name = "FiltroBDLabel";
            this.FiltroBDLabel.Size = new System.Drawing.Size(29, 13);
            this.FiltroBDLabel.TabIndex = 16;
            this.FiltroBDLabel.Text = "Filtro";
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Location = new System.Drawing.Point(199, 94);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(39, 13);
            this.CriterioLabel.TabIndex = 15;
            this.CriterioLabel.Text = "Criterio";
            // 
            // CampoLabel
            // 
            this.CampoLabel.AutoSize = true;
            this.CampoLabel.Location = new System.Drawing.Point(14, 94);
            this.CampoLabel.Name = "CampoLabel";
            this.CampoLabel.Size = new System.Drawing.Size(40, 13);
            this.CampoLabel.TabIndex = 14;
            this.CampoLabel.Text = "Campo";
            // 
            // FiltroButton
            // 
            this.FiltroButton.Location = new System.Drawing.Point(560, 89);
            this.FiltroButton.Name = "FiltroButton";
            this.FiltroButton.Size = new System.Drawing.Size(75, 23);
            this.FiltroButton.TabIndex = 4;
            this.FiltroButton.Text = "Filtrar";
            this.FiltroButton.UseVisualStyleBackColor = true;
            this.FiltroButton.Click += new System.EventHandler(this.FiltroButton_Click);
            // 
            // FiltroTituloLabel
            // 
            this.FiltroTituloLabel.AutoSize = true;
            this.FiltroTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroTituloLabel.Location = new System.Drawing.Point(62, 9);
            this.FiltroTituloLabel.Name = "FiltroTituloLabel";
            this.FiltroTituloLabel.Size = new System.Drawing.Size(99, 20);
            this.FiltroTituloLabel.TabIndex = 20;
            this.FiltroTituloLabel.Text = "Filtro Rápido";
            // 
            // FiltroTituloAvanzadoLabel
            // 
            this.FiltroTituloAvanzadoLabel.AutoSize = true;
            this.FiltroTituloAvanzadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroTituloAvanzadoLabel.Location = new System.Drawing.Point(62, 66);
            this.FiltroTituloAvanzadoLabel.Name = "FiltroTituloAvanzadoLabel";
            this.FiltroTituloAvanzadoLabel.Size = new System.Drawing.Size(119, 20);
            this.FiltroTituloAvanzadoLabel.TabIndex = 21;
            this.FiltroTituloAvanzadoLabel.Text = "Filtro Avanzado";
            // 
            // PokedexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 399);
            this.Controls.Add(this.FiltroTituloAvanzadoLabel);
            this.Controls.Add(this.FiltroTituloLabel);
            this.Controls.Add(this.CriterioComboBox);
            this.Controls.Add(this.CampoComboBox);
            this.Controls.Add(this.FiltroBDTextBox);
            this.Controls.Add(this.FiltroBDLabel);
            this.Controls.Add(this.CriterioLabel);
            this.Controls.Add(this.CampoLabel);
            this.Controls.Add(this.FiltroButton);
            this.Controls.Add(this.FiltroTextBox);
            this.Controls.Add(this.FiltroLabel);
            this.Controls.Add(this.EliminarLogicoButton);
            this.Controls.Add(this.EliminarFisicoButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.PokemonDataGridView);
            this.Controls.Add(this.PokemonPictureBox);
            this.MinimumSize = new System.Drawing.Size(830, 416);
            this.Name = "PokedexForm";
            this.Text = "Pokedex";
            this.Load += new System.EventHandler(this.frmPokedex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PokemonPictureBox;
        private System.Windows.Forms.DataGridView PokemonDataGridView;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button EliminarFisicoButton;
        private System.Windows.Forms.Button EliminarLogicoButton;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.TextBox FiltroTextBox;
        private System.Windows.Forms.ComboBox CriterioComboBox;
        private System.Windows.Forms.ComboBox CampoComboBox;
        private System.Windows.Forms.TextBox FiltroBDTextBox;
        private System.Windows.Forms.Label FiltroBDLabel;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.Label CampoLabel;
        private System.Windows.Forms.Button FiltroButton;
        private System.Windows.Forms.Label FiltroTituloLabel;
        private System.Windows.Forms.Label FiltroTituloAvanzadoLabel;
    }
}

