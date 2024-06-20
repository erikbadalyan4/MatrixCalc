namespace MatrixCalc
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
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AdataGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            BdataGV = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            ResultdataGV = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ARowsnumericUpDown = new NumericUpDown();
            AColnumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            BColnumericUpDown = new NumericUpDown();
            BRowsnumericUpDown = new NumericUpDown();
            plusButton = new Button();
            minusButton = new Button();
            multiplyButton = new Button();
            changeButton = new Button();
            StatLabel = new Label();
            groupBox4 = new GroupBox();
            OKButton = new Button();
            AMultiplyByButton = new Button();
            AReverseButton = new Button();
            ADeterminantButton = new Button();
            ATransposeButton = new Button();
            AMultiplyBytextBox = new TextBox();
            AleftSelButton = new Button();
            ArightSelButton = new Button();
            ResToAbutton = new Button();
            BrightSelButton = new Button();
            BleftSelButton = new Button();
            BMultiplyBytextBox = new TextBox();
            BTransposeButton = new Button();
            BMultiplyByButton = new Button();
            BReverseButton = new Button();
            BDeterminantButton = new Button();
            AClearButton = new Button();
            BClearButton = new Button();
            ResToBbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)AdataGV).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BdataGV).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ResultdataGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ARowsnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AColnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BColnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BRowsnumericUpDown).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // AdataGV
            // 
            AdataGV.AllowUserToAddRows = false;
            AdataGV.AllowUserToDeleteRows = false;
            AdataGV.AllowUserToResizeColumns = false;
            AdataGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AdataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AdataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdataGV.ColumnHeadersVisible = false;
            AdataGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            AdataGV.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            AdataGV.DefaultCellStyle = dataGridViewCellStyle2;
            AdataGV.Location = new Point(6, 22);
            AdataGV.Name = "AdataGV";
            AdataGV.RowHeadersVisible = false;
            AdataGV.RowTemplate.Height = 25;
            AdataGV.ShowCellToolTips = false;
            AdataGV.Size = new Size(340, 213);
            AdataGV.TabIndex = 2;
            AdataGV.CellEndEdit += AdataGV_CellEndEdit;
            AdataGV.CellValidating += AdataGV_CellValidating;
            AdataGV.CurrentCellChanged += AdataGV_CurrentCellChanged;
            AdataGV.EditingControlShowing += AdataGV_EditingControlShowing;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.Width = 5;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.Width = 5;
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.Name = "Column3";
            Column3.Width = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDarkDark;
            groupBox1.Controls.Add(AdataGV);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 241);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "A";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox2.Controls.Add(BdataGV);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(505, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(352, 241);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "B";
            // 
            // BdataGV
            // 
            BdataGV.AllowUserToAddRows = false;
            BdataGV.AllowUserToDeleteRows = false;
            BdataGV.AllowUserToResizeColumns = false;
            BdataGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            BdataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            BdataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BdataGV.ColumnHeadersVisible = false;
            BdataGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            BdataGV.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            BdataGV.DefaultCellStyle = dataGridViewCellStyle4;
            BdataGV.Location = new Point(6, 22);
            BdataGV.Name = "BdataGV";
            BdataGV.RowHeadersVisible = false;
            BdataGV.RowTemplate.Height = 25;
            BdataGV.ShowCellToolTips = false;
            BdataGV.Size = new Size(340, 213);
            BdataGV.TabIndex = 2;
            BdataGV.CellEndEdit += BdataGV_CellEndEdit;
            BdataGV.CellValidating += BdataGV_CellValidating;
            BdataGV.CurrentCellChanged += BdataGV_CurrentCellChanged;
            BdataGV.EditingControlShowing += BdataGV_EditingControlShowing;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Column1";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Column2";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 5;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlDarkDark;
            groupBox3.Controls.Add(ResultdataGV);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(261, 290);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(352, 241);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Result";
            // 
            // ResultdataGV
            // 
            ResultdataGV.AllowUserToAddRows = false;
            ResultdataGV.AllowUserToDeleteRows = false;
            ResultdataGV.AllowUserToResizeColumns = false;
            ResultdataGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ResultdataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ResultdataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultdataGV.ColumnHeadersVisible = false;
            ResultdataGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            ResultdataGV.Cursor = Cursors.Hand;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ResultdataGV.DefaultCellStyle = dataGridViewCellStyle6;
            ResultdataGV.Location = new Point(6, 22);
            ResultdataGV.Name = "ResultdataGV";
            ResultdataGV.ReadOnly = true;
            ResultdataGV.RowHeadersVisible = false;
            ResultdataGV.RowTemplate.Height = 25;
            ResultdataGV.ShowCellToolTips = false;
            ResultdataGV.Size = new Size(340, 213);
            ResultdataGV.TabIndex = 2;
            ResultdataGV.CellValidating += ResultdataGV_CellValidating;
            ResultdataGV.CurrentCellChanged += ResultdataGV_CurrentCellChanged;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Column1";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Column2";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 5;
            // 
            // ARowsnumericUpDown
            // 
            ARowsnumericUpDown.BackColor = SystemColors.ControlDarkDark;
            ARowsnumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            ARowsnumericUpDown.Cursor = Cursors.Hand;
            ARowsnumericUpDown.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ARowsnumericUpDown.ForeColor = SystemColors.ScrollBar;
            ARowsnumericUpDown.Location = new Point(25, 280);
            ARowsnumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            ARowsnumericUpDown.Name = "ARowsnumericUpDown";
            ARowsnumericUpDown.Size = new Size(39, 23);
            ARowsnumericUpDown.TabIndex = 6;
            ARowsnumericUpDown.TextAlign = HorizontalAlignment.Center;
            ARowsnumericUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            ARowsnumericUpDown.ValueChanged += ARowsnumericUpDown_ValueChanged;
            ARowsnumericUpDown.KeyPress += ARowsnumericUpDown_KeyPress;
            // 
            // AColnumericUpDown
            // 
            AColnumericUpDown.BackColor = SystemColors.ControlDarkDark;
            AColnumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            AColnumericUpDown.Cursor = Cursors.Hand;
            AColnumericUpDown.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AColnumericUpDown.ForeColor = SystemColors.ScrollBar;
            AColnumericUpDown.Location = new Point(98, 280);
            AColnumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            AColnumericUpDown.Name = "AColnumericUpDown";
            AColnumericUpDown.Size = new Size(39, 23);
            AColnumericUpDown.TabIndex = 7;
            AColnumericUpDown.TextAlign = HorizontalAlignment.Center;
            AColnumericUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            AColnumericUpDown.ValueChanged += AColnumericUpDown_ValueChanged;
            AColnumericUpDown.KeyPress += ARowsnumericUpDown_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ScrollBar;
            label1.Location = new Point(71, 282);
            label1.Name = "label1";
            label1.Size = new Size(22, 18);
            label1.TabIndex = 8;
            label1.Text = "×";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ScrollBar;
            label2.Location = new Point(783, 280);
            label2.Name = "label2";
            label2.Size = new Size(22, 18);
            label2.TabIndex = 11;
            label2.Text = "×";
            // 
            // BColnumericUpDown
            // 
            BColnumericUpDown.BackColor = SystemColors.ControlDarkDark;
            BColnumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            BColnumericUpDown.Cursor = Cursors.Hand;
            BColnumericUpDown.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BColnumericUpDown.ForeColor = SystemColors.ScrollBar;
            BColnumericUpDown.Location = new Point(810, 278);
            BColnumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            BColnumericUpDown.Name = "BColnumericUpDown";
            BColnumericUpDown.Size = new Size(39, 23);
            BColnumericUpDown.TabIndex = 10;
            BColnumericUpDown.TextAlign = HorizontalAlignment.Center;
            BColnumericUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            BColnumericUpDown.ValueChanged += BColnumericUpDown_ValueChanged;
            BColnumericUpDown.KeyPress += ARowsnumericUpDown_KeyPress;
            // 
            // BRowsnumericUpDown
            // 
            BRowsnumericUpDown.BackColor = SystemColors.ControlDarkDark;
            BRowsnumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            BRowsnumericUpDown.Cursor = Cursors.Hand;
            BRowsnumericUpDown.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BRowsnumericUpDown.ForeColor = SystemColors.ScrollBar;
            BRowsnumericUpDown.Location = new Point(737, 278);
            BRowsnumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            BRowsnumericUpDown.Name = "BRowsnumericUpDown";
            BRowsnumericUpDown.Size = new Size(39, 23);
            BRowsnumericUpDown.TabIndex = 9;
            BRowsnumericUpDown.TextAlign = HorizontalAlignment.Center;
            BRowsnumericUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            BRowsnumericUpDown.ValueChanged += BRowsnumericUpDown_ValueChanged;
            BRowsnumericUpDown.KeyPress += ARowsnumericUpDown_KeyPress;
            // 
            // plusButton
            // 
            plusButton.BackColor = SystemColors.ControlDark;
            plusButton.Cursor = Cursors.Hand;
            plusButton.FlatAppearance.BorderSize = 0;
            plusButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            plusButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            plusButton.FlatStyle = FlatStyle.Flat;
            plusButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            plusButton.ForeColor = SystemColors.ActiveCaptionText;
            plusButton.Location = new Point(391, 72);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(93, 33);
            plusButton.TabIndex = 12;
            plusButton.Text = "Сложить";
            plusButton.UseVisualStyleBackColor = false;
            plusButton.Click += plusButton_Click;
            // 
            // minusButton
            // 
            minusButton.BackColor = SystemColors.ControlDark;
            minusButton.Cursor = Cursors.Hand;
            minusButton.FlatAppearance.BorderSize = 0;
            minusButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            minusButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            minusButton.FlatStyle = FlatStyle.Flat;
            minusButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            minusButton.ForeColor = SystemColors.ActiveCaptionText;
            minusButton.Location = new Point(391, 111);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(93, 33);
            minusButton.TabIndex = 13;
            minusButton.Text = "Вычесть";
            minusButton.UseVisualStyleBackColor = false;
            minusButton.Click += minusButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.BackColor = SystemColors.ControlDark;
            multiplyButton.Cursor = Cursors.Hand;
            multiplyButton.FlatAppearance.BorderSize = 0;
            multiplyButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            multiplyButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            multiplyButton.FlatStyle = FlatStyle.Flat;
            multiplyButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            multiplyButton.ForeColor = SystemColors.ActiveCaptionText;
            multiplyButton.Location = new Point(391, 150);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(93, 33);
            multiplyButton.TabIndex = 14;
            multiplyButton.Text = "Умножить";
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // changeButton
            // 
            changeButton.BackColor = SystemColors.ControlDark;
            changeButton.Cursor = Cursors.Hand;
            changeButton.FlatAppearance.BorderSize = 0;
            changeButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            changeButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            changeButton.FlatStyle = FlatStyle.Flat;
            changeButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            changeButton.ForeColor = SystemColors.WindowFrame;
            changeButton.Image = Properties.Resources.free_icon_refresh_arrows_9847398;
            changeButton.Location = new Point(391, 189);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(93, 33);
            changeButton.TabIndex = 15;
            changeButton.UseVisualStyleBackColor = false;
            changeButton.Click += changeButton_Click;
            // 
            // StatLabel
            // 
            StatLabel.BackColor = SystemColors.ButtonShadow;
            StatLabel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StatLabel.ForeColor = SystemColors.ControlLightLight;
            StatLabel.Location = new Point(1, 9);
            StatLabel.Name = "StatLabel";
            StatLabel.Size = new Size(765, 31);
            StatLabel.TabIndex = 16;
            StatLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(OKButton);
            groupBox4.Controls.Add(StatLabel);
            groupBox4.Location = new Point(10, 550);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(859, 42);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            // 
            // OKButton
            // 
            OKButton.BackColor = Color.FromArgb(42, 42, 42);
            OKButton.Cursor = Cursors.Hand;
            OKButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            OKButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            OKButton.FlatStyle = FlatStyle.Flat;
            OKButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            OKButton.ForeColor = Color.White;
            OKButton.Location = new Point(766, 8);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(93, 33);
            OKButton.TabIndex = 18;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = false;
            OKButton.Click += OKButton_Click;
            // 
            // AMultiplyByButton
            // 
            AMultiplyByButton.BackColor = SystemColors.ControlDark;
            AMultiplyByButton.Cursor = Cursors.Hand;
            AMultiplyByButton.FlatAppearance.BorderSize = 0;
            AMultiplyByButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            AMultiplyByButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            AMultiplyByButton.FlatStyle = FlatStyle.Flat;
            AMultiplyByButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AMultiplyByButton.ForeColor = SystemColors.ActiveCaptionText;
            AMultiplyByButton.Location = new Point(25, 441);
            AMultiplyByButton.Name = "AMultiplyByButton";
            AMultiplyByButton.Size = new Size(128, 33);
            AMultiplyByButton.TabIndex = 20;
            AMultiplyByButton.Text = "Умножить на";
            AMultiplyByButton.UseVisualStyleBackColor = false;
            AMultiplyByButton.Click += AMultiplyByButton_Click;
            // 
            // AReverseButton
            // 
            AReverseButton.BackColor = SystemColors.ControlDark;
            AReverseButton.Cursor = Cursors.Hand;
            AReverseButton.FlatAppearance.BorderSize = 0;
            AReverseButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            AReverseButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            AReverseButton.FlatStyle = FlatStyle.Flat;
            AReverseButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AReverseButton.ForeColor = SystemColors.ActiveCaptionText;
            AReverseButton.Location = new Point(25, 363);
            AReverseButton.Name = "AReverseButton";
            AReverseButton.Size = new Size(216, 33);
            AReverseButton.TabIndex = 19;
            AReverseButton.Text = "Обратная матрица";
            AReverseButton.UseVisualStyleBackColor = false;
            AReverseButton.Click += AReverseButton_Click;
            // 
            // ADeterminantButton
            // 
            ADeterminantButton.BackColor = SystemColors.ControlDark;
            ADeterminantButton.Cursor = Cursors.Hand;
            ADeterminantButton.FlatAppearance.BorderSize = 0;
            ADeterminantButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ADeterminantButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            ADeterminantButton.FlatStyle = FlatStyle.Flat;
            ADeterminantButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ADeterminantButton.ForeColor = SystemColors.ActiveCaptionText;
            ADeterminantButton.Location = new Point(25, 324);
            ADeterminantButton.Name = "ADeterminantButton";
            ADeterminantButton.Size = new Size(216, 33);
            ADeterminantButton.TabIndex = 18;
            ADeterminantButton.Text = "Определитель матрицы";
            ADeterminantButton.UseVisualStyleBackColor = false;
            ADeterminantButton.Click += ADeterminantButton_Click;
            // 
            // ATransposeButton
            // 
            ATransposeButton.BackColor = SystemColors.ControlDark;
            ATransposeButton.Cursor = Cursors.Hand;
            ATransposeButton.FlatAppearance.BorderSize = 0;
            ATransposeButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ATransposeButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            ATransposeButton.FlatStyle = FlatStyle.Flat;
            ATransposeButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ATransposeButton.ForeColor = SystemColors.ActiveCaptionText;
            ATransposeButton.Location = new Point(25, 402);
            ATransposeButton.Name = "ATransposeButton";
            ATransposeButton.Size = new Size(216, 33);
            ATransposeButton.TabIndex = 21;
            ATransposeButton.Text = "Транспонировать матрицу";
            ATransposeButton.UseVisualStyleBackColor = false;
            ATransposeButton.Click += ATransposeButton_Click;
            // 
            // AMultiplyBytextBox
            // 
            AMultiplyBytextBox.BackColor = SystemColors.ScrollBar;
            AMultiplyBytextBox.Font = new Font("Verdana", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            AMultiplyBytextBox.Location = new Point(159, 440);
            AMultiplyBytextBox.MaxLength = 23;
            AMultiplyBytextBox.Name = "AMultiplyBytextBox";
            AMultiplyBytextBox.Size = new Size(82, 35);
            AMultiplyBytextBox.TabIndex = 22;
            AMultiplyBytextBox.TextAlign = HorizontalAlignment.Center;
            AMultiplyBytextBox.TextChanged += AMultiplyBytextBox_TextChanged;
            AMultiplyBytextBox.KeyPress += BMultiplyBytextBox_KeyPress;
            // 
            // AleftSelButton
            // 
            AleftSelButton.BackColor = SystemColors.ButtonShadow;
            AleftSelButton.FlatAppearance.BorderSize = 0;
            AleftSelButton.FlatStyle = FlatStyle.Flat;
            AleftSelButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AleftSelButton.ForeColor = SystemColors.WindowFrame;
            AleftSelButton.Location = new Point(159, 441);
            AleftSelButton.Name = "AleftSelButton";
            AleftSelButton.Size = new Size(12, 33);
            AleftSelButton.TabIndex = 23;
            AleftSelButton.Text = "<";
            AleftSelButton.UseVisualStyleBackColor = false;
            AleftSelButton.Click += AleftSelButton_Click;
            // 
            // ArightSelButton
            // 
            ArightSelButton.BackColor = SystemColors.ButtonShadow;
            ArightSelButton.FlatAppearance.BorderSize = 0;
            ArightSelButton.FlatStyle = FlatStyle.Flat;
            ArightSelButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ArightSelButton.ForeColor = SystemColors.WindowFrame;
            ArightSelButton.Location = new Point(229, 441);
            ArightSelButton.Name = "ArightSelButton";
            ArightSelButton.Size = new Size(12, 33);
            ArightSelButton.TabIndex = 24;
            ArightSelButton.Text = ">";
            ArightSelButton.UseVisualStyleBackColor = false;
            ArightSelButton.Click += ArightSelButton_Click;
            // 
            // ResToAbutton
            // 
            ResToAbutton.BackColor = SystemColors.ControlDark;
            ResToAbutton.Cursor = Cursors.Hand;
            ResToAbutton.FlatAppearance.BorderSize = 0;
            ResToAbutton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ResToAbutton.FlatAppearance.MouseOverBackColor = Color.Gray;
            ResToAbutton.FlatStyle = FlatStyle.Flat;
            ResToAbutton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ResToAbutton.ForeColor = SystemColors.ActiveCaptionText;
            ResToAbutton.Location = new Point(98, 505);
            ResToAbutton.Name = "ResToAbutton";
            ResToAbutton.Size = new Size(157, 25);
            ResToAbutton.TabIndex = 25;
            ResToAbutton.Text = "Результат ➞ A";
            ResToAbutton.UseVisualStyleBackColor = false;
            ResToAbutton.Click += ResToAbutton_Click;
            // 
            // BrightSelButton
            // 
            BrightSelButton.BackColor = SystemColors.ButtonShadow;
            BrightSelButton.FlatAppearance.BorderSize = 0;
            BrightSelButton.FlatStyle = FlatStyle.Flat;
            BrightSelButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BrightSelButton.ForeColor = SystemColors.WindowFrame;
            BrightSelButton.Location = new Point(703, 441);
            BrightSelButton.Name = "BrightSelButton";
            BrightSelButton.Size = new Size(12, 33);
            BrightSelButton.TabIndex = 32;
            BrightSelButton.Text = ">";
            BrightSelButton.UseVisualStyleBackColor = false;
            BrightSelButton.Click += BrightSelButton_Click;
            // 
            // BleftSelButton
            // 
            BleftSelButton.BackColor = SystemColors.ButtonShadow;
            BleftSelButton.FlatAppearance.BorderSize = 0;
            BleftSelButton.FlatStyle = FlatStyle.Flat;
            BleftSelButton.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BleftSelButton.ForeColor = SystemColors.WindowFrame;
            BleftSelButton.Location = new Point(633, 441);
            BleftSelButton.Name = "BleftSelButton";
            BleftSelButton.Size = new Size(12, 33);
            BleftSelButton.TabIndex = 31;
            BleftSelButton.Text = "<";
            BleftSelButton.UseVisualStyleBackColor = false;
            BleftSelButton.Click += BleftSelButton_Click;
            // 
            // BMultiplyBytextBox
            // 
            BMultiplyBytextBox.BackColor = SystemColors.ScrollBar;
            BMultiplyBytextBox.Font = new Font("Verdana", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            BMultiplyBytextBox.Location = new Point(633, 440);
            BMultiplyBytextBox.MaxLength = 23;
            BMultiplyBytextBox.Name = "BMultiplyBytextBox";
            BMultiplyBytextBox.Size = new Size(82, 35);
            BMultiplyBytextBox.TabIndex = 30;
            BMultiplyBytextBox.TextAlign = HorizontalAlignment.Center;
            BMultiplyBytextBox.TextChanged += BMultiplyBytextBox_TextChanged;
            BMultiplyBytextBox.KeyPress += BMultiplyBytextBox_KeyPress;
            // 
            // BTransposeButton
            // 
            BTransposeButton.BackColor = SystemColors.ControlDark;
            BTransposeButton.Cursor = Cursors.Hand;
            BTransposeButton.FlatAppearance.BorderSize = 0;
            BTransposeButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            BTransposeButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            BTransposeButton.FlatStyle = FlatStyle.Flat;
            BTransposeButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BTransposeButton.ForeColor = SystemColors.ActiveCaptionText;
            BTransposeButton.Location = new Point(633, 402);
            BTransposeButton.Name = "BTransposeButton";
            BTransposeButton.Size = new Size(216, 33);
            BTransposeButton.TabIndex = 29;
            BTransposeButton.Text = "Транспонировать матрицу";
            BTransposeButton.UseVisualStyleBackColor = false;
            BTransposeButton.Click += BTransposeButton_Click;
            // 
            // BMultiplyByButton
            // 
            BMultiplyByButton.BackColor = SystemColors.ControlDark;
            BMultiplyByButton.Cursor = Cursors.Hand;
            BMultiplyByButton.FlatAppearance.BorderSize = 0;
            BMultiplyByButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            BMultiplyByButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            BMultiplyByButton.FlatStyle = FlatStyle.Flat;
            BMultiplyByButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BMultiplyByButton.ForeColor = SystemColors.ActiveCaptionText;
            BMultiplyByButton.Location = new Point(723, 441);
            BMultiplyByButton.Name = "BMultiplyByButton";
            BMultiplyByButton.Size = new Size(128, 33);
            BMultiplyByButton.TabIndex = 28;
            BMultiplyByButton.Text = "Умножить на";
            BMultiplyByButton.UseVisualStyleBackColor = false;
            BMultiplyByButton.Click += BMultiplyByButton_Click;
            // 
            // BReverseButton
            // 
            BReverseButton.BackColor = SystemColors.ControlDark;
            BReverseButton.Cursor = Cursors.Hand;
            BReverseButton.FlatAppearance.BorderSize = 0;
            BReverseButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            BReverseButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            BReverseButton.FlatStyle = FlatStyle.Flat;
            BReverseButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BReverseButton.ForeColor = SystemColors.ActiveCaptionText;
            BReverseButton.Location = new Point(633, 363);
            BReverseButton.Name = "BReverseButton";
            BReverseButton.Size = new Size(216, 33);
            BReverseButton.TabIndex = 27;
            BReverseButton.Text = "Обратная матрица";
            BReverseButton.UseVisualStyleBackColor = false;
            BReverseButton.Click += BReverseButton_Click;
            // 
            // BDeterminantButton
            // 
            BDeterminantButton.BackColor = SystemColors.ControlDark;
            BDeterminantButton.Cursor = Cursors.Hand;
            BDeterminantButton.FlatAppearance.BorderSize = 0;
            BDeterminantButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            BDeterminantButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            BDeterminantButton.FlatStyle = FlatStyle.Flat;
            BDeterminantButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BDeterminantButton.ForeColor = SystemColors.ActiveCaptionText;
            BDeterminantButton.Location = new Point(633, 324);
            BDeterminantButton.Name = "BDeterminantButton";
            BDeterminantButton.Size = new Size(216, 33);
            BDeterminantButton.TabIndex = 26;
            BDeterminantButton.Text = "Определитель матрицы";
            BDeterminantButton.UseVisualStyleBackColor = false;
            BDeterminantButton.Click += BDeterminantButton_Click;
            // 
            // AClearButton
            // 
            AClearButton.BackColor = SystemColors.ControlDark;
            AClearButton.Cursor = Cursors.Hand;
            AClearButton.FlatAppearance.BorderSize = 0;
            AClearButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            AClearButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            AClearButton.FlatStyle = FlatStyle.Flat;
            AClearButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AClearButton.ForeColor = SystemColors.ActiveCaptionText;
            AClearButton.Location = new Point(145, 280);
            AClearButton.Name = "AClearButton";
            AClearButton.Size = new Size(96, 23);
            AClearButton.TabIndex = 34;
            AClearButton.Text = "Очистить";
            AClearButton.UseVisualStyleBackColor = false;
            AClearButton.Click += AClearButton_Click;
            // 
            // BClearButton
            // 
            BClearButton.BackColor = SystemColors.ControlDark;
            BClearButton.Cursor = Cursors.Hand;
            BClearButton.FlatAppearance.BorderSize = 0;
            BClearButton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            BClearButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            BClearButton.FlatStyle = FlatStyle.Flat;
            BClearButton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BClearButton.ForeColor = SystemColors.ActiveCaptionText;
            BClearButton.Location = new Point(633, 278);
            BClearButton.Name = "BClearButton";
            BClearButton.Size = new Size(96, 23);
            BClearButton.TabIndex = 35;
            BClearButton.Text = "Очистить";
            BClearButton.UseVisualStyleBackColor = false;
            BClearButton.Click += BClearButton_Click;
            // 
            // ResToBbutton
            // 
            ResToBbutton.BackColor = SystemColors.ControlDark;
            ResToBbutton.Cursor = Cursors.Hand;
            ResToBbutton.FlatAppearance.BorderSize = 0;
            ResToBbutton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ResToBbutton.FlatAppearance.MouseOverBackColor = Color.Gray;
            ResToBbutton.FlatStyle = FlatStyle.Flat;
            ResToBbutton.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ResToBbutton.ForeColor = SystemColors.ActiveCaptionText;
            ResToBbutton.Location = new Point(619, 506);
            ResToBbutton.Name = "ResToBbutton";
            ResToBbutton.Size = new Size(157, 25);
            ResToBbutton.TabIndex = 36;
            ResToBbutton.Text = "Результат ➞ B";
            ResToBbutton.UseVisualStyleBackColor = false;
            ResToBbutton.Click += ResToBbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(879, 602);
            Controls.Add(ResToBbutton);
            Controls.Add(BClearButton);
            Controls.Add(AClearButton);
            Controls.Add(BrightSelButton);
            Controls.Add(BleftSelButton);
            Controls.Add(BMultiplyBytextBox);
            Controls.Add(BTransposeButton);
            Controls.Add(BMultiplyByButton);
            Controls.Add(BReverseButton);
            Controls.Add(BDeterminantButton);
            Controls.Add(ResToAbutton);
            Controls.Add(ArightSelButton);
            Controls.Add(AleftSelButton);
            Controls.Add(AMultiplyBytextBox);
            Controls.Add(ATransposeButton);
            Controls.Add(AMultiplyByButton);
            Controls.Add(AReverseButton);
            Controls.Add(ADeterminantButton);
            Controls.Add(groupBox4);
            Controls.Add(changeButton);
            Controls.Add(multiplyButton);
            Controls.Add(minusButton);
            Controls.Add(plusButton);
            Controls.Add(label2);
            Controls.Add(BColnumericUpDown);
            Controls.Add(BRowsnumericUpDown);
            Controls.Add(label1);
            Controls.Add(AColnumericUpDown);
            Controls.Add(ARowsnumericUpDown);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Матричный калькулятор";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AdataGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BdataGV).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ResultdataGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ARowsnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AColnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)BColnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)BRowsnumericUpDown).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView AdataGV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView BdataGV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private GroupBox groupBox3;
        private DataGridView ResultdataGV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private NumericUpDown ARowsnumericUpDown;
        private NumericUpDown AColnumericUpDown;
        private Label label1;
        private Label label2;
        private NumericUpDown BColnumericUpDown;
        private NumericUpDown BRowsnumericUpDown;
        private Button plusButton;
        private Button minusButton;
        private Button multiplyButton;
        private Button changeButton;
        private Label StatLabel;
        private GroupBox groupBox4;
        private Button OKButton;
        private Button AMultiplyByButton;
        private Button AReverseButton;
        private Button ADeterminantButton;
        private Button ATransposeButton;
        private TextBox AMultiplyBytextBox;
        private Button AleftSelButton;
        private Button ArightSelButton;
        private Button ResToAbutton;
        private Button BrightSelButton;
        private Button BleftSelButton;
        private TextBox BMultiplyBytextBox;
        private Button BTransposeButton;
        private Button BMultiplyByButton;
        private Button BReverseButton;
        private Button BDeterminantButton;
        private Button AClearButton;
        private Button BClearButton;
        private Button ResToBbutton;
    }
}
