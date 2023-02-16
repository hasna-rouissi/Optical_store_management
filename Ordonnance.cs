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
    public partial class Ordonnance : Form
    {
        public Ordonnance()
        {
            InitializeComponent();
            GetIdClient();
            GetlistOrdonnance();
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        /*--------------------afficher id client-------------------*/
        void GetIdClient()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select id_Client from Clients ",con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_Client", typeof(int));
            dt.Load(sdr);
            Id_clientCB.ValueMember = "id_Client";
            Id_clientCB.DataSource = dt;
            con.Close();

        }
        /*--------------------afficher nom -------------------*/
        void getNomClient()
        {
            con.Open();
            String Query="Select *from Clients where id_Client="+Id_clientCB.SelectedValue.ToString()+"";
            SqlCommand cmd1 = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                textBox2_Nom.Text = dr["Nom"].ToString();
            }

            con.Close();
        }
        /*--------------------afficher Docteur-------------------*/
        void getDocteurClient()
        {
            con.Open();
            String Query = "Select *from Clients where id_Client=" + Id_clientCB.SelectedValue.ToString() + "";
            SqlCommand cmd1 = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox3_Docteur.Text = dr["Docteur"].ToString();
            }
            con.Close();
        }


        private void Id_clientCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getNomClient();
            getDocteurClient();
        }

        private void textBox3_Docteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TVT7T8S\\SQLEXPRESS;Initial Catalog=MO_DB;Integrated Security=True");

        /*--------------------Enregistrer Ordonnance-------------------*/
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String IdClient = Id_clientCB.Text;
            String sphere1 = sph1.Text;
            String sphere2 = sph2.Text;

            String cylindre1 = cyl1.Text;
            String cylindre2 = cyl2.Text;

            String axe_1 = axe1.Text;
            String axe_2 = axe2.Text;

            String add_1 = add1.Text;
            String add_2 = add2.Text;

            con.Open();
            SqlCommand cmd2 = new SqlCommand("exec  insert_Ordonnance '" + sphere1 + "','" + sphere2 + "','" + cylindre1 + "'," +
                "'" + cylindre2 + "','" + axe_1 + "','" + axe_2 + "','" + add_1 + "','"+add_2+"','"+IdClient+"'", con);
            cmd2.ExecuteNonQuery();
            GetlistOrdonnance();
            con.Close();
        }

        /*-------------------- List Ordonnance -------------------*/
        void GetlistOrdonnance()
        {
            SqlCommand cmd2 = new SqlCommand("exec listOrdonnance", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView1.DataSource = dt;

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Accueil obj = new Accueil();
            obj.Show();
            this.Hide();
        }

        private void Ordonnance_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String IdClient = Id_clientCB.Text;
            String sphere1 = sph1.Text;
            String sphere2 = sph2.Text;

            String cylindre1 = cyl1.Text;
            String cylindre2 = cyl2.Text;

            String axe_1 = axe1.Text;
            String axe_2 = axe2.Text;

            String add_1 = add1.Text;
            String add_2 = add2.Text;

            con.Open();
            SqlCommand cmd2 = new SqlCommand("exec  Update_Ordonnance '" + sphere1 + "','" + sphere2 + "','" + cylindre1 + "'," +
                "'" + cylindre2 + "','" + axe_1 + "','" + axe_2 + "','" + add_1 + "','" + add_2 + "','" + IdClient + "'", con);
            cmd2.ExecuteNonQuery();
            GetlistOrdonnance();
            con.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Id_clientCB.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec  Delete_Ordonnance '" + Id + "'", con);
            cmd.ExecuteNonQuery();
            GetlistOrdonnance();
            con.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_clientCB.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            getNomClient();
            getDocteurClient();
            sph1.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            sph2.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cyl1.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cyl2.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            axe1.Text = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            axe2.Text = guna2DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            add1.Text = guna2DataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            add2.Text = guna2DataGridView1.SelectedRows[0].Cells[9].Value.ToString();
          

        }

        private void Ordonnance_DoubleClick(object sender, EventArgs e)
        {
            Id_clientCB.Text = string.Empty;
            textBox2_Nom.Text = String.Empty;
            textBox3_Docteur.Text = String.Empty;
            sph1.Text = String.Empty;
            sph2.Text = String.Empty;
            cyl1.Text = String.Empty;
            cyl2.Text = String.Empty;
            axe1.Text = String.Empty;
            axe2.Text = String.Empty;
            add1.Text = String.Empty;
            add2.Text = String.Empty;
          
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
