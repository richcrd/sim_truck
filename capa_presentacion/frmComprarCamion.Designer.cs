namespace SIM_TRUCK.capa_presentacion
{
    partial class frmComprarCamion
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.dgv_Camiones = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Camiones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnComprar);
            this.panel3.Controls.Add(this.dgv_Camiones);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 363);
            this.panel3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Camiones en Venta";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(415, 17);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(124, 23);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // dgv_Camiones
            // 
            this.dgv_Camiones.AllowUserToAddRows = false;
            this.dgv_Camiones.AllowUserToDeleteRows = false;
            this.dgv_Camiones.AllowUserToResizeColumns = false;
            this.dgv_Camiones.AllowUserToResizeRows = false;
            this.dgv_Camiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Camiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Camiones.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_Camiones.Location = new System.Drawing.Point(13, 55);
            this.dgv_Camiones.MultiSelect = false;
            this.dgv_Camiones.Name = "dgv_Camiones";
            this.dgv_Camiones.RowHeadersVisible = false;
            this.dgv_Camiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Camiones.Size = new System.Drawing.Size(526, 290);
            this.dgv_Camiones.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 387);
            this.panel1.TabIndex = 5;
            // 
            // frmComprarCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 387);
            this.Controls.Add(this.panel1);
            this.Name = "frmComprarCamion";
            this.Text = "frmComprarCamion";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Camiones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.DataGridView dgv_Camiones;
        private System.Windows.Forms.Panel panel1;
    }
}