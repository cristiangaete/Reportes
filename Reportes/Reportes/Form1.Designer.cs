namespace Reportes
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabReportes = new System.Windows.Forms.TabControl();
            this.tabR196 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuardar196 = new System.Windows.Forms.Button();
            this.ofdAbrirDocumento = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.tabR196.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(14, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 35);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archivo";
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.tabR196);
            this.tabReportes.Controls.Add(this.tabPage2);
            this.tabReportes.Location = new System.Drawing.Point(-2, 84);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.SelectedIndex = 0;
            this.tabReportes.Size = new System.Drawing.Size(969, 457);
            this.tabReportes.TabIndex = 1;
            // 
            // tabR196
            // 
            this.tabR196.Controls.Add(this.btnGuardar196);
            this.tabR196.Controls.Add(this.dataGridView1);
            this.tabR196.Location = new System.Drawing.Point(4, 22);
            this.tabR196.Name = "tabR196";
            this.tabR196.Padding = new System.Windows.Forms.Padding(3);
            this.tabR196.Size = new System.Drawing.Size(961, 431);
            this.tabR196.TabIndex = 0;
            this.tabR196.Text = "Reporte 1.96";
            this.tabR196.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGuardar196
            // 
            this.btnGuardar196.Location = new System.Drawing.Point(714, 376);
            this.btnGuardar196.Name = "btnGuardar196";
            this.btnGuardar196.Size = new System.Drawing.Size(123, 44);
            this.btnGuardar196.TabIndex = 1;
            this.btnGuardar196.Text = "Guardar 1.96";
            this.btnGuardar196.UseVisualStyleBackColor = true;
            // 
            // ofdAbrirDocumento
            // 
            this.ofdAbrirDocumento.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 538);
            this.Controls.Add(this.tabReportes);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            this.tabR196.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabControl tabReportes;
        private System.Windows.Forms.TabPage tabR196;
        private System.Windows.Forms.Button btnGuardar196;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog ofdAbrirDocumento;
    }
}

