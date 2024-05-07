namespace SIM_TRUCK.capa_presentacion
{
    partial class frmAsignarViaje
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
            this.cbxCamion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxChofer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.cbxCamion);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbxChofer);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnTrabajar);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 216);
            this.panel3.TabIndex = 6;
            // 
            // cbxCamion
            // 
            this.cbxCamion.FormattingEnabled = true;
            this.cbxCamion.Location = new System.Drawing.Point(158, 100);
            this.cbxCamion.Name = "cbxCamion";
            this.cbxCamion.Size = new System.Drawing.Size(121, 21);
            this.cbxCamion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Escoger Camion:";
            // 
            // cbxChofer
            // 
            this.cbxChofer.FormattingEnabled = true;
            this.cbxChofer.Location = new System.Drawing.Point(22, 100);
            this.cbxChofer.Name = "cbxChofer";
            this.cbxChofer.Size = new System.Drawing.Size(121, 21);
            this.cbxChofer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escoger Chofer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Asignar Trabajo";
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.BackColor = System.Drawing.Color.Crimson;
            this.btnTrabajar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrabajar.ForeColor = System.Drawing.Color.White;
            this.btnTrabajar.Location = new System.Drawing.Point(158, 147);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(121, 23);
            this.btnTrabajar.TabIndex = 1;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = false;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // frmAsignarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 246);
            this.Controls.Add(this.panel3);
            this.Name = "frmAsignarViaje";
            this.Text = "frmAsignarViaje";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.ComboBox cbxCamion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxChofer;
        private System.Windows.Forms.Label label1;
    }
}