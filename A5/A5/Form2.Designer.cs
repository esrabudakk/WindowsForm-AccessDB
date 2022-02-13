
namespace A5
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.questionText = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rdOption = new System.Windows.Forms.RadioButton();
            this.rdOption2 = new System.Windows.Forms.RadioButton();
            this.rdOption3 = new System.Windows.Forms.RadioButton();
            this.rdOption4 = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionText
            // 
            this.questionText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionText.Location = new System.Drawing.Point(154, 120);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(554, 75);
            this.questionText.TabIndex = 0;
            this.questionText.Text = "label1";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(711, 432);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 38);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdOption
            // 
            this.rdOption.AutoSize = true;
            this.rdOption.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOption.Location = new System.Drawing.Point(158, 219);
            this.rdOption.Name = "rdOption";
            this.rdOption.Size = new System.Drawing.Size(130, 24);
            this.rdOption.TabIndex = 2;
            this.rdOption.TabStop = true;
            this.rdOption.Text = "radioButton1";
            this.rdOption.UseVisualStyleBackColor = true;
            this.rdOption.CheckedChanged += new System.EventHandler(this.rdOption_CheckedChanged);
            // 
            // rdOption2
            // 
            this.rdOption2.AutoSize = true;
            this.rdOption2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOption2.Location = new System.Drawing.Point(158, 261);
            this.rdOption2.Name = "rdOption2";
            this.rdOption2.Size = new System.Drawing.Size(130, 24);
            this.rdOption2.TabIndex = 3;
            this.rdOption2.TabStop = true;
            this.rdOption2.Text = "radioButton2";
            this.rdOption2.UseVisualStyleBackColor = true;
            this.rdOption2.CheckedChanged += new System.EventHandler(this.rdOption2_CheckedChanged);
            // 
            // rdOption3
            // 
            this.rdOption3.AutoSize = true;
            this.rdOption3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOption3.Location = new System.Drawing.Point(158, 305);
            this.rdOption3.Name = "rdOption3";
            this.rdOption3.Size = new System.Drawing.Size(130, 24);
            this.rdOption3.TabIndex = 4;
            this.rdOption3.TabStop = true;
            this.rdOption3.Text = "radioButton3";
            this.rdOption3.UseVisualStyleBackColor = true;
            this.rdOption3.CheckedChanged += new System.EventHandler(this.rdOption3_CheckedChanged);
            // 
            // rdOption4
            // 
            this.rdOption4.AutoSize = true;
            this.rdOption4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOption4.Location = new System.Drawing.Point(158, 350);
            this.rdOption4.Name = "rdOption4";
            this.rdOption4.Size = new System.Drawing.Size(130, 24);
            this.rdOption4.TabIndex = 5;
            this.rdOption4.TabStop = true;
            this.rdOption4.Text = "radioButton4";
            this.rdOption4.UseVisualStyleBackColor = true;
            this.rdOption4.CheckedChanged += new System.EventHandler(this.rdOption4_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(857, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(27, 486);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(240, 34);
            this.lblUser.TabIndex = 10;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(217, 486);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(240, 34);
            this.lblTime.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Location = new System.Drawing.Point(831, 123);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(65, 22);
            this.txtResult.TabIndex = 12;
            this.txtResult.Text = "00:00:00";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Rockwell Extra Bold", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(689, 58);
            this.label3.TabIndex = 13;
            this.label3.Text = "                                QUIZES ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(951, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rdOption4);
            this.Controls.Add(this.rdOption3);
            this.Controls.Add(this.rdOption2);
            this.Controls.Add(this.rdOption);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.questionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuiZes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdOption;
        private System.Windows.Forms.RadioButton rdOption2;
        private System.Windows.Forms.RadioButton rdOption3;
        private System.Windows.Forms.RadioButton rdOption4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
    }
}