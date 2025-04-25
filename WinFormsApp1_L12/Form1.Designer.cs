namespace WinFormsApp1_L12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            components = new System.ComponentModel.Container();
            txtTimeInput = new TextBox();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtTimeInput
            // 
            txtTimeInput.Location = new Point(30, 30);
            txtTimeInput.Name = "txtTimeInput";
            txtTimeInput.PlaceholderText = "HH:MM:SS";
            txtTimeInput.Size = new Size(200, 27);
            txtTimeInput.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(250, 30);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 27);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 150);
            Controls.Add(btnStart);
            Controls.Add(txtTimeInput);
            Name = "Form1";
            Text = "Alarm Clock";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTimeInput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}
