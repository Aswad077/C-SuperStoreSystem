using System;
using System.IO;
using System.Windows.Forms;

namespace SuperStoreSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            StreamReader ab = new StreamReader("user//"+txtemail.Text+".txt");
            string pass = ab.ReadLine();
            string level = ab.ReadLine();
            ab.Close();

            if (pass.Equals(txtpas.Text))
            {
                new Form3(level).Show();

                txtemail.Text = txtpas.Text = null;
                
            }

            else {

                txtpas.Text = txtemail.Text = null;
                MessageBox.Show("Invalid", "Login");
            
            }

         


        }

        private void btnsign_Click(object sender, EventArgs e)
        {


            StreamWriter abc = new StreamWriter("user//"+txtemail.Text+".txt");
            abc.WriteLine(txtpas.Text);
            abc.WriteLine("user");
            abc.Close();
            txtpas.Text = txtemail.Text=null;
            
            MessageBox.Show("Done","SignedUp");
        }


        }
    }

