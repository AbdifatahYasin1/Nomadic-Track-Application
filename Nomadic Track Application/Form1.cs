using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Admin_project
{

    public partial class Form1 : Form
    {
         string connectionString = "Data Source=DESKTOP-P153C9Q;Database=testing; user=sa; password=1234;";

            //System.Configuration.ConfigurationManager
            //   .ConnectionStrings["OWNPROJECT"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection("Data Source=;Database=testing; user=sa; password=1234;");
                con.Open();
                string query = "Insert into Addmin (Fisrtname,lastname,phone_number,gender,dob) values (@d1,@d2,@d3,@d4,@d5)";
                SqlCommand com = new SqlCommand(query, con);
                
                com.Parameters.AddWithValue("@d1", txtfname.Text);
                com.Parameters.AddWithValue("@d2", txtlname.Text);
                com.Parameters.AddWithValue("@d3", txtphone.Text);
                com.Parameters.AddWithValue("@d4", gender.SelectedItem);
                com.Parameters.AddWithValue("@d5", dob.Value.ToShortDateString());
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
                string query = "update  Addmin set Fisrtname=@d1,lastname=@d2,phone_number=@d3,gender=@d4,dob=@d5 where person1_id=@d0";
                SqlCommand com = new SqlCommand(query, con);

                com.Parameters.AddWithValue("@d1", txtfname.Text);
                com.Parameters.AddWithValue("@d2", txtlname.Text);
                com.Parameters.AddWithValue("@d3", txtphone.Text);
                com.Parameters.AddWithValue("@d4", gender.SelectedItem);
                com.Parameters.AddWithValue("@d5", dob.Value.ToShortDateString());
                com.Parameters.AddWithValue("@d0", txtid.Text);
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
                string query = "select person1_id,fisrtname,lastname,phone_number,gender,dob from Addmin where person1_id='" + txtsearch.Text + "'";
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
                    dob.Value = DateTime.Parse(dr[5].ToString());


                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
