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
    public partial class Produit : Form
    {
        public Produit()
        {
            InitializeComponent();
            GetlistMonture();
            GetIdClient();
            GetlistVerre();
            GetIdClientVerre();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TVT7T8S\\SQLEXPRESS;Initial Catalog=MO_DB;Integrated Security=True");


        private void Monture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*---------------------information datagridview--------------------------*/
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idClientMCB1.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            TypeMCB2.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            CategorieMCB3.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            CouleurMCB4.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            prixMT.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            FormMCB5.Text = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Accueil obj = new Accueil();
            obj.Show();
            this.Hide();
        }

        /*---------------------insertion monture--------------------------*/

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            String id = idClientMCB1.Text;
            String type = TypeMCB2.Text;
            String cat = CategorieMCB3.Text;
            String clr = CouleurMCB4.Text;
            String prix = prixMT.Text;
            String forme = FormMCB5.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("exec  Insert_Monture '" +id + "','" + type + "','" + cat + "'," +
                "'" + clr + "','" + prix + "','" + forme + "'", con);
            cmd.ExecuteNonQuery();
            GetlistMonture();
            con.Close();
        }

        /*---------------------Get id client--------------------------*/
        void GetIdClient()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select id_Client from Ordonnance ", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_Client", typeof(int));
            dt.Load(sdr);
            idClientMCB1.ValueMember = "id_Client";
            idClientMCB1.DataSource = dt;
            con.Close();

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*---------------------supprimer monture--------------------------*/

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int ClientId = int.Parse(idClientMCB1.Text);

            con.Open();
            SqlCommand cmd = new SqlCommand("exec  Delete_Monture '" + ClientId + "'", con);
            cmd.ExecuteNonQuery();
   
            GetlistMonture();
            con.Close();
        }

        /*---------------------update monture--------------------------*/

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            
            String id = idClientMCB1.Text;
            String type = TypeMCB2.Text;
            String cat = CategorieMCB3.Text;
            String clr = CouleurMCB4.Text;
            String prix = prixMT.Text;
            String forme = FormMCB5.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("exec  Update_Monture '" + id + "','" + type + "','" + cat + "'," +
                "'" + clr + "','" + prix + "','" + forme + "'", con); 
            cmd.ExecuteNonQuery();
            GetlistMonture();
            con.Close();
        }
       

        /*---------------------afficher Monture--------------------------*/

        void GetlistMonture()
        {
            SqlCommand cmd2 = new SqlCommand("exec listMonture", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }
        /* -------------------------   Verre  -----------------------------*/
        /*---------------------insertion verre--------------------------*/
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            String id = idCBV.Text;
            String type = TypeCBV.Text;
            String mat = matCBV.Text;
            String trait = traitCBV.Text;
            String prix = PrixTBV.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("exec  Insert_Verre '" + id + "','" + type + "','" + mat + "'," +
                "'" + trait + "','" + prix + "'", con);
            cmd.ExecuteNonQuery();
            GetlistVerre();
            con.Close();
        }
        /*---------------------inforamation Datagridview Verre--------------------------*/

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCBV.Text = guna2DataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            TypeCBV.Text = guna2DataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            matCBV.Text = guna2DataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            traitCBV.Text = guna2DataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            PrixTBV.Text = guna2DataGridView2.SelectedRows[0].Cells[5].Value.ToString();
          
        }
        /*---------------------update verre--------------------------*/

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(idCBV.Text);
            String type = TypeCBV.Text;
            String mat = matCBV.Text;
            String trait = traitCBV.Text;
            String prix = PrixTBV.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("exec  Update_Verre '" + Id + "','" + type + "'," +
                "'" + mat + "','" + trait + "','" + prix + "'", con);
            cmd.ExecuteNonQuery();
            GetlistVerre();
            con.Close();
        }
        /*---------------------supprimer verre--------------------------*/
       
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(idCBV.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec  Delete_Verre '" + Id + "'", con);
            cmd.ExecuteNonQuery();
            GetlistVerre();
            con.Close();
        }
        /*--------------------affichage verre--------------------------*/
        void GetlistVerre()
        {
            SqlCommand cmd2 = new SqlCommand("exec listVerre", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView2.DataSource = dt;
        }
        /**---------------------------Get id client verre ----------------------------------*/
        void GetIdClientVerre()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select id_Client from Ordonnance ", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_Client", typeof(int));
            dt.Load(sdr);
            idCBV.ValueMember = "id_Client";
            idCBV.DataSource = dt;
            con.Close();

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_DoubleClick(object sender, EventArgs e)
        {
            idCBV.Text = string.Empty;
            TypeCBV.Text = string.Empty;
            matCBV.Text = string.Empty;
            traitCBV.Text = string.Empty;
            PrixTBV.Text = string.Empty;
        }

        private void tabPage1_DoubleClick(object sender, EventArgs e)
        {
            idClientMCB1.Text = string.Empty;
            TypeMCB2.Text=String.Empty;
            CategorieMCB3.Text=String.Empty;
            CouleurMCB4.Text= String.Empty;
            prixMT.Text= String.Empty;
            FormMCB5.Text= String.Empty;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Accueil obj = new Accueil();
            obj.Show();
            this.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
