namespace PestControlManagement
{
    partial class ucCustomerReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtInvoice = new MetroFramework.Controls.MetroTile();
            this.mtWorkOrders = new MetroFramework.Controls.MetroTile();
            this.mtQuotations = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtInvoice
            // 
            this.mtInvoice.ActiveControl = null;
            this.mtInvoice.Location = new System.Drawing.Point(251, 192);
            this.mtInvoice.Name = "mtInvoice";
            this.mtInvoice.Size = new System.Drawing.Size(124, 50);
            this.mtInvoice.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtInvoice.TabIndex = 14;
            this.mtInvoice.Text = "Invoice";
            this.mtInvoice.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtInvoice.UseMnemonic = false;
            this.mtInvoice.UseSelectable = true;
            this.mtInvoice.UseStyleColors = true;
            this.mtInvoice.UseTileImage = true;
            this.mtInvoice.Click += new System.EventHandler(this.mtInvoice_Click);
            // 
            // mtWorkOrders
            // 
            this.mtWorkOrders.ActiveControl = null;
            this.mtWorkOrders.Location = new System.Drawing.Point(386, 192);
            this.mtWorkOrders.Name = "mtWorkOrders";
            this.mtWorkOrders.Size = new System.Drawing.Size(124, 50);
            this.mtWorkOrders.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtWorkOrders.TabIndex = 15;
            this.mtWorkOrders.Text = "Work Orders";
            this.mtWorkOrders.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtWorkOrders.UseMnemonic = false;
            this.mtWorkOrders.UseSelectable = true;
            this.mtWorkOrders.UseStyleColors = true;
            this.mtWorkOrders.UseTileImage = true;
            // 
            // mtQuotations
            // 
            this.mtQuotations.ActiveControl = null;
            this.mtQuotations.Location = new System.Drawing.Point(523, 192);
            this.mtQuotations.Name = "mtQuotations";
            this.mtQuotations.Size = new System.Drawing.Size(124, 50);
            this.mtQuotations.Style = MetroFramework.MetroColorStyle.Lime;
            this.mtQuotations.TabIndex = 16;
            this.mtQuotations.Text = "Quotations";
            this.mtQuotations.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtQuotations.UseMnemonic = false;
            this.mtQuotations.UseSelectable = true;
            this.mtQuotations.UseStyleColors = true;
            this.mtQuotations.UseTileImage = true;
            // 
            // ucCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtQuotations);
            this.Controls.Add(this.mtWorkOrders);
            this.Controls.Add(this.mtInvoice);
            this.Name = "ucCustomerReport";
            this.Size = new System.Drawing.Size(898, 435);
            this.Load += new System.EventHandler(this.ucCustomerReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtInvoice;
        private MetroFramework.Controls.MetroTile mtWorkOrders;
        private MetroFramework.Controls.MetroTile mtQuotations;

    }
}
