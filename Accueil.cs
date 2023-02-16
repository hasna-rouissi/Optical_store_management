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

namespace Projet_OMS
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            PanelClient.Visible = false;


        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TVT7T8S\\SQLEXPRESS;Initial Catalog=MO_DB;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                getClientRechercher();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Error Message");
            }


        }
        void getClientRechercher()
        {
            con.Open();
            SqlDataAdapter sd1 = new SqlDataAdapter("rechercher_client",con);
            sd1.SelectCommand.CommandType = CommandType.StoredProcedure;
            sd1.SelectCommand.Parameters.AddWithValue("@Nom", textBox1.Text.Trim());
            DataTable dt1 = new DataTable();
            sd1.Fill(dt1);
            guna2DataGridView1.DataSource = dt1;
            con.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            PanelClient.Visible = true;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void PanelClient_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {
            PanelClient.Visible = false;
            textBox7.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            String Nom = textBox3.Text;
            String Prenom = textBox2.Text;
            String Docteur = textBox4.Text;
            String Tele = textBox5.Text;
            String Addresse = textBox6.Text;
            DateTime Date_naissance = DateTime.Parse(guna2DateTimePicker1.Text);
            String Sexe = guna2ComboBox1.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("exec  Insert_Clients '"+Nom+"','"+Prenom+ "','"+Docteur+ "','"+Tele+ "','"+Addresse+ "','"+Date_naissance+ "','"+Sexe+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("insertion effectué....");
            GetlistClient();
            con.Close();
        }
        void GetlistClient()
        {
            SqlCommand cmd2 = new SqlCommand("exec listClients", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView1.DataSource = dt;

        }
        

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            guna2DateTimePicker1.Text = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            guna2ComboBox1.Text = guna2DataGridView1.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            GetlistClient();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            int ClientId = int.Parse(textBox7.Text);
            String Nom = textBox3.Text;
            String Prenom = textBox2.Text;
            String Docteur = textBox4.Text;
            String Tele = textBox5.Text;
            String Addresse = textBox6.Text;
            DateTime Date_naissance = DateTime.Parse(guna2DateTimePicker1.Text);
            String Sexe = guna2ComboBox1.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("exec  Update_Clients '" + ClientId + "','" + Nom + "','" + Prenom + "','" + Docteur + "','" + Tele + "','" + Addresse + "','" + Date_naissance + "','" + Sexe + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Mis à jour effectué....");
            GetlistClient();
            con.Close();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {

            int ClientId = int.Parse(textBox7.Text);
   
            con.Open();
            SqlCommand cmd = new SqlCommand("exec  Delete_Clients '" + ClientId + "'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supprission effectué....");
            GetlistClient();
            con.Close();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                GetlistClient();
            }
        }

        private void Accueil_Leave(object sender, EventArgs e)
        {

        }
        private void guna2ImageButton1_Leave(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Ordonnance obj = new Ordonnance();
            obj.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Produit obj = new Produit();
            obj.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Paiment obj = new Paiment();
            obj.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
