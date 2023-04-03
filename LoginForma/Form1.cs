namespace LoginForma
{
    public partial class Login : Form
    {
        /*
         * za slucaj da smo koristili dve odvojene liste stringova
        private List<string> userName = new List<string>();
        private List<string> password = new List<string>();
        */
        private Dictionary<string, string> recnik = new Dictionary<string, string>();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLozinka.PasswordChar = '*';
            /*
             * za slucaj da smo koristili dve odvojene liste stringova
            userName.Add("milan");
            password.Add("milan1");
            userName.Add("ana");
            password.Add("ana1");
            userName.Add("uros");
            password.Add("uros1");
            */

            //koriscnje dictionary tj recnika
            recnik["milan"] = "milan1";
            recnik["ana"] = "ana1";
            recnik["uros"] = "uros1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            /*
             * za slucaj da je korisceno dve liste
            for (int i = 0; i < userName.Count; i++)
            {
                if (korisnickoIme == userName[i])
                {
                    if (lozinka == password[i])
                    {
                        MessageBox.Show("Logovanje je uspelo");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Netacna sifra za logovanje");
                        return;
                    }
                }
            }
            MessageBox.Show("Nepostoji uneto korisnicko ime");
            */

            // koriscnje recnika za optimalni kod
            if (recnik.Keys.Contains(korisnickoIme))
            {
                if (recnik[korisnickoIme] == lozinka)
                    MessageBox.Show("Logovanje je uspelo");
                else
                    MessageBox.Show("Lozinka nije ispravna");
            }
            else
            {
                MessageBox.Show("Korisnicko ime ne postoji");
            }
        }
    }
}