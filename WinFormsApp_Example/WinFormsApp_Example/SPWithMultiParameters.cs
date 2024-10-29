using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_Example
{
    public partial class SPWithMultiParameters : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-IFP4QPL; Database = employeedb; Integrated Security=True");
        SqlCommand cmd; SqlParameter p1;
        SqlDataReader dr;
        public SPWithMultiParameters()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("SPEmp_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@PEmpId", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempid.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpName", SqlDbType.VarChar);
            p1.Value = txtempname.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpDesig", SqlDbType.VarChar);
            p1.Value = txtempdesig.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpDOJ", SqlDbType.DateTime);
            p1.Value = Convert.ToDateTime(txtempdoj.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpSal", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempsal.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpDept", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempdeptno.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(s)Inserted");
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DelRecp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@PEmpId", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempid.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(s)deleted");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SPEmp_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@EmpId", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempid.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpName", SqlDbType.VarChar);
            p1.Value = txtempname.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpDesig", SqlDbType.VarChar);
            p1.Value = txtempdesig.Text;
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpDOJ", SqlDbType.DateTime);
            p1.Value = Convert.ToDateTime(txtempdoj.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpSal", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempsal.Text);
            cmd.Parameters.Add(p1);

            p1 = new SqlParameter("@PEmpDept", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempdeptno.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "Record(s)Updated");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Findp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@Pempid", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtempid.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.Read()==true)
            {
                txtempid.Text = dr[0].ToString();
                txtempname.Text = dr[1].ToString();
                txtempdesig.Text = dr[2].ToString();
                txtempdoj.Text = dr[3].ToString();
                txtempsal.Text= dr[4].ToString();
                txtempdeptno.Text= dr[5].ToString();
            }
            else
            {
                MessageBox.Show("records not found");
                dr.Close();
            }
            con.Close();
        }
    }
}
