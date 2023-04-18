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
    public partial class frmpdfviewer : Form
    {
        public frmpdfviewer(string filename)
        {
            InitializeComponent();
            axAcroPDF1.LoadFile(Application.StartupPath + "\\PDF_Files\\" + filename);
        }

        private void frmpdfviewer_Load(object sender, EventArgs e)
        {

        }
        private void filenames(string filename)
        {
            
        }
    }
}
