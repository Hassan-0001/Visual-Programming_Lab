using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1assign
{
    public partial class Form1 : Form
    {
        private object comboBoxItems;

        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // Optional: Populate ComboBox with sample items
        //    comboBoxItems.Items.AddRange(new string[] { "Item 1", "Item 2", "Item 3" });
        //}

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a MessageBox.", "Message");
        }

        private void checkBoxOption_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOption.Checked)
            {
                MessageBox.Show("CheckBox is checked.");
            }
            else
            {
                MessageBox.Show("CheckBox is unchecked.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("RadioButton 1 is selected.");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("RadioButton 2 is selected.");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"NumericUpDown value is: {numericUpDown1.Value}");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Selected date is: {dateTimePicker1.Value.ToShortDateString()}");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show($"Selected date range: {e.Start.ToShortDateString()} to {e.End.ToShortDateString()}");
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            // Specify the path to your image file
            string imagePath = @"D:\assign.jpg"; // Ensure this path is correct

            // Load the image into the PictureBox
            try
            {
                // Check if the file exists
                if (!System.IO.File.Exists(imagePath))
                {
                    MessageBox.Show("Image file not found: " + imagePath);
                    return; // Exit if file does not exist
                }

                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Optional
            }
            catch (System.IO.FileNotFoundException fnfEx)
            {
                MessageBox.Show("File not found: " + fnfEx.Message);
            }
            catch (System.IO.IOException ioEx)
            {
                MessageBox.Show("IO error: " + ioEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }


    }
}
