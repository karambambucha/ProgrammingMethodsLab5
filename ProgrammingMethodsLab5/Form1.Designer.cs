
namespace ProgrammingMethodsLab5
{
    partial class ClocksInterface
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
            this.getAnalogTimeBtn = new System.Windows.Forms.Button();
            this.changeTimeBtn = new System.Windows.Forms.Button();
            this.hourNum = new System.Windows.Forms.NumericUpDown();
            this.minuteNum = new System.Windows.Forms.NumericUpDown();
            this.secondNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.setSecondNum = new System.Windows.Forms.NumericUpDown();
            this.setMinuteNum = new System.Windows.Forms.NumericUpDown();
            this.setHourNum = new System.Windows.Forms.NumericUpDown();
            this.setTimeBtn = new System.Windows.Forms.Button();
            this.setRealTimeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSecondNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setMinuteNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setHourNum)).BeginInit();
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
            this.clockText.Location = new System.Drawing.Point(804, 87);
            this.clockText.Name = "clockText";
            this.clockText.ShowSelectionMargin = true;
            this.clockText.Size = new System.Drawing.Size(423, 200);
            this.clockText.TabIndex = 2;
            this.clockText.Text = "0";
            // 
            // getAnalogTimeBtn
            // 
            this.getAnalogTimeBtn.Location = new System.Drawing.Point(424, 37);
            this.getAnalogTimeBtn.Name = "getAnalogTimeBtn";
            this.getAnalogTimeBtn.Size = new System.Drawing.Size(172, 50);
            this.getAnalogTimeBtn.TabIndex = 3;
            this.getAnalogTimeBtn.Text = "Получить время с аналоговых часов";
            this.getAnalogTimeBtn.UseVisualStyleBackColor = true;
            this.getAnalogTimeBtn.Click += new System.EventHandler(this.GetAnalogTime_Click);
            // 
            // changeTimeBtn
            // 
            this.changeTimeBtn.Location = new System.Drawing.Point(613, 338);
            this.changeTimeBtn.Name = "changeTimeBtn";
            this.changeTimeBtn.Size = new System.Drawing.Size(172, 50);
            this.changeTimeBtn.TabIndex = 4;
            this.changeTimeBtn.Text = "Изменить время";
            this.changeTimeBtn.UseVisualStyleBackColor = true;
            this.changeTimeBtn.Click += new System.EventHandler(this.changeTimeBtn_Click);
            // 
            // hourNum
            // 
            this.hourNum.Location = new System.Drawing.Point(613, 243);
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
            // minuteNum
            // 
            this.minuteNum.Location = new System.Drawing.Point(614, 271);
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
            this.minuteNum.Name = "minuteNum";
            this.minuteNum.Size = new System.Drawing.Size(141, 22);
            this.minuteNum.TabIndex = 6;
            // 
            // secondNum
            // 
            this.secondNum.Location = new System.Drawing.Point(613, 299);
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
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(141, 22);
            this.secondNum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(613, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "На сколько \r\nвремени изменятся \r\nчасы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(760, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ч.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(761, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "мин.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(760, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "сек.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(571, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "сек.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(571, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "мин.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(571, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "ч.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(443, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 34);
            this.label8.TabIndex = 16;
            this.label8.Text = "На какое время\r\nизменятся часы";
            // 
            // setSecondNum
            // 
            this.setSecondNum.Location = new System.Drawing.Point(424, 299);
            this.setSecondNum.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.setSecondNum.Name = "setSecondNum";
            this.setSecondNum.Size = new System.Drawing.Size(141, 22);
            this.setSecondNum.TabIndex = 15;
            // 
            // setMinuteNum
            // 
            this.setMinuteNum.Location = new System.Drawing.Point(424, 271);
            this.setMinuteNum.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.setMinuteNum.Name = "setMinuteNum";
            this.setMinuteNum.Size = new System.Drawing.Size(141, 22);
            this.setMinuteNum.TabIndex = 14;
            // 
            // setHourNum
            // 
            this.setHourNum.Location = new System.Drawing.Point(424, 243);
            this.setHourNum.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.setHourNum.Name = "setHourNum";
            this.setHourNum.Size = new System.Drawing.Size(141, 22);
            this.setHourNum.TabIndex = 13;
            // 
            // setTimeBtn
            // 
            this.setTimeBtn.Location = new System.Drawing.Point(424, 338);
            this.setTimeBtn.Name = "setTimeBtn";
            this.setTimeBtn.Size = new System.Drawing.Size(172, 50);
            this.setTimeBtn.TabIndex = 12;
            this.setTimeBtn.Text = "Установить время";
            this.setTimeBtn.UseVisualStyleBackColor = true;
            this.setTimeBtn.Click += new System.EventHandler(this.setTimeBtn_Click);
            // 
            // setRealTimeBtn
            // 
            this.setRealTimeBtn.Location = new System.Drawing.Point(606, 37);
            this.setRealTimeBtn.Name = "setRealTimeBtn";
            this.setRealTimeBtn.Size = new System.Drawing.Size(172, 50);
            this.setRealTimeBtn.TabIndex = 20;
            this.setRealTimeBtn.Text = "Задать часам текущее время";
            this.setRealTimeBtn.UseVisualStyleBackColor = true;
            this.setRealTimeBtn.Click += new System.EventHandler(this.setRealTimeBtn_Click);
            // 
            // ClocksInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1239, 400);
            this.Controls.Add(this.setRealTimeBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.setSecondNum);
            this.Controls.Add(this.setMinuteNum);
            this.Controls.Add(this.setHourNum);
            this.Controls.Add(this.setTimeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.minuteNum);
            this.Controls.Add(this.hourNum);
            this.Controls.Add(this.changeTimeBtn);
            this.Controls.Add(this.getAnalogTimeBtn);
            this.Controls.Add(this.clockText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ClocksInterface";
            this.Text = "Программа для работы с аналоговым часами";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSecondNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setMinuteNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setHourNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox clockText;
        private System.Windows.Forms.Button getAnalogTimeBtn;
        private System.Windows.Forms.Button changeTimeBtn;
        private System.Windows.Forms.NumericUpDown hourNum;
        private System.Windows.Forms.NumericUpDown minuteNum;
        private System.Windows.Forms.NumericUpDown secondNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown setSecondNum;
        private System.Windows.Forms.NumericUpDown setMinuteNum;
        private System.Windows.Forms.NumericUpDown setHourNum;
        private System.Windows.Forms.Button setTimeBtn;
        private System.Windows.Forms.Button setRealTimeBtn;
    }
}

