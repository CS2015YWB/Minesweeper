namespace Minesweeper
{
    partial class Form_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Setting));
            this.Label_Width = new System.Windows.Forms.Label();
            this.NumericUpDown_Width = new System.Windows.Forms.NumericUpDown();
            this.Label_Height = new System.Windows.Forms.Label();
            this.NumericUpDown_Height = new System.Windows.Forms.NumericUpDown();
            this.Label_Mine = new System.Windows.Forms.Label();
            this.NumericUpDown_Mine = new System.Windows.Forms.NumericUpDown();
            this.label_setting = new System.Windows.Forms.Label();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cannel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Mine)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Width
            // 
            this.Label_Width.AutoSize = true;
            this.Label_Width.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Width.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Width.Location = new System.Drawing.Point(35, 66);
            this.Label_Width.Name = "Label_Width";
            this.Label_Width.Size = new System.Drawing.Size(83, 21);
            this.Label_Width.TabIndex = 0;
            this.Label_Width.Text = "宽度 (1-30)";
            // 
            // NumericUpDown_Width
            // 
            this.NumericUpDown_Width.Location = new System.Drawing.Point(135, 66);
            this.NumericUpDown_Width.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumericUpDown_Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_Width.Name = "NumericUpDown_Width";
            this.NumericUpDown_Width.Size = new System.Drawing.Size(107, 21);
            this.NumericUpDown_Width.TabIndex = 1;
            this.NumericUpDown_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown_Width.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Height.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Height.Location = new System.Drawing.Point(35, 112);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(76, 21);
            this.Label_Height.TabIndex = 2;
            this.Label_Height.Text = "高度(1-16)";
            // 
            // NumericUpDown_Height
            // 
            this.NumericUpDown_Height.Location = new System.Drawing.Point(135, 112);
            this.NumericUpDown_Height.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumericUpDown_Height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_Height.Name = "NumericUpDown_Height";
            this.NumericUpDown_Height.Size = new System.Drawing.Size(107, 21);
            this.NumericUpDown_Height.TabIndex = 3;
            this.NumericUpDown_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown_Height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label_Mine
            // 
            this.Label_Mine.AutoSize = true;
            this.Label_Mine.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mine.Location = new System.Drawing.Point(35, 157);
            this.Label_Mine.Name = "Label_Mine";
            this.Label_Mine.Size = new System.Drawing.Size(81, 21);
            this.Label_Mine.TabIndex = 4;
            this.Label_Mine.Text = "地雷(1-99)";
            // 
            // NumericUpDown_Mine
            // 
            this.NumericUpDown_Mine.Location = new System.Drawing.Point(135, 157);
            this.NumericUpDown_Mine.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NumericUpDown_Mine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_Mine.Name = "NumericUpDown_Mine";
            this.NumericUpDown_Mine.Size = new System.Drawing.Size(107, 21);
            this.NumericUpDown_Mine.TabIndex = 5;
            this.NumericUpDown_Mine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown_Mine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_setting
            // 
            this.label_setting.AutoSize = true;
            this.label_setting.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label_setting.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_setting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_setting.Location = new System.Drawing.Point(108, 20);
            this.label_setting.Name = "label_setting";
            this.label_setting.Size = new System.Drawing.Size(52, 23);
            this.label_setting.TabIndex = 6;
            this.label_setting.Text = "设置";
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(36, 217);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 8;
            this.Button_OK.Text = "确 定";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cannel
            // 
            this.Button_Cannel.Location = new System.Drawing.Point(167, 217);
            this.Button_Cannel.Name = "Button_Cannel";
            this.Button_Cannel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cannel.TabIndex = 9;
            this.Button_Cannel.Text = "取 消";
            this.Button_Cannel.UseVisualStyleBackColor = true;
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Button_Cannel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.label_setting);
            this.Controls.Add(this.NumericUpDown_Mine);
            this.Controls.Add(this.Label_Mine);
            this.Controls.Add(this.NumericUpDown_Height);
            this.Controls.Add(this.Label_Height);
            this.Controls.Add(this.NumericUpDown_Width);
            this.Controls.Add(this.Label_Width);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "扫雷";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Mine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Width;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Width;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Height;
        private System.Windows.Forms.Label Label_Mine;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Mine;
        private System.Windows.Forms.Label label_setting;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cannel;
    }
}