
namespace Lesson7
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblCounterText = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.lblGetNumber = new System.Windows.Forms.Label();
            this.lblMinTurns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(270, 76);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(270, 126);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 0;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(270, 176);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber.Location = new System.Drawing.Point(174, 81);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(15, 15);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "0";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(267, 215);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(13, 13);
            this.lblCounter.TabIndex = 2;
            this.lblCounter.Text = "0";
            // 
            // lblCounterText
            // 
            this.lblCounterText.AutoSize = true;
            this.lblCounterText.Location = new System.Drawing.Point(174, 215);
            this.lblCounterText.Name = "lblCounterText";
            this.lblCounterText.Size = new System.Drawing.Size(93, 13);
            this.lblCounterText.TabIndex = 2;
            this.lblCounterText.Text = "Кол-во комманд:";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playButton.Location = new System.Drawing.Point(29, 12);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(79, 29);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Играть";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // lblGetNumber
            // 
            this.lblGetNumber.AutoSize = true;
            this.lblGetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGetNumber.Location = new System.Drawing.Point(25, 44);
            this.lblGetNumber.Name = "lblGetNumber";
            this.lblGetNumber.Size = new System.Drawing.Size(385, 20);
            this.lblGetNumber.TabIndex = 5;
            this.lblGetNumber.Text = "Получи число за минимальное количество ходов";
            this.lblGetNumber.Visible = false;
            // 
            // lblMinTurns
            // 
            this.lblMinTurns.AutoSize = true;
            this.lblMinTurns.Location = new System.Drawing.Point(29, 244);
            this.lblMinTurns.Name = "lblMinTurns";
            this.lblMinTurns.Size = new System.Drawing.Size(171, 13);
            this.lblMinTurns.TabIndex = 6;
            this.lblMinTurns.Text = "Минимальное количество ходов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 313);
            this.Controls.Add(this.lblMinTurns);
            this.Controls.Add(this.lblGetNumber);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.lblCounterText);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblCounterText;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label lblGetNumber;
        private System.Windows.Forms.Label lblMinTurns;
    }
}

