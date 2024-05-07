namespace SIM_TRUCK
{
    partial class frmHome
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuOffice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuTravelStat = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuDriverStat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCamiones = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmComprarC = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmVenderC = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlHeader.Controls.Add(this.btnCerrarSesion);
            this.pnlHeader.Controls.Add(this.panel1);
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 41);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(201, 8);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(98, 23);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.lblMoney);
            this.panel1.Location = new System.Drawing.Point(688, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 30);
            this.panel1.TabIndex = 9;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(21, 6);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(64, 17);
            this.lblMoney.TabIndex = 8;
            this.lblMoney.Text = "9999999";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(64, 11);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(131, 17);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pnlContainer);
            this.panel2.Controls.Add(this.menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 409);
            this.panel2.TabIndex = 2;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 24);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(800, 385);
            this.pnlContainer.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOffice,
            this.menuJobs,
            this.menuStatus,
            this.menuCamiones});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuOffice
            // 
            this.menuOffice.Name = "menuOffice";
            this.menuOffice.Size = new System.Drawing.Size(57, 20);
            this.menuOffice.Text = "Oficina";
            this.menuOffice.Click += new System.EventHandler(this.menuOffice_Click);
            // 
            // menuJobs
            // 
            this.menuJobs.Name = "menuJobs";
            this.menuJobs.Size = new System.Drawing.Size(57, 20);
            this.menuJobs.Text = "Trabajo";
            this.menuJobs.Click += new System.EventHandler(this.menuJobs_Click);
            // 
            // menuStatus
            // 
            this.menuStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuTravelStat,
            this.submenuDriverStat});
            this.menuStatus.Name = "menuStatus";
            this.menuStatus.Size = new System.Drawing.Size(54, 20);
            this.menuStatus.Text = "Estado";
            // 
            // submenuTravelStat
            // 
            this.submenuTravelStat.Name = "submenuTravelStat";
            this.submenuTravelStat.Size = new System.Drawing.Size(180, 22);
            this.submenuTravelStat.Text = "Estado Viajes";
            this.submenuTravelStat.Click += new System.EventHandler(this.submenuTravelStat_Click);
            // 
            // submenuDriverStat
            // 
            this.submenuDriverStat.Name = "submenuDriverStat";
            this.submenuDriverStat.Size = new System.Drawing.Size(180, 22);
            this.submenuDriverStat.Text = "Estado Conductores";
            this.submenuDriverStat.Click += new System.EventHandler(this.submenuDriverStat_Click);
            // 
            // menuCamiones
            // 
            this.menuCamiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmComprarC,
            this.sbmVenderC});
            this.menuCamiones.Name = "menuCamiones";
            this.menuCamiones.Size = new System.Drawing.Size(72, 20);
            this.menuCamiones.Text = "Camiones";
            // 
            // sbmComprarC
            // 
            this.sbmComprarC.Name = "sbmComprarC";
            this.sbmComprarC.Size = new System.Drawing.Size(180, 22);
            this.sbmComprarC.Text = "Comprar";
            this.sbmComprarC.Click += new System.EventHandler(this.sbmComprarC_Click);
            // 
            // sbmVenderC
            // 
            this.sbmVenderC.Name = "sbmVenderC";
            this.sbmVenderC.Size = new System.Drawing.Size(180, 22);
            this.sbmVenderC.Text = "Vender";
            this.sbmVenderC.Click += new System.EventHandler(this.sbmVenderC_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuOffice;
        private System.Windows.Forms.ToolStripMenuItem menuJobs;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ToolStripMenuItem menuStatus;
        private System.Windows.Forms.ToolStripMenuItem submenuTravelStat;
        private System.Windows.Forms.ToolStripMenuItem submenuDriverStat;
        private System.Windows.Forms.ToolStripMenuItem menuCamiones;
        private System.Windows.Forms.ToolStripMenuItem sbmComprarC;
        private System.Windows.Forms.ToolStripMenuItem sbmVenderC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}

