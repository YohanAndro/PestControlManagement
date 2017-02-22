using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using Models;
using Repository;
using MetroFramework;


namespace PestControlManagement
{
    public partial class MainGrid : MetroForm
    {
        static MainGrid _instance;
        public static MainGrid Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainGrid();
                return _instance;
            }
        }
        public MetroPanel MContainer
        {
            get { return mPanel; }
            set { mPanel = value; }
        }
        public MetroLink MBack
        {
            get { return mlnkBack; }
            set { mlnkBack = value; }
        }
        public MainGrid()
        {
            InitializeComponent();
        }

        private void MainGrid_Load(object sender, EventArgs e)
        {
            MBack.Visible = false;
            _instance = this;
            ucDashboard uc = new ucDashboard();
            uc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(uc);
        }

        private void mlnkBack_Click(object sender, EventArgs e)
        {
            mPanel.Controls["ucDashboard"].BringToFront();
            MBack.Visible = false;
        }

    }
}
