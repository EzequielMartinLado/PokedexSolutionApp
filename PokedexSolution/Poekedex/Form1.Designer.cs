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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.EliminarFisicoButton = new System.Windows.Forms.Button();
            this.EliminarLogicoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PokemonPictureBox
            // 
            this.PokemonPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PokemonPictureBox.Location = new System.Drawing.Point(575, 55);
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
            this.PokemonDataGridView.Location = new System.Drawing.Point(12, 55);
            this.PokemonDataGridView.MultiSelect = false;
            this.PokemonDataGridView.Name = "PokemonDataGridView";
            this.PokemonDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PokemonDataGridView.Size = new System.Drawing.Size(557, 226);
            this.PokemonDataGridView.TabIndex = 1;
            this.PokemonDataGridView.SelectionChanged += new System.EventHandler(this.PokemonDataGridView_SelectionChanged);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AgregarButton.Location = new System.Drawing.Point(41, 321);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 2;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModificarButton.Location = new System.Drawing.Point(141, 321);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 3;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // EliminarFisicoButton
            // 
            this.EliminarFisicoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EliminarFisicoButton.Location = new System.Drawing.Point(241, 321);
            this.EliminarFisicoButton.Name = "EliminarFisicoButton";
            this.EliminarFisicoButton.Size = new System.Drawing.Size(93, 23);
            this.EliminarFisicoButton.TabIndex = 4;
            this.EliminarFisicoButton.Text = "Eliminar físico";
            this.EliminarFisicoButton.UseVisualStyleBackColor = true;
            this.EliminarFisicoButton.Click += new System.EventHandler(this.EliminarFisicoButton_Click);
            // 
            // EliminarLogicoButton
            // 
            this.EliminarLogicoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EliminarLogicoButton.Location = new System.Drawing.Point(358, 321);
            this.EliminarLogicoButton.Name = "EliminarLogicoButton";
            this.EliminarLogicoButton.Size = new System.Drawing.Size(93, 23);
            this.EliminarLogicoButton.TabIndex = 5;
            this.EliminarLogicoButton.Text = "Eliminar lógico";
            this.EliminarLogicoButton.UseVisualStyleBackColor = true;
            this.EliminarLogicoButton.Click += new System.EventHandler(this.EliminarLogicoButton_Click);
            // 
            // PokedexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 377);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox PokemonPictureBox;
        private System.Windows.Forms.DataGridView PokemonDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button EliminarFisicoButton;
        private System.Windows.Forms.Button EliminarLogicoButton;
    }
}

