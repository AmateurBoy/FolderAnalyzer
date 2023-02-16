using FolderAnalyzer.Service;
using FolderAnalyzer.Service.Loger;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ThreadState = System.Threading.ThreadState;

namespace FolderAnalyzer
{
    public partial class AnalizatorFolder : Form
    {
        public FolderManager folderManager;
        public SynchronizationContext context;        
        public bool Work = false;
        Point LastPoint;
        public AnalizatorFolder()
        {
            InitializeComponent();
            InitializeSelectingNumberElements();
            InitializeUnitList();
            //Defolde Select
            pictureBox1.Visible = false;
            SelectingNumberElements.SelectedItem = 100; //SelectRange
            UnitList.SelectedItem = "mB";//Unit
            textBox1.Text = "D:\\";       //Path
            Logger.CreateLog("Приложение запушено удачно.");
        }
        private void InitializeSelectingNumberElements()
        {
            SelectingNumberElements.Items.Add(10);
            SelectingNumberElements.Items.Add(20);
            SelectingNumberElements.Items.Add(50);
            SelectingNumberElements.Items.Add(100);
            SelectingNumberElements.Items.Add(300);
            SelectingNumberElements.Items.Add(500);
        }
        private void InitializeUnitList()
        {
            UnitList.Items.AddRange(BiteTransform.UnitInfo.Select(x => x.Key.ToString()).ToArray());
        }
        protected void ChangeTextStatus()
        {
            if (StatusText.Text.Equals("Stop"))
            {
                StatusText.Text = "Start";
                StatusText.ForeColor = Color.Green;
            }
            else
            {
                StatusText.Text = "Stop";
                StatusText.ForeColor = Color.DarkRed;
            }            
        }
        protected void PaintElement()
        {
            if (SelectingNumberElements.SelectedItem != null)
            {
                if (UnitList.SelectedItem == null)
                {
                    UnitList.SelectedItem = "B";
                }

                foreach (var item in folderManager.TopSizeFloaders((int)SelectingNumberElements.SelectedItem, (string)UnitList.SelectedItem))
                {
                    MainList.Items.Add(item);

                }
            }
            else
            {
                MainList.Items.Add("Выберите размер выборки");
            }
            CountSecret.Text = folderManager.GetCountSecret().ToString();            
            folderManager.Dispose();
            folderManager = null;
        }        
        public async void Animations()
        {   
            pictureBox1.Visible = true;
                while (Work)
                {
                    await Task.Delay(500);
                    Image img = pictureBox1.Image;
                    img.RotateFlip(RotateFlipType.Rotate270FlipXY);
                    pictureBox1.Image = img;
                }
                pictureBox1.Visible = false;
        }
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
        private void SelectFolder_Click(object sender, EventArgs e)
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
        private async void Analiz_Click(object sender, EventArgs e)
        {
            Logger.CreateLog("Запушен Анализ");
            AnalizButton.Visible = false;
            MainList.Items.Clear();
            CountSecret.Text = "0";                      
            string path = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(path))
            {
                context = SynchronizationContext.Current;
                //var test = "D:\\TestDebugRecursion";
                folderManager = new FolderManager(path);
                Task task = new Task(async () =>
                {
                    Work = true;                    
                    context.Post(x => ChangeTextStatus(), null);                                                          
                    await folderManager.Run();                    
                    context.Post(x=> PaintElement(), null);
                    context.Post(x => ChangeTextStatus(), null);
                    context.Post(x => AnalizButton.Visible = true, null);
                    Work = false;
                });
                task.Start();
                var task1 = new Task(async () =>
                {
                    context.Post(x =>Animations(), null);
                });
                task1.Start();
            }
            else
            {
                MainList.Items.Add("Путь пустой");
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            MainList.Items.Clear();
            CountSecret.Text = "0";
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SelectdItem_Path_List(object sender, EventArgs e)
        {
            try
            {
                var logResult = "Попытка зайти в папку -> ";                
                InfoDTO info = JsonConvert.DeserializeObject<InfoDTO>(MainList.SelectedItem.ToString());
                logResult += info.Name;
                Process.Start(info.Name);
                Logger.CreateLog($"Успешно зашли в папку:{info.Name}");                
            }
            catch
            {                
                MessageBox.Show("Произошла ошибка пути.");
                Logger.CreateLog("Произошла ошибка пути.");
            }
            
        }

       
    }
}
