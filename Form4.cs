using System;
using System.IO;
using System.Windows.Forms;

namespace SuperStoreSystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
            xgrid2.Columns.Add("B", "Item-Name");
            xgrid2.Columns.Add("C", "Price");
            read();
      }


        private void read()
        {


            xgrid2.Rows.Clear();
            string[] Arr;

            StreamReader ab = new StreamReader("proceeditemdata.txt");

            while (!ab.EndOfStream)
            {

                Arr = ab.ReadLine().Split('#');


                xgrid2.Rows.Add(Arr[0], Arr[1]);

            }
            ab.Close();
            ab.Dispose();

        }

      
    }
}
