
namespace ProgrammingMethodsLab5
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clockText = new System.Windows.Forms.RichTextBox();
            this.GetAnalogTime = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hourNum = new System.Windows.Forms.NumericUpDown();
            this.minuteNum = new System.Windows.Forms.NumericUpDown();
            this.secondNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNum)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(280, 210);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // clockText
            // 
            this.clockText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.clockText.Font = new System.Drawing.Font("Helvetica LT UltraCompressed", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockText.Location = new System.Drawing.Point(800, 87);
            this.clockText.Name = "clockText";
            this.clockText.ShowSelectionMargin = true;
            this.clockText.Size = new System.Drawing.Size(427, 200);
            this.clockText.TabIndex = 2;
            this.clockText.Text = "0";
            // 
            // GetAnalogTime
            // 
            this.GetAnalogTime.Location = new System.Drawing.Point(426, 338);
            this.GetAnalogTime.Name = "GetAnalogTime";
            this.GetAnalogTime.Size = new System.Drawing.Size(172, 50);
            this.GetAnalogTime.TabIndex = 3;
            this.GetAnalogTime.Text = "Получить время с аналоговых часов";
            this.GetAnalogTime.UseVisualStyleBackColor = true;
            this.GetAnalogTime.Click += new System.EventHandler(this.GetAnalogTime_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Изменить время";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hourNum
            // 
            this.hourNum.Location = new System.Drawing.Point(604, 243);
            this.hourNum.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hourNum.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            -2147483648});
            this.hourNum.Name = "hourNum";
            this.hourNum.Size = new System.Drawing.Size(141, 22);
            this.hourNum.TabIndex = 5;
            // 
            // minutesNum
            // 
            this.minuteNum.Location = new System.Drawing.Point(604, 271);
            this.minuteNum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minuteNum.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.minuteNum.Name = "minutesNum";
            this.minuteNum.Size = new System.Drawing.Size(141, 22);
            this.minuteNum.TabIndex = 6;
            // 
            // secondsNum
            // 
            this.secondNum.Location = new System.Drawing.Point(604, 299);
            this.secondNum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secondNum.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.secondNum.Name = "secondsNum";
            this.secondNum.Size = new System.Drawing.Size(141, 22);
            this.secondNum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(623, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "На сколько \r\nизменится время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(751, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ч.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(751, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "мин.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(751, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "сек.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1239, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.minuteNum);
            this.Controls.Add(this.hourNum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GetAnalogTime);
            this.Controls.Add(this.clockText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox clockText;
        private System.Windows.Forms.Button GetAnalogTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown hourNum;
        private System.Windows.Forms.NumericUpDown minuteNum;
        private System.Windows.Forms.NumericUpDown secondNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

