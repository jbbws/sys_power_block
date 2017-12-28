namespace System_PowerBlock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PkoefTextBox = new System.Windows.Forms.TextBox();
            this.TkoefTextBox = new System.Windows.Forms.TextBox();
            this.SetRegParamBtn = new System.Windows.Forms.Button();
            this.ResetRegParamBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.InitPowerTextBox = new System.Windows.Forms.TextBox();
            this.InternalTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SetInitParamBtn = new System.Windows.Forms.Button();
            this.ResetInitParamBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UseDirectControlTextBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AirConsumTextBox = new System.Windows.Forms.TextBox();
            this.SetAirConsBtn = new System.Windows.Forms.Button();
            this.ResetAirConsBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CurPowerTextBox = new System.Windows.Forms.TextBox();
            this.SetCurPowerBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RunSysBtn = new System.Windows.Forms.Button();
            this.AbortSysBtn = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ClearOutputBtn = new System.Windows.Forms.Button();
            this.outputRTextBox = new System.Windows.Forms.RichTextBox();
            this.sysTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResetInitParamBtn);
            this.groupBox1.Controls.Add(this.SetInitParamBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.InternalTimeTextBox);
            this.groupBox1.Controls.Add(this.InitPowerTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальные параметры";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResetRegParamBtn);
            this.groupBox2.Controls.Add(this.SetRegParamBtn);
            this.groupBox2.Controls.Add(this.TkoefTextBox);
            this.groupBox2.Controls.Add(this.PkoefTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(220, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настроки ПИ регулятора";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Коэф. усиления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Итегральный коэф.";
            // 
            // PkoefTextBox
            // 
            this.PkoefTextBox.Location = new System.Drawing.Point(134, 28);
            this.PkoefTextBox.Name = "PkoefTextBox";
            this.PkoefTextBox.Size = new System.Drawing.Size(65, 20);
            this.PkoefTextBox.TabIndex = 2;
            // 
            // TkoefTextBox
            // 
            this.TkoefTextBox.Location = new System.Drawing.Point(134, 56);
            this.TkoefTextBox.Name = "TkoefTextBox";
            this.TkoefTextBox.Size = new System.Drawing.Size(65, 20);
            this.TkoefTextBox.TabIndex = 3;
            // 
            // SetRegParamBtn
            // 
            this.SetRegParamBtn.Location = new System.Drawing.Point(13, 87);
            this.SetRegParamBtn.Name = "SetRegParamBtn";
            this.SetRegParamBtn.Size = new System.Drawing.Size(75, 23);
            this.SetRegParamBtn.TabIndex = 4;
            this.SetRegParamBtn.Text = "Ок";
            this.SetRegParamBtn.UseVisualStyleBackColor = true;
            this.SetRegParamBtn.Click += new System.EventHandler(this.SetRegParamBtn_Click);
            // 
            // ResetRegParamBtn
            // 
            this.ResetRegParamBtn.Location = new System.Drawing.Point(94, 87);
            this.ResetRegParamBtn.Name = "ResetRegParamBtn";
            this.ResetRegParamBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetRegParamBtn.TabIndex = 5;
            this.ResetRegParamBtn.Text = "Сброс";
            this.ResetRegParamBtn.UseVisualStyleBackColor = true;
            this.ResetRegParamBtn.Click += new System.EventHandler(this.ResetRegParamBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Мощность";
            // 
            // InitPowerTextBox
            // 
            this.InitPowerTextBox.Location = new System.Drawing.Point(109, 24);
            this.InitPowerTextBox.Name = "InitPowerTextBox";
            this.InitPowerTextBox.Size = new System.Drawing.Size(71, 20);
            this.InitPowerTextBox.TabIndex = 1;
            // 
            // InternalTimeTextBox
            // 
            this.InternalTimeTextBox.Location = new System.Drawing.Point(109, 53);
            this.InternalTimeTextBox.Name = "InternalTimeTextBox";
            this.InternalTimeTextBox.Size = new System.Drawing.Size(71, 20);
            this.InternalTimeTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время \r\nквантования (мс)";
            // 
            // SetInitParamBtn
            // 
            this.SetInitParamBtn.Location = new System.Drawing.Point(10, 87);
            this.SetInitParamBtn.Name = "SetInitParamBtn";
            this.SetInitParamBtn.Size = new System.Drawing.Size(75, 23);
            this.SetInitParamBtn.TabIndex = 5;
            this.SetInitParamBtn.Text = "Ок";
            this.SetInitParamBtn.UseVisualStyleBackColor = true;
            this.SetInitParamBtn.Click += new System.EventHandler(this.SetInitParamBtn_Click);
            // 
            // ResetInitParamBtn
            // 
            this.ResetInitParamBtn.Location = new System.Drawing.Point(97, 87);
            this.ResetInitParamBtn.Name = "ResetInitParamBtn";
            this.ResetInitParamBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetInitParamBtn.TabIndex = 6;
            this.ResetInitParamBtn.Text = "Сброс";
            this.ResetInitParamBtn.UseVisualStyleBackColor = true;
            this.ResetInitParamBtn.Click += new System.EventHandler(this.ResetInitParamBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResetAirConsBtn);
            this.groupBox3.Controls.Add(this.SetAirConsBtn);
            this.groupBox3.Controls.Add(this.AirConsumTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.UseDirectControlTextBox);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(6, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прямое управление";
            // 
            // UseDirectControlTextBox
            // 
            this.UseDirectControlTextBox.AutoSize = true;
            this.UseDirectControlTextBox.Location = new System.Drawing.Point(16, 30);
            this.UseDirectControlTextBox.Name = "UseDirectControlTextBox";
            this.UseDirectControlTextBox.Size = new System.Drawing.Size(202, 17);
            this.UseDirectControlTextBox.TabIndex = 0;
            this.UseDirectControlTextBox.Text = "Использовать прямое управление";
            this.UseDirectControlTextBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Расход воздуха";
            // 
            // AirConsumTextBox
            // 
            this.AirConsumTextBox.Location = new System.Drawing.Point(108, 59);
            this.AirConsumTextBox.Name = "AirConsumTextBox";
            this.AirConsumTextBox.Size = new System.Drawing.Size(75, 20);
            this.AirConsumTextBox.TabIndex = 2;
            // 
            // SetAirConsBtn
            // 
            this.SetAirConsBtn.Location = new System.Drawing.Point(16, 87);
            this.SetAirConsBtn.Name = "SetAirConsBtn";
            this.SetAirConsBtn.Size = new System.Drawing.Size(75, 23);
            this.SetAirConsBtn.TabIndex = 5;
            this.SetAirConsBtn.Text = "Установить";
            this.SetAirConsBtn.UseVisualStyleBackColor = true;
            // 
            // ResetAirConsBtn
            // 
            this.ResetAirConsBtn.Location = new System.Drawing.Point(108, 87);
            this.ResetAirConsBtn.Name = "ResetAirConsBtn";
            this.ResetAirConsBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetAirConsBtn.TabIndex = 6;
            this.ResetAirConsBtn.Text = "Сбросить";
            this.ResetAirConsBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SetCurPowerBtn);
            this.groupBox4.Controls.Add(this.CurPowerTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 86);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выполнение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Мощность";
            // 
            // CurPowerTextBox
            // 
            this.CurPowerTextBox.Location = new System.Drawing.Point(97, 24);
            this.CurPowerTextBox.Name = "CurPowerTextBox";
            this.CurPowerTextBox.Size = new System.Drawing.Size(97, 20);
            this.CurPowerTextBox.TabIndex = 1;
            // 
            // SetCurPowerBtn
            // 
            this.SetCurPowerBtn.Location = new System.Drawing.Point(22, 56);
            this.SetCurPowerBtn.Name = "SetCurPowerBtn";
            this.SetCurPowerBtn.Size = new System.Drawing.Size(75, 23);
            this.SetCurPowerBtn.TabIndex = 2;
            this.SetCurPowerBtn.Text = "Задать";
            this.SetCurPowerBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(13, 137);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 280);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Система";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.AbortSysBtn);
            this.groupBox6.Controls.Add(this.RunSysBtn);
            this.groupBox6.Location = new System.Drawing.Point(446, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(267, 62);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Управление";
            // 
            // RunSysBtn
            // 
            this.RunSysBtn.Location = new System.Drawing.Point(28, 20);
            this.RunSysBtn.Name = "RunSysBtn";
            this.RunSysBtn.Size = new System.Drawing.Size(75, 23);
            this.RunSysBtn.TabIndex = 0;
            this.RunSysBtn.Text = "Пуск";
            this.RunSysBtn.UseVisualStyleBackColor = true;
            this.RunSysBtn.Click += new System.EventHandler(this.RunSysBtn_Click);
            // 
            // AbortSysBtn
            // 
            this.AbortSysBtn.Location = new System.Drawing.Point(109, 20);
            this.AbortSysBtn.Name = "AbortSysBtn";
            this.AbortSysBtn.Size = new System.Drawing.Size(75, 23);
            this.AbortSysBtn.TabIndex = 1;
            this.AbortSysBtn.Text = "Стоп";
            this.AbortSysBtn.UseVisualStyleBackColor = true;
            this.AbortSysBtn.Click += new System.EventHandler(this.AbortSysBtn_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.outputRTextBox);
            this.groupBox7.Controls.Add(this.ClearOutputBtn);
            this.groupBox7.Location = new System.Drawing.Point(260, 137);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(453, 286);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Вывод";
            // 
            // ClearOutputBtn
            // 
            this.ClearOutputBtn.Location = new System.Drawing.Point(7, 20);
            this.ClearOutputBtn.Name = "ClearOutputBtn";
            this.ClearOutputBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearOutputBtn.TabIndex = 0;
            this.ClearOutputBtn.Text = "Очистить";
            this.ClearOutputBtn.UseVisualStyleBackColor = true;
            // 
            // outputRTextBox
            // 
            this.outputRTextBox.Location = new System.Drawing.Point(7, 50);
            this.outputRTextBox.Name = "outputRTextBox";
            this.outputRTextBox.ReadOnly = true;
            this.outputRTextBox.Size = new System.Drawing.Size(440, 230);
            this.outputRTextBox.TabIndex = 1;
            this.outputRTextBox.Text = "";
            // 
            // sysTimer
            // 
            this.sysTimer.Tick += new System.EventHandler(this.sysTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 435);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Управление мощностью блока";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ResetInitParamBtn;
        private System.Windows.Forms.Button SetInitParamBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InternalTimeTextBox;
        private System.Windows.Forms.TextBox InitPowerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetRegParamBtn;
        private System.Windows.Forms.Button SetRegParamBtn;
        private System.Windows.Forms.TextBox TkoefTextBox;
        private System.Windows.Forms.TextBox PkoefTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SetAirConsBtn;
        private System.Windows.Forms.TextBox AirConsumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox UseDirectControlTextBox;
        private System.Windows.Forms.Button ResetAirConsBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SetCurPowerBtn;
        private System.Windows.Forms.TextBox CurPowerTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button AbortSysBtn;
        private System.Windows.Forms.Button RunSysBtn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox outputRTextBox;
        private System.Windows.Forms.Button ClearOutputBtn;
        private System.Windows.Forms.Timer sysTimer;
    }
}

