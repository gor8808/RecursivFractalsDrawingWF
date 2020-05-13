namespace RecursivFractalsDrawing
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
            this.BinarytreePicCanvas = new System.Windows.Forms.PictureBox();
            this.TimestablesPicCanvas = new System.Windows.Forms.PictureBox();
            this.Binarytree = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AngleScaleValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.DeepValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LengthValue = new System.Windows.Forms.NumericUpDown();
            this.LengthScaleValue = new System.Windows.Forms.TextBox();
            this.Timestables = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.YMaxTimeTable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.YMinTimeTable = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.XMaxTimeTable = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.XMinTimeTable = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CircleR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MultiplyScale = new System.Windows.Forms.TextBox();
            this.PointsCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.FractalType = new System.Windows.Forms.ComboBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.BinarytreePicCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimestablesPicCanvas)).BeginInit();
            this.Binarytree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngleScaleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeepValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthValue)).BeginInit();
            this.Timestables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointsCount)).BeginInit();
            this.HomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BinarytreePicCanvas
            // 
            this.BinarytreePicCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BinarytreePicCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BinarytreePicCanvas.Location = new System.Drawing.Point(0, 0);
            this.BinarytreePicCanvas.Name = "BinarytreePicCanvas";
            this.BinarytreePicCanvas.Size = new System.Drawing.Size(858, 429);
            this.BinarytreePicCanvas.TabIndex = 0;
            this.BinarytreePicCanvas.TabStop = false;
            this.BinarytreePicCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.BinaryTree_Paint);
            // 
            // TimestablesPicCanvas
            // 
            this.TimestablesPicCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimestablesPicCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimestablesPicCanvas.Location = new System.Drawing.Point(0, 0);
            this.TimestablesPicCanvas.Name = "TimestablesPicCanvas";
            this.TimestablesPicCanvas.Size = new System.Drawing.Size(858, 416);
            this.TimestablesPicCanvas.TabIndex = 0;
            this.TimestablesPicCanvas.TabStop = false;
            this.TimestablesPicCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.TimeTables_Paint);
            // 
            // Binarytree
            // 
            this.Binarytree.Controls.Add(this.splitContainer1);
            this.Binarytree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Binarytree.Location = new System.Drawing.Point(0, 0);
            this.Binarytree.Name = "Binarytree";
            this.Binarytree.Size = new System.Drawing.Size(858, 512);
            this.Binarytree.TabIndex = 0;
            this.Binarytree.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.AngleScaleValue);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.DeepValue);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.LengthValue);
            this.splitContainer1.Panel1.Controls.Add(this.LengthScaleValue);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BinarytreePicCanvas);
            this.splitContainer1.Size = new System.Drawing.Size(858, 512);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResetBinaryTree_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 60);
            this.button1.TabIndex = 22;
            this.button1.Text = "Select Back Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectBackColor_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 60);
            this.button3.TabIndex = 21;
            this.button3.Text = "Select Tree Color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SelectDrawingColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "AngleScale";
            // 
            // AngleScaleValue
            // 
            this.AngleScaleValue.Location = new System.Drawing.Point(334, 39);
            this.AngleScaleValue.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.AngleScaleValue.Name = "AngleScaleValue";
            this.AngleScaleValue.Size = new System.Drawing.Size(120, 22);
            this.AngleScaleValue.TabIndex = 19;
            this.AngleScaleValue.ValueChanged += new System.EventHandler(this.BinaryTree_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Deep";
            // 
            // DeepValue
            // 
            this.DeepValue.Location = new System.Drawing.Point(334, 10);
            this.DeepValue.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.DeepValue.Name = "DeepValue";
            this.DeepValue.Size = new System.Drawing.Size(120, 22);
            this.DeepValue.TabIndex = 17;
            this.DeepValue.ValueChanged += new System.EventHandler(this.BinaryTree_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "LengthScale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Length";
            // 
            // LengthValue
            // 
            this.LengthValue.Location = new System.Drawing.Point(99, 10);
            this.LengthValue.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.LengthValue.Name = "LengthValue";
            this.LengthValue.Size = new System.Drawing.Size(120, 22);
            this.LengthValue.TabIndex = 13;
            this.LengthValue.ValueChanged += new System.EventHandler(this.BinaryTree_ValueChanged);
            // 
            // LengthScaleValue
            // 
            this.LengthScaleValue.Location = new System.Drawing.Point(99, 39);
            this.LengthScaleValue.Name = "LengthScaleValue";
            this.LengthScaleValue.Size = new System.Drawing.Size(120, 22);
            this.LengthScaleValue.TabIndex = 24;
            this.LengthScaleValue.TextChanged += new System.EventHandler(this.BinaryTree_ValueChanged);
            // 
            // Timestables
            // 
            this.Timestables.Controls.Add(this.splitContainer2);
            this.Timestables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Timestables.Location = new System.Drawing.Point(0, 0);
            this.Timestables.Name = "Timestables";
            this.Timestables.Size = new System.Drawing.Size(858, 512);
            this.Timestables.TabIndex = 0;
            this.Timestables.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.YMaxTimeTable);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.YMinTimeTable);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.XMaxTimeTable);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.XMinTimeTable);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.CircleR);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.button6);
            this.splitContainer2.Panel1.Controls.Add(this.button5);
            this.splitContainer2.Panel1.Controls.Add(this.button4);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.MultiplyScale);
            this.splitContainer2.Panel1.Controls.Add(this.PointsCount);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TimestablesPicCanvas);
            this.splitContainer2.Size = new System.Drawing.Size(858, 512);
            this.splitContainer2.SplitterDistance = 92;
            this.splitContainer2.TabIndex = 0;
            // 
            // YMaxTimeTable
            // 
            this.YMaxTimeTable.Location = new System.Drawing.Point(475, 60);
            this.YMaxTimeTable.Name = "YMaxTimeTable";
            this.YMaxTimeTable.Size = new System.Drawing.Size(61, 22);
            this.YMaxTimeTable.TabIndex = 16;
            this.YMaxTimeTable.TextChanged += new System.EventHandler(this.TimeTables_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "YMax";
            // 
            // YMinTimeTable
            // 
            this.YMinTimeTable.Location = new System.Drawing.Point(475, 35);
            this.YMinTimeTable.Name = "YMinTimeTable";
            this.YMinTimeTable.Size = new System.Drawing.Size(61, 22);
            this.YMinTimeTable.TabIndex = 14;
            this.YMinTimeTable.TextChanged += new System.EventHandler(this.TimeTables_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(430, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "YMin";
            // 
            // XMaxTimeTable
            // 
            this.XMaxTimeTable.Location = new System.Drawing.Point(356, 61);
            this.XMaxTimeTable.Name = "XMaxTimeTable";
            this.XMaxTimeTable.Size = new System.Drawing.Size(68, 22);
            this.XMaxTimeTable.TabIndex = 12;
            this.XMaxTimeTable.TextChanged += new System.EventHandler(this.TimeTables_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "XMax";
            // 
            // XMinTimeTable
            // 
            this.XMinTimeTable.Location = new System.Drawing.Point(356, 36);
            this.XMinTimeTable.Name = "XMinTimeTable";
            this.XMinTimeTable.Size = new System.Drawing.Size(68, 22);
            this.XMinTimeTable.TabIndex = 10;
            this.XMinTimeTable.TextChanged += new System.EventHandler(this.TimeTables_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "XMin";
            // 
            // CircleR
            // 
            this.CircleR.Location = new System.Drawing.Point(412, 8);
            this.CircleR.Name = "CircleR";
            this.CircleR.Size = new System.Drawing.Size(102, 22);
            this.CircleR.TabIndex = 8;
            this.CircleR.TextChanged += new System.EventHandler(this.TimeTables_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "R of the circle";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(736, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 28);
            this.button6.TabIndex = 6;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ResetTimeTables_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(633, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 66);
            this.button5.TabIndex = 5;
            this.button5.Text = "Select back color";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SelectBackColor_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(542, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 67);
            this.button4.TabIndex = 4;
            this.button4.Text = "Slect drawing color";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SelectDrawingColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Points multiply scale";
            // 
            // MultiplyScale
            // 
            this.MultiplyScale.Location = new System.Drawing.Point(212, 50);
            this.MultiplyScale.Name = "MultiplyScale";
            this.MultiplyScale.Size = new System.Drawing.Size(93, 22);
            this.MultiplyScale.TabIndex = 2;
            this.MultiplyScale.TextChanged += new System.EventHandler(this.TimeTables_ValueChanged);
            // 
            // PointsCount
            // 
            this.PointsCount.Location = new System.Drawing.Point(212, 15);
            this.PointsCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PointsCount.Name = "PointsCount";
            this.PointsCount.Size = new System.Drawing.Size(93, 22);
            this.PointsCount.TabIndex = 1;
            this.PointsCount.ValueChanged += new System.EventHandler(this.TimeTables_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Count of the points on the circle";
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HomePanel.Controls.Add(this.button7);
            this.HomePanel.Controls.Add(this.label13);
            this.HomePanel.Controls.Add(this.label12);
            this.HomePanel.Controls.Add(this.FractalType);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(858, 512);
            this.HomePanel.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(315, 254);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 43);
            this.button7.TabIndex = 3;
            this.button7.Text = "Enter";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.EnterHome_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(225, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 36);
            this.label13.TabIndex = 2;
            this.label13.Text = "Type:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(247, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(287, 39);
            this.label12.TabIndex = 1;
            this.label12.Text = "Recursive fractals";
            // 
            // FractalType
            // 
            this.FractalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FractalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FractalType.FormattingEnabled = true;
            this.FractalType.Items.AddRange(new object[] {
            "Binary tree",
            "Times tables"});
            this.FractalType.Location = new System.Drawing.Point(331, 195);
            this.FractalType.Name = "FractalType";
            this.FractalType.Size = new System.Drawing.Size(235, 37);
            this.FractalType.TabIndex = 0;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Home";
            this.menuItem1.Visible = false;
            this.menuItem1.Click += new System.EventHandler(this.HomeMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4});
            this.menuItem2.Text = "File";
            this.menuItem2.Visible = false;
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Exit";
            this.menuItem4.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem6});
            this.menuItem3.Text = "Change type";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Binary tree";
            this.menuItem5.Click += new System.EventHandler(this.ChangeTypeMenuItem_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Times tables";
            this.menuItem6.Click += new System.EventHandler(this.ChangeTypeMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 512);
            this.Controls.Add(this.Binarytree);
            this.Controls.Add(this.Timestables);
            this.Controls.Add(this.HomePanel);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BinarytreePicCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimestablesPicCanvas)).EndInit();
            this.Binarytree.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AngleScaleValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeepValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthValue)).EndInit();
            this.Timestables.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PointsCount)).EndInit();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Binarytree;
        private System.Windows.Forms.PictureBox BinarytreePicCanvas;
        private System.Windows.Forms.PictureBox TimestablesPicCanvas;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AngleScaleValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DeepValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LengthValue;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox LengthScaleValue;
        private System.Windows.Forms.Panel Timestables;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MultiplyScale;
        private System.Windows.Forms.NumericUpDown PointsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CircleR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox YMaxTimeTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox YMinTimeTable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox XMaxTimeTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox XMinTimeTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox FractalType;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
    }
}

