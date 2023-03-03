namespace Nico_Exo_2
{


    public partial class Form1 : Form
    {
        float var1;
        float t;
        float var2;
        TextBox tb;
        string op = "";
        float resultat;
        double resultattrigo;
        public Form1()
        {
            InitializeComponent();
            tb = textBox1;
        }

        private void NumberClick(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            if (t == 1)
            {
                tb.Text = "" ;
                t = 0;

            }
            tb.Text += c.Text;
        }

        private void WhenoperateurClick(object sender, EventArgs e)
        {
            
            if (op == "")
            {
                var1 = float.Parse(tb.Text);
            }
            if (op != "")
            {
                var2 = float.Parse(tb.Text);


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
            t = 1;
            if (op == "=")
            {
                op = "";
            }
            
              
            
           
            
            
            





        }

        private void WhenCClick(object sender, EventArgs e)
        {
            tb.Text = "";
            op = "";
        }

        private void Trigono(object sender, EventArgs e)
        {
            Button tri = (Button)sender;
            if (tri.Text == "sin")
            {
                resultattrigo = Math.Sin(float.Parse(tb.Text) * (3.14 / 180));
            }
            else if (tri.Text == "tan")
            {
                resultattrigo = Math.Tan(float.Parse(tb.Text) * (3.14 / 180));
            }
            else if (tri.Text == "cos")
            {
                resultattrigo = Math.Cos(float.Parse(tb.Text) * (3.14 / 180));
                
            }
            tb.Text = resultattrigo.ToString();
        }

        private void ClickEffacer(object sender, EventArgs e)
        {
            String s = tb.Text;
            s = s.Remove(s.Length - 1);
            tb.Text = s;

        }
    }
}