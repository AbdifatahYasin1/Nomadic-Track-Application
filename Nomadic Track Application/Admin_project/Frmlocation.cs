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
    public partial class Frmlocation : Form
    {
        string connectionString = "Data Source=DESKTOP-P153C9Q;Database=testing; user=sa; password=1234;";

        public Frmlocation()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtadmid.Text == "")
            {
                MessageBox.Show("Enter Admin ID");
            }
            if (txtlocation.Text == "")
            {
                MessageBox.Show("Enter Country");
            }
            if (txtlname.Text == "")
            {
                MessageBox.Show("Enter District");
            }
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-P153C9Q;;Database=testing; user=sa; password=1234;");
                con.Open();
                string query = "Insert into location (Fk_person1_id,Country,Disrict,dateTimo) values (@d1,@d2,@d3,getdate())";

                SqlCommand com = new SqlCommand(query, con);

                com.Parameters.AddWithValue("@d1", txtadmid.Text);
                com.Parameters.AddWithValue("@d2", txtlocation.Text);
                com.Parameters.AddWithValue("@d3", txtlname.Text);
                
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
                string query = "update  location set Fk_person1_id=@d1,location=@d2,GeogCol1=@d3 where Pk_Track_location='" + txtid.Text +"'";
                SqlCommand com = new SqlCommand(query, con);

                com.Parameters.AddWithValue("@d1", txtadmid.Text);
                com.Parameters.AddWithValue("@d2", txtlocation.Text);
                com.Parameters.AddWithValue("@d3", txtlname.Text);

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
                string query = "select Pk_Track_location,Fk_person1_id,Country,Disrict  from location where Pk_Track_location='" + txtsearch.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                //   com.Parameters.AddWithValue("@d0", txtsearch.Text);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read() == true)
                {
                    txtid.Text = dr[0].ToString();
                    txtadmid.Text = dr[1].ToString();
                    txtlocation.Text = dr[2].ToString();
                    txtlname.Text = dr[3].ToString();
                    


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
                string query = "delete from location where Pk_Track_location='" + txtid.Text + "'";
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

        private void txtadmid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
