namespace Trionfi
{
    partial class Trionfi
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
            this.pCardInfo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lCardNum = new System.Windows.Forms.Label();
            this.lCardTreeNum = new System.Windows.Forms.Label();
            this.lCardRuledBy = new System.Windows.Forms.Label();
            this.lCardHebrewLetter = new System.Windows.Forms.Label();
            this.lCardNumercalValue = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.pCardInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCardInfo
            // 
            this.pCardInfo.Controls.Add(this.lCardNumercalValue);
            this.pCardInfo.Controls.Add(this.lCardHebrewLetter);
            this.pCardInfo.Controls.Add(this.lCardRuledBy);
            this.pCardInfo.Controls.Add(this.lCardTreeNum);
            this.pCardInfo.Controls.Add(this.lCardNum);
            this.pCardInfo.Controls.Add(this.label5);
            this.pCardInfo.Controls.Add(this.label4);
            this.pCardInfo.Controls.Add(this.label3);
            this.pCardInfo.Controls.Add(this.label2);
            this.pCardInfo.Controls.Add(this.label1);
            this.pCardInfo.Location = new System.Drawing.Point(419, 49);
            this.pCardInfo.Name = "pCardInfo";
            this.pCardInfo.Size = new System.Drawing.Size(324, 256);
            this.pCardInfo.TabIndex = 0;
            this.pCardInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pCardInfo_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numerical Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hebrew Letter:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ruled By:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tree Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tarot Card Number:";
            // 
            // lCardNum
            // 
            this.lCardNum.AutoSize = true;
            this.lCardNum.Location = new System.Drawing.Point(129, 44);
            this.lCardNum.Name = "lCardNum";
            this.lCardNum.Size = new System.Drawing.Size(13, 13);
            this.lCardNum.TabIndex = 7;
            this.lCardNum.Text = "0";
            // 
            // lCardTreeNum
            // 
            this.lCardTreeNum.AutoSize = true;
            this.lCardTreeNum.Location = new System.Drawing.Point(129, 57);
            this.lCardTreeNum.Name = "lCardTreeNum";
            this.lCardTreeNum.Size = new System.Drawing.Size(13, 13);
            this.lCardTreeNum.TabIndex = 8;
            this.lCardTreeNum.Text = "0";
            // 
            // lCardRuledBy
            // 
            this.lCardRuledBy.AutoSize = true;
            this.lCardRuledBy.Location = new System.Drawing.Point(129, 70);
            this.lCardRuledBy.Name = "lCardRuledBy";
            this.lCardRuledBy.Size = new System.Drawing.Size(13, 13);
            this.lCardRuledBy.TabIndex = 9;
            this.lCardRuledBy.Text = "0";
            this.lCardRuledBy.Click += new System.EventHandler(this.label8_Click);
            // 
            // lCardHebrewLetter
            // 
            this.lCardHebrewLetter.AutoSize = true;
            this.lCardHebrewLetter.Location = new System.Drawing.Point(129, 84);
            this.lCardHebrewLetter.Name = "lCardHebrewLetter";
            this.lCardHebrewLetter.Size = new System.Drawing.Size(13, 13);
            this.lCardHebrewLetter.TabIndex = 10;
            this.lCardHebrewLetter.Text = "0";
            this.lCardHebrewLetter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lCardHebrewLetter.Click += new System.EventHandler(this.lHebrewLetter_Click);
            // 
            // lCardNumercalValue
            // 
            this.lCardNumercalValue.AutoSize = true;
            this.lCardNumercalValue.Location = new System.Drawing.Point(129, 97);
            this.lCardNumercalValue.Name = "lCardNumercalValue";
            this.lCardNumercalValue.Size = new System.Drawing.Size(13, 13);
            this.lCardNumercalValue.TabIndex = 11;
            this.lCardNumercalValue.Text = "0";
            this.lCardNumercalValue.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(181, 199);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Trionfi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 604);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pCardInfo);
            this.Name = "Trionfi";
            this.Text = "Form1";
            this.pCardInfo.ResumeLayout(false);
            this.pCardInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCardInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCardNumercalValue;
        private System.Windows.Forms.Label lCardHebrewLetter;
        private System.Windows.Forms.Label lCardRuledBy;
        private System.Windows.Forms.Label lCardTreeNum;
        private System.Windows.Forms.Label lCardNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTest;
    }
}

