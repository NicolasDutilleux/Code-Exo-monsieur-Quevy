namespace Nico_Exo_2
{


    public partial class Form1 : Form
    {
        float var1;
        string compteur;
        float var2;
        TextBox tb;
        string op = "";
        float resultat;
        public Form1()
        {
            InitializeComponent();
            tb = textBox1;
        }

        private void NumberClick(object sender, EventArgs e)
        {
            Button c = (Button)sender;

            tb.Text += c.Text;
            compteur += c.Text;
        }

        private void WhenoperateurClick(object sender, EventArgs e)
        {
            
            if (op == "")
            {
                var1 = float.Parse(compteur);
            }
            if (op != "")
            {
                var2 = float.Parse(compteur);


                if (op == "+")
                {
                    resultat = var1 + var2;
                    tb.Text = resultat.ToString();
                }
                else if (op == "-")
                {
                    resultat = var1 - var2;
                    tb.Text = resultat.ToString();
                }
                else if (op == "*")
                {
                    resultat = var1 * var2;
                    tb.Text = resultat.ToString();
                }
                else if (op == "/")
                {
                    resultat = var1 / var2;
                    tb.Text = resultat.ToString();
                }
                var1 = resultat;
            }
            Button o = (Button)sender;
            
            op = o.Text;
            if (op != "=")
            {
                tb.Text += o.Text;
            }
           
            
            
            compteur = "";





        }
    }
}