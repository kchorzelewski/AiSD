using System.IO.Pipes;
using System.Linq;

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
        public List<Wezel3> odwiedzone = new();
        public Queue<Wezel3> kolejka = new();
        private void button1_Click(object sender, EventArgs e)
        {
            
            var w1 = new Wezel3(1);
            var w2 = new Wezel3(2);
            var w3 = new Wezel3(3);
            var w4 = new Wezel3(4);
            var w5 = new Wezel3(5);
            var w6 = new Wezel3(6);
            w1.sasiedzi.Add(w2);
            w3.sasiedzi.Add(w1);
            w2.sasiedzi.Add(w4);
            w2.sasiedzi.Add(w1);
            w1.sasiedzi.Add(w3);
            w3.sasiedzi.Add(w6);
            w2.sasiedzi.Add(w5);
            //w4.sasiedzi.Add(w6);
            w6.sasiedzi.Add(w3);
            w4.sasiedzi.Add(w2);
            w5.sasiedzi.Add(w2);
            //w6.sasiedzi.Add(w4);

            BFS(w1);
            MessageBox.Show(napis);
        }
        public string napis = "";

        void A(Wezel3 w)
        {
            foreach (var sasiad in w.sasiedzi)
            {
                if (!odwiedzone.Contains(sasiad))
                {
                    napis += " " + w.wartosc.ToString();
                    odwiedzone.Add(w);
                }
                A(sasiad);

            }
        }

        void BFS(Wezel3 w)
        {
            napis += w.wartosc.ToString();
            kolejka.Enqueue(w);
            odwiedzone.Add(w);
            while (kolejka.Count > 0)
            {
                Wezel3 actual = kolejka.Dequeue();
                //MessageBox.Show(actual.ToString());
                foreach (var sasiad in actual.sasiedzi)
                {
                    
                    if (!odwiedzone.Contains(sasiad))
                    {
                        kolejka.Enqueue(sasiad);
                        odwiedzone.Add(sasiad);
                        napis += " " + sasiad.wartosc.ToString();

                    }
                }
            }
        }
    }

    public class Wêze³
    {
        public int wartosc;
        public string napis;
        public List<Wêze³> dzieci = new List<Wêze³>();
        public Wêze³(int liczba)
        {
            this.wartosc = liczba;
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

    public class Wezel3
    {
        public int wartosc;
        public string napis;
        public List<Wezel3> sasiedzi = new List<Wezel3>();
        public Wezel3(int liczba)
        {
            this.wartosc = liczba;
        }
    }

}