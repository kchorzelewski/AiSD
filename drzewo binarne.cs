using System.Configuration;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;

namespace bfs
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

            var d = new DrzewoBinarne(5);
            d.Add(8);
            d.Add(4);
            d.Add(7);
            d.Add(3);
            d.Add(1);
            d.Add(10);

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

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(587, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private Button button1;
        private Button button2;

        private void button2_Click(object sender, EventArgs e)
        {
            var d = new DrzewoBinarne(5);
            d.Add(3);
            d.Add(6);
            d.Add(10);
            d.Add(8);
            d.Add(1);

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
        public override string ToString()
        {
            return "Wartosc: " + this.wartosc.ToString();
        }

        public int wartosc;
        public string napis;
        public List<Wezel3> sasiedzi = new List<Wezel3>();
        public Wezel3(int liczba)
        {
            this.wartosc = liczba;
        }
        public Wezel3 leweDziecko;
        public Wezel3 praweDziecko;
        public Wezel3 rodzic;

        public void Add(int liczba)
        {

            this.wartosc.ToString();

            var dziecko = new Wezel3(liczba);
            dziecko.rodzic = this;
            if (liczba < this.wartosc)
            {
                this.leweDziecko = dziecko;
            }
            else
            {
                this.praweDziecko = dziecko;
            }
        }
    }

    public class DrzewoBinarne
    {
        public Wezel3 Znajdz(int liczba)
        {
            var w = this.korzen;
            while (true)
            {
                if(w.wartosc == liczba)
                {
                    return w;
                }

                if (liczba < w.wartosc)
                {
                    if (w.leweDziecko == null)
                    {
                        return null;
                    }
                    else
                    {
                        w = w.leweDziecko;
                    }
                }
                else
                {
                   if (w.praweDziecko == null)
                   {
                       return null;
                   }
                   else
                   {
                       w = w.praweDziecko;
                   }

                }
                
            }
            // zwrocic wezel, który posiada taką wartość
            // jak będą dwie liczby, to ma zwrócić tą pierwszą napotkaną
            // return wezel albo null
        }

        public Wezel3 znajdzMin(Wezel3 w)
        {

            while(w.leweDziecko != null)
            {
                w = w.leweDziecko;
            }
            //if (w.leweDziecko != null)
            //{
            //    znajdzMin(w.leweDziecko);
            //}

            // znajdz najmniejszą minimalną wartość
            // cały czas idziemy w lewo tak daleko jak się da
            // jak nie mogę dalej iść w lewo, to to jest najmniejsza warość
            return w;
        }
        public Wezel3 znajdzMax(Wezel3 w)
        {
            if (w.praweDziecko != null)
            {
                znajdzMax(w);
            }
            // tak jak największą wartość 
            return w;
        }
        public Wezel3 nastepnik(Wezel3 w)
        {
            if (w.praweDziecko != null)
            {
                return this.znajdzMin(w.praweDziecko);
            }
            while (w.rodzic != null)
            {
                if (w.rodzic.leweDziecko == w)
                {
                    return w.rodzic;
                }
                w = w.rodzic;
            }
            // a) jeżeli jest prawe dziecko
            //      znajdzMin(w.praweDziecko) -> nastepnik
            // b) jeżeli nie ma prawego dziecka
            //      idź do góry tak długo aż wyjdziesz w rodzicu jako lewe dziecko
            //      następnikiem jest rodzic 
            // c) jeżeli nie ma prawego dziecka i nie zachodzi "b)", ale nie ma już rodzica, bo jestem w korzeniu wtedy nie ma następnika
            // ma wskazywać kolejne wartości w drzewie (1, 2, 3, 4, 5, 5, 8)
            // if, else if, else    
            return null;
        }
        public Wezel3 poprzednik()
        {
            // następnik jest taki sam jak poprzednik, tylko że łatwiejszy
            return null;
        }

        public Wezel3 usun(Wezel3 w)
        {
            if (w.leweDziecko == null && w.praweDziecko == null)
            {
                if(w.wartosc > w.rodzic.wartosc)
                {
                    
                    w.rodzic.praweDziecko = null;
                }
                
            }
            // 1) gdy nie ma dzieci, odwiązujemy węzeł
            // najpierw kasujemy rodzic -> dziecko, a potem dziecko -> rodzic
            // 2) gdy jest jedno dziecko, to dziecko wchodzi w miejsce usuwanego węsła
            // 3) gdy 2 dzieci, to bierzem następnik
            //    Następnik może mieć jedno lub zero dzieci 
            //    zwalniamy następnik wg (1) lub (2) i wstawiamy
            //    w miejsce usuwanego węzła
        }

        Wezel3 znajdzWezel(int liczba)
        {
            var w = this.korzen;
            return w;
        }

        public Wezel3 korzen;
        public int liczbawezlow;
        public DrzewoBinarne(int liczba)
        {
            this.korzen = new(liczba);
            this.liczbawezlow = 1;
        }
        public void Add(int liczba)
        {
            var rodzic = this.znajdzRodzica(liczba);
            rodzic.Add(liczba);
        }
        public Wezel3 znajdzRodzica(int liczba)
        {
            //this.wartosc.toString()
            var w = this.korzen;
            while (true)
            {
                if (liczba < w.wartosc)
                {
                    if (w.leweDziecko == null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.leweDziecko;
                    }
                }
                else
                {
                    if (w.praweDziecko == null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.praweDziecko;
                    }
                }
            }
        }
    }



}
