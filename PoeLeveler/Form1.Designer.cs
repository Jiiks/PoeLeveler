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
            btnCopyRegex = new Button();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblRegex = new Label();
            label1 = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            cbStep = new ComboBox();
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
            groupBox3.Controls.Add(btnCopyRegex);
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
            // btnCopyRegex
            // 
            btnCopyRegex.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCopyRegex.FlatStyle = FlatStyle.Flat;
            btnCopyRegex.ForeColor = SystemColors.Control;
            btnCopyRegex.Location = new Point(6, 52);
            btnCopyRegex.Name = "btnCopyRegex";
            btnCopyRegex.Size = new Size(617, 39);
            btnCopyRegex.TabIndex = 11;
            btnCopyRegex.Text = "Copy To Clipboard(num5)";
            btnCopyRegex.UseVisualStyleBackColor = true;
            btnCopyRegex.Click += btnCopyRegex_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 9;
            label4.Text = "Wanted Links:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(6, 125);
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
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = SystemColors.Control;
            btnNext.Location = new Point(1422, 809);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 23);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next(num6)";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.ForeColor = SystemColors.Control;
            btnPrev.Location = new Point(1316, 809);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(100, 23);
            btnPrev.TabIndex = 6;
            btnPrev.Text = "Prev(num4)";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // cbStep
            // 
            cbStep.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbStep.BackColor = Color.FromArgb(30, 30, 30);
            cbStep.FlatStyle = FlatStyle.Flat;
            cbStep.ForeColor = SystemColors.Control;
            cbStep.FormattingEnabled = true;
            cbStep.Items.AddRange(new object[] { "Start" });
            cbStep.Location = new Point(1127, 809);
            cbStep.Name = "cbStep";
            cbStep.Size = new Size(183, 23);
            cbStep.TabIndex = 7;
            cbStep.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            Controls.Add(cbStep);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
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
        }

        #endregion

        private ListBox stepsBox;
        private PictureBox passiveTree;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblRegex;
        private Label label1;
        private Button btnNext;
        private Button btnPrev;
        private ComboBox cbStep;
        private GroupBox groupBox4;
        private ListBox nextStepsBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private SplitContainer splitContainer1;
        private CheckBox cbAlwaysOnTop;
        private Panel panel1;
        private NumericUpDown numericFontSize;
        private Label label2;
        private Button btnCopyRegex;
    }
}
