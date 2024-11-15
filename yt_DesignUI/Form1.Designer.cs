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
            this.components = new System.ComponentModel.Container();
            this.textBoxN = new yt_DesignUI.EgoldsGoogleTextBox();
            this.buttonStart = new yt_DesignUI.yt_Button();
            this.comboBoxThreads = new System.Windows.Forms.ComboBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.buttonChangePriority = new yt_DesignUI.yt_Button();
            this.richTextBoxArray = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSortedArray = new System.Windows.Forms.RichTextBox();
            this.comboBoxThreadCount = new System.Windows.Forms.ComboBox();
            this.textBoxA = new yt_DesignUI.EgoldsGoogleTextBox();
            this.textBoxB = new yt_DesignUI.EgoldsGoogleTextBox();
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxN
            // 
            this.textBoxN.BackColor = System.Drawing.Color.White;
            this.textBoxN.BorderColor = System.Drawing.Color.Black;
            this.textBoxN.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.ForeColor = System.Drawing.Color.Black;
            this.textBoxN.Location = new System.Drawing.Point(15, 7);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.SelectionStart = 0;
            this.textBoxN.Size = new System.Drawing.Size(50, 40);
            this.textBoxN.TabIndex = 9;
            this.textBoxN.TextInput = "900";
            this.textBoxN.TextPreview = "N";
            this.textBoxN.UseSystemPasswordChar = false;
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
            this.buttonStart.Location = new System.Drawing.Point(79, 79);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.RippleColor = System.Drawing.Color.Black;
            this.buttonStart.Rounding = 40;
            this.buttonStart.RoundingEnable = true;
            this.buttonStart.Size = new System.Drawing.Size(93, 27);
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
            this.comboBoxThreads.Location = new System.Drawing.Point(21, 27);
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
            this.comboBoxPriority.Location = new System.Drawing.Point(109, 27);
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
            this.buttonChangePriority.Location = new System.Drawing.Point(21, 70);
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
            this.richTextBoxArray.Location = new System.Drawing.Point(278, 25);
            this.richTextBoxArray.Name = "richTextBoxArray";
            this.richTextBoxArray.Size = new System.Drawing.Size(345, 117);
            this.richTextBoxArray.TabIndex = 28;
            this.richTextBoxArray.Text = "";
            // 
            // richTextBoxSortedArray
            // 
            this.richTextBoxSortedArray.Location = new System.Drawing.Point(278, 171);
            this.richTextBoxSortedArray.Name = "richTextBoxSortedArray";
            this.richTextBoxSortedArray.Size = new System.Drawing.Size(345, 117);
            this.richTextBoxSortedArray.TabIndex = 29;
            this.richTextBoxSortedArray.Text = "";
            // 
            // comboBoxThreadCount
            // 
            this.comboBoxThreadCount.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboBoxThreadCount.FormattingEnabled = true;
            this.comboBoxThreadCount.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8"});
            this.comboBoxThreadCount.Location = new System.Drawing.Point(15, 78);
            this.comboBoxThreadCount.Name = "comboBoxThreadCount";
            this.comboBoxThreadCount.Size = new System.Drawing.Size(50, 28);
            this.comboBoxThreadCount.TabIndex = 30;
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.Color.White;
            this.textBoxA.BorderColor = System.Drawing.Color.Black;
            this.textBoxA.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.ForeColor = System.Drawing.Color.Black;
            this.textBoxA.Location = new System.Drawing.Point(79, 7);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.SelectionStart = 0;
            this.textBoxA.Size = new System.Drawing.Size(50, 40);
            this.textBoxA.TabIndex = 31;
            this.textBoxA.TextInput = "-100";
            this.textBoxA.TextPreview = "A";
            this.textBoxA.UseSystemPasswordChar = false;
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.Color.White;
            this.textBoxB.BorderColor = System.Drawing.Color.Black;
            this.textBoxB.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.ForeColor = System.Drawing.Color.Black;
            this.textBoxB.Location = new System.Drawing.Point(135, 7);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.SelectionStart = 0;
            this.textBoxB.Size = new System.Drawing.Size(50, 40);
            this.textBoxB.TabIndex = 32;
            this.textBoxB.TextInput = "100";
            this.textBoxB.TextPreview = "B";
            this.textBoxB.UseSystemPasswordChar = false;
            // 
            // egoldsFormStyle1
            // 
            this.egoldsFormStyle1.AllowUserResize = false;
            this.egoldsFormStyle1.BackColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.ContextMenuForm = null;
            this.egoldsFormStyle1.ControlBoxButtonsWidth = 20;
            this.egoldsFormStyle1.EnableControlBoxIconsLight = false;
            this.egoldsFormStyle1.EnableControlBoxMouseLight = false;
            this.egoldsFormStyle1.Form = null;
            this.egoldsFormStyle1.FormStyle = yt_DesignUI.Components.EgoldsFormStyle.fStyle.None;
            this.egoldsFormStyle1.HeaderColor = System.Drawing.Color.DimGray;
            this.egoldsFormStyle1.HeaderColorAdditional = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderColorGradientEnable = false;
            this.egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.egoldsFormStyle1.HeaderHeight = 38;
            this.egoldsFormStyle1.HeaderImage = null;
            this.egoldsFormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.comboBoxThreadCount);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.textBoxN);
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 123);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonChangePriority);
            this.groupBox2.Controls.Add(this.comboBoxPriority);
            this.groupBox2.Controls.Add(this.comboBoxThreads);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 135);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBoxSortedArray);
            this.Controls.Add(this.richTextBoxArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EgoldsGoogleTextBox textBoxN;
        private yt_Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxThreads;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private yt_Button buttonChangePriority;
        private System.Windows.Forms.RichTextBox richTextBoxArray;
        private System.Windows.Forms.RichTextBox richTextBoxSortedArray;
        private System.Windows.Forms.ComboBox comboBoxThreadCount;
        private EgoldsGoogleTextBox textBoxA;
        private EgoldsGoogleTextBox textBoxB;
        private Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}