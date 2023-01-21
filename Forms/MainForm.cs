using FolderAnalyzer.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FolderAnalyzer
{
    public partial class AnalizatorFolder : Form
    {
        public AnalizatorFolder()
        {
            InitializeComponent();
            comboBox1.Items.Add(10);
            comboBox1.Items.Add(20);
            comboBox1.Items.Add(50);
            comboBox1.Items.Add(100);
            comboBox2.Items.AddRange(MyInfoFloader.UnitInfo.Select(x=>x.Key.ToString()).ToArray());
        }
        Point LastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Select Folder
            using (var folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    string path = folderDialog.SelectedPath;
                    if (path != "" || path != null) textBox1.Text = path;
                    else
                        textBox1.Text = "Not Found";
                }                
            }
        }
        
        private async void button2_Click(object sender, EventArgs e)
        {
            
            string path = textBox1.Text;
            if (path!=null)
            {
                //var test = "D:\\TestDebugRecursion";
                FolderManager FM = new FolderManager(path);                
                if (comboBox1.SelectedItem != null)
                {
                    if(comboBox2.SelectedItem==null)
                    {
                        comboBox2.SelectedItem = "B";
                    }
                    
                    await FM.Run(FM.Path);
                    foreach (var item in FM.TopSizeFloaders((int)comboBox1.SelectedItem, (string)comboBox2.SelectedItem))
                    {
                        listBox1.Items.Add(item);
                        
                    }
                }
                else
                {
                    listBox1.Items.Add("Выберите размер выборки");
                }
            }                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            InfoDTO info = JsonConvert.DeserializeObject<InfoDTO>(listBox1.SelectedItem.ToString());
            Process.Start(info.Name);
        }
    }
}
