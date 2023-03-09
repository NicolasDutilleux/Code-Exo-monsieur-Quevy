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
        int touche;
        public Form1()
        {
            InitializeComponent();
            tb = textBox1;
            label1.Visible = false;
            label2.Visible = false;
            Euro.Visible = false;
            Francs.Visible = false;
        }

        private void NumberClick(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            // remettre le texte à "" quand on va retaper un chiffre apres avoir tapé sur un opérateur (+, - etc)
            if (t == 1)
            {
                tb.Text = "";
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

                // Faire le calcul avec op stocké précédemment dans la mémoire
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
            // stocker l'opérateur qui vient d'être pressé, passer t = 1 pour permettre de reset à "" dans "NumberClick"
            op = o.Text;
            t = 1;
            if (op == "=")
            {
                op = "";
            }
        }

        private void WhenCClick(object sender, EventArgs e)
        {
            //tout reset dans C est click et aussi remettre calculatrice normale si on est en euro Francs
            tb.Text = "";
            op = "";
            if (Euro.Visible == true)
            {
                label1.Visible = false;
                label2.Visible = false;
                Euro.Visible = false;
                Francs.Visible = false;
                textBox1.Visible = true;
            }
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
            // efface le caractere au bout du "string" de la textbox ( au bout du text dans textBox.Text)
            String s = tb.Text;
            s = s.Remove(s.Length - 1);
            tb.Text = s;

        }

        private void ClickEuro(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            Euro.Visible = true;
            Francs.Visible = true;
            textBox1.Visible = false;

        }

        private void Francs_TextChanged(object sender, EventArgs e)
        {
            if (Francs.TextLength != 0)
            {
                float franc = float.Parse(Francs.Text);
                float euro = franc / 40;
                Euro.TextChanged -= new EventHandler(Euro_TextChanged);
                Euro.Text = euro.ToString();
                Euro.TextChanged += new EventHandler(Euro_TextChanged);

            }

            else
            {
                Euro.TextChanged -= new EventHandler(Euro_TextChanged);
                Euro.Text = "";
                Euro.TextChanged += new EventHandler(Euro_TextChanged);
            }
        }

        private void Euro_TextChanged(object sender, EventArgs e)
        {
            if (Euro.TextLength != 0)
            {
                float euro = float.Parse(Euro.Text);
                float franc = euro * 40;
                Francs.TextChanged -= new EventHandler(Francs_TextChanged);
                Francs.Text = franc.ToString();
                Francs.TextChanged += new EventHandler(Francs_TextChanged);
            }
            else
            {
                Francs.TextChanged -= new EventHandler(Francs_TextChanged);
                Francs.Text = "";
                Francs.TextChanged += new EventHandler(Francs_TextChanged);
            }
        }

        private void verif1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && touche == 0)
            {
                e.Handled = true;
                touche = 1;
            }
        }

        private void verif2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                touche = 1;
            }
            else
            {
                touche = 0;
            }
        }

        private void WhenTbClick(object sender, EventArgs e)
        {
            //focus sur la barre sur laquelle on a cliqué
            tb = (TextBox)sender;
        }
    }
}