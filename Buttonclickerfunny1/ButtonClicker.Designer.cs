
namespace Buttonclickerfunny1
{
    partial class ButtonClicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonClicker));
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_noOfClicks = new System.Windows.Forms.TextBox();
            this.button_click1 = new System.Windows.Forms.Button();
            this.button_click2 = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(83, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(99, 15);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Number of Clicks";
            // 
            // textBox_noOfClicks
            // 
            this.textBox_noOfClicks.Enabled = false;
            this.textBox_noOfClicks.Location = new System.Drawing.Point(82, 36);
            this.textBox_noOfClicks.Name = "textBox_noOfClicks";
            this.textBox_noOfClicks.ReadOnly = true;
            this.textBox_noOfClicks.Size = new System.Drawing.Size(100, 23);
            this.textBox_noOfClicks.TabIndex = 1;
            // 
            // button_click1
            // 
            this.button_click1.Enabled = false;
            this.button_click1.Location = new System.Drawing.Point(12, 65);
            this.button_click1.Name = "button_click1";
            this.button_click1.Size = new System.Drawing.Size(75, 23);
            this.button_click1.TabIndex = 2;
            this.button_click1.Text = "Click me!";
            this.button_click1.UseVisualStyleBackColor = true;
            this.button_click1.Click += new System.EventHandler(this.button_click1_Click);
            // 
            // button_click2
            // 
            this.button_click2.Enabled = false;
            this.button_click2.Location = new System.Drawing.Point(188, 65);
            this.button_click2.Name = "button_click2";
            this.button_click2.Size = new System.Drawing.Size(75, 23);
            this.button_click2.TabIndex = 3;
            this.button_click2.Text = "Click me!";
            this.button_click2.UseVisualStyleBackColor = true;
            this.button_click2.Click += new System.EventHandler(this.button_click2_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(107, 111);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Start game!";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(107, 140);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Exit game";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 97);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 106);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(188, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 50);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // ButtonClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_click2);
            this.Controls.Add(this.button_click1);
            this.Controls.Add(this.textBox_noOfClicks);
            this.Controls.Add(this.label_title);
            this.Name = "ButtonClicker";
            this.Text = "Button Clicker";
            this.Load += new System.EventHandler(this.ButtonClicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_noOfClicks;
        private System.Windows.Forms.Button button_click1;
        private System.Windows.Forms.Button button_click2;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

