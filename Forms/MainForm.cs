using FolderAnalyzer.Service;
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
            const long TestSize = 192890880;
            string path = textBox1.Text;
            //var test = "D:\\TestDebugRecursion";
            FolderManager FM = new FolderManager(path);
            long res = 0;
            res = await FM.Run(FM.Path);

            listBox1.Items.Add($"Path:{path} Size:{res.ToString()}\n");
            foreach (var item in FM.Top10SizeFloaders())
            {
                listBox1.Items.Add(item);
            }            

            MessageBox.Show((res).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var P = Process.GetProcessesByName("devenv");
            ProcessStartInfo processInfo = new ProcessStartInfo(P[0].ProcessName); //создаем новый процесс
            processInfo.Verb = "runas"; //в данном случае указываем, что процесс должен быть запущен с правами администратора
            processInfo.FileName = Application.ExecutablePath; //указываем исполняемый файл (программу) для запуска
            try
            {
                Process.Start(processInfo); //пытаемся запустить процесс
                MessageBox.Show("Доступ предоставлен");
            }
            catch (Win32Exception)
            {
                //Ничего не делаем, потому что пользователь, возможно, нажал кнопку "Нет" в ответ на вопрос о запуске программы в окне предупреждения UAC (для Windows 7)
            }
            Application.Exit();
        }
    }
}
