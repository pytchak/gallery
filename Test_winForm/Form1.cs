﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_winForm
{


    public partial class Form1 : Form
    {
        void Cheak()
        {
            if (dirName == null)
            {
                MessageBox.Show("Задайте шлях до папки");
            }
        }
       





        string dirName;
        int counet=0;
       public string photo = "";
        string[] photoSplit;
        string[] lines = System.IO.File.ReadAllLines(@"F:\С#\Універ\КР\KR_1\KR_1\Properties\Text.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cheak();
            //textBox1.Text = lines[1];
            //textBox2.Text = lines[2];
            counet++;
            pictureBox1.Image = Image.FromFile(photoSplit[counet]);



            FileInfo file = new FileInfo(photoSplit[counet]);
            long size = file.Length;
            this.label2.Text = "Розмір " + size+"кб";
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dirName = textBox3.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cheak();

            if (Directory.Exists(dirName))
            {

                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    string[] split = s.Split('.');
                    if (split[split.Length - 1] == "jpg")
                    {
                        photo = photo + s + "&";


                    }
                }
                
                photoSplit = photo.Split('&');
            }


            




        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cheak();
            counet--;
            pictureBox1.Image = Image.FromFile(photoSplit[counet]);

            FileInfo file = new FileInfo(photoSplit[counet]);
            long size = file.Length;
            this.label2.Text = "Розмір " + size;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           // label1.Text("Задайте шлях");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Cheak();
            FileInfo file = new FileInfo(photoSplit[counet]);
            long size = file.Length;
            this.label2.Text = "Розмір " + size + "кб";

        }
    }
}
