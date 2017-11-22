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
namespace Assessment6B
{
    public partial class FileReaderApplicationForm : Form
    {
        public FileReaderApplicationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserOutputListBox_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileLine;
                // Declare a StreamReader variable.
                StreamReader inputFile;
                // set up initial open directory! 
                String UN = Environment.UserName; //variable for the username
               String FilePath = @"C:\Users\"+ UN + @"\Documents\"; //concatinating the username with the path
               openFile.InitialDirectory = FilePath;  //this folder is getting showed in the second replicate of the save dialogue window
                // show only files with .txt extension
                openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                //if the uyser click on open and open a file then
                if (openFile.ShowDialog() == DialogResult.OK) //adding this condition creates the problem of choosing the file 2 times
                {
                //show the file dialog
               // openFile.ShowDialog();
                inputFile = File.OpenText(openFile.FileName);
                
                    while (!inputFile.EndOfStream) //if the file didn't reach its end
                    {
                        fileLine = inputFile.ReadLine();
                        listBoxFileData.Items.Add(fileLine);
                    }
                    //close the file
                    inputFile.Close();
                }
                else //if the user don't open a file then an error message is shown!
                {
                    MessageBox.Show("Operation cancelled!");
                }

            }
            catch (Exception ex)
            {
                //show the error message
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //empty the listbox
            listBoxFileData.Items.Clear();
            MessageBox.Show("List Box cleared!");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }
    }
}
