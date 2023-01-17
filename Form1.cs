using System;
using System.IO;
using System.Windows.Forms;

namespace SuperStoreSystem
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();

          
            xgrid.Columns.Add("A", "Item-Name");
            xgrid.Columns.Add("B", "Price");
            read();
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            

            if (txtbox1.Text == "" && txtbox2.Text == "")
            {


                MessageBox.Show("Input Data Please", "Error");

            }
            else
            {
                StreamWriter abc = new StreamWriter("Itemdata.txt", true);



                abc.WriteLine(txtbox1.Text + "#" + txtbox2.Text);
                abc.Close();
                abc.Dispose();

                txtbox1.Text = txtbox2.Text = null;


                read();

              
            }
        }


       


        private void read() {


            xgrid.Rows.Clear();
            string[] Arr;

            StreamReader ab = new StreamReader("Itemdata.txt");

            while (!ab.EndOfStream) {

                Arr = ab.ReadLine().Split('#');

                xgrid.Rows.Add( Arr[0], Arr[1]);
            
            }
            ab.Close();
            ab.Dispose();
        
        
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
