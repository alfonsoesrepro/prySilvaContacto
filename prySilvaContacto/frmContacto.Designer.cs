namespace prySilvaContacto
{
    partial class frmContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContacto));
            lblContacto = new Label();
            lblTelefono = new Label();
            cmdGrabar = new Button();
            txtContacto = new TextBox();
            mskTelefono = new MaskedTextBox();
            lstDatos = new ListBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(39, 83);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(56, 15);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(43, 150);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Teléfono";
            // 
            // cmdGrabar
            // 
            cmdGrabar.Location = new Point(302, 201);
            cmdGrabar.Name = "cmdGrabar";
            cmdGrabar.Size = new Size(75, 23);
            cmdGrabar.TabIndex = 2;
            cmdGrabar.Text = "Grabar";
            cmdGrabar.UseVisualStyleBackColor = true;
            cmdGrabar.Click += cmdGrabar_Click;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(277, 75);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 3;
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(277, 142);
            mskTelefono.Mask = "000-0000";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(100, 23);
            mskTelefono.TabIndex = 4;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 15;
            lstDatos.Location = new Point(35, 248);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(342, 49);
            lstDatos.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 21);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Ingrese los datos de contacto";
            // 
            // frmContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(475, 341);
            Controls.Add(lblTitulo);
            Controls.Add(lstDatos);
            Controls.Add(mskTelefono);
            Controls.Add(txtContacto);
            Controls.Add(cmdGrabar);
            Controls.Add(lblTelefono);
            Controls.Add(lblContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmContacto";
            Text = "Contactos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblTelefono;
        private Button cmdGrabar;
        private TextBox txtContacto;
        private MaskedTextBox mskTelefono;
        private ListBox lstDatos;
        private Label lblTitulo;
    }
}
