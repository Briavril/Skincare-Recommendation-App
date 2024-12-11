namespace Demo
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
            this.cboSkinType = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.txtRecommendation = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSkinType
            // 
            this.cboSkinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkinType.FormattingEnabled = true;
            this.cboSkinType.Items.AddRange(new object[] {
            "Oily",
            "Dry",
            "Combination",
            "Sensitive"});
            this.cboSkinType.Location = new System.Drawing.Point(886, 144);
            this.cboSkinType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSkinType.Name = "cboSkinType";
            this.cboSkinType.Size = new System.Drawing.Size(180, 28);
            this.cboSkinType.TabIndex = 0;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(886, 227);
            this.numAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(180, 26);
            this.numAge.TabIndex = 1;
            this.numAge.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // txtRecommendation
            // 
            this.txtRecommendation.Location = new System.Drawing.Point(11, 144);
            this.txtRecommendation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRecommendation.Multiline = true;
            this.txtRecommendation.Name = "txtRecommendation";
            this.txtRecommendation.ReadOnly = true;
            this.txtRecommendation.Size = new System.Drawing.Size(816, 342);
            this.txtRecommendation.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(886, 369);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(213, 82);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Get Recommendation\r\n";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 155);
            this.label1.TabIndex = 4;
            this.label1.Text = "Skincare Recommendation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1128, 521);
            this.Controls.Add(this.txtRecommendation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.cboSkinType);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSkinType;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox txtRecommendation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
    }
}

