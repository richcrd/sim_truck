namespace SIM_TRUCK.capa_presentacion
{
    partial class frmJobs
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.dgvTrabajos = new System.Windows.Forms.DataGridView();
            this.panelContenedor3 = new System.Windows.Forms.FlowLayoutPanel();
            this.CuentaRegresiva = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnAsignar);
            this.panel3.Controls.Add(this.dgvTrabajos);
            this.panel3.Location = new System.Drawing.Point(12, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 363);
            this.panel3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Oferta de Trabajos";
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.Crimson;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Location = new System.Drawing.Point(412, 17);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(124, 23);
            this.btnAsignar.TabIndex = 1;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dgvTrabajos
            // 
            this.dgvTrabajos.AllowUserToAddRows = false;
            this.dgvTrabajos.AllowUserToDeleteRows = false;
            this.dgvTrabajos.AllowUserToResizeColumns = false;
            this.dgvTrabajos.AllowUserToResizeRows = false;
            this.dgvTrabajos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvTrabajos.Location = new System.Drawing.Point(13, 55);
            this.dgvTrabajos.MultiSelect = false;
            this.dgvTrabajos.Name = "dgvTrabajos";
            this.dgvTrabajos.ReadOnly = true;
            this.dgvTrabajos.RowHeadersVisible = false;
            this.dgvTrabajos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrabajos.Size = new System.Drawing.Size(523, 293);
            this.dgvTrabajos.TabIndex = 0;
            // 
            // panelContenedor3
            // 
            this.panelContenedor3.Location = new System.Drawing.Point(589, 29);
            this.panelContenedor3.Name = "panelContenedor3";
            this.panelContenedor3.Size = new System.Drawing.Size(199, 363);
            this.panelContenedor3.TabIndex = 7;
            // 
            // CuentaRegresiva
            // 
            this.CuentaRegresiva.Tick += new System.EventHandler(this.CuentaRegresiva_Tick);
            // 
            // frmJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor3);
            this.Controls.Add(this.panel3);
            this.Name = "frmJobs";
            this.Text = "frmJobs";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DataGridView dgvTrabajos;
        private System.Windows.Forms.FlowLayoutPanel panelContenedor3;
        private System.Windows.Forms.Timer CuentaRegresiva;
    }
}