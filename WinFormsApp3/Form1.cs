using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WinFormsApp3
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string podana_liczba = textBox1.Text;
        }

        public string Wpisane
        {
            get { return textBox1.Text; }
        }
        public int[] Convert(string Wpisane)
        {
            var liczbyS = Wpisane.Trim().Split(" ");
            var liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }

        private Random random = new Random();

        private void button1_Click_3(object sender, EventArgs e)
        {
            int minValue = (int)numericUpDown1.Minimum;
            int maxValue = (int)numericUpDown1.Maximum;

            int randomNumber = random.Next(minValue, maxValue + 1);

            numericUpDown1.Value = randomNumber;
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = checkBox1.Checked;
            checkBox1.Enabled = checkBox1.Checked;
            button1.Enabled = checkBox1.Checked;

        }



        public string sortowanie(int[] Convert)
        {
            int nowa;
            bool cbz;
            do
            {
                cbz = false;
                for (int i = 0; i < (Convert.Length - 1); i++)
                {
                    if (Convert[i] > Convert[i + 1])
                    {
                        nowa = Convert[i];
                        Convert[i] = Convert[i + 1];
                        Convert[i + 1] = nowa;
                        cbz = true;
                    }
                }
            } while (cbz);
            string odp = "";
            for (int i = 0; i < Convert.Length; i++)
            {
                odp = odp + Convert[i].ToString() + " ";
            }
            return odp;
        }

        public string selection_sort(int[] Convert)
        {
            int n = Convert.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Convert[min_idx] > Convert[j])
                    {
                        min_idx = j;
                    }
                }
                int temp_min = Convert[min_idx];
                Convert[min_idx] = Convert[i];
                Convert[i] = temp_min;
            }

            string odp = "";
            for (int i = 0; i < Convert.Length; i++)
            {
                odp = odp + Convert[i].ToString() + " ";
            }
            return odp;
        }

        public string insert_sort(int[] Convert)
        {
            int n = Convert.Length;
            for (int i = 1; i < n; ++i)
            {
                int najw = Convert[i];
                int j = i - 1;

                while (j >= 0 && Convert[j] > najw)
                {
                    Convert[j + 1] = Convert[j];
                    j--;
                }
                Convert[j + 1] = najw;
            }
            string odp = "";
            for (int i = 0; i < Convert.Length; i++)
            {
                odp = odp + Convert[i].ToString() + " ";
            }
            return odp;
        }


        public string merge_sort(int[] Convert)
        {
            void merge(int[] Convert, int l, int m, int r)
            {
                int n1 = m - l + 1;
                int n2 = r - m;

                int[] L = new int[n1];
                int[] R = new int[n2];
                int i, j;

                for (i = 0; i < n1; ++i)
                    L[i] = Convert[l + i];
                for (j = 0; j < n2; ++j)
                    R[j] = Convert[m + 1 + j];

                i = 0;
                j = 0;

                int k = l;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        Convert[k] = L[i];
                        i++;
                    }
                    else
                    {
                        Convert[k] = R[j];
                        j++;
                    }
                    k++;
                }

                while (i < n1)
                {
                    Convert[k] = L[i];
                    i++;
                    k++;
                }

                while (j < n2)
                {
                    Convert[k] = R[j];
                    j++;
                    k++;
                }
            }

            int[] sort(int[] Convert, int l, int r)
            {
                if (l < r)
                {

                    int m = l + (r - l) / 2;

                    sort(Convert, l, m);
                    sort(Convert, m + 1, r);

                    merge(Convert, l, m, r);
                }
                return Convert;
            }

            int[] nowa = sort(Convert, 0, Convert.Length - 1);

            string odp = "";
            for (int i = 0; i < nowa.Length; i++)
            {
                odp = odp + nowa[i].ToString() + " ";
            }
            return odp;
        }


        public string quick_sort(int[] Convert)
        {
            int n = Convert.Length;
            static void zamiana(int[] Convert, int i, int j)
            {
                int temp = Convert[i];
                Convert[i] = Convert[j];
                Convert[j] = temp;
            }

            static int rozdziel(int[] Convert, int low, int high)
            {
                int pivot = Convert[high];

                int i = (low - 1);

                for (int j = low; j <= high - 1; j++)
                {

                    if (Convert[j] < pivot)
                    {

                        i++;
                        zamiana(Convert, i, j);
                    }
                }
                zamiana(Convert, i + 1, high);
                return (i + 1);
            }

            static void quick_sort_cw(int[] Convert, int low, int high)
            {
                if (low < high)
                {
                    int pi = rozdziel(Convert, low, high);

                    quick_sort_cw(Convert, low, pi - 1);
                    quick_sort_cw(Convert, pi + 1, high);
                }
            }
            quick_sort_cw(Convert, 0, n - 1);
            string odp = "";
            for (int i = 0; i < Convert.Length; i++)
            {
                odp = odp + Convert[i].ToString() + " ";
            }
            return odp;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            textBox2.Text = (quick_sort(Convert(Wpisane)));
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            label4.Text = $"Elapsed Time: {elapsedMs} milliseconds";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            textBox2.Text = merge_sort(Convert(Wpisane));
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            label4.Text = $"Elapsed Time: {elapsedMs} milliseconds";
        }

        private void btn_si_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            textBox2.Text = insert_sort(Convert(Wpisane));
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            label4.Text = $"Elapsed Time: {elapsedMs} milliseconds";
        }

        private void btn_ss_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            textBox2.Text = selection_sort(Convert(Wpisane));
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            label4.Text = $"Elapsed Time: {elapsedMs} milliseconds";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            textBox2.Text = sortowanie(Convert(Wpisane));
            watch.Stop();
            double elapsedMs = watch.ElapsedMilliseconds;
            label4.Text = $"Elapsed Time: {elapsedMs} milliseconds";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}