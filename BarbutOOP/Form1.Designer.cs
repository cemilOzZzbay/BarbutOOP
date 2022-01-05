
namespace BarbutOOP
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
            this.lZar1 = new System.Windows.Forms.Label();
            this.lZar2 = new System.Windows.Forms.Label();
            this.bZarAt = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.pbZar1 = new System.Windows.Forms.PictureBox();
            this.pbZar2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbZar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZar2)).BeginInit();
            this.SuspendLayout();
            // 
            // lZar1
            // 
            this.lZar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lZar1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lZar1.Location = new System.Drawing.Point(331, 47);
            this.lZar1.Name = "lZar1";
            this.lZar1.Size = new System.Drawing.Size(130, 130);
            this.lZar1.TabIndex = 0;
            this.lZar1.Text = "lZar1";
            this.lZar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lZar2
            // 
            this.lZar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lZar2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lZar2.Location = new System.Drawing.Point(476, 47);
            this.lZar2.Name = "lZar2";
            this.lZar2.Size = new System.Drawing.Size(130, 130);
            this.lZar2.TabIndex = 1;
            this.lZar2.Text = "lZar2";
            this.lZar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bZarAt
            // 
            this.bZarAt.Location = new System.Drawing.Point(16, 196);
            this.bZarAt.Name = "bZarAt";
            this.bZarAt.Size = new System.Drawing.Size(120, 34);
            this.bZarAt.TabIndex = 2;
            this.bZarAt.Text = "Zarları At";
            this.bZarAt.UseVisualStyleBackColor = true;
            this.bZarAt.Click += new System.EventHandler(this.bZarAt_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 16;
            this.lbSonuc.Location = new System.Drawing.Point(16, 242);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(590, 196);
            this.lbSonuc.TabIndex = 3;
            // 
            // pbZar1
            // 
            this.pbZar1.Location = new System.Drawing.Point(16, 47);
            this.pbZar1.Name = "pbZar1";
            this.pbZar1.Size = new System.Drawing.Size(130, 130);
            this.pbZar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZar1.TabIndex = 4;
            this.pbZar1.TabStop = false;
            // 
            // pbZar2
            // 
            this.pbZar2.Location = new System.Drawing.Point(175, 47);
            this.pbZar2.Name = "pbZar2";
            this.pbZar2.Size = new System.Drawing.Size(130, 130);
            this.pbZar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZar2.TabIndex = 5;
            this.pbZar2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "BİRİNCİ ZAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(171, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "İKİNCİ ZAR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbZar2);
            this.Controls.Add(this.pbZar1);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.bZarAt);
            this.Controls.Add(this.lZar2);
            this.Controls.Add(this.lZar1);
            this.Name = "Form1";
            this.Text = "Barbut";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbZar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lZar1;
        private System.Windows.Forms.Label lZar2;
        private System.Windows.Forms.Button bZarAt;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.PictureBox pbZar1;
        private System.Windows.Forms.PictureBox pbZar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

