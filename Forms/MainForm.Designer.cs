namespace FolderAnalyzer
{
    partial class AnalizatorFolder
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalizatorFolder));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MainList = new System.Windows.Forms.ListBox();
            this.SelectingNumberElements = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UnitList = new System.Windows.Forms.ComboBox();
            this.CountSecret = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в AnalizatorRAM";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(870, 34);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(888, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Location = new System.Drawing.Point(454, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Analiz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Analiz_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(888, 509);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "ClearList";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MainList
            // 
            this.MainList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MainList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainList.ForeColor = System.Drawing.SystemColors.Window;
            this.MainList.FormattingEnabled = true;
            this.MainList.HorizontalScrollbar = true;
            this.MainList.ItemHeight = 29;
            this.MainList.Location = new System.Drawing.Point(12, 44);
            this.MainList.Name = "MainList";
            this.MainList.ScrollAlwaysVisible = true;
            this.MainList.Size = new System.Drawing.Size(1033, 319);
            this.MainList.TabIndex = 6;
            this.MainList.SelectedIndexChanged += new System.EventHandler(this.SelectdItem_Path_List);
            // 
            // SelectingNumberElements
            // 
            this.SelectingNumberElements.FormattingEnabled = true;
            this.SelectingNumberElements.Location = new System.Drawing.Point(136, 456);
            this.SelectingNumberElements.Name = "SelectingNumberElements";
            this.SelectingNumberElements.Size = new System.Drawing.Size(271, 24);
            this.SelectingNumberElements.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выборка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status:";
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusText.ForeColor = System.Drawing.Color.IndianRed;
            this.StatusText.Location = new System.Drawing.Point(92, 379);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(63, 29);
            this.StatusText.TabIndex = 10;
            this.StatusText.Text = "Stop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(487, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Единица измерения:";
            // 
            // UnitList
            // 
            this.UnitList.FormattingEnabled = true;
            this.UnitList.Location = new System.Drawing.Point(746, 456);
            this.UnitList.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.UnitList.Name = "UnitList";
            this.UnitList.Size = new System.Drawing.Size(88, 24);
            this.UnitList.TabIndex = 11;
            // 
            // CountSecret
            // 
            this.CountSecret.AutoSize = true;
            this.CountSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountSecret.ForeColor = System.Drawing.Color.IndianRed;
            this.CountSecret.Location = new System.Drawing.Point(994, 379);
            this.CountSecret.Name = "CountSecret";
            this.CountSecret.Size = new System.Drawing.Size(26, 29);
            this.CountSecret.TabIndex = 14;
            this.CountSecret.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(473, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(506, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Скрытых папок которые не вошли в анализ:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::FolderAnalyzer.Properties.Resources.LoadingMain;
            this.pictureBox1.InitialImage = global::FolderAnalyzer.Properties.Resources.LoadingMain;
            this.pictureBox1.Location = new System.Drawing.Point(12, 485);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AnalizatorFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1057, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CountSecret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UnitList);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectingNumberElements);
            this.Controls.Add(this.MainList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnalizatorFolder";
            this.Text = "FolderAnalyer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.ComboBox SelectingNumberElements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox UnitList;
        private System.Windows.Forms.Label CountSecret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

