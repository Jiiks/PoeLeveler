namespace PoeLeveler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            stepsBox = new ListBox();
            passiveTree = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblRegex = new Label();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            groupBox4 = new GroupBox();
            nextStepsBox = new ListBox();
            splitContainer1 = new SplitContainer();
            cbAlwaysOnTop = new CheckBox();
            panel1 = new Panel();
            numericFontSize = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)passiveTree).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericFontSize).BeginInit();
            SuspendLayout();
            // 
            // stepsBox
            // 
            stepsBox.BackColor = Color.FromArgb(30, 30, 30);
            stepsBox.BorderStyle = BorderStyle.None;
            stepsBox.Dock = DockStyle.Fill;
            stepsBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stepsBox.ForeColor = SystemColors.Control;
            stepsBox.FormattingEnabled = true;
            stepsBox.Location = new Point(3, 19);
            stepsBox.Name = "stepsBox";
            stepsBox.SelectionMode = SelectionMode.None;
            stepsBox.Size = new Size(869, 152);
            stepsBox.TabIndex = 0;
            // 
            // passiveTree
            // 
            passiveTree.Dock = DockStyle.Fill;
            passiveTree.Location = new Point(3, 19);
            passiveTree.Name = "passiveTree";
            passiveTree.Size = new Size(869, 414);
            passiveTree.SizeMode = PictureBoxSizeMode.CenterImage;
            passiveTree.TabIndex = 1;
            passiveTree.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(passiveTree);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(875, 436);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Passive Tree";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(stepsBox);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(875, 174);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Steps";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(flowLayoutPanel1);
            groupBox3.Controls.Add(lblRegex);
            groupBox3.Controls.Add(label1);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(893, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(629, 791);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Misc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 61);
            label5.Name = "label5";
            label5.Size = new Size(168, 15);
            label5.TabIndex = 10;
            label5.Text = "Copy To Clipboard: Numpad 5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 85);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 9;
            label4.Text = "Wanted Links:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(6, 103);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(617, 434);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // lblRegex
            // 
            lblRegex.AutoSize = true;
            lblRegex.Font = new Font("Segoe UI", 15.75F);
            lblRegex.Location = new Point(158, 19);
            lblRegex.Name = "lblRegex";
            lblRegex.Size = new Size(426, 30);
            lblRegex.TabIndex = 1;
            lblRegex.Text = "b-b-|-b-b|b-.-b|b-b|nne|r-.-b|b-r-|g-b-r|g-r|r-g\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 0;
            label1.Text = "Vendor Regex:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(669, 673);
            label3.Name = "label3";
            label3.Size = new Size(200, 15);
            label3.TabIndex = 2;
            label3.Text = "Wanted Links: BBBB, GBR|GBB, GBBR";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(1422, 809);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 5;
            button1.Text = "Next(num6)";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(1316, 809);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 6;
            button2.Text = "Prev(num4)";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.BackColor = Color.FromArgb(30, 30, 30);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = SystemColors.Control;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Start" });
            comboBox1.Location = new Point(1127, 809);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(nextStepsBox);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.ForeColor = SystemColors.Control;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(875, 171);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Next Steps";
            // 
            // nextStepsBox
            // 
            nextStepsBox.BackColor = Color.FromArgb(30, 30, 30);
            nextStepsBox.BorderStyle = BorderStyle.None;
            nextStepsBox.Dock = DockStyle.Fill;
            nextStepsBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextStepsBox.ForeColor = SystemColors.Control;
            nextStepsBox.FormattingEnabled = true;
            nextStepsBox.Location = new Point(3, 19);
            nextStepsBox.Name = "nextStepsBox";
            nextStepsBox.SelectionMode = SelectionMode.None;
            nextStepsBox.Size = new Size(869, 149);
            nextStepsBox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(12, 445);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox4);
            splitContainer1.Size = new Size(875, 349);
            splitContainer1.SplitterDistance = 174;
            splitContainer1.TabIndex = 8;
            // 
            // cbAlwaysOnTop
            // 
            cbAlwaysOnTop.AutoSize = true;
            cbAlwaysOnTop.ForeColor = SystemColors.Control;
            cbAlwaysOnTop.Location = new Point(13, 11);
            cbAlwaysOnTop.Name = "cbAlwaysOnTop";
            cbAlwaysOnTop.Size = new Size(105, 19);
            cbAlwaysOnTop.TabIndex = 10;
            cbAlwaysOnTop.Text = "Always On Top";
            cbAlwaysOnTop.UseVisualStyleBackColor = true;
            cbAlwaysOnTop.CheckedChanged += cbAlwaysOnTop_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(numericFontSize);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbAlwaysOnTop);
            panel1.Location = new Point(12, 800);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 42);
            panel1.TabIndex = 10;
            // 
            // numericFontSize
            // 
            numericFontSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numericFontSize.BackColor = Color.FromArgb(30, 30, 30);
            numericFontSize.ForeColor = SystemColors.Control;
            numericFontSize.Location = new Point(958, 9);
            numericFontSize.Name = "numericFontSize";
            numericFontSize.Size = new Size(120, 23);
            numericFontSize.TabIndex = 13;
            numericFontSize.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numericFontSize.ValueChanged += numericFontSize_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(898, 13);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 12;
            label2.Text = "Font Size";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1534, 844);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)passiveTree).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericFontSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox stepsBox;
        private PictureBox passiveTree;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Label lblRegex;
        private Label label1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private GroupBox groupBox4;
        private ListBox nextStepsBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private SplitContainer splitContainer1;
        private CheckBox cbAlwaysOnTop;
        private Panel panel1;
        private Label label5;
        private NumericUpDown numericFontSize;
        private Label label2;
    }
}
