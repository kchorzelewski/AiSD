using System.Configuration;
using System.Diagnostics;
using System.Threading;

namespace AiSD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Enabled = false;
            generujButton.Enabled = false;
            numericUpDown1.Maximum = 2000000;
        }

        public static int[] generated_list;
        int[] convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            var liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }
        void print(int[] tab)
        {
            string text = "";
            for (int i = 0; i < tab.Length; i++)
            {
                text += tab[i] + " ";
            }
            outputTextBox.Text = text;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                inputTextBox.Enabled = false;
                outputTextBox.Enabled = false;

                numericUpDown1.Enabled = true;
                generujButton.Enabled = true;
            }
            else
            {
                inputTextBox.Enabled = true;
                outputTextBox.Enabled = true;

                numericUpDown1.Enabled = false;
                generujButton.Enabled = false;
            }
        }

        int[] bubbleSort(int[] tab)
        {
            bool cbz;
            do
            {
                cbz = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        (tab[i], tab[i + 1]) = (tab[i + 1], tab[i]);
                        cbz = true;
                    }
                }
            } while (cbz);
            return tab;
        }

        int[] selectionSort(int[] tab)
        {
            return tab;
        }
        int[] insertSort(int[] tab)
        {
            return tab;
        }
        int[] mergeSort(int[] tab)
        {
            return tab;
        }
        int[] quickSort(int[] tab)
        {
            return tab;
        }

        private void sbButton_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                int[] tab = convert(inputTextBox.Text);
                tab = bubbleSort(tab);
                print(tab);
            }
            else
                stopwatch(0);
        }
        private void ssButton_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                int[] tab = convert(inputTextBox.Text);
                tab = selectionSort(tab);
                print(tab);
            }
            else
                stopwatch(1);
        }
        private void siButton_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                int[] tab = convert(inputTextBox.Text);
                tab = insertSort(tab);
                print(tab);
            }
            else
                stopwatch(2);
        }
        private void smButton_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                int[] tab = convert(inputTextBox.Text);
                tab = mergeSort(tab);
                print(tab);
            }
            else
                stopwatch(3);
        }
        private void sqButton_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                int[] tab = convert(inputTextBox.Text);
                tab = quickSort(tab);
                print(tab);
            }
            else
                stopwatch(4);
        }
        void stopwatch(int choose)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            choose_algorithm(choose);
            time.Stop();
            var elapsed_time = time.Elapsed;
            czas.Text = elapsed_time.Seconds.ToString() + "." + elapsed_time.Milliseconds.ToString();
        }
        
        void generate(int n)
        {
            Random rnd = new Random();
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = rnd.Next();
            }
            generated_list = result;
        }

        private void generujButton_Click(object sender, EventArgs e)
        {
            generate((int)numericUpDown1.Value);
        }

        int[] choose_algorithm(int choose)
        {
            switch (choose)
            {
                case 0:
                    return bubbleSort(generated_list);
                case 1:
                    return selectionSort(generated_list);
                case 2:
                    return insertSort(generated_list);
                case 3:
                    return mergeSort(generated_list);
                case 4:
                    return quickSort(generated_list);
            }
            return new int[0];
        }
    }
}
