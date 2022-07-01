using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class FormPerceptron : Form
    {
        private Color[,] _backgroundColors;
        private int[,] _tableInputs;
        private int[,] _inputs;
        private double[] _weights;
        private double[] _weights1;
        private double[] _weights2;
        private double[] _weights3;
        private double[] _weights4;
        private double[] _weights5;
        private int[] _desiredOutputs;
        private int[] _desiredOutputs1;
        private int[] _desiredOutputs2;
        private int[] _desiredOutputs3;
        private int[] _desiredOutputs4;
        private int[] _desiredOutputs5;
        private int _totalRows;
        private int _totalColumns;
        private int _totalLetters;
        private int _totalInputs;
        private double _learningRate;
        private int _maxEpoch;
        private String _letters;

        public FormPerceptron()
        {
            InitializeComponent();
            _totalLetters = 26;
            _learningRate = 0.1;
            _maxEpoch = 100;
            _letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            _totalRows = tableLayoutPanel.RowCount;
            _totalColumns = tableLayoutPanel.ColumnCount;
            _totalInputs = _totalRows * _totalColumns;
            _inputs = new int[_totalLetters, _totalInputs + 1]; // add bias
            _tableInputs = new int[_totalRows, _totalColumns];
            _backgroundColors = new Color[_totalRows, _totalColumns];
            _desiredOutputs = new int[_totalLetters];
            _desiredOutputs1 = new int[_totalLetters];
            _desiredOutputs2 = new int[_totalLetters];
            _desiredOutputs3 = new int[_totalLetters];
            _desiredOutputs4 = new int[_totalLetters];
            _desiredOutputs5 = new int[_totalLetters];
            _weights = new double[_totalInputs + 1]; // add bias
            _weights1 = new double[_totalInputs + 1]; // add bias
            _weights2 = new double[_totalInputs + 1]; // add bias
            _weights3 = new double[_totalInputs + 1]; // add bias
            _weights4 = new double[_totalInputs + 1]; // add bias
            _weights5 = new double[_totalInputs + 1]; // add bias

            ClearTableLayoutPanel();
            LoadLetters();
            LoadDesiredOutputCharacters();
            LoadWeights();
        }

        private void TableLayoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            int row = 0;
            int verticalOffset = 0;
            foreach (int h in tableLayoutPanel.GetRowHeights())
            {
                int column = 0;
                int horizontalOffset = 0;
                foreach (int w in tableLayoutPanel.GetColumnWidths())
                {
                    Rectangle rectangle = new Rectangle(horizontalOffset, verticalOffset, w, h);
                    if (rectangle.Contains(e.Location))
                    {
                        if (_tableInputs[row, column] == 0)
                        {
                            _tableInputs[row, column] = 1;
                            _backgroundColors[row, column] = Color.Black;
                        }
                        else
                        {
                            _tableInputs[row, column] = 0;
                            _backgroundColors[row, column] = Color.White;
                        }
                        tableLayoutPanel.Invalidate();
                        tableLayoutPanel.Update();
                        tableLayoutPanel.Refresh();
                        return;
                    }
                    horizontalOffset += w;
                    column++;
                }
                verticalOffset += h;
                row++;
            }
        }

        private void TableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var solidBrush = new SolidBrush(_backgroundColors[e.Row, e.Column]))
            {
                e.Graphics.FillRectangle(solidBrush, e.CellBounds);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = "";
            cboBoxLetters.SelectedIndex = -1;
            ClearTableLayoutPanel();
            tableLayoutPanel.Invalidate();
            tableLayoutPanel.Update();
            tableLayoutPanel.Refresh();
        }

        private void CboBoxLetters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            int index = cboBoxLetters.SelectedIndex;
            if (index >= 0)
            {
                for (int row = 0; row < _totalRows; row++)
                {
                    for (int column = 0; column < _totalColumns; column++)
                    {
                        if (_inputs[index, count] == 1)
                        {
                            _backgroundColors[row, column] = Color.Black;
                        }
                        else
                        {
                            _backgroundColors[row, column] = Color.White;
                        }
                        _tableInputs[row, column] = _inputs[index, count];
                        count++;
                    }
                }
                tableLayoutPanel.Invalidate();
                tableLayoutPanel.Update();
                tableLayoutPanel.Refresh();
            }
        }

        private void BtnTrain_Click(object sender, EventArgs e)
        {
            if (radioBtnCharacterType.Checked)
            {
                Train(0);
            }
            else if (radioBtnCharacter.Checked)
            {
                Train(1);
                Train(2);
                Train(3);
                Train(4);
                Train(5);
            }
        }

        private void Train(int counter)
        {
            int epoch = 0;
            int totalError = 0;
            do
            {
                totalError = 0;
                for (int i = 0; i < _totalLetters; i++)
                {
                    int output = 0;
                    int error = 0;

                    switch (counter)
                    {
                        case 0:
                            output = CalculateOutput(_weights, i);
                            error = _desiredOutputs[i] - output;
                            break;
                        case 1:
                            output = CalculateOutput(_weights1, i);
                            error = _desiredOutputs1[i] - output;
                            break;
                        case 2:
                            output = CalculateOutput(_weights2, i);
                            error = _desiredOutputs2[i] - output;
                            break;
                        case 3:
                            output = CalculateOutput(_weights3, i);
                            error = _desiredOutputs3[i] - output;
                            break;
                        case 4:
                            output = CalculateOutput(_weights4, i);
                            error = _desiredOutputs4[i] - output;
                            break;
                        case 5:
                            output = CalculateOutput(_weights5, i);
                            error = _desiredOutputs5[i] - output;
                            break;
                    }

                    for (int j = 0; j < _weights.Length; j++)
                    {
                        switch (counter)
                        {
                            case 0:
                                _weights[j] += _learningRate * error * _inputs[i, j];
                                break;
                            case 1:
                                _weights1[j] += _learningRate * error * _inputs[i, j];
                                break;
                            case 2:
                                _weights2[j] += _learningRate * error * _inputs[i, j];
                                break;
                            case 3:
                                _weights3[j] += _learningRate * error * _inputs[i, j];
                                break;
                            case 4:
                                _weights4[j] += _learningRate * error * _inputs[i, j];
                                break;
                            case 5:
                                _weights5[j] += _learningRate * error * _inputs[i, j];
                                break;
                        }
                    }

                    totalError += Math.Abs(error);
                }
            } while (totalError > 0 && epoch++ < _maxEpoch);
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (radioBtnCharacterType.Checked)
            {
                if (GetResult(_weights) == 0)
                {
                    txtBoxResult.Text = "Vowel";
                }
                else
                {
                    txtBoxResult.Text = "Consonant";
                }
            }
            else if (radioBtnCharacter.Checked)
            {
                int index = GetCharacterIndex();
                if (index >= 0 && index < _totalLetters)
                {
                    txtBoxResult.Text = _letters[index].ToString();
                }
                else
                {
                    txtBoxResult.Text = "Unknown";
                }
            }
        }

        private int GetResult(double[] weights)
        {
            double result = 0;
            int count = 0;
            for (int row = 0; row < _totalRows; row++)
            {
                for (int column = 0; column < _totalColumns; column++)
                {
                    result += _tableInputs[row, column] * weights[count++];
                }
            }
            result += 1 * weights[count]; // add bias
            return (result >= 0) ? 1 : 0;
        }

        private int GetCharacterIndex()
        {
            String binary = "";
            binary += GetResult(_weights1);
            binary += GetResult(_weights2);
            binary += GetResult(_weights3);
            binary += GetResult(_weights4);
            binary += GetResult(_weights5);
            return Convert.ToInt32(binary, 2);
        }

        private void LoadLetters()
        {
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "//letters.txt");
            int countRow = 0;
            int countInput = 0;
            int countLetter = 0;
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                if (countRow < _totalRows)
                {
                    char[] charArray = line.ToCharArray();
                    foreach (char ch in charArray)
                    {
                        _inputs[countLetter, countInput++] = Int32.Parse(ch.ToString());
                    }
                    countRow++;
                }
                else
                {
                    _inputs[countLetter, countInput++] = 1;
                    int desiredOutput = Int32.Parse(line);
                    _desiredOutputs[countLetter++] = desiredOutput;
                    countInput = 0;
                    countRow = 0;
                }
            }
            sr.Close();
        }

        private int CalculateOutput(double[] weights, int counter)
        {
            double output = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                output += _inputs[counter, i] * weights[i];
            }
            return (output >= 0) ? 1 : 0;
        }

        private void ClearTableLayoutPanel()
        {
            for (int row = 0; row < _totalRows; row++)
            {
                for (int column = 0; column < _totalColumns; column++)
                {
                    _tableInputs[row, column] = 0;
                    _backgroundColors[row, column] = Color.White;
                }
            }
        }

        private void LoadWeights()
        {
            Random random = new Random();
            for (int i = 0; i < _weights.Length; i++)
            {
                _weights[i] = random.NextDouble();
                _weights1[i] = random.NextDouble();
                _weights2[i] = random.NextDouble();
                _weights3[i] = random.NextDouble();
                _weights4[i] = random.NextDouble();
                _weights5[i] = random.NextDouble();
            }
        }

        private void LoadDesiredOutputCharacters()
        {
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "//desiredOutputCharacters.txt");
            string line = null;
            int count = 0;
            while ((line = sr.ReadLine()) != null)
            {
                char[] charArray = line.ToCharArray();
                _desiredOutputs1[count] = Int32.Parse(charArray[0].ToString());
                _desiredOutputs2[count] = Int32.Parse(charArray[1].ToString());
                _desiredOutputs3[count] = Int32.Parse(charArray[2].ToString());
                _desiredOutputs4[count] = Int32.Parse(charArray[3].ToString());
                _desiredOutputs5[count] = Int32.Parse(charArray[4].ToString());
                count++;
            }
            sr.Close();
        }

        private void RadioBtnCharacterType_Click(object sender, EventArgs e)
        {
            radioBtnCharacterType.Checked = true;
            radioBtnCharacter.Checked = false;
        }

        private void RadioBtnCharacter_Click(object sender, EventArgs e)
        {
            radioBtnCharacterType.Checked = false;
            radioBtnCharacter.Checked = true;
        }
    }
}
