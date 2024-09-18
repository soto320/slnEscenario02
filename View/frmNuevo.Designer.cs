namespace View
{
    partial class frmNuevo
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblMarca = new Label();
            lblProveedor = new Label();
            lblNumeroExistentes = new Label();
            lblVidaUtil = new Label();
            lblUbicacion = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtMarca = new TextBox();
            txtProveedor = new TextBox();
            txtNumeroExistente = new TextBox();
            txtVidaUtil = new TextBox();
            txtUbicacion = new TextBox();
            lblObligatorio = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(96, 279);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(188, 279);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(62, 14);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(57, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(68, 73);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(68, 104);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca:";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(47, 140);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(64, 15);
            lblProveedor.TabIndex = 2;
            lblProveedor.Text = "Proveedor:";
            // 
            // lblNumeroExistentes
            // 
            lblNumeroExistentes.AutoSize = true;
            lblNumeroExistentes.Location = new Point(5, 174);
            lblNumeroExistentes.Name = "lblNumeroExistentes";
            lblNumeroExistentes.Size = new Size(95, 15);
            lblNumeroExistentes.TabIndex = 2;
            lblNumeroExistentes.Text = "Num. Existentes:";
            // 
            // lblVidaUtil
            // 
            lblVidaUtil.AutoSize = true;
            lblVidaUtil.Location = new Point(60, 208);
            lblVidaUtil.Name = "lblVidaUtil";
            lblVidaUtil.Size = new Size(54, 15);
            lblVidaUtil.TabIndex = 2;
            lblVidaUtil.Text = "Vida Util:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(48, 245);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(63, 15);
            lblUbicacion.TabIndex = 2;
            lblUbicacion.Text = "Ubicacion:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(115, 6);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "C-012";
            txtCodigo.Size = new Size(187, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(115, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Computador";
            txtNombre.Size = new Size(187, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(115, 65);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "20";
            txtPrecio.Size = new Size(187, 23);
            txtPrecio.TabIndex = 3;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(115, 96);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Apple";
            txtMarca.Size = new Size(187, 23);
            txtMarca.TabIndex = 3;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(115, 132);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.PlaceholderText = "Proveedor XYZ";
            txtProveedor.Size = new Size(187, 23);
            txtProveedor.TabIndex = 3;
            // 
            // txtNumeroExistente
            // 
            txtNumeroExistente.Location = new Point(115, 166);
            txtNumeroExistente.Name = "txtNumeroExistente";
            txtNumeroExistente.PlaceholderText = "2";
            txtNumeroExistente.Size = new Size(187, 23);
            txtNumeroExistente.TabIndex = 3;
            // 
            // txtVidaUtil
            // 
            txtVidaUtil.Location = new Point(115, 200);
            txtVidaUtil.Name = "txtVidaUtil";
            txtVidaUtil.PlaceholderText = "2";
            txtVidaUtil.Size = new Size(187, 23);
            txtVidaUtil.TabIndex = 3;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(115, 237);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.PlaceholderText = "Bodega";
            txtUbicacion.Size = new Size(187, 23);
            txtUbicacion.TabIndex = 3;
            // 
            // lblObligatorio
            // 
            lblObligatorio.AutoSize = true;
            lblObligatorio.Location = new Point(308, 14);
            lblObligatorio.Name = "lblObligatorio";
            lblObligatorio.Size = new Size(12, 15);
            lblObligatorio.TabIndex = 4;
            lblObligatorio.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 43);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 4;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 78);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 4;
            label2.Text = "*";
            // 
            // frmNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 332);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblObligatorio);
            Controls.Add(txtUbicacion);
            Controls.Add(txtVidaUtil);
            Controls.Add(txtNumeroExistente);
            Controls.Add(txtProveedor);
            Controls.Add(txtMarca);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblUbicacion);
            Controls.Add(lblVidaUtil);
            Controls.Add(lblNumeroExistentes);
            Controls.Add(lblProveedor);
            Controls.Add(lblMarca);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "frmNuevo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienes";
            Load += frmNuevo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblMarca;
        private Label lblProveedor;
        private Label lblNumeroExistentes;
        private Label lblVidaUtil;
        private Label lblUbicacion;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtMarca;
        private TextBox txtProveedor;
        private TextBox txtNumeroExistente;
        private TextBox txtVidaUtil;
        private TextBox txtUbicacion;
        private Label lblObligatorio;
        private Label label1;
        private Label label2;
    }
}