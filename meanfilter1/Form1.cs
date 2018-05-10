using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meanfilter1
{
    public partial class meanFilterForm : Form
    {
        public int stDev = 20;
        public int arithmosMetriseon = 0;

        public Random rand = new Random();

        public List<Point> pragmatikesMetriseis = new List<Point>();
        public List<Point> MetriseisMeThorivo = new List<Point>();
        public List<Point> M = new List<Point>();
        public List<Point> weightM = new List<Point>();





        public meanFilterForm()
        {
            InitializeComponent();
        }

        private void openTxtFileBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string fileN = openFileDialog1.FileName;
                selectFileTxt.Text = fileN;
                try
                {
                    int x;
                    int y;
                    int nX;
                    int nY;

                    int counter = 1;

                    using (var file = System.IO.File.OpenText(fileN))
                    {
                        while (!file.EndOfStream)
                        {
                            string line = file.ReadLine();
                            if (line.Length > 0)
                            {
                                string[] tmp = Regex.Split(line, @"\W+");
                                x = Int16.Parse(tmp[1]);
                                y = Int16.Parse(tmp[2]);

                                nX = Int16.Parse(tmp[4]);
                                nY = Int16.Parse(tmp[5]);

                                outputBase1.AppendText(counter + " ");

                                combineActualAndNoise(x, y, nX, nY);

                                mCalc();

                                mWCalc();

                                counter++;
                            }
                        }
                    }

                }
                catch (IOException)
                {
                    //
                }
            }


        }




        public void combineActualAndNoise(int x, int y, int nx, int ny)
        {
            Point p = new Point(x, y);

            arithmosMetriseon++;
            pragmatikesMetriseis.Add(p);
            outputBase1.AppendText("Actual values (" + x + "," + y + ")");

            double u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - rand.NextDouble();

            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)

            nx = (int)(randStdNormal * stDev) + x;
            ny = (int)(randStdNormal * stDev) + y;

            Point p2 = new Point(nx, ny);
            MetriseisMeThorivo.Add(p2);

            outputBase1.AppendText("---");
            outputBase1.AppendText("Noisy values (" + nx + "," + ny + ")" + Environment.NewLine);

        }

        public void mCalc()
        {
            int mX = 0;
            int mY = 0;

            int lp = Math.Min(arithmosMetriseon, 10);

                for (int i = 0; i < lp; i++)
                {
                    mX += MetriseisMeThorivo[MetriseisMeThorivo.Count-i-1].X;
                    mY += MetriseisMeThorivo[MetriseisMeThorivo.Count-i-1].Y;
                }

                mX = (mX / lp);
                mY = (mY / lp);
                Point p = new Point(mX, mY);
                M.Add(p);


        }


        public void mWCalc()
        {
            int wmX = 0;
            int wmY = 0;
            int sum = 0;

            int lp = Math.Min(arithmosMetriseon, 10);

            for (int i = 0; i < lp; i++)
            {
                wmX += (10 - i) * (MetriseisMeThorivo[MetriseisMeThorivo.Count - i - 1].X);
                wmY += (10 - i) * (MetriseisMeThorivo[MetriseisMeThorivo.Count - i - 1].Y);
                sum += 10 - i;
            }

            wmX = wmX / sum;
            wmY = wmY / sum;
            Point p = new Point(wmX, wmY);
            weightM.Add(p);

            
        }

        private void meanBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < M.Count; i++)
            {
                outputMean.AppendText(M[i].X + "," + M[i].Y + Environment.NewLine);
            }
        }

        private void wMeanBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < weightM.Count; i++)
            {
                outputWeighted.AppendText(weightM[i].X + "," + weightM[i].Y + Environment.NewLine);
            }

        }

        private void distBtn_Click(object sender, EventArgs e)
        {
            double div1 = 0;
            double div2 = 0;
            double div3 = 0;

            for (int i=0; i< pragmatikesMetriseis.Count; i++)
            {

                div1 += Point.EucDist(pragmatikesMetriseis[i], MetriseisMeThorivo[i]);
                div2 += Point.EucDist(pragmatikesMetriseis[i], M[i]);
                div3 += Point.EucDist(pragmatikesMetriseis[i], weightM[i]);
            }
            div1 = div1 / pragmatikesMetriseis.Count;
            div2 = div2 / pragmatikesMetriseis.Count;
            div3 = div3 / pragmatikesMetriseis.Count;

            tb1.Text = div1.ToString();
            tb2.Text = div2.ToString();
            tb3.Text = div3.ToString();

        }
    }
}

