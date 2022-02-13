using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Password_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        
        private void InformationtextBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void passwordgenerationbutton_Click(object sender, EventArgs e)
        {
            //password characters 
            String[] password_characters = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h", "I", "i", "J", "j", "K", "k", "L", "l", "M", "m", "N", "n", "O", "o", "P", "Q", "q", "R", "r", "S", "s", "T", "t", "U", "u", "V", "v", "W", "w" };

            //password array
            String[] password_array = new string[16];

            //Random password generator
            Random r_password_drawn = new Random();

            for (int i = 0; i < password_array.Length; i++)
            {
                password_array[i] = password_characters[r_password_drawn.Next(0, 55)];

            }

            //password in string
            string password_code = password_array[0] + password_array[1] + password_array[2] + password_array[3] + password_array[4] + password_array[5] + password_array[6] + password_array[7] + password_array[8] + password_array[9] + password_array[10] + password_array[11] + password_array[12] + password_array[13] + password_array[14] + password_array[15];

            PasswordtextBox.Text = password_code.ToString();




            //Create folder and file here "this pc" documents
            if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Password Generator/passwords.txt")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Password Generator"));
                File.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Password Generator/passwords.txt")).Dispose();

                TextWriter tw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Password Generator/passwords.txt"), true);
                tw.WriteLine("Information: " + InformationtextBox.Text);
                tw.WriteLine();
                tw.WriteLine("Username: " + UsernameBox.Text);
                tw.WriteLine();
                tw.WriteLine("Password: " + password_code);
                tw.WriteLine();
                tw.WriteLine("--------------------------------------------------");
                tw.WriteLine();
                tw.Close();

                string message1 = "The passwords.txt file does not exist.\nThat's why it was created here: \n\n" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Password Generator\\passwords.txt");
                string title1 = "System message";
                MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                DialogResult result1 = MessageBox.Show(message1, title1, buttons1);
                if (result1 == DialogResult.OK)
                {
                    string message2 = "Successful password generation!\nThe information, username, and password have been saved to passwords.txt .\n\npasswords.txt path:\n\n" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Password Generator\\passwords.txt");
                    string title2 = "System message";
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                    DialogResult result2 = MessageBox.Show(message2, title2, buttons2);
                    if (result2 == DialogResult.OK)
                    {

                    }
                }
            }
            else if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Password Generator/passwords.txt")))
            {
                using (var tw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Password Generator/passwords.txt"), true))
                {
                    tw.WriteLine("Information: " + InformationtextBox.Text);
                    tw.WriteLine();
                    tw.WriteLine("Username: " + UsernameBox.Text);
                    tw.WriteLine();
                    tw.WriteLine("Password: " + password_code);
                    tw.WriteLine();
                    tw.WriteLine("--------------------------------------------------");
                    tw.WriteLine();
                    tw.Close();


                    string message3 = "Successful password generation!\nThe information, username, and password have been saved to passwords.txt .\n\npasswords.txt path:\n\n" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Password Generator\\passwords.txt");
                    string title3 = "System message";
                    MessageBoxButtons buttons3 = MessageBoxButtons.OK;
                    DialogResult result3 = MessageBox.Show(message3, title3, buttons3);
                    if (result3 == DialogResult.OK)
                    {

                    }


                }
            }







        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Information_Click(object sender, EventArgs e)
        {

        }


    }
}
