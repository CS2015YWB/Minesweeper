namespace Minesweeper
{
    partial class Form_Rank
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
            this.Label_Beginner = new System.Windows.Forms.Label();
            this.Label_Intermediate = new System.Windows.Forms.Label();
            this.Label_Expert = new System.Windows.Forms.Label();
            this.label_rank = new System.Windows.Forms.Label();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Beginner
            // 
            this.Label_Beginner.AutoSize = true;
            this.Label_Beginner.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Beginner.Location = new System.Drawing.Point(54, 63);
            this.Label_Beginner.Name = "Label_Beginner";
            this.Label_Beginner.Size = new System.Drawing.Size(61, 21);
            this.Label_Beginner.TabIndex = 0;
            this.Label_Beginner.Text = "新 手：";
            // 
            // Label_Intermediate
            // 
            this.Label_Intermediate.AutoSize = true;
            this.Label_Intermediate.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Intermediate.Location = new System.Drawing.Point(52, 93);
            this.Label_Intermediate.Name = "Label_Intermediate";
            this.Label_Intermediate.Size = new System.Drawing.Size(61, 21);
            this.Label_Intermediate.TabIndex = 1;
            this.Label_Intermediate.Text = "中 等：";
            // 
            // Label_Expert
            // 
            this.Label_Expert.AutoSize = true;
            this.Label_Expert.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Expert.Location = new System.Drawing.Point(52, 123);
            this.Label_Expert.Name = "Label_Expert";
            this.Label_Expert.Size = new System.Drawing.Size(61, 21);
            this.Label_Expert.TabIndex = 2;
            this.Label_Expert.Text = "专 家：";
            // 
            // label_rank
            // 
            this.label_rank.AutoSize = true;
            this.label_rank.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label_rank.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rank.Location = new System.Drawing.Point(101, 19);
            this.label_rank.Name = "label_rank";
            this.label_rank.Size = new System.Drawing.Size(65, 19);
            this.label_rank.TabIndex = 3;
            this.label_rank.Text = "排 行 榜";
            // 
            // Button_Reset
            // 
            this.Button_Reset.Location = new System.Drawing.Point(38, 183);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(75, 23);
            this.Button_Reset.TabIndex = 4;
            this.Button_Reset.Text = "重 置";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(164, 183);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 5;
            this.Button_OK.Text = "确 定";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Form_Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.label_rank);
            this.Controls.Add(this.Label_Expert);
            this.Controls.Add(this.Label_Intermediate);
            this.Controls.Add(this.Label_Beginner);
            this.Name = "Form_Rank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Rank";
            this.Load += new System.EventHandler(this.Form_Rank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Beginner;
        private System.Windows.Forms.Label Label_Intermediate;
        private System.Windows.Forms.Label Label_Expert;
        private System.Windows.Forms.Label label_rank;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Button Button_OK;
    }
}