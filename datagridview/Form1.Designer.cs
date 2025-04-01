namespace datagridview
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
            Tabla2 = new DataGridView();
            cFoto = new DataGridViewImageColumn();
            cNombre = new DataGridViewTextBoxColumn();
            cDireccion = new DataGridViewTextBoxColumn();
            cTelefono = new DataGridViewTextBoxColumn();
            esCasado = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Tabla2).BeginInit();
            SuspendLayout();
            // 
            // Tabla2
            // 
            Tabla2.AllowUserToOrderColumns = true;
            Tabla2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tabla2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            Tabla2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla2.Columns.AddRange(new DataGridViewColumn[] { cFoto, cNombre, cDireccion, cTelefono, esCasado });
            Tabla2.Dock = DockStyle.Fill;
            Tabla2.Location = new Point(0, 0);
            Tabla2.Name = "Tabla2";
            Tabla2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            Tabla2.Size = new Size(534, 271);
            Tabla2.TabIndex = 0;
            Tabla2.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cFoto
            // 
            cFoto.HeaderText = "Foto";
            cFoto.Name = "cFoto";
            // 
            // cNombre
            // 
            cNombre.HeaderText = "Nombre";
            cNombre.Name = "cNombre";
            // 
            // cDireccion
            // 
            cDireccion.HeaderText = "Direccion";
            cDireccion.Name = "cDireccion";
            // 
            // cTelefono
            // 
            cTelefono.HeaderText = "Telefono";
            cTelefono.Name = "cTelefono";
            // 
            // esCasado
            // 
            esCasado.HeaderText = "Casado";
            esCasado.Name = "esCasado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 271);
            Controls.Add(Tabla2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Tabla2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Tabla2;
        private DataGridViewImageColumn cFoto;
        private DataGridViewTextBoxColumn cNombre;
        private DataGridViewTextBoxColumn cDireccion;
        private DataGridViewTextBoxColumn cTelefono;
        private DataGridViewCheckBoxColumn esCasado;
    }
}
