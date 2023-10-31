using System.Data;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NoteDannyApp
{
    public partial class Form1 : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        string notesDirectory = "C:\\NotepadFiles"; //Specify directory to store notes

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //New Button 
        {
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            //Create directory for notes if it doesnt exist.
            if (!Directory.Exists(notesDirectory))
            {
                Directory.CreateDirectory(notesDirectory);
            }
            string[] noteFiles = Directory.GetFiles(notesDirectory, "*.txt");

            foreach (string noteFile in noteFiles)
            {

                string fileName = Path.GetFileNameWithoutExtension(noteFile);
                string noteContent = File.ReadAllText(noteFile);
                notes.Rows.Add(fileName, noteContent);

            }
            prevNotes.DataSource = notes;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleBox.Text) || string.IsNullOrWhiteSpace(noteBox.Text))
            {
                //check both title and note are filled in
                MessageBox.Show("Both title and note must be filled in, please.");
                return;
            }
            if (editing) //existing note
            {
                string oldTitle = notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"].ToString();
                string fileName = Path.Combine(notesDirectory, oldTitle + ".txt");
                File.WriteAllText(fileName, noteBox.Text);

                notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[prevNotes.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                //if saving new note, create new file to add to data table
                string fileName = Path.Combine(notesDirectory, titleBox.Text + ".txt");
                File.WriteAllText(fileName, noteBox.Text);

                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
            //clear input fields and reset editing flag.
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void ReadButton_Click(object sender, EventArgs e) //Selected note's title and file
        {
            titleBox.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            string title = titleBox.Text;
            string fileName = Path.Combine(notesDirectory, title + ".txt");

            if (File.Exists(fileName))
            {
                // Load content from text file
                noteBox.Text = File.ReadAllText(fileName);
                editing = true;
            }
            else
            {
                noteBox.Text = "!File Not Found!";
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear input fields and reset editing flag
            titleBox.Clear();
            noteBox.Clear();
            editing = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Get title of selected note construct file path
                string title = notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"].ToString();
                string fileName = Path.Combine(notesDirectory, title + ".txt");

                //delete file
                File.Delete(fileName);
                notes.Rows.RemoveAt(prevNotes.CurrentCell.RowIndex); //Remove the row from data table
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not a valid note: " + ex.Message);
            }
        }
    }
}