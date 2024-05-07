namespace SIM_TRUCK.capa_presentacion
{
    partial class frmVenderCamion
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
            this.btnVender = new System.Windows.Forms.Button();
            this.dgv_MisCamiones = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MisCamiones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnVender);
            this.panel3.Controls.Add(this.dgv_MisCamiones);
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
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mis camiones";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Crimson;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Location = new System.Drawing.Point(412, 17);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(124, 23);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // dgv_MisCamiones
            // 
            this.dgv_MisCamiones.AllowUserToAddRows = false;
            this.dgv_MisCamiones.AllowUserToDeleteRows = false;
            this.dgv_MisCamiones.AllowUserToResizeColumns = false;
            this.dgv_MisCamiones.AllowUserToResizeRows = false;
            this.dgv_MisCamiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_MisCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MisCamiones.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_MisCamiones.Location = new System.Drawing.Point(13, 55);
            this.dgv_MisCamiones.MultiSelect = false;
            this.dgv_MisCamiones.Name = "dgv_MisCamiones";
            this.dgv_MisCamiones.ReadOnly = true;
            this.dgv_MisCamiones.RowHeadersVisible = false;
            this.dgv_MisCamiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MisCamiones.Size = new System.Drawing.Size(523, 293);
            this.dgv_MisCamiones.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 6;
            // 
            // frmVenderCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmVenderCamion";
            this.Text = "frmVenderCamion";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MisCamiones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.DataGridView dgv_MisCamiones;
        private System.Windows.Forms.Panel panel1;
    }
}