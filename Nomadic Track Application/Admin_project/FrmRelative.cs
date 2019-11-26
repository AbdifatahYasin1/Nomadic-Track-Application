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

namespace Admin_project
{
    public partial class FrmRelative : Form
    {
        string connectionString = "Data Source=DESKTOP-P153C9Q;Database=testing; user=sa; password=1234;";

        public FrmRelative()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-P153C9Q;Database=testing; user=sa; password=1234;");
                con.Open();
                string query = "Insert into relative (Firstname,lastname,phone_number,Relative_Type,reG_daTE,Fk_person1_id) values (@d1,@d2,@d3,@d4,getdate(),@d5)";
                SqlCommand com = new SqlCommand(query, con);

                com.Parameters.AddWithValue("@d1", txtfname.Text);
                com.Parameters.AddWithValue("@d2", txtlname.Text);
                com.Parameters.AddWithValue("@d3", txtphone.Text);
                com.Parameters.AddWithValue("@d4", gender.SelectedItem);
                com.Parameters.AddWithValue("@d5", txtadmid.Text);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "update  relative set Firstname=@d1,lastname=@d2,phone_number=@d3,Relative_Type=@d4 where Pk_Realtive_Id='"+txtid.Text +"'";
                SqlCommand com = new SqlCommand(query, con);

                com.Parameters.AddWithValue("@d1", txtfname.Text);
                com.Parameters.AddWithValue("@d2", txtlname.Text);
                com.Parameters.AddWithValue("@d3", txtphone.Text);
                com.Parameters.AddWithValue("@d4", gender.SelectedItem);
               
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("updated ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "select Pk_Realtive_Id,Firstname,lastname,phone_number,Relative_Type,Fk_person1_id from relative where Pk_Realtive_Id='" + txtsearch.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                //   com.Parameters.AddWithValue("@d0", txtsearch.Text);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read() == true)
                {
                    txtid.Text = dr[0].ToString();
                    txtfname.Text = dr[1].ToString();
                    txtlname.Text = dr[2].ToString();
                    txtphone.Text = dr[3].ToString();
                    gender.Text = dr[4].ToString();
                    txtadmid.Text = dr[5].ToString();


                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "delete from relative where Pk_Realtive_Id='" + txtid.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                //   com.Parameters.AddWithValue("@d0", txtsearch.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
