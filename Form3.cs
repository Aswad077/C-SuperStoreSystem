using System;
using System.IO;
using System.Windows.Forms;

namespace SuperStoreSystem
{
    public partial class Form3 : Form
    {

        private int e, r;

        public Form3(string level)
        {
            InitializeComponent();


            xgrid3.Columns.Add("A", "Item");
            xgrid3.Columns.Add("B", "Price");
            e = r = 0;
            readcmbbox();
            if (level.Equals("Admin"))
            {

                searchmnu.Enabled = true;
                insertmnu.Enabled = true;
                cstmnu.Enabled = true;

            }

            else {


                searchmnu.Enabled = true;
                insertmnu.Enabled = false;
                cstmnu.Enabled = false;

            }

        }



        private void namemnu_Click(object sender, EventArgs e)
        {

            new Form2().Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }


        private void Btn_add_Click(object sender, EventArgs e)
        {


            if (cmbbox1.Text == string.Empty)
            {

                MessageBox.Show("Input Data Please", "Error");

            }
            else
            {
                string[] Arr;
                Arr = cmbbox1.Text.Split('#');
                txtbox6.Text = Arr[0];
                txtbox7.Text = Arr[1];
                StreamWriter ab = new StreamWriter("customerItemdata.txt", true);
                ab.WriteLine(txtbox6.Text + "#" + txtbox7.Text);
                ab.Close();
                ab.Dispose();

                read();
                total();
                itemquantity();

            }
        }


        private void total()
        {

            e = Convert.ToInt32(txtbox7.Text);
            r = e + r;
            txtbox8.Text = r.ToString();
        }


        private void read()
        {


            xgrid3.Rows.Clear();
            string[] Arr;

            StreamReader ab = new StreamReader("customerItemdata.txt");

            while (!ab.EndOfStream)
            {

                Arr = ab.ReadLine().Split('#');

                xgrid3.Rows.Add(Arr[0], Arr[1]);

            }
            ab.Close();
            ab.Dispose();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool a = false;
            cmbbox1.Items.Clear();

            if (!File.Exists("Itemdata.txt"))
            {


                File.CreateText("Itemdata.txt");


                a = true;
            }

            else if (true)
            {
                StreamReader abc = new StreamReader("Itemdata.txt");

                while (!abc.EndOfStream)
                {

                    cmbbox1.Items.Add(abc.ReadLine());

                }
                abc.Close();
            }


            else
            {



            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            StreamWriter ab = new StreamWriter("customerItemdata.txt");
            ab.Close();
            ab.Dispose();


            read();
            txtbox6.Text = txtbox7.Text = txtbox8.Text = cmbbox1.Text = null;
            e = null;
            r = 0;
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {


            if (txtbox6.Text == string.Empty) { }

            else
            {


                DialogResult dialogResult = MessageBox.Show("Entering  Data", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                if (dialogResult == DialogResult.Yes)
                {


                    using (TextWriter w = new StreamWriter("proceeditemdata.txt", true))
                    {
                        for (int i = 0; i < xgrid3.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < xgrid3.Columns.Count; j++)
                            {
                                w.Write(xgrid3.Rows[i].Cells[j].Value.ToString());

                                if (j != xgrid3.Columns.Count - 1)
                                {
                                    w.Write("#");
                                }
                            }

                            w.WriteLine();
                        }
                       
                        w.WriteLine("Total:" + "#" + txtbox8.Text+"#Time:"+DateTime.Now.ToString("ddd-mmm-yyy"));
                        w.Write("Superstore#managementsystem");
                        w.WriteLine();
                    }


                    xgrid3.Rows.Clear();

                    StreamWriter ab = new StreamWriter("customerItemdata.txt");
                    ab.Close();
                    ab.Dispose();


                    txtbox6.Text = txtbox7.Text = txtbox8.Text = cmbbox1.Text = null;
                    e = null;
                    r = 0;
                }


                else
                { }

            }

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cstmnu_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void readcmbbox()
        {

            StreamReader abc = new StreamReader("Itemdata.txt");

            while (!abc.EndOfStream)
            {

                cmbbox1.Items.Add(abc.ReadLine());

            }
            abc.Close();
        }

       // private void btndlt_Click(object sender, EventArgs e)
        //{


           // if (txtbox8.Text == string.Empty || txtbox8.Text == "0")
           // {

               // MessageBox.Show("No Data to Be deleted.", "Invalid");

           // }

           // else
            //{
        //
                

               // string liner = null;
               // string line;
                


                //using (FileStream fileStream = new FileStream("customerItemdata.txt", FileMode.Open, FileAccess.ReadWrite))
                //{
                  //  string[] lines = File.ReadAllLines("customerItemdata.txt");
                   // int cnt = lines.Length - 1;
                    //string lastline = lines[cnt];
                    //string line_to_delete = lastline;

                   // using (StreamReader reader = new StreamReader(fileStream))
                   // {
                       // using (StreamWriter writer = new StreamWriter(fileStream))
                       // {
                          //  while ((line = reader.ReadLine()) != null)
                            //{
                               // if (String.Compare(line, line_to_delete) == 0)
                                   // continue;

                                //writer.WriteLine(liner);
                            //}
                       // }
                   // }



                    //read();




                    //itemquantity();
                    //dltprvvalue();


                    //xgrid3.Rows.RemoveAt(xgrid3.Rows[xgrid3.Rows.GetLastRow(0)].Index);


               // }
            //}
        //}
        


       // private void dltprvvalue()
        //{
           // for (int i = 0; i <= xgrid3.Rows.Count-1 ; i++)
            //{
             // e = int.Parse(xgrid3.Rows[i].Cells["B"].Value.ToString());

           // }

              //  r =  r-e;
              //  txtbox8.Text = r.ToString();
       // }



        private void itemquantity()
        {
          int rowCount = xgrid3.Rows.Count;
           label5.Text = Convert.ToString(rowCount);
        }

        


        }

       

    }

    
       



