namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlFill = new System.Windows.Forms.Panel();
            this.Standart = new System.Windows.Forms.Label();
            this.btrMenu = new System.Windows.Forms.PictureBox();
            this.btnHistory = new System.Windows.Forms.PictureBox();
            this.txtOperationDisplay = new System.Windows.Forms.TextBox();
            this.txtResultDisplay = new System.Windows.Forms.TextBox();
            this.pnlText = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMemoryClear = new CustomRoundedButton.RoundedButton();
            this.btnMRecall = new CustomRoundedButton.RoundedButton();
            this.btnMAdd = new CustomRoundedButton.RoundedButton();
            this.btnMSubtract = new CustomRoundedButton.RoundedButton();
            this.btnMemorySave = new CustomRoundedButton.RoundedButton();
            this.btnShowMemory = new CustomRoundedButton.RoundedButton();
            this.btnBackSpace = new CustomRoundedButton.RoundedButton();
            this.btnClear = new CustomRoundedButton.RoundedButton();
            this.btnClearEntry = new CustomRoundedButton.RoundedButton();
            this.btnPercent = new CustomRoundedButton.RoundedButton();
            this.btnDivide = new CustomRoundedButton.RoundedButton();
            this.btnSQRT = new CustomRoundedButton.RoundedButton();
            this.btnSqure = new CustomRoundedButton.RoundedButton();
            this.btnReciprecal = new CustomRoundedButton.RoundedButton();
            this.btnMultiply = new CustomRoundedButton.RoundedButton();
            this.btn9 = new CustomRoundedButton.RoundedButton();
            this.btn8 = new CustomRoundedButton.RoundedButton();
            this.btn7 = new CustomRoundedButton.RoundedButton();
            this.btnSubtract = new CustomRoundedButton.RoundedButton();
            this.btn6 = new CustomRoundedButton.RoundedButton();
            this.btn5 = new CustomRoundedButton.RoundedButton();
            this.btn4 = new CustomRoundedButton.RoundedButton();
            this.btnAdd = new CustomRoundedButton.RoundedButton();
            this.btn3 = new CustomRoundedButton.RoundedButton();
            this.btn2 = new CustomRoundedButton.RoundedButton();
            this.btn1 = new CustomRoundedButton.RoundedButton();
            this.btnEquals = new CustomRoundedButton.RoundedButton();
            this.btnDecimal = new CustomRoundedButton.RoundedButton();
            this.btn0 = new CustomRoundedButton.RoundedButton();
            this.btnNagate = new CustomRoundedButton.RoundedButton();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btrMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFill
            // 
            this.pnlFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFill.Controls.Add(this.Standart);
            this.pnlFill.Controls.Add(this.btrMenu);
            this.pnlFill.Controls.Add(this.btnHistory);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFill.Location = new System.Drawing.Point(0, 35);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(325, 47);
            this.pnlFill.TabIndex = 0;
            this.pnlFill.Click += new System.EventHandler(this.txtResultDisplay_Click);
            // 
            // Standart
            // 
            this.Standart.AutoSize = true;
            this.Standart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Standart.ForeColor = System.Drawing.Color.White;
            this.Standart.Location = new System.Drawing.Point(48, 3);
            this.Standart.Name = "Standart";
            this.Standart.Size = new System.Drawing.Size(130, 38);
            this.Standart.TabIndex = 5;
            this.Standart.Text = "Standart";
            // 
            // btrMenu
            // 
            this.btrMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btrMenu.Image = ((System.Drawing.Image)(resources.GetObject("btrMenu.Image")));
            this.btrMenu.Location = new System.Drawing.Point(0, 0);
            this.btrMenu.Name = "btrMenu";
            this.btrMenu.Size = new System.Drawing.Size(44, 45);
            this.btrMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btrMenu.TabIndex = 1;
            this.btrMenu.TabStop = false;
            this.btrMenu.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btrMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximize_MouseMove);
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(279, 0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(44, 45);
            this.btnHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHistory.TabIndex = 0;
            this.btnHistory.TabStop = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            this.btnHistory.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnHistory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximize_MouseMove);
            // 
            // txtOperationDisplay
            // 
            this.txtOperationDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtOperationDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOperationDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOperationDisplay.Enabled = false;
            this.txtOperationDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperationDisplay.ForeColor = System.Drawing.Color.DarkGray;
            this.txtOperationDisplay.Location = new System.Drawing.Point(0, 82);
            this.txtOperationDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.txtOperationDisplay.Multiline = true;
            this.txtOperationDisplay.Name = "txtOperationDisplay";
            this.txtOperationDisplay.ReadOnly = true;
            this.txtOperationDisplay.Size = new System.Drawing.Size(325, 21);
            this.txtOperationDisplay.TabIndex = 6;
            this.txtOperationDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOperationDisplay.Click += new System.EventHandler(this.txtResultDisplay_Click);
            // 
            // txtResultDisplay
            // 
            this.txtResultDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtResultDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtResultDisplay.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultDisplay.ForeColor = System.Drawing.Color.White;
            this.txtResultDisplay.Location = new System.Drawing.Point(0, 103);
            this.txtResultDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.txtResultDisplay.Multiline = true;
            this.txtResultDisplay.Name = "txtResultDisplay";
            this.txtResultDisplay.ReadOnly = true;
            this.txtResultDisplay.Size = new System.Drawing.Size(325, 50);
            this.txtResultDisplay.TabIndex = 7;
            this.txtResultDisplay.TabStop = false;
            this.txtResultDisplay.Text = "0";
            this.txtResultDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultDisplay.Click += new System.EventHandler(this.txtResultDisplay_Click);
            this.txtResultDisplay.TextChanged += new System.EventHandler(this.txtResultDisplay_TextChanged);
            // 
            // pnlText
            // 
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlText.Location = new System.Drawing.Point(0, 529);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(325, 1);
            this.pnlText.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMemoryClear);
            this.panel2.Controls.Add(this.btnMRecall);
            this.panel2.Controls.Add(this.btnMAdd);
            this.panel2.Controls.Add(this.btnMSubtract);
            this.panel2.Controls.Add(this.btnMemorySave);
            this.panel2.Controls.Add(this.btnShowMemory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 49);
            this.panel2.TabIndex = 33;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(255, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 35);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            this.btnMaximize.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnMaximize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximize_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(220, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximize_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "calculator";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 56);
            this.panel1.TabIndex = 5;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(325, 35);
            this.pnlTop.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(290, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMemoryClear.BorderColor = System.Drawing.Color.Transparent;
            this.btnMemoryClear.BorderRadius = 10;
            this.btnMemoryClear.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnMemoryClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMemoryClear.Enabled = false;
            this.btnMemoryClear.FlatAppearance.BorderSize = 0;
            this.btnMemoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemoryClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryClear.ForeColor = System.Drawing.Color.White;
            this.btnMemoryClear.Location = new System.Drawing.Point(1, 0);
            this.btnMemoryClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(54, 49);
            this.btnMemoryClear.TabIndex = 38;
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.UseVisualStyleBackColor = false;
            this.btnMemoryClear.Click += new System.EventHandler(this.btnMemoryClear_Click);
            // 
            // btnMRecall
            // 
            this.btnMRecall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMRecall.BorderColor = System.Drawing.Color.Transparent;
            this.btnMRecall.BorderRadius = 10;
            this.btnMRecall.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnMRecall.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMRecall.Enabled = false;
            this.btnMRecall.FlatAppearance.BorderSize = 0;
            this.btnMRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMRecall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMRecall.ForeColor = System.Drawing.Color.White;
            this.btnMRecall.Location = new System.Drawing.Point(55, 0);
            this.btnMRecall.Margin = new System.Windows.Forms.Padding(0);
            this.btnMRecall.Name = "btnMRecall";
            this.btnMRecall.Size = new System.Drawing.Size(54, 49);
            this.btnMRecall.TabIndex = 37;
            this.btnMRecall.Text = "MR";
            this.btnMRecall.UseVisualStyleBackColor = false;
            this.btnMRecall.Click += new System.EventHandler(this.btnMRecall_Click);
            // 
            // btnMAdd
            // 
            this.btnMAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnMAdd.BorderRadius = 10;
            this.btnMAdd.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnMAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMAdd.FlatAppearance.BorderSize = 0;
            this.btnMAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAdd.ForeColor = System.Drawing.Color.White;
            this.btnMAdd.Location = new System.Drawing.Point(109, 0);
            this.btnMAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnMAdd.Name = "btnMAdd";
            this.btnMAdd.Size = new System.Drawing.Size(54, 49);
            this.btnMAdd.TabIndex = 36;
            this.btnMAdd.Text = "M+";
            this.btnMAdd.UseVisualStyleBackColor = false;
            this.btnMAdd.Click += new System.EventHandler(this.btnMAdd_Click);
            // 
            // btnMSubtract
            // 
            this.btnMSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMSubtract.BorderColor = System.Drawing.Color.Transparent;
            this.btnMSubtract.BorderRadius = 10;
            this.btnMSubtract.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnMSubtract.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMSubtract.FlatAppearance.BorderSize = 0;
            this.btnMSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMSubtract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSubtract.ForeColor = System.Drawing.Color.White;
            this.btnMSubtract.Location = new System.Drawing.Point(163, 0);
            this.btnMSubtract.Margin = new System.Windows.Forms.Padding(0);
            this.btnMSubtract.Name = "btnMSubtract";
            this.btnMSubtract.Size = new System.Drawing.Size(54, 49);
            this.btnMSubtract.TabIndex = 35;
            this.btnMSubtract.Text = "M-";
            this.btnMSubtract.UseVisualStyleBackColor = false;
            this.btnMSubtract.Click += new System.EventHandler(this.btnMSubtract_Click);
            // 
            // btnMemorySave
            // 
            this.btnMemorySave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMemorySave.BorderColor = System.Drawing.Color.Transparent;
            this.btnMemorySave.BorderRadius = 10;
            this.btnMemorySave.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnMemorySave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMemorySave.FlatAppearance.BorderSize = 0;
            this.btnMemorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemorySave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemorySave.ForeColor = System.Drawing.Color.White;
            this.btnMemorySave.Location = new System.Drawing.Point(217, 0);
            this.btnMemorySave.Margin = new System.Windows.Forms.Padding(0);
            this.btnMemorySave.Name = "btnMemorySave";
            this.btnMemorySave.Size = new System.Drawing.Size(54, 49);
            this.btnMemorySave.TabIndex = 34;
            this.btnMemorySave.Text = "MS";
            this.btnMemorySave.UseVisualStyleBackColor = false;
            this.btnMemorySave.Click += new System.EventHandler(this.btnMemorySave_Click);
            // 
            // btnShowMemory
            // 
            this.btnShowMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnShowMemory.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowMemory.BorderRadius = 10;
            this.btnShowMemory.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnShowMemory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowMemory.Enabled = false;
            this.btnShowMemory.FlatAppearance.BorderSize = 0;
            this.btnShowMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMemory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMemory.ForeColor = System.Drawing.Color.White;
            this.btnShowMemory.Location = new System.Drawing.Point(271, 0);
            this.btnShowMemory.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowMemory.Name = "btnShowMemory";
            this.btnShowMemory.Size = new System.Drawing.Size(54, 49);
            this.btnShowMemory.TabIndex = 33;
            this.btnShowMemory.Text = "Mv";
            this.btnShowMemory.UseVisualStyleBackColor = false;
            this.btnShowMemory.Click += new System.EventHandler(this.btnShowMemory_Click_1);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnBackSpace.BorderColor = System.Drawing.Color.Transparent;
            this.btnBackSpace.BorderRadius = 10;
            this.btnBackSpace.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnBackSpace.FlatAppearance.BorderSize = 0;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnBackSpace.ForeColor = System.Drawing.Color.White;
            this.btnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackSpace.Image")));
            this.btnBackSpace.Location = new System.Drawing.Point(243, 197);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(75, 50);
            this.btnBackSpace.TabIndex = 32;
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnClear.BorderColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 10;
            this.btnClear.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(163, 197);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 50);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnClearEntry.BorderColor = System.Drawing.Color.Transparent;
            this.btnClearEntry.BorderRadius = 10;
            this.btnClearEntry.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnClearEntry.FlatAppearance.BorderSize = 0;
            this.btnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnClearEntry.ForeColor = System.Drawing.Color.White;
            this.btnClearEntry.Location = new System.Drawing.Point(83, 197);
            this.btnClearEntry.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(75, 50);
            this.btnClearEntry.TabIndex = 30;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.roundedButton23_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnPercent.BorderColor = System.Drawing.Color.Transparent;
            this.btnPercent.BorderRadius = 10;
            this.btnPercent.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnPercent.ForeColor = System.Drawing.Color.White;
            this.btnPercent.Location = new System.Drawing.Point(3, 197);
            this.btnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(75, 50);
            this.btnPercent.TabIndex = 29;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDivide.BorderColor = System.Drawing.Color.Transparent;
            this.btnDivide.BorderRadius = 10;
            this.btnDivide.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(243, 253);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 50);
            this.btnDivide.TabIndex = 28;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            this.btnDivide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Operations_MouseDown);
            // 
            // btnSQRT
            // 
            this.btnSQRT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSQRT.BorderColor = System.Drawing.Color.Transparent;
            this.btnSQRT.BorderRadius = 10;
            this.btnSQRT.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnSQRT.FlatAppearance.BorderSize = 0;
            this.btnSQRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSQRT.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnSQRT.ForeColor = System.Drawing.Color.White;
            this.btnSQRT.Location = new System.Drawing.Point(163, 253);
            this.btnSQRT.Margin = new System.Windows.Forms.Padding(0);
            this.btnSQRT.Name = "btnSQRT";
            this.btnSQRT.Size = new System.Drawing.Size(75, 50);
            this.btnSQRT.TabIndex = 27;
            this.btnSQRT.Text = "√x";
            this.btnSQRT.UseVisualStyleBackColor = false;
            this.btnSQRT.Click += new System.EventHandler(this.btnSQRT_Click);
            this.btnSQRT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Operations_MouseDown);
            // 
            // btnSqure
            // 
            this.btnSqure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSqure.BorderColor = System.Drawing.Color.Transparent;
            this.btnSqure.BorderRadius = 10;
            this.btnSqure.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnSqure.FlatAppearance.BorderSize = 0;
            this.btnSqure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqure.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnSqure.ForeColor = System.Drawing.Color.White;
            this.btnSqure.Location = new System.Drawing.Point(83, 253);
            this.btnSqure.Margin = new System.Windows.Forms.Padding(0);
            this.btnSqure.Name = "btnSqure";
            this.btnSqure.Size = new System.Drawing.Size(75, 50);
            this.btnSqure.TabIndex = 26;
            this.btnSqure.Text = "x²";
            this.btnSqure.UseVisualStyleBackColor = false;
            this.btnSqure.Click += new System.EventHandler(this.btnSqure_Click);
            this.btnSqure.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Operations_MouseDown);
            // 
            // btnReciprecal
            // 
            this.btnReciprecal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnReciprecal.BorderColor = System.Drawing.Color.Transparent;
            this.btnReciprecal.BorderRadius = 10;
            this.btnReciprecal.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnReciprecal.FlatAppearance.BorderSize = 0;
            this.btnReciprecal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReciprecal.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnReciprecal.ForeColor = System.Drawing.Color.White;
            this.btnReciprecal.Location = new System.Drawing.Point(3, 253);
            this.btnReciprecal.Margin = new System.Windows.Forms.Padding(0);
            this.btnReciprecal.Name = "btnReciprecal";
            this.btnReciprecal.Size = new System.Drawing.Size(75, 50);
            this.btnReciprecal.TabIndex = 25;
            this.btnReciprecal.Text = "⅟x";
            this.btnReciprecal.UseVisualStyleBackColor = false;
            this.btnReciprecal.Click += new System.EventHandler(this.btnReciprecal_Click);
            this.btnReciprecal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Operations_MouseDown);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnMultiply.BorderColor = System.Drawing.Color.Transparent;
            this.btnMultiply.BorderRadius = 10;
            this.btnMultiply.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(243, 305);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 50);
            this.btnMultiply.TabIndex = 24;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            this.btnMultiply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Operations_MouseDown);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn9.BorderColor = System.Drawing.Color.Transparent;
            this.btn9.BorderRadius = 10;
            this.btn9.DisabledTextColor = System.Drawing.Color.Empty;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(163, 305);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 50);
            this.btn9.TabIndex = 23;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn8.BorderColor = System.Drawing.Color.Transparent;
            this.btn8.BorderRadius = 10;
            this.btn8.DisabledTextColor = System.Drawing.Color.Empty;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(83, 305);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 50);
            this.btn8.TabIndex = 22;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn7.BorderColor = System.Drawing.Color.Transparent;
            this.btn7.BorderRadius = 10;
            this.btn7.DisabledTextColor = System.Drawing.Color.Empty;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(3, 305);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 50);
            this.btn7.TabIndex = 21;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSubtract.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubtract.BorderRadius = 10;
            this.btnSubtract.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnSubtract.ForeColor = System.Drawing.Color.White;
            this.btnSubtract.Location = new System.Drawing.Point(243, 359);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 50);
            this.btnSubtract.TabIndex = 20;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            this.btnSubtract.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Operations_MouseDown);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn6.BorderColor = System.Drawing.Color.Transparent;
            this.btn6.BorderRadius = 10;
            this.btn6.DisabledTextColor = System.Drawing.Color.Empty;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(163, 359);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 50);
            this.btn6.TabIndex = 19;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn5.BorderColor = System.Drawing.Color.Transparent;
            this.btn5.BorderRadius = 10;
            this.btn5.DisabledTextColor = System.Drawing.Color.Empty;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(83, 359);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 50);
            this.btn5.TabIndex = 18;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn4.BorderColor = System.Drawing.Color.Transparent;
            this.btn4.BorderRadius = 10;
            this.btn4.DisabledTextColor = System.Drawing.Color.Empty;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(3, 359);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 50);
            this.btn4.TabIndex = 17;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(243, 415);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 50);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Operations_MouseDown);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn3.BorderColor = System.Drawing.Color.Transparent;
            this.btn3.BorderRadius = 10;
            this.btn3.DisabledTextColor = System.Drawing.Color.Empty;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(163, 415);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 50);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn2.BorderColor = System.Drawing.Color.Transparent;
            this.btn2.BorderRadius = 10;
            this.btn2.DisabledTextColor = System.Drawing.Color.Empty;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(83, 415);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 50);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn1.BorderColor = System.Drawing.Color.Transparent;
            this.btn1.BorderRadius = 10;
            this.btn1.DisabledTextColor = System.Drawing.Color.Empty;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(3, 415);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 50);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Teal;
            this.btnEquals.BorderColor = System.Drawing.Color.Transparent;
            this.btnEquals.BorderRadius = 10;
            this.btnEquals.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnEquals.ForeColor = System.Drawing.Color.White;
            this.btnEquals.Location = new System.Drawing.Point(243, 471);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 50);
            this.btnEquals.TabIndex = 12;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDecimal.BorderColor = System.Drawing.Color.Transparent;
            this.btnDecimal.BorderRadius = 10;
            this.btnDecimal.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnDecimal.FlatAppearance.BorderSize = 0;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnDecimal.ForeColor = System.Drawing.Color.White;
            this.btnDecimal.Location = new System.Drawing.Point(163, 471);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(0);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 50);
            this.btnDecimal.TabIndex = 11;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn0.BorderColor = System.Drawing.Color.Transparent;
            this.btn0.BorderRadius = 10;
            this.btn0.DisabledTextColor = System.Drawing.Color.Empty;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(83, 471);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 50);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumButtons_Click);
            // 
            // btnNagate
            // 
            this.btnNagate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnNagate.BorderColor = System.Drawing.Color.Transparent;
            this.btnNagate.BorderRadius = 10;
            this.btnNagate.DisabledTextColor = System.Drawing.Color.Empty;
            this.btnNagate.FlatAppearance.BorderSize = 0;
            this.btnNagate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNagate.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnNagate.ForeColor = System.Drawing.Color.White;
            this.btnNagate.Location = new System.Drawing.Point(3, 471);
            this.btnNagate.Margin = new System.Windows.Forms.Padding(0);
            this.btnNagate.Name = "btnNagate";
            this.btnNagate.Size = new System.Drawing.Size(75, 50);
            this.btnNagate.TabIndex = 8;
            this.btnNagate.Text = "+/-";
            this.btnNagate.UseVisualStyleBackColor = false;
            this.btnNagate.Click += new System.EventHandler(this.btnNagate_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(325, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSQRT);
            this.Controls.Add(this.btnSqure);
            this.Controls.Add(this.btnReciprecal);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.btnNagate);
            this.Controls.Add(this.txtResultDisplay);
            this.Controls.Add(this.txtOperationDisplay);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btrMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.PictureBox btnHistory;
        private System.Windows.Forms.PictureBox btrMenu;
        private System.Windows.Forms.Label Standart;
        private System.Windows.Forms.TextBox txtOperationDisplay;
        private System.Windows.Forms.TextBox txtResultDisplay;
        private CustomRoundedButton.RoundedButton btnNagate;
        private System.Windows.Forms.Panel pnlText;
        private CustomRoundedButton.RoundedButton btn0;
        private CustomRoundedButton.RoundedButton btnEquals;
        private CustomRoundedButton.RoundedButton btnDecimal;
        private CustomRoundedButton.RoundedButton btnAdd;
        private CustomRoundedButton.RoundedButton btn3;
        private CustomRoundedButton.RoundedButton btn2;
        private CustomRoundedButton.RoundedButton btn1;
        private CustomRoundedButton.RoundedButton btnSubtract;
        private CustomRoundedButton.RoundedButton btn6;
        private CustomRoundedButton.RoundedButton btn5;
        private CustomRoundedButton.RoundedButton btn4;
        private CustomRoundedButton.RoundedButton btnMultiply;
        private CustomRoundedButton.RoundedButton btn9;
        private CustomRoundedButton.RoundedButton btn8;
        private CustomRoundedButton.RoundedButton btn7;
        private CustomRoundedButton.RoundedButton btnDivide;
        private CustomRoundedButton.RoundedButton btnSQRT;
        private CustomRoundedButton.RoundedButton btnSqure;
        private CustomRoundedButton.RoundedButton btnReciprecal;
        private CustomRoundedButton.RoundedButton btnBackSpace;
        private CustomRoundedButton.RoundedButton btnClear;
        private CustomRoundedButton.RoundedButton btnClearEntry;
        private CustomRoundedButton.RoundedButton btnPercent;
        private System.Windows.Forms.Panel panel2;
        private CustomRoundedButton.RoundedButton btnShowMemory;
        private CustomRoundedButton.RoundedButton btnMSubtract;
        private CustomRoundedButton.RoundedButton btnMemorySave;
        private CustomRoundedButton.RoundedButton btnMemoryClear;
        private CustomRoundedButton.RoundedButton btnMRecall;
        private CustomRoundedButton.RoundedButton btnMAdd;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox btnExit;
    }
}

