namespace CourseFormApp
{
    partial class CourseFormApp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DoNotClickButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ShutdownPC = new System.Windows.Forms.Button();
            this.HeightTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HeigtButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.XNumberTextBox = new System.Windows.Forms.TextBox();
            this.YNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.RadioButton();
            this.SubstractButton = new System.Windows.Forms.RadioButton();
            this.MultiplyButton = new System.Windows.Forms.RadioButton();
            this.DivideButton = new System.Windows.Forms.RadioButton();
            this.sleepButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.logs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoNotClickButton
            // 
            this.DoNotClickButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DoNotClickButton.Cursor = System.Windows.Forms.Cursors.No;
            this.DoNotClickButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DoNotClickButton.Location = new System.Drawing.Point(12, 12);
            this.DoNotClickButton.Name = "DoNotClickButton";
            this.DoNotClickButton.Size = new System.Drawing.Size(141, 56);
            this.DoNotClickButton.TabIndex = 0;
            this.DoNotClickButton.Text = "DoNotClickButton";
            this.DoNotClickButton.UseVisualStyleBackColor = false;
            this.DoNotClickButton.Click += new System.EventHandler(this.DoNotClickButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(632, 415);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 415);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ShutdownPC
            // 
            this.ShutdownPC.Location = new System.Drawing.Point(304, 415);
            this.ShutdownPC.Name = "ShutdownPC";
            this.ShutdownPC.Size = new System.Drawing.Size(92, 23);
            this.ShutdownPC.TabIndex = 3;
            this.ShutdownPC.Text = "Shutdown PC";
            this.ShutdownPC.UseVisualStyleBackColor = true;
            this.ShutdownPC.Click += new System.EventHandler(this.ShutdownPC_Click);
            // 
            // HeightTextBox1
            // 
            this.HeightTextBox1.Location = new System.Drawing.Point(655, 30);
            this.HeightTextBox1.Name = "HeightTextBox1";
            this.HeightTextBox1.Size = new System.Drawing.Size(72, 23);
            this.HeightTextBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input Your height";
            // 
            // HeigtButton
            // 
            this.HeigtButton.Location = new System.Drawing.Point(689, 59);
            this.HeigtButton.Name = "HeigtButton";
            this.HeigtButton.Size = new System.Drawing.Size(75, 23);
            this.HeigtButton.TabIndex = 6;
            this.HeigtButton.Text = "Run";
            this.HeigtButton.UseVisualStyleBackColor = true;
            this.HeigtButton.Click += new System.EventHandler(this.HeigtButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "cm.";
            // 
            // XNumberTextBox
            // 
            this.XNumberTextBox.Location = new System.Drawing.Point(12, 121);
            this.XNumberTextBox.Name = "XNumberTextBox";
            this.XNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.XNumberTextBox.TabIndex = 8;
            // 
            // YNumberTextBox
            // 
            this.YNumberTextBox.Location = new System.Drawing.Point(12, 175);
            this.YNumberTextBox.Name = "YNumberTextBox";
            this.YNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.YNumberTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "X number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y number";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 317);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 346);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(100, 23);
            this.ResultTextBox.TabIndex = 14;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Checked = true;
            this.AddButton.Location = new System.Drawing.Point(12, 204);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(47, 19);
            this.AddButton.TabIndex = 15;
            this.AddButton.TabStop = true;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // SubstractButton
            // 
            this.SubstractButton.AutoSize = true;
            this.SubstractButton.Location = new System.Drawing.Point(12, 229);
            this.SubstractButton.Name = "SubstractButton";
            this.SubstractButton.Size = new System.Drawing.Size(74, 19);
            this.SubstractButton.TabIndex = 16;
            this.SubstractButton.TabStop = true;
            this.SubstractButton.Text = "Substract";
            this.SubstractButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.AutoSize = true;
            this.MultiplyButton.Location = new System.Drawing.Point(12, 254);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(69, 19);
            this.MultiplyButton.TabIndex = 17;
            this.MultiplyButton.TabStop = true;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            // 
            // DivideButton
            // 
            this.DivideButton.AutoSize = true;
            this.DivideButton.Location = new System.Drawing.Point(13, 279);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(58, 19);
            this.DivideButton.TabIndex = 18;
            this.DivideButton.TabStop = true;
            this.DivideButton.Text = "Divide";
            this.DivideButton.UseVisualStyleBackColor = true;
            // 
            // sleepButton
            // 
            this.sleepButton.Location = new System.Drawing.Point(402, 415);
            this.sleepButton.Name = "sleepButton";
            this.sleepButton.Size = new System.Drawing.Size(103, 23);
            this.sleepButton.TabIndex = 19;
            this.sleepButton.Text = "Put PC to Sleep";
            this.sleepButton.UseVisualStyleBackColor = true;
            this.sleepButton.Click += new System.EventHandler(this.sleepButton_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(118, 229);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(387, 140);
            this.LogTextBox.TabIndex = 20;
            // 
            // logs
            // 
            this.logs.AutoSize = true;
            this.logs.Location = new System.Drawing.Point(118, 206);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(35, 15);
            this.logs.TabIndex = 21;
            this.logs.Text = "Logs:";
            // 
            // CourseFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.sleepButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubstractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YNumberTextBox);
            this.Controls.Add(this.XNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeigtButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightTextBox1);
            this.Controls.Add(this.ShutdownPC);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.DoNotClickButton);
            this.Name = "CourseFormApp";
            this.Text = "ALX Course Form App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DoNotClickButton;
        private Button RestartButton;
        private Button ExitButton;
        private Button ShutdownPC;
        private TextBox HeightTextBox1;
        private Label label1;
        private Button HeigtButton;
        private Label label2;
        private TextBox XNumberTextBox;
        private TextBox YNumberTextBox;
        private Label label3;
        private Label label4;
        private Button calculateButton;
        private TextBox ResultTextBox;
        private RadioButton AddButton;
        private RadioButton SubstractButton;
        private RadioButton MultiplyButton;
        private RadioButton DivideButton;
        private Button sleepButton;
        private TextBox LogTextBox;
        private Label logs;
    }
}