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
    public partial class frmtenant : Form
    {
        public frmtenant()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;


        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        private void retrieve_data()
        {

            txttentantid.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            TabControl1.SelectedTab = tpaddtenant;
            txttentantid.Enabled = false;


            sql = "SELECT *  FROM `tbltenant` as E, `tbltenantcontactinfo` W " +
                      "WHERE E.`TenantID`=W.`TenantID` and E.`TenantID`='" +
                      DataGridView1.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {


                txttentantid.Text = config.dt.Rows[0].Field<int>("TenantID").ToString();
                txtlastname.Text = config.dt.Rows[0].Field<string>("LastName").ToString();
                txtfirstname.Text = config.dt.Rows[0].Field<string>("FirstName").ToString();
                txtmiddlename.Text = config.dt.Rows[0].Field<string>("MiddleName").ToString();
                txtoccupation.Text = config.dt.Rows[0].Field<string>("Occupation").ToString();
                txtphonenumber.Text = config.dt.Rows[0].Field<string>("PhoneNumber").ToString();
                txtemailaddress.Text = config.dt.Rows[0].Field<string>("EmailAddress").ToString();
                dtpdbirth.Text = config.dt.Rows[0].Field<DateTime>("BirthDate").ToString();
                txtpressentaddress.Text = config.dt.Rows[0].Field<string>("PressentAddress").ToString();
                if (config.dt.Rows[0].Field<string>("Gender").ToString() == "Male")
                {
                    rdomale.Checked = true;

                }
                else
                {
                    rdofemale.Checked = true;
                }
                txtage.Text = config.dt.Rows[0].Field<int>("Age").ToString();
                txtlastnamecontracts.Text = config.dt.Rows[0].Field<string>("LastNameContact").ToString();
                txtfirstnamecontact.Text = config.dt.Rows[0].Field<string>("FirstNameContract").ToString();
                txtmiddlenamecontract.Text = config.dt.Rows[0].Field<string>("MiddleNameContract").ToString();
                txtoccupationcontact.Text = config.dt.Rows[0].Field<string>("OccupationContact").ToString();
                dtpregistration.Text = config.dt.Rows[0].Field<DateTime>("DateOfRegistration").ToString();
                cbostat.Text = config.dt.Rows[0].Field<string>("Status").ToString();
                txtpresentaddresscontact.Text = config.dt.Rows[0].Field<string>("PressentAddressContract").ToString();
                txtphonenumbercontact.Text = config.dt.Rows[0].Field<string>("PhoneNumberContract").ToString();
                txtemailaddresscontract.Text = config.dt.Rows[0].Field<string>("EmailAddressContact").ToString();
                PictureBox1.ImageLocation = Application.StartupPath + "/Photo/" + config.dt.Rows[0].Field<string>("TPImage").ToString();
                tpaddtenant.Text = "Update Tenant";
            }
            else
            {
                txtoccupation.Clear();
                txtage.Clear();
                txtpressentaddress.Clear();
                txtphonenumber.Clear();
             // cbostat.Clear();
                txttentantid.Clear();
                txtlastname.Clear();
                txtfirstname.Clear();
                txtmiddlename.Clear();
                txtPhoto.Clear();
                txtemailaddresscontract.Clear();
                txtpresentaddresscontact.Clear();
                txtphonenumbercontact.Clear();
                cbostat.Text = "";
                PictureBox1.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                tpaddtenant.Text = "Add New Tenant";
            }


        }




        private void dtpdbirth_ValueChanged(object sender, EventArgs e)
        {
         
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string search_value = txtsearch.Text;
            if (cboCategory.Text == "ID")
            {
                sql = "SELECT distinct(E.`TenantID`) as 'Tenent ID No', concat(`LastName`,', ',`FirstName`,' ',  `MiddleName`) as Name" +
                              ", `Occupation` as 'Occupation', `Gender` as 'Sex', `Age` as 'Age',concat(`LastNameContact`,', ',`FirstNameContract`,' ',  `MiddleNameContract`) as 'Co Maker Name'" +
                              "   FROM `tbltenant` as E, `tbltenantcontactinfo` W WHERE E.`TenantID`=W.`TenantID`" +
                               "AND E.`TenantID` LIKE '%" + search_value + "%'";
                config.Load_DTG(sql, DataGridView1);
                sql = "SELECT * FROM tbltenant WHERE `TenantID` LIKE '%" + search_value + "%'";
                config.singleResult(sql);

                if (search_value == "")
                {
                    if (config.dt.Rows.Count > 0)
                    {
                        PictureBox2.ImageLocation = Application.StartupPath + "/Photo/" + config.dt.Rows[0].Field<string>("TPImage").ToString();
                    }
                    else
                    {
                        PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                    }

                }
                else
                {
                    PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                }

            }
            else
            {
                sql = "SELECT distinct(E.`TenantID`) as 'EmployeeId', concat(`LastName`,', ',`FirstName`,' ',  `MiddleName`) as Name" +
                       ", `Occupation` as 'Occupation', `Gender` as 'Sex', `Age` as 'Age',concat(`LastNameContact`,', ',`FirstNameContract`,' ',  `MiddleNameContract`) as 'Co Maker Name' " +
                       "   FROM `tbltenant` as E, `tbltenantcontactinfo` W WHERE E.`TenantID`=W.`TenantID`" +
                      "AND  concat(`LastName`,', ',`FirstName`,' ',  `MiddleName`) LIKE '%" + txtsearch.Text + "%'";
                config.Load_DTG(sql, DataGridView1);

                sql = "SELECT * FROM tbltenant WHERE concat(`LastName`,', ',`FirstName`,' ',  `MiddleName`) LIKE '%" + txtsearch.Text + "%'";
                config.singleResult(sql);

                if (search_value == "")
                {
                    if (config.dt.Rows.Count > 0)
                    {
                        PictureBox2.ImageLocation = Application.StartupPath + "/Photo/" + config.dt.Rows[0].Field<string>("TPImage").ToString();
                    }
                    else
                    {
                        PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                    }

                }
                else
                {
                    PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                }
            }

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            retrieve_data();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            retrieve_data();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
      //      Form frm = new frmUploadFiles(DataGridView1.CurrentRow.Cells[0].Value.ToString());
      //     frm.ShowDialog();
        }



        private void tpAddEmp_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnempsave_Click(object sender, EventArgs e)
        {
           
        }

       

        private void dtpdbirth_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime f_date = dtpdbirth.Value;
            DateTime s_date = DateTime.Now;
            int age;

            age = s_date.Year - f_date.Year;

            txtage.Text = age.ToString();

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
           
        }

        private void txtsearch_TextChanged_1(object sender, EventArgs e)
        {
            {
                string search_value = txtsearch.Text;
                if (cboCategory.Text == "ID")
                {
                    sql = "SELECT distinct(E.`TenantID`) as 'Tenant Id', concat(`LastName`,', ',`FirstName`,' ',  `MiddleName`) as Name" +
                                  ", `Occupation` as 'Occupation', `Gender` as 'Sex', `Age` as 'Age',concat(`LastNameContact`,', ',`FirstNameContract`,' ',  `MiddleNameContract`) as 'Co Maker Name' " +
                                  "   FROM `tbltenant` as E, `tbltenantcontactinfo` W WHERE E.`TenantID`=W.`TenantID`" +
                                   "AND E.`TenantID` LIKE '%" + search_value + "%'";
                    config.Load_DTG(sql, DataGridView1);
                    sql = "SELECT * FROM tbltenant WHERE `TenantID` LIKE '%" + search_value + "%'";
                    config.singleResult(sql);

                    if (search_value == "")
                    {
                        if (config.dt.Rows.Count > 0)
                        {
                            PictureBox2.ImageLocation = Application.StartupPath + "/Photo/" + config.dt.Rows[0].Field<string>("TPImage").ToString();
                        }
                        else
                        {
                            PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                        }

                    }
                    else
                    {
                        PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                    }

                }
                else
                {
                    sql = "SELECT distinct(E.`TenantID`) as 'Tenant ID', concat(`LastName`,', ',`FirstName`,' ',  `MiddleName`) as Name" +
                           ", `Occupation` as 'Occupation', `Gender` as 'Sex', `Age` as 'Age',concat(`LastNameContact`,', ',`FirstNameContract`,' ',  `MiddleNameContract`) as 'Co Maker Name' " +
                           "   FROM `tbltenant` as E, `tbltenantcontactinfo` W WHERE E.`TenantID`=W.`TenantID`" +
                          "AND  concat(`LastName`,', ',`FirstName`,' ',  `Middlename`) LIKE '%" + txtsearch.Text + "%'";
                    config.Load_DTG(sql, DataGridView1);

                    sql = "SELECT * FROM tbltenant WHERE concat(`LastName`,', ',`FirstName`,' ',  `MiddleName`) LIKE '%" + txtsearch.Text + "%'";
                    config.singleResult(sql);

                    if (search_value == "")
                    {
                        if (config.dt.Rows.Count > 0)
                        {
                            PictureBox2.ImageLocation = Application.StartupPath + "/Photo/" + config.dt.Rows[0].Field<string>("TPImage").ToString();
                        }
                        else
                        {
                            PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                        }

                    }
                    else
                    {
                        PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
                    }
                }

            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
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
                txtPhoto.Text = openFileDialog1.FileName;
                PictureBox1.ImageLocation = openFileDialog1.FileName;
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sql = "SELECT * FROM tbltenant WHERE TenantID = '" + DataGridView1.CurrentRow.Cells[0].Value + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                PictureBox2.ImageLocation = Application.StartupPath + "/Photo/" + config.dt.Rows[0].Field<string>("TPImage").ToString();
            }
            else
            {
                PictureBox2.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnpsave_Click(object sender, EventArgs e)
        {
            string gender;
            if (rdomale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            sql = "SELECT * FROM tbltenant e ,tbltenantcontactinfo w WHERE e.TenantID=w.TenantID AND e.TenantID= " + txttentantid.Text;
            config.singleResult(sql);

            if (txtlastname.Text == "" || txtfirstname.Text == "" || txtoccupation.Text == ""
                 || txtage.Text == "" || txtphonenumber.Text == "" || txtfirstnamecontact.Text == ""
                 || txtemailaddress.Text == "" || txtlastnamecontracts.Text == "" || txtfirstnamecontact.Text == "")
            {
                MessageBox.Show("Empty Fields are required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (config.dt.Rows.Count > 0)
            {

                sql = "UPDATE `tbltenant` E,`tbltenantcontactinfo` W  SET " +
                    "`LastName`='" + txtlastname.Text + "', `FirstName`='" + txtfirstname.Text + "', `MiddleName`='" + txtmiddlename.Text +
                    "',  `Occupation`='" + txtoccupation.Text + "', `PhoneNumber`='" + txtphonenumber.Text + "', `EmailAddress`='" + txtemailaddress.Text +
                    "', `BirthDate`='" + dtpdbirth.Text + "',`PressentAddress`='" + txtpressentaddress.Text +
                    "', `Gender`='" + gender + "', `Age`='" + txtage.Text +
                    "',`Status`='" + cbostat.Text + "', `DateOfRegistration`='" + dtpregistration.Text +
                    "',TPImage = '" + Path.GetFileName(PictureBox1.ImageLocation) +
                    "' WHERE E.`TenantID`= W.`TenantID` and E.`TenantID`= '" + txttentantid.Text + "' ";
                btnpsave.Text = "Save";
                config.Execute_CUD(sql, "No data update.", "Data has been updated in the database");


                //sql = "";
                //config.Execute_Query(sql);

            }
            else
            {

                sql = "insert into `tbltenant`  " +
                    "(`TenantID`, `LastName`, `FirstName`, `MiddleName`, `Occupation`, `PhoneNumber`, `EmailAddress`, `BirthDate`," +
                    "`PressentAddress`, `Gender`, `Age`, `TPImage`,`Status`, `DateOfRegistration`)" +
                    " VALUES " +
                    "('" + txttentantid.Text + "','" + txtlastname.Text + "','" + txtfirstname.Text + "','" + txtmiddlename.Text +
                    "','" + txtoccupation.Text + "','" + txtphonenumber.Text + "','" + txtemailaddress.Text + "','" + dtpdbirth.Text +
                    "','" + txtpressentaddress.Text + "','" + gender + "','" + txtage.Text + "','" + Path.GetFileName(PictureBox1.ImageLocation) +
                    "','" + cbostat.Text + "','" + dtpregistration.Text + "' )";
                config.Execute_CUD(sql, "No data save.", "Data has been saved in the database");


                sql = "insert into `tbltenantcontactinfo` (`TenantID`, `LastNameContact`, `FirstNameContract`, `MiddleNameContract`,`OccupationContact`,`PhoneNumberContract`, `PressentAddressContract`, `EmailAddressContact`)" +
                    " values " +
                    " ('" + txttentantid.Text + "','" + txtlastnamecontracts.Text + "','" + txtfirstnamecontact.Text +
                    "','" + txtmiddlenamecontract.Text + "','" + txtoccupationcontact.Text +
                    "','" + txtphonenumbercontact.Text + "','" + txtpresentaddresscontact.Text + "','" + txtemailaddresscontract.Text + "')";
                config.Execute_Query(sql);


            }
            if (txtPhoto.Text != "")
            {
                File.Copy(txtPhoto.Text, Application.StartupPath + "/Photo/" + Path.GetFileName(PictureBox1.ImageLocation), true);
            }
            btnnew_Click_2(sender, e);
        }

        private void txtSocialAdd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tpAddEmp_Click_1(object sender, EventArgs e)
        {

        }

        private void frmtenant_Load(object sender, EventArgs e)
        {
            btnnew_Click_2(sender, e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click_2(object sender, EventArgs e)
        {
            retrieve_data();
            btnpsave.Text = "Update";
        }

        private void tplisttenant_Click(object sender, EventArgs e)
        {
        }

        private void btnUpload_Click_1(object sender, EventArgs e)
        {

            frmuploadfiles f2 = new frmuploadfiles();
            f2.lbltenid.Text = this.DataGridView1.CurrentRow.Cells[0].Value.ToString();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void Label25_Click(object sender, EventArgs e)
        {

        }

        private void txtemailaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void Label35_Click(object sender, EventArgs e)
        {

        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void btnnew_Click_2(object sender, EventArgs e)
        {
            funct.clearTxt(GroupBox9);
            funct.clearTxt(GroupBox10);
            txttentantid.Enabled = true;
            tpaddtenant.Text = "Add New Tenant";
            txtlastnamecontracts.Text = "";
            txtfirstnamecontact.Text = "";
            btnpsave.Text = "Save";
            dtpdbirth.Value = DateTime.Now;
            txtmiddlenamecontract.Text = "";
            PictureBox1.ImageLocation = Application.StartupPath + "/Photo/no_image.png";
            sql = "SELECT distinct(E.`TenantID`) as 'Tenant ID No', concat(`LastName`,', ',`FirstName`,' ',  `MiddleName`) as Name" +
            ", `Occupation` as 'Occupation', `Gender` as 'Sex', `Age` as 'Age',concat(`LastNameContact`,', ',`FirstNameContract`,' ',  `MiddleNameContract`) as 'Co Maker Name' " +
            ",`PressentAddressContract` as 'Co Maker Present Address'   FROM `tbltenant` as E, `tbltenantcontactinfo` W WHERE E.`TenantID`=W.`TenantID`";
            config.Load_DTG(sql, DataGridView1);
            funct.ResponsiveDtg(DataGridView1);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM `tbltenant` WHERE  `TenantID`='" + DataGridView1.CurrentRow.Cells[0].Value + "'";
            config.Execute_Query(sql);

            sql = "DELETE FROM `tbltenantcontactinfo` WHERE  `TenantID`='" + DataGridView1.CurrentRow.Cells[0].Value + "'";
            config.Execute_CUD(sql, "No date delete", "Data has been deleted.");
            btnnew_Click_2(sender, e);
        }
    }
}

