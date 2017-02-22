namespace PestControlManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mbtnlogin = new MetroFramework.Controls.MetroButton();
            this.mbtnTechnicians = new MetroFramework.Controls.MetroButton();
            this.mbtnPesticides = new MetroFramework.Controls.MetroButton();
            this.mbtnCustomerTechnician = new MetroFramework.Controls.MetroButton();
            this.mbtnCustomers = new MetroFramework.Controls.MetroButton();
            this.mbtnShowhide = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroPanel1.Controls.Add(this.mbtnlogin);
            this.metroPanel1.Controls.Add(this.mbtnTechnicians);
            this.metroPanel1.Controls.Add(this.mbtnPesticides);
            this.metroPanel1.Controls.Add(this.mbtnCustomerTechnician);
            this.metroPanel1.Controls.Add(this.mbtnCustomers);
            this.metroPanel1.Controls.Add(this.mbtnShowhide);
            this.metroPanel1.ForeColor = System.Drawing.Color.White;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(153, 396);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mbtnlogin
            // 
            this.mbtnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mbtnlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mbtnlogin.BackgroundImage")));
            this.mbtnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbtnlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mbtnlogin.Location = new System.Drawing.Point(14, 77);
            this.mbtnlogin.Name = "mbtnlogin";
            this.mbtnlogin.Size = new System.Drawing.Size(116, 23);
            this.mbtnlogin.TabIndex = 2;
            this.mbtnlogin.Text = "Login";
            this.mbtnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mbtnlogin.UseCustomForeColor = true;
            this.mbtnlogin.UseSelectable = true;
            this.mbtnlogin.Click += new System.EventHandler(this.mbtnlogin_Click);
            // 
            // mbtnTechnicians
            // 
            this.mbtnTechnicians.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mbtnTechnicians.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mbtnTechnicians.BackgroundImage")));
            this.mbtnTechnicians.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbtnTechnicians.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mbtnTechnicians.Location = new System.Drawing.Point(14, 131);
            this.mbtnTechnicians.Name = "mbtnTechnicians";
            this.mbtnTechnicians.Size = new System.Drawing.Size(116, 23);
            this.mbtnTechnicians.TabIndex = 3;
            this.mbtnTechnicians.Text = "Technicians";
            this.mbtnTechnicians.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mbtnTechnicians.UseCustomForeColor = true;
            this.mbtnTechnicians.UseSelectable = true;
            this.mbtnTechnicians.Click += new System.EventHandler(this.mbtnTechnicians_Click);
            // 
            // mbtnPesticides
            // 
            this.mbtnPesticides.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mbtnPesticides.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mbtnPesticides.BackgroundImage")));
            this.mbtnPesticides.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbtnPesticides.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mbtnPesticides.Location = new System.Drawing.Point(14, 314);
            this.mbtnPesticides.Name = "mbtnPesticides";
            this.mbtnPesticides.Size = new System.Drawing.Size(116, 23);
            this.mbtnPesticides.TabIndex = 6;
            this.mbtnPesticides.Text = "Pesticides";
            this.mbtnPesticides.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mbtnPesticides.UseCustomForeColor = true;
            this.mbtnPesticides.UseSelectable = true;
            // 
            // mbtnCustomerTechnician
            // 
            this.mbtnCustomerTechnician.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mbtnCustomerTechnician.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mbtnCustomerTechnician.BackgroundImage")));
            this.mbtnCustomerTechnician.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbtnCustomerTechnician.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mbtnCustomerTechnician.Location = new System.Drawing.Point(14, 253);
            this.mbtnCustomerTechnician.Name = "mbtnCustomerTechnician";
            this.mbtnCustomerTechnician.Size = new System.Drawing.Size(116, 23);
            this.mbtnCustomerTechnician.TabIndex = 5;
            this.mbtnCustomerTechnician.Text = "          CustomerTechnician";
            this.mbtnCustomerTechnician.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mbtnCustomerTechnician.UseCustomForeColor = true;
            this.mbtnCustomerTechnician.UseSelectable = true;
            // 
            // mbtnCustomers
            // 
            this.mbtnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mbtnCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mbtnCustomers.BackgroundImage")));
            this.mbtnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbtnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mbtnCustomers.Location = new System.Drawing.Point(14, 192);
            this.mbtnCustomers.Name = "mbtnCustomers";
            this.mbtnCustomers.Size = new System.Drawing.Size(116, 23);
            this.mbtnCustomers.TabIndex = 4;
            this.mbtnCustomers.Text = "Customers";
            this.mbtnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mbtnCustomers.UseCustomForeColor = true;
            this.mbtnCustomers.UseSelectable = true;
            // 
            // mbtnShowhide
            // 
            this.mbtnShowhide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mbtnShowhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbtnShowhide.Location = new System.Drawing.Point(108, 14);
            this.mbtnShowhide.Name = "mbtnShowhide";
            this.mbtnShowhide.Size = new System.Drawing.Size(20, 18);
            this.mbtnShowhide.TabIndex = 1;
            this.mbtnShowhide.Text = "=";
            this.mbtnShowhide.UseCustomBackColor = true;
            this.mbtnShowhide.UseCustomForeColor = true;
            this.mbtnShowhide.UseSelectable = true;
            this.mbtnShowhide.UseStyleColors = true;
            this.mbtnShowhide.Click += new System.EventHandler(this.mbtnShowhide_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 476);
            this.Controls.Add(this.metroPanel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton mbtnlogin;
        private MetroFramework.Controls.MetroButton mbtnTechnicians;
        private MetroFramework.Controls.MetroButton mbtnPesticides;
        private MetroFramework.Controls.MetroButton mbtnCustomerTechnician;
        private MetroFramework.Controls.MetroButton mbtnCustomers;
        private MetroFramework.Controls.MetroButton mbtnShowhide;

    }
}