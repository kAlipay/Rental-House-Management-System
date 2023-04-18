using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalHouseManagementSystem.Includes;
using System.IO;

namespace RentalHouseManagementSystem
{
    public partial class frmuploadfiles : Form
    {
        public frmuploadfiles()
        {
            InitializeComponent();

           

        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        private void UploadSecond(string txt)
        {
            sql = "INSERT INTO tblscanned(TenID, ImageCaption,ImageType,FileLocation,DateUpload) " +
            " VALUES (" + lbltenid.Text + " ,'" + txt + "','" + cbofiles.Text + "','" + txt + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            config.Execute_Query(sql);

        }







        private void frmUploadFiles_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpId_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

   private void uploadfrm_Load(string id)
     {
        lbltenid.Text = id;
        }

        private void uploadfrm_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            ProgressBar1.Value += 1;
            if (ProgressBar1.Value == 100)
            {
                Timer1.Stop();
                UploadSecond(Path.GetFileName(txtlocation.Text));
                if (txtlocation.Text != "")
                {
                    System.IO.File.Copy(txtlocation.Text, Application.StartupPath + "/PDF_Files/" + System.IO.Path.GetFileName(txtlocation.Text), true);
                }
                MessageBox.Show("Scanned file uploaded successfully.");
                txtlocation.Clear();
                ProgressBar1.Value = 0;
                cbofiles.Text = "Select what file to be upload";
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.DereferenceLinks = true;
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Select a file to open";
            openFileDialog1.ValidateNames = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtlocation.Text = openFileDialog1.FileName;
            }
        }

        private void txtLocation_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            if (txtlocation.Text != "" && cbofiles.Text != "Select what file to be upload")
            {
                Timer1.Start();
            }
            else if (cbofiles.Text == "Select what file to be upload")
            {
                MessageBox.Show("Please select what file to be upload.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
