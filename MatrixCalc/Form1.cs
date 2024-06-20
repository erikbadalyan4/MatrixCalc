using System.Diagnostics;
using System.Drawing.Drawing2D;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace MatrixCalc
{
    public partial class Form1 : Form
    {
        int FixedRowsHeihgt = 30;
        int DefaultColomnsWidth = 65;
        int LabelWidth = 857;
        bool AColumnLastValueIs0 = false;
        bool BColumnLastValueIs0 = false;
        double[,] AMatrix;
        double[,] BMatrix;
        double[,] ResMatrix;
        double epsilon = 0.00000001;
        public Form1()
        {
           
            InitializeComponent();
            AdataGV.ColumnCount = 3;
            AdataGV.RowCount = 3;
            BdataGV.ColumnCount = 3;
            BdataGV.RowCount = 3;
            for (int i = 0; i < AdataGV.Rows.Count; i++)
            {
                AdataGV.Columns[i].Width = DefaultColomnsWidth;
                AdataGV.Rows[i].Height = FixedRowsHeihgt;
                BdataGV.Columns[i].Width = DefaultColomnsWidth;
                BdataGV.Rows[i].Height = FixedRowsHeihgt;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OKButton.Visible = false;
            AleftSelButton.Visible = false;
            ArightSelButton.Visible = false;
            BrightSelButton.Visible = false;
            BleftSelButton.Visible = false;
            StatLabel.Width = LabelWidth;
            AMatrix = new double[AdataGV.RowCount, AdataGV.ColumnCount];
            BMatrix = new double[BdataGV.RowCount, BdataGV.ColumnCount];
            BdataGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ResultdataGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        double[,] NewMatrix(double[,] Matrix, int Rows, int Columns)
        {
            double[,] NewMatrix = new double[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    try
                    {
                        NewMatrix[i, j] = Matrix[i, j];
                    }
                    catch (Exception)
                    {
                        NewMatrix[i, j] = 0;
                    }
                }
            }
            return NewMatrix;
        }
        private void ARowsnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            AdataGV.RowCount = (int)ARowsnumericUpDown.Value;
            if (AdataGV.RowCount == 0)
            {
                AdataGV.ColumnCount = 0;
            }
            AColnumericUpDown.Value = AdataGV.ColumnCount;
            for (int i = 0; i < AdataGV.Rows.Count; i++)
            {
                AdataGV.Rows[i].Height = FixedRowsHeihgt;
            }

            if (ARowsnumericUpDown.Value == 100)
            {
                ARowsnumericUpDown.Width = 45;
            }
            else
            {
                ARowsnumericUpDown.Width = 39;
            }
            AMatrix = NewMatrix(AMatrix, AdataGV.RowCount, AdataGV.ColumnCount);
        }

        private void AColnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            AdataGV.ColumnCount = (int)AColnumericUpDown.Value;
            if (AColumnLastValueIs0)
            {
                AdataGV.RowCount = 1;
                AColumnLastValueIs0 = false;
            }
            ARowsnumericUpDown.Value = AdataGV.RowCount;
            for (int i = 0; i < AdataGV.ColumnCount; i++)
            {
                AdataGV.Columns[i].Width = DefaultColomnsWidth;
            }
            if (AColnumericUpDown.Value == 100)
            {
                AColnumericUpDown.Width = 45;
            }
            else
            {
                AColnumericUpDown.Width = 39;
            }
            if (AdataGV.ColumnCount == 0)
            {
                AColumnLastValueIs0 = true;
            }
            AMatrix = NewMatrix(AMatrix, AdataGV.RowCount, AdataGV.ColumnCount);
        }

        private void BRowsnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BdataGV.RowCount = (int)BRowsnumericUpDown.Value;
            if (BdataGV.RowCount == 0)
            {
                BdataGV.ColumnCount = 0;
            }
            BColnumericUpDown.Value = BdataGV.ColumnCount;
            if (BdataGV.RowCount == 0)
            {
                BColnumericUpDown.Value = 0;
            }
            for (int i = 0; i < BdataGV.Rows.Count; i++)
            {
                BdataGV.Rows[i].Height = FixedRowsHeihgt;
            }
            if (BRowsnumericUpDown.Value == 100)
            {
                BRowsnumericUpDown.Width = 45;
            }
            else
            {
                BRowsnumericUpDown.Width = 39;
            }
            BMatrix = NewMatrix(BMatrix, BdataGV.RowCount, BdataGV.ColumnCount);
        }

        private void BColnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BdataGV.ColumnCount = (int)BColnumericUpDown.Value;
            if (BColumnLastValueIs0)
            {
                BdataGV.RowCount = 1;
                BColumnLastValueIs0 = false;
            }
            BRowsnumericUpDown.Value = BdataGV.RowCount;
            for (int i = 0; i < BdataGV.ColumnCount; i++)
            {
                BdataGV.Columns[i].Width = DefaultColomnsWidth;
            }
            if (BColnumericUpDown.Value == 100)
            {
                BColnumericUpDown.Width = 45;
            }
            else
            {
                BColnumericUpDown.Width = 39;
            }
            if (BdataGV.ColumnCount == 0)
            {
                BColumnLastValueIs0 = true;
            }
            BMatrix = NewMatrix(BMatrix, BdataGV.RowCount, BdataGV.ColumnCount);
        }

        private void ARowsnumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (Char.IsControl(e.KeyChar) && e.KeyChar == (char)Keys.Back) return;
            e.Handled = true;
        }

        private void AMultiplyBytextBox_TextChanged(object sender, EventArgs e)
        {
            if (AMultiplyBytextBox.TextLength > 5)
            {
                AMultiplyBytextBox.Location = new Point(171, AMultiplyBytextBox.Location.Y);
                AMultiplyBytextBox.Width = 58;
                ArightSelButton.Visible = true;
                AleftSelButton.Visible = true;
                int SelStart = AMultiplyBytextBox.SelectionStart;
                AMultiplyBytextBox.SelectionStart = 0;
                AMultiplyBytextBox.SelectionStart = SelStart;
            }
            else
            {
                AMultiplyBytextBox.Location = new Point(159, AMultiplyBytextBox.Location.Y);
                AMultiplyBytextBox.Width = 82;
                ArightSelButton.Visible = false;
                AleftSelButton.Visible = false;
                int SelStart = AMultiplyBytextBox.SelectionStart;
                AMultiplyBytextBox.SelectionStart = 0;
                AMultiplyBytextBox.SelectionStart = SelStart;
            }
        }

        private void AleftSelButton_Click(object sender, EventArgs e)
        {
            AMultiplyBytextBox.Focus();
            if (AMultiplyBytextBox.SelectionStart != 0)
            {
                AMultiplyBytextBox.SelectionStart -= 1;
            }
        }

        private void ArightSelButton_Click(object sender, EventArgs e)
        {
            AMultiplyBytextBox.Focus();
            AMultiplyBytextBox.SelectionStart += 1;
        }

        private void BleftSelButton_Click(object sender, EventArgs e)
        {
            BMultiplyBytextBox.Focus();
            if (BMultiplyBytextBox.SelectionStart != 0)
            {
                BMultiplyBytextBox.SelectionStart -= 1;
            }
        }

        private void BrightSelButton_Click(object sender, EventArgs e)
        {
            BMultiplyBytextBox.Focus();
            BMultiplyBytextBox.SelectionStart += 1;
        }

        private void BMultiplyBytextBox_TextChanged(object sender, EventArgs e)
        {
            if (BMultiplyBytextBox.TextLength > 5)
            {
                BMultiplyBytextBox.Location = new Point(645, BMultiplyBytextBox.Location.Y);
                BMultiplyBytextBox.Width = 58;
                BrightSelButton.Visible = true;
                BleftSelButton.Visible = true;
                int SelStart = BMultiplyBytextBox.SelectionStart;
                BMultiplyBytextBox.SelectionStart = 0;
                BMultiplyBytextBox.SelectionStart = SelStart;
            }
            else
            {
                BMultiplyBytextBox.Location = new Point(633, BMultiplyBytextBox.Location.Y);
                BMultiplyBytextBox.Width = 82;
                BrightSelButton.Visible = false;
                BleftSelButton.Visible = false;
                int SelStart = BMultiplyBytextBox.SelectionStart;
                BMultiplyBytextBox.SelectionStart = 0;
                BMultiplyBytextBox.SelectionStart = SelStart;
            }
        }

        private void AdataGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox AdataGVCelltb = e.Control as TextBox;
            AdataGVCelltb.MaxLength = 20;
            if (AdataGVCelltb != null)
            {
                AdataGVCelltb.KeyPress -= AdataGVCelltb_KeyPress;
                AdataGVCelltb.KeyPress += AdataGVCelltb_KeyPress;
                void AdataGVCelltb_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || (e.KeyChar == ',' && !AdataGVCelltb.Text.Contains(',')) || (e.KeyChar == '-' && AdataGVCelltb.SelectionStart == 0) && !AdataGVCelltb.Text.Contains('-'))
                    {
                        if (e.KeyChar == (char)Keys.Back)
                        {
                            int widthkoef = 0;
                            if (AdataGVCelltb.Text.Length - AdataGVCelltb.SelectionLength - 6 > 0) widthkoef = AdataGVCelltb.Text.Length - AdataGVCelltb.SelectionLength - 6;
                            AdataGV.Columns[AdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth + widthkoef * 11;
                            return;
                        }
                        else if (e.KeyChar == (char)22)
                        {
                            if (Clipboard.ContainsText())
                            {
                                string clipboardText = Clipboard.GetText();
                                if (double.TryParse(clipboardText, out _))
                                {
                                    int widthkoef = 0;
                                    AdataGVCelltb.Text = "";
                                    if (clipboardText.Length > 4) widthkoef = clipboardText.Length - 4;
                                    AdataGV.Columns[AdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth + widthkoef * 11;
                                    return;
                                }
                            }
                        }
                        else if (e.KeyChar == (char)3)
                        {
                            return;
                        }
                        else
                        {
                            int widthkoef = 0;
                            if (AdataGVCelltb.Text.Length - AdataGVCelltb.SelectionLength - 4 > 0) widthkoef = AdataGVCelltb.Text.Length - AdataGVCelltb.SelectionLength - 4;
                            AdataGV.Columns[AdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth + widthkoef * 11;
                            return;
                        }
                    }
                    e.Handled = true;
                }
            }
        }

        private void BdataGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox BdataGVCelltb = e.Control as TextBox;
            BdataGVCelltb.MaxLength = 20;
            if (BdataGVCelltb != null)
            {
                BdataGVCelltb.KeyPress -= BdataGVCelltb_KeyPress;
                BdataGVCelltb.KeyPress += BdataGVCelltb_KeyPress;
                void BdataGVCelltb_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || (e.KeyChar == ',' && !BdataGVCelltb.Text.Contains(',')) || (e.KeyChar == '-' && BdataGVCelltb.SelectionStart == 0) && !BdataGVCelltb.Text.Contains('-'))
                    {
                        if (e.KeyChar == (char)Keys.Back)
                        {
                            int widthkoef = 0;
                            if (BdataGVCelltb.Text.Length - BdataGVCelltb.SelectionLength - 6 > 0) widthkoef = BdataGVCelltb.Text.Length - BdataGVCelltb.SelectionLength - 6;
                            BdataGV.Columns[BdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth + widthkoef * 11;
                            return;
                        }
                        else if (e.KeyChar == (char)22)
                        {
                            if (Clipboard.ContainsText())
                            {
                                string clipboardText = Clipboard.GetText();
                                if (double.TryParse(clipboardText, out _))
                                {
                                    int widthkoef = 0;
                                    BdataGVCelltb.Text = "";
                                    if (clipboardText.Length > 4) widthkoef = clipboardText.Length - 4;
                                    BdataGV.Columns[BdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth + widthkoef * 11;
                                    return;
                                }
                            }
                        }
                        else if (e.KeyChar == (char)3)
                        {
                            return;
                        }
                        else
                        {
                            int widthkoef = 0;
                            if (BdataGVCelltb.Text.Length - BdataGVCelltb.SelectionLength - 4 > 0) widthkoef = BdataGVCelltb.Text.Length - BdataGVCelltb.SelectionLength - 4;
                            BdataGV.Columns[BdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth + widthkoef * 11;
                            return;
                        }
                    }
                    e.Handled = true;
                }
            }
        }
        private void AdataGV_CurrentCellChanged(object sender, EventArgs e)
        {
            if (AdataGV.CurrentCell != null && AdataGV.CurrentCell.Value != null)
            {
                string Value = AdataGV.Rows[AdataGV.CurrentCell.RowIndex].Cells[AdataGV.CurrentCell.ColumnIndex].Value.ToString();
                int widthkoef = 0;
                if (!string.IsNullOrEmpty(Value) && Value.Length - 4 > 0) widthkoef = Value.Length - 4;
                AdataGV.Columns[AdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth + widthkoef * 11;
            }
        }

        private void BdataGV_CurrentCellChanged(object sender, EventArgs e)
        {
            if (BdataGV.CurrentCell != null && BdataGV.CurrentCell.Value != null)
            {
                string Value = BdataGV.Rows[BdataGV.CurrentCell.RowIndex].Cells[BdataGV.CurrentCell.ColumnIndex].Value.ToString();
                int widthkoef = 0;
                if (!string.IsNullOrEmpty(Value) && Value.Length - 4 > 0) widthkoef = Value.Length - 4;
                BdataGV.Columns[BdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth + widthkoef * 11;
            }
        }
        private void ResultdataGV_CurrentCellChanged(object sender, EventArgs e)
        {
            if (ResultdataGV.CurrentCell != null && ResultdataGV.CurrentCell.Value != null)
            {
                string Value = ResultdataGV.Rows[ResultdataGV.CurrentCell.RowIndex].Cells[ResultdataGV.CurrentCell.ColumnIndex].Value.ToString();
                int widthkoef = 0;
                if (!string.IsNullOrEmpty(Value) && Value.Length - 4 > 0) widthkoef = Value.Length - 4;
                ResultdataGV.Columns[ResultdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth + widthkoef * 11;
            }
        }


        private void AdataGV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            AdataGV.Columns[AdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth;
        }
        private void BdataGV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            BdataGV.Columns[BdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth;
        }
        private void ResultdataGV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ResultdataGV.Columns[ResultdataGV.CurrentCell.ColumnIndex].Width = DefaultColomnsWidth;
        }
        private void AdataGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = AdataGV.CurrentCell.RowIndex;
            int ColumnIndex = AdataGV.CurrentCell.ColumnIndex;
            double value;
            if (double.TryParse(Convert.ToString(AdataGV.Rows[RowIndex].Cells[ColumnIndex].Value), out value))
            {
                AMatrix[RowIndex, ColumnIndex] = value;
                AdataGV.Rows[RowIndex].Cells[ColumnIndex].Value = value;

            }

        }

        private void BdataGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = BdataGV.CurrentCell.RowIndex;
            int ColumnIndex = BdataGV.CurrentCell.ColumnIndex;
            double value;
            if (double.TryParse(Convert.ToString(BdataGV.Rows[RowIndex].Cells[ColumnIndex].Value), out value))
            {
                BMatrix[RowIndex, ColumnIndex] = value;
                BdataGV.Rows[RowIndex].Cells[ColumnIndex].Value = value;
            }
        }

        private void BMultiplyBytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox MultiplyTB = sender as TextBox;
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || (e.KeyChar == ',' && !MultiplyTB.Text.Contains(',')) || (e.KeyChar == '-' && MultiplyTB.SelectionStart == 0) && !MultiplyTB.Text.Contains('-'))
            {
                if (e.KeyChar == (char)22)
                {
                    if (Clipboard.ContainsText())
                    {
                        string clipboardText = Clipboard.GetText();
                        if (double.TryParse(clipboardText, out _))
                        {
                            int widthkoef = 0;
                            MultiplyTB.Text = "";
                            return;
                        }
                    }
                }
                else return;
            }
            e.Handled = true;
        }

        void ShowMatrix(double[,] Matrix, DataGridView dgv)
        {
            dgv.RowCount = Matrix.GetLength(0);
            dgv.ColumnCount = Matrix.GetLength(1);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Width = DefaultColomnsWidth;
            }
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                dgv.Rows[i].Height = FixedRowsHeihgt;
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == 0)
                    {
                        dgv.Rows[i].Cells[j].Value = 0;
                    }
                    else if (Matrix[i, j].ToString() == "∞" || double.IsNaN(Matrix[i,j]))
                    {
                        for (int k = 0; k < Matrix.GetLength(0); k++)
                        {
                            for (int l = 0; l < Matrix.GetLength(1); l++)
                            {
                                Matrix[k, l] = 0;
                                dgv.Rows[k].Cells[l].Value = null;
                            }
                        }
                        ClearResultMatrix();
                        ShowError("Ошибка! Слишком большое число!");
                        return;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[j].Value = Matrix[i, j];
                    }

                }
            }
        }
        void NullCells(DataGridView dgv)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value == null)
                    {
                        dgv.Rows[i].Cells[j].Value = 0;
                    }
                }
            }
        }
        void ClearResultMatrix()
        {
            ResMatrix = null;
            ResultdataGV.ColumnCount = 0;
            ResultdataGV.RowCount = 0;
        }
        void DisableControls()
        {
            AdataGV.Enabled = false;
            BdataGV.Enabled = false;
            ResultdataGV.Enabled = false;
            plusButton.Enabled = false;
            minusButton.Enabled = false;
            multiplyButton.Enabled = false;
            changeButton.Enabled = false;
            ARowsnumericUpDown.Enabled = false;
            BRowsnumericUpDown.Enabled = false;
            AColnumericUpDown.Enabled = false;
            BColnumericUpDown.Enabled = false;
            AClearButton.Enabled = false;
            BClearButton.Enabled = false;
            ADeterminantButton.Enabled = false;
            BDeterminantButton.Enabled = false;
            AReverseButton.Enabled = false;
            BReverseButton.Enabled = false;
            ATransposeButton.Enabled = false;
            BTransposeButton.Enabled = false;
            AMultiplyByButton.Enabled = false;
            BMultiplyByButton.Enabled = false;
            AMultiplyBytextBox.Enabled = false;
            BMultiplyBytextBox.Enabled = false;
            AleftSelButton.Enabled = false;
            BleftSelButton.Enabled = false;
            ArightSelButton.Enabled = false;
            BrightSelButton.Enabled = false;
            ResToAbutton.Enabled = false;
            ResToBbutton.Enabled = false;
        }
        void EnableControls()
        {
            AdataGV.Enabled = true;
            BdataGV.Enabled = true;
            ResultdataGV.Enabled = true;
            plusButton.Enabled = true;
            minusButton.Enabled = true;
            multiplyButton.Enabled = true;
            changeButton.Enabled = true;
            ARowsnumericUpDown.Enabled = true;
            BRowsnumericUpDown.Enabled = true;
            AColnumericUpDown.Enabled = true;
            BColnumericUpDown.Enabled = true;
            AClearButton.Enabled = true;
            BClearButton.Enabled = true;
            ADeterminantButton.Enabled = true;
            BDeterminantButton.Enabled = true;
            AReverseButton.Enabled = true;
            BReverseButton.Enabled = true;
            ATransposeButton.Enabled = true;
            BTransposeButton.Enabled = true;
            AMultiplyByButton.Enabled = true;
            BMultiplyByButton.Enabled = true;
            AMultiplyBytextBox.Enabled = true;
            BMultiplyBytextBox.Enabled = true;
            AleftSelButton.Enabled = true;
            BleftSelButton.Enabled = true;
            ArightSelButton.Enabled = true;
            BrightSelButton.Enabled = true;
            ResToAbutton.Enabled = true;
            ResToBbutton.Enabled = true;
        }
        void ShowError(string ErrorText)
        {
            DisableControls();
            ClearResultMatrix();
            StatLabel.Text = ErrorText;
            StatLabel.Width = 765;
            StatLabel.BackColor = Color.FromArgb(42, 42, 42);
            OKButton.Visible = true;
            OKButton.Focus();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            EnableControls();
            StatLabel.Text = "";
            StatLabel.Width = LabelWidth;
            StatLabel.BackColor = Color.DarkGray;
            OKButton.Visible = false;
        }
        private void plusButton_Click(object sender, EventArgs e)
        {

            NullCells(AdataGV);
            NullCells(BdataGV);
            if (AMatrix.GetLength(0) == 0 && BMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размеры матрицы A и B заданы некоректно!"); return;
            }
            if (AMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы A задан некоректно!"); return;
            }
            if (BMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы B задан некоректно!"); return;
            }
            if (AMatrix.GetLength(0) == BMatrix.GetLength(0) && AMatrix.GetLength(1) == BMatrix.GetLength(1))
            {
                ResMatrix = new double[AMatrix.GetLength(0), AMatrix.GetLength(1)];
                for (int i = 0; i < AMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < AMatrix.GetLength(1); j++)
                    {
                        ResMatrix[i, j] = AMatrix[i, j] + BMatrix[i, j];
                    }
                }
                ShowMatrix(ResMatrix, ResultdataGV);
            }
            else
            {
                ShowError("Ошибка! Размеры матриц не равны!");
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            NullCells(AdataGV);
            NullCells(BdataGV);
            if (AMatrix.GetLength(0) == 0 && BMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размеры матрицы A и B заданы некоректно!"); return;
            }
            if (AMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы A задан некоректно!"); return;
            }
            if (BMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы B задан некоректно!"); return;
            }
            if (AMatrix.GetLength(0) == BMatrix.GetLength(0) && AMatrix.GetLength(1) == BMatrix.GetLength(1))
            {
                ResMatrix = new double[AMatrix.GetLength(0), AMatrix.GetLength(1)];
                for (int i = 0; i < AMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < AMatrix.GetLength(1); j++)
                    {
                        ResMatrix[i, j] = AMatrix[i, j] - BMatrix[i, j];
                    }
                }
                ShowMatrix(ResMatrix, ResultdataGV);
            }
            else
            {
                ShowError("Ошибка! Размеры матриц не равны!");
            }
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            NullCells(AdataGV);
            NullCells(BdataGV);
            if (AMatrix.GetLength(0) == 0 && BMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размеры матрицы A и B заданы некоректно!"); return;
            }
            if (AMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы A задан некоректно!"); return;
            }
            if (BMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы B задан некоректно!"); return;
            }
            if (AMatrix.GetLength(1) == BMatrix.GetLength(0))
            {
                ResMatrix = new double[AMatrix.GetLength(0), BMatrix.GetLength(1)];
                for (int i = 0; i < ResMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < ResMatrix.GetLength(1); j++)
                    {
                        double sum = 0;
                        for (int k = 0; k < AMatrix.GetLength(1); k++)
                        {
                            double mul = 0;

                            if (Math.Abs(AMatrix[i, k] * BMatrix[k, j]) > epsilon) mul = AMatrix[i, k] * BMatrix[k, j];
                            sum += mul;
                        }
                        if (Math.Abs(sum) < epsilon) sum = 0; 
                        ResMatrix[i, j] = sum;
                    }
                }
                ShowMatrix(ResMatrix, ResultdataGV);
            }
            else
            {
                ShowError("Ошибка! Матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В.");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (AMatrix.GetLength(0) == 0 && BMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размеры матрицы A и B заданы некоректно!"); return;
            }
            if (AMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы A задан некоректно!"); return;
            }
            if (BMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы B задан некоректно!"); return;
            }
            double[,] AtempMatrix = AMatrix;
            AMatrix = BMatrix;
            BMatrix = AtempMatrix;
            ShowMatrix(AMatrix, AdataGV);
            ShowMatrix(BMatrix, BdataGV);
        }

        private void AClearButton_Click(object sender, EventArgs e)
        {
            AMatrix = new double[AMatrix.GetLength(0), AMatrix.GetLength(1)];
            for (int i = 0; i < AMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < AMatrix.GetLength(1); j++)
                {
                    AdataGV.Rows[i].Cells[j].Value = null;
                }
            }
        }

        private void BClearButton_Click(object sender, EventArgs e)
        {
            BMatrix = new double[BMatrix.GetLength(0), BMatrix.GetLength(1)];
            for (int i = 0; i < BMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < BMatrix.GetLength(1); j++)
                {
                    BdataGV.Rows[i].Cells[j].Value = null;
                }
            }
        }

        public double CalculateDeterminant(double[,] matrix)
        {
            int size = matrix.GetLength(0);
            if (size == 1)
            {
                return matrix[0, 0];
            }
            else if (size == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            else
            {
                double determinant = 0;
                for (int i = 0; i < size; i++)
                {
                    double[,] subMatrix = new double[size - 1, size - 1];
                    for (int j = 1; j < size; j++)
                    {
                        for (int k = 0; k < size - 1; k++) 
                        {
                            if (k < i)
                            {
                                subMatrix[j - 1, k] = matrix[j, k];
                            }
                            else if (k >= i) 
                            {
                                subMatrix[j - 1, k] = matrix[j, k + 1]; 
                            }
                        }
                    }
                    determinant += Math.Pow(-1, i) * matrix[0, i] * CalculateDeterminant(subMatrix);
                }
                return determinant;
            }
        }

        private void ADeterminantButton_Click(object sender, EventArgs e)
        {
            NullCells(AdataGV);
            if (AMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы A задан некоректно!"); return;
            }
            if (AMatrix.GetLength(0) == AMatrix.GetLength(1))
            {
                if (Convert.ToString(CalculateDeterminant(AMatrix)) == "∞"||double.IsNaN(CalculateDeterminant(AMatrix)))
                {
                    ShowError("Ошибка! Слишком большое число!");
                }
                else if (CalculateDeterminant(AMatrix) == double.NaN) 
                {
                    ShowError("Определитель матрицы A равен: 0");
                }
                else
                {
                    ShowError("Определитель матрицы A равен: " + CalculateDeterminant(AMatrix));
                }
            }
            else
            {
                ShowError("Ошибка! Невозможно найти определитель матрицы, так как количество строк не равно количеству столбцов!");
            }
            ClearResultMatrix();
        }

        private void BDeterminantButton_Click(object sender, EventArgs e)
        {
            NullCells(BdataGV);
            if (BMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы B задан некоректно!"); return;
            }
            if (BMatrix.GetLength(0) == BMatrix.GetLength(1))
            {
                if (Convert.ToString(CalculateDeterminant(BMatrix)) == "∞" || double.IsNaN(CalculateDeterminant(BMatrix)))
                {
                    ShowError("Ошибка! Слишком большое число!");
                }
                else if (CalculateDeterminant(BMatrix) == double.NaN)
                {
                    ShowError("Определитель матрицы B равен: 0");
                }
                
                else
                {
                    ShowError("Определитель матрицы B равен: " + CalculateDeterminant(AMatrix));
                }
            }
            else
            {
                ShowError("Ошибка! Невозможно найти определитель матрицы, так как количество строк не равно количеству столбцов!");
            }
            ClearResultMatrix();
        }

        double[,] Transpose(double[,] Matrix)
        {
            double[,] TransposeMatrix = new double[Matrix.GetLength(1), Matrix.GetLength(0)];
            for (int i = 0; i < TransposeMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < TransposeMatrix.GetLength(1); j++)
                {
                    TransposeMatrix[i, j] = Matrix[j, i];
                }
            }
            return TransposeMatrix;
        }
        private void ATransposeButton_Click(object sender, EventArgs e)
        {
            NullCells(AdataGV);
            if (AMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы A задан некоректно!"); return;
            }
            ResMatrix = Transpose(AMatrix);
            ShowMatrix(ResMatrix, ResultdataGV);
            //AColumnLastValueIs0 = false;
            //AColnumericUpDown.Value = AdataGV.ColumnCount;
            //ARowsnumericUpDown.Value = AdataGV.RowCount;
            //ClearResultMatrix();
        }

        private void BTransposeButton_Click(object sender, EventArgs e)
        {
            NullCells(BdataGV);
            if (BMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы B задан некоректно!"); return;
            }
            ResMatrix = Transpose(BMatrix);
            ShowMatrix(ResMatrix, ResultdataGV);
            //BColumnLastValueIs0 = false;
            //BColnumericUpDown.Value = BdataGV.ColumnCount;
            //BRowsnumericUpDown.Value = BdataGV.RowCount;
            //ClearResultMatrix();
        }
        double AlgComplement(double[,] Matrix, int RowNum, int ColNum)
        {
            double[,] Minor = new double[Matrix.GetLength(0) - 1, Matrix.GetLength(1) - 1];
            int m = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                if (i == RowNum) continue;

                int n = 0;
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (j == ColNum) continue;

                    Minor[m, n] = Matrix[i, j];
                    n++;
                }
                m++;
            }
            return Math.Pow((-1), RowNum + ColNum) * CalculateDeterminant(Minor);
        }
        double[,] ReverseMatrix(double[,] Matrix)
        {
            double Determinant = CalculateDeterminant(Matrix);
            double[,] TransposeMatrix = Transpose(Matrix);
            double[,] ReverseMatrix = new double[Matrix.GetLength(0), Matrix.GetLength(0)];
            if (Matrix.GetLength(0) != 1)
            {
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix.GetLength(0); j++)
                    {
                        ReverseMatrix[i, j] = AlgComplement(TransposeMatrix, i, j) / Determinant;
                    }
                }
            }
            else
            {
                ReverseMatrix[0, 0] = 1 / Determinant;
            }
            return ReverseMatrix;
        }

        private void AReverseButton_Click(object sender, EventArgs e)
        {
            NullCells(AdataGV);
            if (AMatrix.GetLength(0) == AMatrix.GetLength(1))
            {
                if (AMatrix.GetLength(0) == 0)
                {
                    ShowError("Ошибка! Размер матрицы A задан некоректно!"); return;
                }
                else if (CalculateDeterminant(AMatrix) == 0)
                {
                    ShowError("Ошибка! Невозможно найти обратную матрицу, так как определитель матрицы A равен 0!"); return;
                }
                ResMatrix = ReverseMatrix(AMatrix);
                ShowMatrix(ResMatrix, ResultdataGV);
                
            }
            else
            {
                ShowError("Ошибка! Невозможно найти обратную матрицу, так как количество строк не равно количеству столбцов!");
            }
            //ClearResultMatrix();
        }

        private void BReverseButton_Click(object sender, EventArgs e)
        {
            NullCells(BdataGV);
            if (BMatrix.GetLength(0) == BMatrix.GetLength(1))
            {
                if (BMatrix.GetLength(0) == 0)
                {
                    ShowError("Ошибка! Размер матрицы B задан некоректно!"); return;
                }
                else if (CalculateDeterminant(BMatrix) == 0)
                {
                    ShowError("Ошибка! Невозможно найти обратную матрицу, так как определитель матрицы B равен 0!"); return;
                }
                    ResMatrix = ReverseMatrix(BMatrix);
                    ShowMatrix(ResMatrix, ResultdataGV);
                
            }
            else
            {
                ShowError("Ошибка! Невозможно найти обратную матрицу, так как количество строк не равно количеству столбцов!");
            }
            //ClearResultMatrix();
        }

        private void AMultiplyByButton_Click(object sender, EventArgs e)
        {
            NullCells(AdataGV);
            if (AMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы A задан некоректно!"); return;
            }
            double value;
            if (double.TryParse(AMultiplyBytextBox.Text, out value))
            {
                ResMatrix = new double[AMatrix.GetLength(0), AMatrix.GetLength(1)];
                for (int i = 0; i < AMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < AMatrix.GetLength(1); j++)
                    {
                        ResMatrix[i, j] = AMatrix[i,j] *value;
                    }
                }
                ShowMatrix(ResMatrix, ResultdataGV);
            }
            else ShowError("Ошибка! Невозмонжо умножить матрицу на это число!");
            //ClearResultMatrix();
        }

        private void BMultiplyByButton_Click(object sender, EventArgs e)
        {
            NullCells(BdataGV);
            if (BMatrix.GetLength(0) == 0)
            {
                ShowError("Ошибка! Размер матрицы B задан некоректно!"); return;
            }
            double value;
            if (double.TryParse(BMultiplyBytextBox.Text, out value))
            {
                ResMatrix = new double[BMatrix.GetLength(0), BMatrix.GetLength(1)];
                for (int i = 0; i < BMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < BMatrix.GetLength(1); j++)
                    {
                        ResMatrix[i, j] = BMatrix[i, j] * value;
                    }
                }
                ShowMatrix(ResMatrix, ResultdataGV);
            }
            else ShowError("Ошибка! Невозмонжо умножить матрицу на это число!");
            //ClearResultMatrix();
        }

        private void ResToAbutton_Click(object sender, EventArgs e)
        {
            if (ResMatrix != null)
            {
                AMatrix = ResMatrix;
                ShowMatrix(AMatrix, AdataGV);
                AColumnLastValueIs0 = false;
                AColnumericUpDown.Value = AdataGV.ColumnCount;
                ARowsnumericUpDown.Value = AdataGV.RowCount;
            }
        }

        private void ResToBbutton_Click(object sender, EventArgs e)
        {
            if (ResMatrix != null)
            {
                BMatrix = ResMatrix;
                ShowMatrix(BMatrix, BdataGV);
                BColumnLastValueIs0 = false;
                BColnumericUpDown.Value = BdataGV.ColumnCount;
                BRowsnumericUpDown.Value = BdataGV.RowCount;
            }
        }
    }
}
