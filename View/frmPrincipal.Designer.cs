namespace View
{
    partial class frmPrincipal
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
            gpListView = new GroupBox();
            dataGridView = new DataGridView();
            mnStrip = new MenuStrip();
            mnNuevo = new ToolStripMenuItem();
            gpListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            mnStrip.SuspendLayout();
            SuspendLayout();
            // 
            // gpListView
            // 
            gpListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpListView.Controls.Add(dataGridView);
            gpListView.Controls.Add(mnStrip);
            gpListView.Location = new Point(12, 12);
            gpListView.Name = "gpListView";
            gpListView.Size = new Size(776, 419);
            gpListView.TabIndex = 0;
            gpListView.TabStop = false;
            gpListView.Text = "Lista de bienes";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(15, 22);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(695, 391);
            dataGridView.TabIndex = 0;
            // 
            // mnStrip
            // 
            mnStrip.Dock = DockStyle.Right;
            mnStrip.Items.AddRange(new ToolStripItem[] { mnNuevo });
            mnStrip.Location = new Point(647, 19);
            mnStrip.Name = "mnStrip";
            mnStrip.RenderMode = ToolStripRenderMode.Professional;
            mnStrip.Size = new Size(126, 397);
            mnStrip.TabIndex = 1;
            mnStrip.Text = "menuStrip1";
            // 
            // mnNuevo
            // 
            mnNuevo.Name = "mnNuevo";
            mnNuevo.Size = new Size(113, 19);
            mnNuevo.Text = "Nuevo";
            mnNuevo.Click += mnNuevo_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpListView);
            Name = "frmPrincipal";
            Text = "Activo Fijo";
            gpListView.ResumeLayout(false);
            gpListView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            mnStrip.ResumeLayout(false);
            mnStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpListView;
        private DataGridView dataGridView;
        private MenuStrip mnStrip;
        private ToolStripMenuItem mnNuevo;
    }
}
