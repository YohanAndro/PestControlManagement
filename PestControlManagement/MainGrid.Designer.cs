namespace PestControlManagement
{
    partial class MainGrid
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
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mLinkPower = new MetroFramework.Controls.MetroLink();
            this.mlnkBack = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mPanel
            // 
            this.mPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(23, 51);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(898, 460);
            this.mPanel.TabIndex = 0;
            this.mPanel.UseStyleColors = true;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mLinkPower
            // 
            this.mLinkPower.BackgroundImage = global::PestControlManagement.Properties.Resources._1488829744_on_off;
            this.mLinkPower.Location = new System.Drawing.Point(889, 29);
            this.mLinkPower.Name = "mLinkPower";
            this.mLinkPower.Size = new System.Drawing.Size(32, 32);
            this.mLinkPower.TabIndex = 11;
            this.mLinkPower.UseSelectable = true;
            this.mLinkPower.Click += new System.EventHandler(this.mLinkPower_Click);
            // 
            // mlnkBack
            // 
            this.mlnkBack.BackgroundImage = global::PestControlManagement.Properties.Resources.Button_Back;
            this.mlnkBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mlnkBack.Location = new System.Drawing.Point(23, 20);
            this.mlnkBack.Name = "mlnkBack";
            this.mlnkBack.Size = new System.Drawing.Size(32, 32);
            this.mlnkBack.TabIndex = 10;
            this.mlnkBack.UseSelectable = true;
            this.mlnkBack.UseStyleColors = true;
            this.mlnkBack.Click += new System.EventHandler(this.mlnkBack_Click);
            // 
            // MainGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 534);
            this.ControlBox = false;
            this.Controls.Add(this.mLinkPower);
            this.Controls.Add(this.mlnkBack);
            this.Controls.Add(this.mPanel);
            this.Name = "MainGrid";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Load += new System.EventHandler(this.MainGrid_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLink mlnkBack;
        private MetroFramework.Controls.MetroLink mLinkPower;
    }
}