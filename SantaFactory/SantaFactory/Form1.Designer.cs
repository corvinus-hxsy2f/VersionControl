
namespace SantaFactory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnBall = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnColorBox = new System.Windows.Forms.Button();
            this.btnColorRibbon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(0, 174);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(801, 275);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "CAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBall
            // 
            this.btnBall.Location = new System.Drawing.Point(122, 12);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(108, 44);
            this.btnBall.TabIndex = 1;
            this.btnBall.Text = "BALL";
            this.btnBall.UseVisualStyleBackColor = true;
            this.btnBall.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(367, 9);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(68, 13);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next:";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Fuchsia;
            this.btnColor.Location = new System.Drawing.Point(122, 62);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(108, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "PRESENT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnColorBox
            // 
            this.btnColorBox.BackColor = System.Drawing.Color.Yellow;
            this.btnColorBox.Location = new System.Drawing.Point(236, 62);
            this.btnColorBox.Name = "btnColorBox";
            this.btnColorBox.Size = new System.Drawing.Size(108, 23);
            this.btnColorBox.TabIndex = 5;
            this.btnColorBox.UseVisualStyleBackColor = false;
            this.btnColorBox.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColorRibbon
            // 
            this.btnColorRibbon.BackColor = System.Drawing.Color.Red;
            this.btnColorRibbon.Location = new System.Drawing.Point(236, 91);
            this.btnColorRibbon.Name = "btnColorRibbon";
            this.btnColorRibbon.Size = new System.Drawing.Size(108, 23);
            this.btnColorRibbon.TabIndex = 6;
            this.btnColorRibbon.UseVisualStyleBackColor = false;
            this.btnColorRibbon.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColorRibbon);
            this.Controls.Add(this.btnColorBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.btnBall);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnColorBox;
        private System.Windows.Forms.Button btnColorRibbon;
    }
}

