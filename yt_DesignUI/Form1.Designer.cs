namespace yt_DesignUI
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
            this.textBoxN = new yt_DesignUI.EgoldsGoogleTextBox();
            this.textBoxThreadsCount = new yt_DesignUI.EgoldsGoogleTextBox();
            this.buttonStart = new yt_DesignUI.yt_Button();
            this.comboBoxThreads = new System.Windows.Forms.ComboBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.buttonChangePriority = new yt_DesignUI.yt_Button();
            this.richTextBoxArray = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSortedArray = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxN
            // 
            this.textBoxN.BackColor = System.Drawing.Color.White;
            this.textBoxN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxN.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.ForeColor = System.Drawing.Color.Black;
            this.textBoxN.Location = new System.Drawing.Point(38, 35);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.SelectionStart = 0;
            this.textBoxN.Size = new System.Drawing.Size(157, 40);
            this.textBoxN.TabIndex = 9;
            this.textBoxN.TextInput = "";
            this.textBoxN.TextPreview = "N";
            this.textBoxN.UseSystemPasswordChar = false;
            // 
            // textBoxThreadsCount
            // 
            this.textBoxThreadsCount.BackColor = System.Drawing.Color.White;
            this.textBoxThreadsCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBoxThreadsCount.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxThreadsCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxThreadsCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxThreadsCount.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxThreadsCount.ForeColor = System.Drawing.Color.Black;
            this.textBoxThreadsCount.Location = new System.Drawing.Point(38, 81);
            this.textBoxThreadsCount.Name = "textBoxThreadsCount";
            this.textBoxThreadsCount.SelectionStart = 0;
            this.textBoxThreadsCount.Size = new System.Drawing.Size(157, 40);
            this.textBoxThreadsCount.TabIndex = 10;
            this.textBoxThreadsCount.TextInput = "";
            this.textBoxThreadsCount.TextPreview = "Thread Count";
            this.textBoxThreadsCount.UseSystemPasswordChar = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LightGreen;
            this.buttonStart.BackColorAdditional = System.Drawing.Color.SeaGreen;
            this.buttonStart.BackColorGradientEnabled = true;
            this.buttonStart.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.buttonStart.BorderColor = System.Drawing.Color.DimGray;
            this.buttonStart.BorderColorEnabled = true;
            this.buttonStart.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonStart.BorderColorOnHoverEnabled = false;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(38, 136);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.RippleColor = System.Drawing.Color.Black;
            this.buttonStart.Rounding = 40;
            this.buttonStart.RoundingEnable = true;
            this.buttonStart.Size = new System.Drawing.Size(141, 27);
            this.buttonStart.TabIndex = 24;
            this.buttonStart.Text = "Start";
            this.buttonStart.TextHover = null;
            this.buttonStart.UseDownPressEffectOnClick = true;
            this.buttonStart.UseRippleEffect = true;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.UseZoomEffectOnHover = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxThreads
            // 
            this.comboBoxThreads.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboBoxThreads.FormattingEnabled = true;
            this.comboBoxThreads.Location = new System.Drawing.Point(38, 207);
            this.comboBoxThreads.Name = "comboBoxThreads";
            this.comboBoxThreads.Size = new System.Drawing.Size(71, 28);
            this.comboBoxThreads.TabIndex = 25;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "Lowest",
            "Normal",
            "Highest",
            "BelowNormal",
            "AboveNormal"});
            this.comboBoxPriority.Location = new System.Drawing.Point(142, 207);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPriority.TabIndex = 26;
            this.comboBoxPriority.SelectedIndexChanged += new System.EventHandler(this.comboBoxThreads_SelectedIndexChanged);
            // 
            // buttonChangePriority
            // 
            this.buttonChangePriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonChangePriority.BackColorAdditional = System.Drawing.Color.Yellow;
            this.buttonChangePriority.BackColorGradientEnabled = true;
            this.buttonChangePriority.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.buttonChangePriority.BorderColor = System.Drawing.Color.DimGray;
            this.buttonChangePriority.BorderColorEnabled = true;
            this.buttonChangePriority.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonChangePriority.BorderColorOnHoverEnabled = false;
            this.buttonChangePriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangePriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePriority.ForeColor = System.Drawing.Color.Black;
            this.buttonChangePriority.Location = new System.Drawing.Point(38, 251);
            this.buttonChangePriority.Name = "buttonChangePriority";
            this.buttonChangePriority.RippleColor = System.Drawing.Color.Black;
            this.buttonChangePriority.Rounding = 40;
            this.buttonChangePriority.RoundingEnable = true;
            this.buttonChangePriority.Size = new System.Drawing.Size(71, 27);
            this.buttonChangePriority.TabIndex = 27;
            this.buttonChangePriority.Text = "Change";
            this.buttonChangePriority.TextHover = null;
            this.buttonChangePriority.UseDownPressEffectOnClick = true;
            this.buttonChangePriority.UseRippleEffect = true;
            this.buttonChangePriority.UseVisualStyleBackColor = false;
            this.buttonChangePriority.UseZoomEffectOnHover = false;
            this.buttonChangePriority.Click += new System.EventHandler(this.buttonChangePriority_Click);
            // 
            // richTextBoxArray
            // 
            this.richTextBoxArray.Location = new System.Drawing.Point(337, 35);
            this.richTextBoxArray.Name = "richTextBoxArray";
            this.richTextBoxArray.Size = new System.Drawing.Size(345, 117);
            this.richTextBoxArray.TabIndex = 28;
            this.richTextBoxArray.Text = "";
            // 
            // richTextBoxSortedArray
            // 
            this.richTextBoxSortedArray.Location = new System.Drawing.Point(337, 207);
            this.richTextBoxSortedArray.Name = "richTextBoxSortedArray";
            this.richTextBoxSortedArray.Size = new System.Drawing.Size(345, 117);
            this.richTextBoxSortedArray.TabIndex = 29;
            this.richTextBoxSortedArray.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxSortedArray);
            this.Controls.Add(this.richTextBoxArray);
            this.Controls.Add(this.buttonChangePriority);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.comboBoxThreads);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxThreadsCount);
            this.Controls.Add(this.textBoxN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private EgoldsGoogleTextBox textBoxN;
        private EgoldsGoogleTextBox textBoxThreadsCount;
        private yt_Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxThreads;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private yt_Button buttonChangePriority;
        private System.Windows.Forms.RichTextBox richTextBoxArray;
        private System.Windows.Forms.RichTextBox richTextBoxSortedArray;
    }
}