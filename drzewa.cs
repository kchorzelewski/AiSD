using System.IO.Pipes;

namespace drzewa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var w1 = new Węzeł(5);
            var w2 = new Węzeł(2);
            var w3 = new Węzeł(1);
            var w4 = new Węzeł(3);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            var w5 = new Węzeł(4);
            var w6 = new Węzeł(6);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);
            A(w1);
            MessageBox.Show(napis);
        }
        public string napis = "";

        void A(Węzeł w)
        {
            napis += " " + w.wartosc.ToString();
            foreach (var dziecko in w.dzieci)
            {
                A(dziecko);
            }

        }
    }

    public class Węzeł
    {
        public int wartosc;
        public string napis;
        public List<Węzeł> dzieci = new List<Węzeł>();
        public Węzeł(int liczba)
        {
            this.wartosc = liczba;
        }
    }

}
