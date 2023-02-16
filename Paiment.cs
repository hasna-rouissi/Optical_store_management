using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projet_OMS
{
    public partial class Paiment : Form
    {
        public Paiment()
        {
            InitializeComponent();
            GetIdClient();
          
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TVT7T8S\\SQLEXPRESS;Initial Catalog=MO_DB;Integrated Security=True");


        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Accueil obj = new Accueil();
            obj.Show();
            this.Hide();
        }
     
   
        
        private void label8_Click(object sender, EventArgs e)
        {
        
            SqlCommand cmd = new SqlCommand("select * from Monture where  " +
                "id_Client=" + Id_clientCB1.SelectedValue.ToString() + "", con);
            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader()){
                if (dr.Read())
                {
                    TM.Text = String.Empty;
                    TM.Text = dr["prix"].ToString();
                }
            }
         
            con.Close();
        }
        
   
        private void Id_clientCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Nom_TextChanged(object sender, EventArgs e)
        {

        }
        void GetIdClient()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select id_Client from Ordonnance ", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_Client", typeof(int));
            dt.Load(sdr);
            Id_clientCB1.ValueMember = "id_Client";
            Id_clientCB1.DataSource = dt;
            con.Close();

        }
        /*--------------------afficher nom -------------------*/
        void getNomClient()
        {
            con.Open();
            String Query = "Select *from Clients where id_Client=" + Id_clientCB1.SelectedValue.ToString() + "";
            SqlCommand cmd1 = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Nom.Text = dr["Nom"].ToString();
            }

            con.Close();
        }

        private void Id_clientCB1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getNomClient();
        }

        private void Facture_DoubleClick(object sender, EventArgs e)
        {
            Id_clientCB1.Text = String.Empty;
            Nom.Clear();
           
        }

        private void Facture_Load(object sender, EventArgs e)
        {

        }

        private void Facture_Load_1(object sender, EventArgs e)
        {

        }

        private void TV_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Verre where  id_Client=" + Id_clientCB1.SelectedValue.ToString() + "", con);
            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    TV.Text = dr["prix"].ToString();
                }
            }
            con.Close();
        }

        private void Total_Click(object sender, EventArgs e)
        {
            Total.Text = "700.000";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Facture_Load_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
          
            String total = Total.Text;
            DateTime Date_paiment = DateTime.Parse(guna2DateTimePicker1.Text);

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Paiment (PrixTotal,Date_Paiment) " +
                "values ('" + total + "','"+Date_paiment+"' )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("insertion effectué....");
            con.Close();
        }
    }
}
