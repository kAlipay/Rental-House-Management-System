using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalHouseManagementSystem
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         frmuploadfiles form2 = new frmuploadfiles();
           form2.ShowDialog();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlistscanned form2 = new frmlistscanned();
            form2.ShowDialog();
        }

        private void addTenenatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtenant form2 = new frmtenant();
            form2.ShowDialog();
        }
    }
}
