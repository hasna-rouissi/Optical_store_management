namespace Projet_OMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (Nom.Text == "" || ModePasse.Text == "")
            {
                MessageBox.Show("remplir les deux champs !!!");
            }
            else if(Nom.Text == "Saida Hasna" && ModePasse.Text == "Projet")
            {
                Accueil obj = new Accueil();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou Mode de passe est incorrecte ");
            }
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nom_Leave(object sender, EventArgs e)
        {
           
            if (Nom.Text == "")
            {
                Nom.Text = "Nom d'utilisateur";
                Nom.ForeColor = Color.Gray;
            }

        }
        private void Nom_Enter(object sender, EventArgs e)
        {
            if (Nom.Text == "Nom d'utilisateur")
            {
                Nom.Text = "";
                Nom.ForeColor = Color.Gray;
            }

        }
        private void ModePasse_Leave(object sender, EventArgs e)
        {
            if (ModePasse.Text == "")
            {
                ModePasse.Text = "Mode de Passe";
                ModePasse.ForeColor = Color.Gray;
            }

        }

        private void ModePasse_Enter(object sender, EventArgs e)
        {
            if (ModePasse.Text == "Mode de Passe")
            {
                ModePasse.Text = "";
                ModePasse.ForeColor = Color.Gray;
            }
        }
    }
}