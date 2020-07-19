namespace TexturesExtractor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.remote_dir = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn1In = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn2Out = new System.Windows.Forms.PictureBox();
            this.out_dir = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn3Log = new System.Windows.Forms.PictureBox();
            this.log_dir = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartThread = new System.Windows.Forms.ToolStripMenuItem();
            this.TH = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn1In)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn2Out)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn3Log)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // remote_dir
            // 
            this.remote_dir.Location = new System.Drawing.Point(6, 19);
            this.remote_dir.Name = "remote_dir";
            this.remote_dir.Size = new System.Drawing.Size(293, 20);
            this.remote_dir.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn1In);
            this.groupBox1.Controls.Add(this.remote_dir);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Путь к общей папке (gamedata)";
            // 
            // btn1In
            // 
            this.btn1In.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1In.BackgroundImage")));
            this.btn1In.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1In.Location = new System.Drawing.Point(305, 19);
            this.btn1In.Name = "btn1In";
            this.btn1In.Size = new System.Drawing.Size(20, 20);
            this.btn1In.TabIndex = 2;
            this.btn1In.TabStop = false;
            this.btn1In.Click += new System.EventHandler(this.btn1In_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn2Out);
            this.groupBox2.Controls.Add(this.out_dir);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 48);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Путь для выгрузки скопированных текстур";
            // 
            // btn2Out
            // 
            this.btn2Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2Out.BackgroundImage")));
            this.btn2Out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2Out.Location = new System.Drawing.Point(305, 19);
            this.btn2Out.Name = "btn2Out";
            this.btn2Out.Size = new System.Drawing.Size(20, 20);
            this.btn2Out.TabIndex = 3;
            this.btn2Out.TabStop = false;
            this.btn2Out.Click += new System.EventHandler(this.btn2Out_Click);
            // 
            // out_dir
            // 
            this.out_dir.Location = new System.Drawing.Point(6, 19);
            this.out_dir.Name = "out_dir";
            this.out_dir.Size = new System.Drawing.Size(293, 20);
            this.out_dir.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn3Log);
            this.groupBox3.Controls.Add(this.log_dir);
            this.groupBox3.Location = new System.Drawing.Point(12, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 48);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Путь к логу игры, либо компилятора sdk";
            // 
            // btn3Log
            // 
            this.btn3Log.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3Log.BackgroundImage")));
            this.btn3Log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3Log.Location = new System.Drawing.Point(305, 19);
            this.btn3Log.Name = "btn3Log";
            this.btn3Log.Size = new System.Drawing.Size(20, 20);
            this.btn3Log.TabIndex = 4;
            this.btn3Log.TabStop = false;
            this.btn3Log.Click += new System.EventHandler(this.btn3Log_Click);
            // 
            // log_dir
            // 
            this.log_dir.Location = new System.Drawing.Point(6, 19);
            this.log_dir.Name = "log_dir";
            this.log_dir.Size = new System.Drawing.Size(293, 20);
            this.log_dir.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.btnStartThread});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInfo,
            this.btnSave});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // btnInfo
            // 
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(193, 22);
            this.btnInfo.Text = "О программе";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 22);
            this.btnSave.Text = "Сохранить настройки";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStartThread
            // 
            this.btnStartThread.Name = "btnStartThread";
            this.btnStartThread.Size = new System.Drawing.Size(50, 20);
            this.btnStartThread.Text = "Старт";
            this.btnStartThread.Click += new System.EventHandler(this.btnStartThread_Click);
            // 
            // TH
            // 
            this.TH.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TH_DoWork);
            this.TH.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.TH_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 193);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(371, 232);
            this.MinimumSize = new System.Drawing.Size(371, 232);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Textures Searches";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn1In)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn2Out)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn3Log)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remote_dir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btn1In;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox btn2Out;
        private System.Windows.Forms.TextBox out_dir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox btn3Log;
        private System.Windows.Forms.TextBox log_dir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnStartThread;
        private System.ComponentModel.BackgroundWorker TH;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnInfo;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
    }
}

