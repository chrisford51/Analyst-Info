using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analyst_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hddb01DataSet2.StaffInfo' table. You can move, or remove it, as needed.
            this.staffInfoTableAdapter1.Fill(this.hddb01DataSet2.StaffInfo);


        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.staffInfoTableAdapter.Fill(this.hddb01DataSet.StaffInfo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
