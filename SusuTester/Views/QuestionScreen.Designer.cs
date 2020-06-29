namespace SusuTester
{
    partial class QuestionScreen
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionText = new System.Windows.Forms.Label();
            this.QuestionImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AnswersGroup = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionText
            // 
            this.QuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionText.AutoSize = true;
            this.QuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionText.Location = new System.Drawing.Point(3, 10);
            this.QuestionText.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.QuestionText.MaximumSize = new System.Drawing.Size(700, 0);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Padding = new System.Windows.Forms.Padding(10);
            this.QuestionText.Size = new System.Drawing.Size(694, 37);
            this.QuestionText.TabIndex = 0;
            // 
            // QuestionImage
            // 
            this.QuestionImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionImage.Location = new System.Drawing.Point(3, 50);
            this.QuestionImage.Name = "QuestionImage";
            this.QuestionImage.Size = new System.Drawing.Size(694, 154);
            this.QuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QuestionImage.TabIndex = 1;
            this.QuestionImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.QuestionText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.QuestionImage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AnswersGroup, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 500);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AnswersGroup
            // 
            this.AnswersGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswersGroup.AutoScroll = true;
            this.AnswersGroup.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AnswersGroup.Location = new System.Drawing.Point(0, 207);
            this.AnswersGroup.Margin = new System.Windows.Forms.Padding(0);
            this.AnswersGroup.Name = "AnswersGroup";
            this.AnswersGroup.Size = new System.Drawing.Size(700, 293);
            this.AnswersGroup.TabIndex = 2;
            this.AnswersGroup.WrapContents = false;
            // 
            // QuestionScreen
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QuestionScreen";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.PictureBox QuestionImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel AnswersGroup;
    }
}
