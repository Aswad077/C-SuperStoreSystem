using System;
using System.IO;
using System.Windows.Forms;

namespace SuperStoreSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          

            xgrid1.Columns.Add("A", "Item-Name");
            xgrid1.Columns.Add("B", "Price");

            read();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (txtbox3.Text == "")
            {

                MessageBox.Show("Input Searching Data", "Error");

            }

            else
            {
                xgrid1.Rows.Clear();
                string[] Arr;

                StreamReader ab = new StreamReader("Itemdata.txt");

                while (!ab.EndOfStream)
                {

                    Arr = ab.ReadLine().Split('#');

                    if (Arr[0] == txtbox3.Text )
                    {

                        xgrid1.Rows.Add(Arr[0], Arr[1]);
                    }
                }
                ab.Close();
                ab.Dispose();

            }
        }



        private void read() {


            xgrid1.Rows.Clear();
            string[] Arr;

            StreamReader ab = new StreamReader("Itemdata.txt");

            while (!ab.EndOfStream)
            {

                Arr = ab.ReadLine().Split('#');


                    xgrid1.Rows.Add(Arr[0], Arr[1]);
                
            }
            ab.Close();
            ab.Dispose();
        
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
