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


namespace RentalHouseManagementSystem
{
    public partial class frmlistscanned : Form
    {
        public frmlistscanned()
        {
            InitializeComponent();
           
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        private void frmlistscanned_Load(object sender, EventArgs e)
        {
            sql = "SELECT ScannedId,TenantID, concat(`LastName`,' ',  `FirstName`, ' ',`MiddleName`) as 'Tenant Name', `ImageCaption` as 'FilesName', `ImageType` as 'FilesType', `DateUpload` as 'DateUploaded' " +
                " FROM  `tblscanned` s,  `tbltenant` e WHERE  `TenantID` = `TenID` AND concat(`LastName`,' ',  `FirstName`, ' ',`MiddleName`) Like '%" + txtsearch.Text + "%'";

            config.Load_DTG(sql, dtglist);
            dtglist.Columns[0].Visible = false;
           dtglist.Columns[1].Visible = false;


            sql = "SELECT concat(`LastName`,' ',  `FirstName`, ' ',`MiddleName`) FROM `tbltenant`";
            config.autocomplete(sql, txtsearch);

            //sql = "SELECT concat(`FIRST_NAME`,' ',  `MIDDLE_NAME`, ' ',`LAST_NAME`) FROM `employees`"
            //append(sql, txtSearch)
        }



        private void btnUplaod_Click(object sender, EventArgs e)
        {
   
        }



   

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cbofile.Text != "Select what file")
            {
                sql = "SELECT * " +
                        " FROM  `tblscanned` s,  `tbltenant` e WHERE  `TenantID` = `TenID` AND ImageType='"
                        + cbofile.Text + "'  AND  concat(`LastName`,' ',  `FirstName`, ' ',`MiddleName`) Like '%"
                        + txtsearch.Text + "%'";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    lblName.Text = config.dt.Rows[0].Field<string>("LastName").ToString() + " " + config.dt.Rows[0].Field<string>("FirstName").ToString();
                }

                sql = "SELECT ScannedId,TenantID, concat(`LastName`,' ',  `FirstName`, ' ',`MiddleName`) as 'Name', `ImageCaption` as 'FilesName', `ImageType` as 'FilesType', `DateUpload` as 'DateUploaded' " +
                        " FROM  `tblscanned` s,  `tbltenant` e WHERE  `TenantID` = `TenID` AND ImageType='" + cbofile.Text + "'  AND   concat(`LastName`,' ',  `FirstName`, ' ',`MiddleName`) Like '%" + txtsearch.Text + "%'";
                config.Load_DTG(sql, dtglist);
                dtglist.Columns[0].Visible = false;
                dtglist.Columns[1].Visible = false;

            }
            else if (cbofile.Text == "Select what file")
            {
                MessageBox.Show("Select what files to search", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            frmlistscanned_Load(sender, e);
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            //    Form frm = new frmUploadFiles(dtglist.CurrentRow.Cells[1].Value.ToString());
            // frm.ShowDialog();
            frmuploadfiles f2 = new frmuploadfiles();
            f2.lbltenid.Text = this.dtglist.CurrentRow.Cells[1].Value.ToString();
            f2.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM tblscanned WHERE ScannedId= " + dtglist.CurrentRow.Cells[0].Value;
            config.Execute_CUD(sql, "No delete data", "Data has been deleted");
            //   frmListScannedFiles_Load(sender, e);
        }

        private void btnpreview_Click_1(object sender, EventArgs e)
        {
            sql = "SELECT * FROM  `tblscanned` s,  `tbltenant` e WHERE  `TenantID` =  `TenID` AND ScannedId=" + dtglist.CurrentRow.Cells[0].Value;
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                string filename = config.dt.Rows[0].Field<string>("FileLocation").ToString();
                Form frm = new frmpdfviewer(filename);
                frm.Show();


            }
        }
    }

}
