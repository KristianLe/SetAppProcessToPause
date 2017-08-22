namespace SetAppProcessToPause
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
            this.components = new System.ComponentModel.Container();
            this.toChoosedProcessesButton = new System.Windows.Forms.Button();
            this.FromChoosedProcessesButton = new System.Windows.Forms.Button();
            this.runningProcessesListBox = new System.Windows.Forms.ListBox();
            this.choosedProcessesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toChoosedProcessesButton
            // 
            this.toChoosedProcessesButton.Location = new System.Drawing.Point(230, 66);
            this.toChoosedProcessesButton.Name = "toChoosedProcessesButton";
            this.toChoosedProcessesButton.Size = new System.Drawing.Size(75, 23);
            this.toChoosedProcessesButton.TabIndex = 0;
            this.toChoosedProcessesButton.Text = ">>";
            this.toChoosedProcessesButton.UseVisualStyleBackColor = true;
            this.toChoosedProcessesButton.Click += new System.EventHandler(this.toChoosedProcessesButton_Click);
            // 
            // FromChoosedProcessesButton
            // 
            this.FromChoosedProcessesButton.Location = new System.Drawing.Point(230, 95);
            this.FromChoosedProcessesButton.Name = "FromChoosedProcessesButton";
            this.FromChoosedProcessesButton.Size = new System.Drawing.Size(75, 23);
            this.FromChoosedProcessesButton.TabIndex = 1;
            this.FromChoosedProcessesButton.Text = "<<";
            this.FromChoosedProcessesButton.UseVisualStyleBackColor = true;
            this.FromChoosedProcessesButton.Click += new System.EventHandler(this.FromChoosedProcessesButton_Click);
            // 
            // runningProcessesListBox
            // 
            this.runningProcessesListBox.ColumnWidth = 20;
            this.runningProcessesListBox.FormattingEnabled = true;
            this.runningProcessesListBox.IntegralHeight = false;
            this.runningProcessesListBox.Location = new System.Drawing.Point(13, 48);
            this.runningProcessesListBox.Name = "runningProcessesListBox";
            this.runningProcessesListBox.Size = new System.Drawing.Size(211, 160);
            this.runningProcessesListBox.TabIndex = 2;
            // 
            // choosedProcessesListBox
            // 
            this.choosedProcessesListBox.ColumnWidth = 100;
            this.choosedProcessesListBox.FormattingEnabled = true;
            this.choosedProcessesListBox.Location = new System.Drawing.Point(320, 48);
            this.choosedProcessesListBox.Name = "choosedProcessesListBox";
            this.choosedProcessesListBox.Size = new System.Drawing.Size(217, 160);
            this.choosedProcessesListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Запущенные процессы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Привязка на паузу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Хоткей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ctrl + F12";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(158, 196);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 10;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "State";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(255, 10);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(22, 13);
            this.stateLabel.TabIndex = 12;
            this.stateLabel.Text = "HZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 272);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choosedProcessesListBox);
            this.Controls.Add(this.runningProcessesListBox);
            this.Controls.Add(this.FromChoosedProcessesButton);
            this.Controls.Add(this.toChoosedProcessesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toChoosedProcessesButton;
        private System.Windows.Forms.Button FromChoosedProcessesButton;
        private System.Windows.Forms.ListBox runningProcessesListBox;
        private System.Windows.Forms.ListBox choosedProcessesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label stateLabel;
    }
}

