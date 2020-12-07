
namespace PointTwo
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
            this.userNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNumber
            // 
            this.userNumber.Location = new System.Drawing.Point(409, 66);
            this.userNumber.Name = "userNumber";
            this.userNumber.Size = new System.Drawing.Size(100, 20);
            this.userNumber.TabIndex = 0;
            this.userNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNumber_Input);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(183, 73);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(220, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Компьютер загадал число от нуля до 100:";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(51, 62);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Играть";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(183, 105);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(69, 13);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "Подсказка: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.userNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTip;
    }
}

