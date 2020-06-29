namespace SusuTester
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenQuestionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionsHolder = new System.Windows.Forms.Panel();
            this.GoPrev = new System.Windows.Forms.Button();
            this.GoNext = new System.Windows.Forms.Button();
            this.SendAnswersButton = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(981, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenQuestionsMenuItem,
            this.AboutMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(65, 24);
            this.FileMenuItem.Text = "Меню";
            // 
            // OpenQuestionsMenuItem
            // 
            this.OpenQuestionsMenuItem.Name = "OpenQuestionsMenuItem";
            this.OpenQuestionsMenuItem.Size = new System.Drawing.Size(283, 26);
            this.OpenQuestionsMenuItem.Text = "Открыть файл с вопросами";
            this.OpenQuestionsMenuItem.Click += new System.EventHandler(this.OpenQuestionsMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(283, 26);
            this.AboutMenuItem.Text = "О программе";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // QuestionsHolder
            // 
            this.QuestionsHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionsHolder.Location = new System.Drawing.Point(0, 31);
            this.QuestionsHolder.Name = "QuestionsHolder";
            this.QuestionsHolder.Size = new System.Drawing.Size(981, 554);
            this.QuestionsHolder.TabIndex = 1;
            // 
            // GoPrev
            // 
            this.GoPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoPrev.Location = new System.Drawing.Point(0, 588);
            this.GoPrev.Margin = new System.Windows.Forms.Padding(0);
            this.GoPrev.Name = "GoPrev";
            this.GoPrev.Size = new System.Drawing.Size(212, 34);
            this.GoPrev.TabIndex = 2;
            this.GoPrev.Text = "<<<";
            this.GoPrev.UseVisualStyleBackColor = true;
            this.GoPrev.Click += new System.EventHandler(this.GoPrev_Click);
            // 
            // GoNext
            // 
            this.GoNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoNext.Location = new System.Drawing.Point(769, 588);
            this.GoNext.Margin = new System.Windows.Forms.Padding(0);
            this.GoNext.Name = "GoNext";
            this.GoNext.Size = new System.Drawing.Size(212, 34);
            this.GoNext.TabIndex = 3;
            this.GoNext.Text = ">>>";
            this.GoNext.UseVisualStyleBackColor = true;
            this.GoNext.Click += new System.EventHandler(this.GoNext_Click);
            // 
            // SendAnswersButton
            // 
            this.SendAnswersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendAnswersButton.Location = new System.Drawing.Point(212, 588);
            this.SendAnswersButton.Margin = new System.Windows.Forms.Padding(0);
            this.SendAnswersButton.Name = "SendAnswersButton";
            this.SendAnswersButton.Size = new System.Drawing.Size(557, 34);
            this.SendAnswersButton.TabIndex = 4;
            this.SendAnswersButton.Text = "Проверить ответы";
            this.SendAnswersButton.UseVisualStyleBackColor = true;
            this.SendAnswersButton.Click += new System.EventHandler(this.SendAnswersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 620);
            this.Controls.Add(this.SendAnswersButton);
            this.Controls.Add(this.GoNext);
            this.Controls.Add(this.GoPrev);
            this.Controls.Add(this.QuestionsHolder);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Susu Tester";
            this.Shown += new System.EventHandler(this.FormShown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenQuestionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.Panel QuestionsHolder;
        private System.Windows.Forms.Button GoPrev;
        private System.Windows.Forms.Button GoNext;
        private System.Windows.Forms.Button SendAnswersButton;
    }
}

