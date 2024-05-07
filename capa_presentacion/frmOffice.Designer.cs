namespace SIM_TRUCK.capa_presentacion
{
    partial class frmOffice
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvMisEmpleados = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDespedir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnContratar = new System.Windows.Forms.Button();
            this.dgvChoferes = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCamiones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisEmpleados)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.panel4);
            this.pnlContainer.Controls.Add(this.panel3);
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Controls.Add(this.panel1);
            this.pnlContainer.Location = new System.Drawing.Point(1, 1);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(800, 385);
            this.pnlContainer.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel4.Controls.Add(this.dgvMisEmpleados);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnDespedir);
            this.panel4.Location = new System.Drawing.Point(424, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 269);
            this.panel4.TabIndex = 4;
            // 
            // dgvMisEmpleados
            // 
            this.dgvMisEmpleados.AllowUserToAddRows = false;
            this.dgvMisEmpleados.AllowUserToDeleteRows = false;
            this.dgvMisEmpleados.AllowUserToResizeColumns = false;
            this.dgvMisEmpleados.AllowUserToResizeRows = false;
            this.dgvMisEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMisEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisEmpleados.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvMisEmpleados.Location = new System.Drawing.Point(13, 55);
            this.dgvMisEmpleados.MultiSelect = false;
            this.dgvMisEmpleados.Name = "dgvMisEmpleados";
            this.dgvMisEmpleados.ReadOnly = true;
            this.dgvMisEmpleados.RowHeadersVisible = false;
            this.dgvMisEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMisEmpleados.Size = new System.Drawing.Size(325, 198);
            this.dgvMisEmpleados.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mis empleados";
            // 
            // btnDespedir
            // 
            this.btnDespedir.Location = new System.Drawing.Point(214, 17);
            this.btnDespedir.Name = "btnDespedir";
            this.btnDespedir.Size = new System.Drawing.Size(124, 23);
            this.btnDespedir.TabIndex = 2;
            this.btnDespedir.Text = "Despedir";
            this.btnDespedir.UseVisualStyleBackColor = true;
            this.btnDespedir.Click += new System.EventHandler(this.btnDespedir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnContratar);
            this.panel3.Controls.Add(this.dgvChoferes);
            this.panel3.Location = new System.Drawing.Point(31, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 269);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Buscar Choferes";
            // 
            // btnContratar
            // 
            this.btnContratar.Location = new System.Drawing.Point(214, 17);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(124, 23);
            this.btnContratar.TabIndex = 1;
            this.btnContratar.Text = "Contratar";
            this.btnContratar.UseVisualStyleBackColor = true;
            this.btnContratar.Click += new System.EventHandler(this.btnContratar_Click);
            // 
            // dgvChoferes
            // 
            this.dgvChoferes.AllowUserToAddRows = false;
            this.dgvChoferes.AllowUserToDeleteRows = false;
            this.dgvChoferes.AllowUserToResizeColumns = false;
            this.dgvChoferes.AllowUserToResizeRows = false;
            this.dgvChoferes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoferes.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvChoferes.Location = new System.Drawing.Point(13, 55);
            this.dgvChoferes.MultiSelect = false;
            this.dgvChoferes.Name = "dgvChoferes";
            this.dgvChoferes.ReadOnly = true;
            this.dgvChoferes.RowHeadersVisible = false;
            this.dgvChoferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChoferes.Size = new System.Drawing.Size(325, 198);
            this.dgvChoferes.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.lblEmpleados);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(211, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 56);
            this.panel2.TabIndex = 2;
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblEmpleados.Location = new System.Drawing.Point(124, 15);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(24, 25);
            this.lblEmpleados.TabIndex = 1;
            this.lblEmpleados.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Empleados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.lblCamiones);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 56);
            this.panel1.TabIndex = 0;
            // 
            // lblCamiones
            // 
            this.lblCamiones.AutoSize = true;
            this.lblCamiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamiones.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblCamiones.Location = new System.Drawing.Point(124, 15);
            this.lblCamiones.Name = "lblCamiones";
            this.lblCamiones.Size = new System.Drawing.Size(36, 25);
            this.lblCamiones.TabIndex = 1;
            this.lblCamiones.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camiones";
            // 
            // frmOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 387);
            this.Controls.Add(this.pnlContainer);
            this.Name = "frmOffice";
            this.Text = "frmOffice";
            this.pnlContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisEmpleados)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvChoferes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCamiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContratar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDespedir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMisEmpleados;
    }
}