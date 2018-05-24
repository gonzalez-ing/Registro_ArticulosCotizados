namespace Registro_Articulos.UI.Consultar
{
    partial class ConsultarArticulos
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
            this.BuscarFiltrobutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltrartextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarFiltrobutton
            // 
            this.BuscarFiltrobutton.BackColor = System.Drawing.Color.Lime;
            this.BuscarFiltrobutton.Image = global::Registro_Articulos.Properties.Resources.find;
            this.BuscarFiltrobutton.Location = new System.Drawing.Point(399, 54);
            this.BuscarFiltrobutton.Name = "BuscarFiltrobutton";
            this.BuscarFiltrobutton.Size = new System.Drawing.Size(80, 40);
            this.BuscarFiltrobutton.TabIndex = 32;
            this.BuscarFiltrobutton.UseVisualStyleBackColor = false;
            this.BuscarFiltrobutton.Click += new System.EventHandler(this.BuscarFiltrobutton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Buscar";
            // 
            // FiltrartextBox
            // 
            this.FiltrartextBox.Location = new System.Drawing.Point(219, 74);
            this.FiltrartextBox.Name = "FiltrartextBox";
            this.FiltrartextBox.Size = new System.Drawing.Size(174, 20);
            this.FiltrartextBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Filtrar por:";
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Items.AddRange(new object[] {
            "ArticuloId",
            "Descripcion",
            "Precio"});
            this.FiltrarcomboBox.Location = new System.Drawing.Point(12, 73);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(186, 21);
            this.FiltrarcomboBox.TabIndex = 28;
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 100);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(467, 178);
            this.ConsultadataGridView.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(98, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Consulta De Articulos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConsultarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(493, 290);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BuscarFiltrobutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltrartextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.ConsultadataGridView);
            this.Name = "ConsultarArticulos";
            this.Text = "ConsultarArticulos";
            this.Load += new System.EventHandler(this.ConsultarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarFiltrobutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FiltrartextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Label label6;
    }
}