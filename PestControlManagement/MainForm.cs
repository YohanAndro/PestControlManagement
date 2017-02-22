using MetroFramework.Forms;
using Models;
using Repository;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace PestControlManagement
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
           
        }
       
        private void mbtnCancel_Click(object sender, System.EventArgs e)
        {

            //MainWindow newMDIChild = new MainWindow();

            //// Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;

            //// Display the new form.
            //newMDIChild.Show();
            //newMDIChild.Visible = true;

          
            //this.Hide();
            //Form1 f = new Form1();
            //f.ShowDialog();
            //this.Close();
        }      

        private void mbtnTechnicians_Click(object sender, System.EventArgs e)
        {
            minimize();
            TechnicianForm t = new TechnicianForm();
            t.MdiParent = this;
            t.Show(); 
            
        }
        private void mbtnShowhide_Click(object sender, System.EventArgs e)
        {
            minimize();

        }

        private void minimize()
        {
            if (metroPanel1.Height == 396 && metroPanel1.Width == 153)
            {
                metroPanel1.Height = 396;
                metroPanel1.Width = 45;
                mbtnShowhide.Left = 15;
                mbtnShowhide.Text = "=";
                //mbtnShowhide.BackgroundImage = System.Drawing.Image.FromFile("E:\\PestConstrolSoftware\\PestControlManagement\\PestControlManagement\\Icons\\symbol_multiplication.gif");
            }
            else
            {
                metroPanel1.Height = 396;
                metroPanel1.Width = 153;
                mbtnShowhide.Left = 108;
                mbtnShowhide.Text = "x";

                //mbtnShowhide.BackgroundImage = System.Drawing.Image.FromFile("E:\\PestConstrolSoftware\\PestControlManagement\\PestControlManagement\\Icons\\view_more_text.png");
            }
        }

        private void mbtnlogin_Click(object sender, System.EventArgs e)
        {
            
           
        }


       

      
    }
}
