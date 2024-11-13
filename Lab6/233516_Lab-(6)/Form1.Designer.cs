using System;
using System.Collections.Generic;
using System.Linq;

namespace _233516_Lab__6_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Text_Box = new System.Windows.Forms.RichTextBox();
            this.List_Box = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add_item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove_item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Display";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(67, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sort_list";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(212, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "Clear_list";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Text_Box
            // 
            this.Text_Box.Location = new System.Drawing.Point(411, 109);
            this.Text_Box.Name = "Text_Box";
            this.Text_Box.Size = new System.Drawing.Size(256, 98);
            this.Text_Box.TabIndex = 5;
            this.Text_Box.Text = "";
            // 
            // List_Box
            // 
            this.List_Box.FormattingEnabled = true;
            this.List_Box.ItemHeight = 20;
            this.List_Box.Location = new System.Drawing.Point(411, 247);
            this.List_Box.Name = "List_Box";
            this.List_Box.Size = new System.Drawing.Size(261, 104);
            this.List_Box.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.List_Box);
            this.Controls.Add(this.Text_Box);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string item = Text_Box.Text;

            if (!string.IsNullOrEmpty(item))
            {
                List_Box.Items.Add(item);  // Add item to the ListBox for display
                Text_Box.Clear();          // Clear the TextBox after adding
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (List_Box.SelectedItem != null)
            {
                List_Box.Items.Remove(List_Box.SelectedItem);  // Remove selected item
            }
        }


        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            List_Box.Items.Clear();
            Text_Box.Clear();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            List<string> items = List_Box.Items.Cast<string>().ToList();
            items.Sort();
            List_Box.Items.Clear();
            foreach (var item in items)
            {
                List_Box.Items.Add(item);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Text_Box.Clear();
            foreach (var item in List_Box.Items)
            {
                Text_Box.AppendText(item + "\n");
            }
        }


        private void Remove_item(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Add_item(object sender, EventArgs e)
        {
            string item = txtInput.Text;  // Assuming txtInput is your input TextBox for adding items.

            if (!string.IsNullOrEmpty(item))
            {
                stringList.Add(item);     // Add item to the List<string>
                arrayList.Add(item);      // Add item to the ArrayList
                txtInput.Clear();         // Clear the TextBox after adding
            }

            DisplayItems();               // Refresh the displayed items in ListBox
        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox Text_Box;
  
        private System.Windows.Forms.ListBox List_Box;
      
    }
}

