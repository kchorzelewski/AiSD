using System.IO.Pipes;

namespace Drzewa_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var w5 = new Wezel2(5);
            var w3 = new Wezel2(3);
            var w2 = new Wezel2(2);
            var w4 = new Wezel2(4);
            var w1 = new Wezel2(1);
            var w8 = new Wezel2(8);
            var w6 = new Wezel2(6);
            w5.sasiedzi.Add(w3);
            w5.sasiedzi.Add(w1);
            w3.sasiedzi.Add(w2);
            w3.sasiedzi.Add(w4);
            w3.sasiedzi.Add(w5);
            w2.sasiedzi.Add(w8);
            //w2.sasiedzi.Add(w8);
            w4.sasiedzi.Add(w3);
            w1.sasiedzi.Add(w3);
            w1.sasiedzi.Add(w8);
            w1.sasiedzi.Add(w6);
            w8.sasiedzi.Add(w1);
            //w8.sasiedzi.Add(w2);
            w6.sasiedzi.Add(w1);
            A(w5);
            MessageBox.Show(napis);
            odwiedzone.Clear();
            //BFS
        }
        public string napis = "";
        List<Wezel2> odwiedzone = new();
        void A(Wezel2 w)
        {
            napis += " " + w.wartosc.ToString();
            foreach(var sasiad in w.sasiedzi)
            {
                
                MessageBox.Show(sasiad.ToString());
                A(sasiad);
            }
        }
    }
    public class Wezel2
    {
        public int wartosc;
        public string napis;
        public List<Wezel2> sasiedzi = new List<Wezel2>();
        public Wezel2(int liczba)
        {
            this.wartosc = liczba;
        }
    }
}
