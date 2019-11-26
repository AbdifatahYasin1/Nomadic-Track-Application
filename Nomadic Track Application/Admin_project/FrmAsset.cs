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
    public partial class FrmAsset : Form
    {
        string connectionString = "Data Source=DESKTOP-P153C9Q;Database=testing; user=sa; password=1234;";
        public FrmAsset()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "Insert into Addmin_Asset (Fk_person1_id, Asset_Type ,Asset_number,Reg_date) values (@d1,@d2,@d3,getdate())";
                SqlCommand com = new SqlCommand(query, con);

                com.Parameters.AddWithValue("@d1", txtfname.Text);
                com.Parameters.AddWithValue("@d2", txtasset.Text);
                com.Parameters.AddWithValue("@d3", txtasset.Text);


                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved ");
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
                string query = "select Pk_Asset_Id,Fk_person1_id,AssetType,Asset_number from Addmin_Asset where Pk_Asset_Id='" + txtsearch.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                //   com.Parameters.AddWithValue("@d0", txtsearch.Text);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read() == true)
                {
                    txtid.Text = dr[0].ToString();
                    txtfname.Text = dr[1].ToString();
                    txtasset.Text = dr[2].ToString();
                     


                }
                con.Close();

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
                string query = "update  Addmin_Asset set Fk_person1_id=@d1,AssetType=@d2 where Pk_Asset_Id='" + txtid.Text + "'";
                SqlCommand com = new SqlCommand(query, con);

                com.Parameters.AddWithValue("@d1", txtfname.Text);
                com.Parameters.AddWithValue("@d2", txtasset.Text);
                

                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("updated ");
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
                string query = "delete from Addmin_Asset where Pk_Asset_Id='" + txtid.Text + "'";
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

