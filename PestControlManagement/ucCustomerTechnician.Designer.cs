namespace PestControlManagement
{
    partial class ucCustomerTechnician
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mbtnDelete = new MetroFramework.Controls.MetroButton();
            this.mbtnUpdate = new MetroFramework.Controls.MetroButton();
            this.mbtnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.technicianIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicianNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custmerTechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mComboBoxCustomerType = new MetroFramework.Controls.MetroComboBox();
            this.technicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custmerTechBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mlblFilter = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custmerTechBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custmerTechBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.Location = new System.Drawing.Point(726, 362);
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.Size = new System.Drawing.Size(75, 23);
            this.mbtnDelete.TabIndex = 3;
            this.mbtnDelete.Text = "&Delete";
            this.mbtnDelete.UseSelectable = true;
            this.mbtnDelete.Click += new System.EventHandler(this.mbtnDelete_Click);
            // 
            // mbtnUpdate
            // 
            this.mbtnUpdate.Location = new System.Drawing.Point(630, 362);
            this.mbtnUpdate.Name = "mbtnUpdate";
            this.mbtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.mbtnUpdate.TabIndex = 4;
            this.mbtnUpdate.Text = "&Update";
            this.mbtnUpdate.UseSelectable = true;
            this.mbtnUpdate.Click += new System.EventHandler(this.mbtnUpdate_Click);
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.Location = new System.Drawing.Point(531, 362);
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Size = new System.Drawing.Size(75, 23);
            this.mbtnAdd.TabIndex = 5;
            this.mbtnAdd.Text = "&Add";
            this.mbtnAdd.UseSelectable = true;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(345, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(198, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "CustomerTechnicians Details";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.technicianIDDataGridViewTextBoxColumn,
            this.technicianNameDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerTypeDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.custmerTechBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(41, 79);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(816, 249);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 21;
            this.metroGrid1.UseStyleColors = true;
            // 
            // technicianIDDataGridViewTextBoxColumn
            // 
            this.technicianIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.technicianIDDataGridViewTextBoxColumn.DataPropertyName = "TechnicianID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.technicianIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.technicianIDDataGridViewTextBoxColumn.HeaderText = "TechnicianID";
            this.technicianIDDataGridViewTextBoxColumn.Name = "technicianIDDataGridViewTextBoxColumn";
            this.technicianIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // technicianNameDataGridViewTextBoxColumn
            // 
            this.technicianNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.technicianNameDataGridViewTextBoxColumn.DataPropertyName = "TechnicianName";
            this.technicianNameDataGridViewTextBoxColumn.HeaderText = "TechnicianName";
            this.technicianNameDataGridViewTextBoxColumn.Name = "technicianNameDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerTypeDataGridViewTextBoxColumn
            // 
            this.customerTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerTypeDataGridViewTextBoxColumn.DataPropertyName = "CustomerType";
            this.customerTypeDataGridViewTextBoxColumn.HeaderText = "CustomerType";
            this.customerTypeDataGridViewTextBoxColumn.Name = "customerTypeDataGridViewTextBoxColumn";
            this.customerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custmerTechBindingSource
            // 
            this.custmerTechBindingSource.DataSource = typeof(PestControlManagement.CustmerTech);
            // 
            // mComboBoxCustomerType
            // 
            this.mComboBoxCustomerType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.technicianBindingSource, "ID", true));
            this.mComboBoxCustomerType.DataSource = this.custmerTechBindingSource1;
            this.mComboBoxCustomerType.DisplayMember = "TechnicianName";
            this.mComboBoxCustomerType.FormattingEnabled = true;
            this.mComboBoxCustomerType.ItemHeight = 23;
            this.mComboBoxCustomerType.Location = new System.Drawing.Point(389, 35);
            this.mComboBoxCustomerType.Name = "mComboBoxCustomerType";
            this.mComboBoxCustomerType.Size = new System.Drawing.Size(121, 29);
            this.mComboBoxCustomerType.TabIndex = 22;
            this.mComboBoxCustomerType.UseSelectable = true;
            this.mComboBoxCustomerType.ValueMember = "TechnicianID";
            this.mComboBoxCustomerType.SelectionChangeCommitted += new System.EventHandler(this.mComboBoxCustomerType_SelectionChangeCommitted);
            // 
            // technicianBindingSource
            // 
            this.technicianBindingSource.DataSource = typeof(PestControlManagement.Technician);
            // 
            // custmerTechBindingSource1
            // 
            this.custmerTechBindingSource1.DataSource = typeof(PestControlManagement.CustmerTech);
            // 
            // mlblFilter
            // 
            this.mlblFilter.AutoSize = true;
            this.mlblFilter.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblFilter.Location = new System.Drawing.Point(171, 45);
            this.mlblFilter.Name = "mlblFilter";
            this.mlblFilter.Size = new System.Drawing.Size(76, 19);
            this.mlblFilter.Style = MetroFramework.MetroColorStyle.Orange;
            this.mlblFilter.TabIndex = 23;
            this.mlblFilter.Text = "Filter By:  ";
            this.mlblFilter.UseStyleColors = true;
            // 
            // ucCustomerTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlblFilter);
            this.Controls.Add(this.mComboBoxCustomerType);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbtnDelete);
            this.Controls.Add(this.mbtnUpdate);
            this.Controls.Add(this.mbtnAdd);
            this.Name = "ucCustomerTechnician";
            this.Size = new System.Drawing.Size(898, 435);
            this.Load += new System.EventHandler(this.ucCustomerTechnician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custmerTechBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custmerTechBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtnDelete;
        private MetroFramework.Controls.MetroButton mbtnUpdate;
        private MetroFramework.Controls.MetroButton mbtnAdd;
        private System.Windows.Forms.BindingSource custmerTechBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroComboBox mComboBoxCustomerType;
        private MetroFramework.Controls.MetroLabel mlblFilter;
        private System.Windows.Forms.BindingSource technicianBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicianNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource custmerTechBindingSource1;
    }
}
