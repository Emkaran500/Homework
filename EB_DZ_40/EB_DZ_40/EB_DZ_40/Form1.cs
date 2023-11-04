using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace EB_DZ_40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string jsonPath = "C:\\Users\\PC\\Desktop\\Степит\\EB_DZ_40\\EB_DZ_40\\EB_DZ_40\\Operations.json";
            var json = File.ReadAllText(jsonPath);
            this.operationsList = JsonSerializer.Deserialize<List<Log>>(json);
            this.operationsListBox.Items.AddRange(operationsList.ToArray());
        }

        private void digitButton_Click(object sender, EventArgs e)
        {
            if (this.operationsTextBox.Text.IndexOf(this.resultButton.Text) != -1)
            {
                return;
            }

            if (sender is Button)
            {
                Button button = sender as Button;

                this.operationsTextBox.Text += button.Text;
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (this.operationsTextBox.Text.IndexOf(this.resultButton.Text) != -1)
            {
                return;
            }

            if (sender is Button)
            {
                Button button = sender as Button;
                int indexOfOperation = -1;

                if (double.TryParse(this.operationsTextBox.Text, out double result) == false)
                {
                    if (this.operationsTextBox.Text.IndexOf(this.additionButton.Text) != -1)
                    {
                        indexOfOperation = this.operationsTextBox.Text.IndexOf(this.additionButton.Text);
                    }
                    else if (this.operationsTextBox.Text.IndexOf(this.subtractionButton.Text) != -1)
                    {
                        indexOfOperation = this.operationsTextBox.Text.IndexOf(this.subtractionButton.Text);
                    }
                    else if (this.operationsTextBox.Text.IndexOf(this.multiplicationButton.Text) != -1)
                    {
                        indexOfOperation = this.operationsTextBox.Text.IndexOf(this.multiplicationButton.Text);
                    }
                    else if (this.operationsTextBox.Text.IndexOf(this.divisionButton.Text) != -1)
                    {
                        indexOfOperation = this.operationsTextBox.Text.IndexOf(this.divisionButton.Text);
                    }
                    else if (this.operationsTextBox.Text.IndexOf(this.powerButton.Text) != -1)
                    {
                        indexOfOperation = this.operationsTextBox.Text.IndexOf(this.powerButton.Text);
                    }
                    else if (this.operationsTextBox.Text.IndexOf(this.rootButton.Text) != -1)
                    {
                        indexOfOperation = this.operationsTextBox.Text.IndexOf(this.rootButton.Text);
                    }
                    else if (this.operationsTextBox.Text.IndexOf(this.percentButton.Text) != -1)
                    {
                        indexOfOperation = this.operationsTextBox.Text.IndexOf(this.percentButton.Text);
                    }
                    else
                    {
                        if (this.operationsTextBox.Text.Length != 0)
                        {
                            return;
                        }
                    }

                    if (this.operationsTextBox.Text.Substring(indexOfOperation + 1, this.operationsTextBox.Text.Length - (indexOfOperation + 1)).Contains(button.Text))
                    {
                        return;
                    }
                    else
                    {
                        if (this.operationsTextBox.Text.Substring(indexOfOperation + 1, this.operationsTextBox.Text.Length - (indexOfOperation + 1)).Length == 0)
                        {
                            this.operationsTextBox.Text += this.zeroButton.Text + button.Text;
                        }
                        else
                        {
                            this.operationsTextBox.Text += button.Text;
                        }
                    }
                }

                if (button.Text != this.decimalButton.Text || this.operationsTextBox.Text.Contains(this.decimalButton.Text))
                {
                    return;
                }
                else
                {
                    if (this.operationsTextBox.Text.Length == 0)
                    {
                        this.operationsTextBox.Text += this.zeroButton.Text + button.Text;
                    }
                    else
                    {
                        this.operationsTextBox.Text += button.Text;
                    }
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.operationsTextBox.Text = "";
            this.resultsTextBox.Text = "";
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            if (this.operationsTextBox.Text.Length == 0 || this.operationsTextBox.Text[this.operationsTextBox.Text.Length - 1].Equals(this.decimalButton.Text))
            {
                return;
            }
            if ((this.operationsTextBox.Text.IndexOf(this.additionButton.Text) < this.operationsTextBox.Text.Length - 1 && this.operationsTextBox.Text.IndexOf(this.additionButton.Text) != -1) || (this.operationsTextBox.Text.IndexOf(this.subtractionButton.Text) < this.operationsTextBox.Text.Length - 1 && this.operationsTextBox.Text.IndexOf(this.subtractionButton.Text) != -1) || (this.operationsTextBox.Text.IndexOf(this.multiplicationButton.Text) < this.operationsTextBox.Text.Length - 1 && this.operationsTextBox.Text.IndexOf(this.multiplicationButton.Text) != -1) || (this.operationsTextBox.Text.IndexOf(this.divisionButton.Text) < this.operationsTextBox.Text.Length - 1 && this.operationsTextBox.Text.IndexOf(this.divisionButton.Text) != -1) || (this.operationsTextBox.Text.IndexOf(this.powerButton.Text) < this.operationsTextBox.Text.Length - 1 && this.operationsTextBox.Text.IndexOf(this.powerButton.Text) != -1) || (this.operationsTextBox.Text.IndexOf(this.rootButton.Text) < this.operationsTextBox.Text.Length - 1 && this.operationsTextBox.Text.IndexOf(this.rootButton.Text) != -1) || (this.operationsTextBox.Text.IndexOf(this.percentButton.Text) < this.operationsTextBox.Text.Length - 1 && this.operationsTextBox.Text.IndexOf(this.percentButton.Text) != -1))
            {
                return;
            }
            if (this.operationsTextBox.Text.IndexOf(this.resultButton.Text) != -1)
            {
                return;
            }

            if (sender is Button)
            {
                Button button = sender as Button;

                if (this.operationsTextBox.Text[this.operationsTextBox.Text.Length - 1].Equals(this.additionButton.Text[0]) || this.operationsTextBox.Text[this.operationsTextBox.Text.Length - 1].Equals(this.subtractionButton.Text[0]) || this.operationsTextBox.Text[this.operationsTextBox.Text.Length - 1].Equals(this.multiplicationButton.Text[0]) || this.operationsTextBox.Text[this.operationsTextBox.Text.Length - 1].Equals(this.divisionButton.Text[0]) || this.operationsTextBox.Text[this.operationsTextBox.Text.Length - 1].Equals(this.powerButton.Text[0]) || this.operationsTextBox.Text[this.operationsTextBox.Text.Length - 1].Equals(this.rootButton.Text[0]) || this.operationsTextBox.Text[this.operationsTextBox.Text.Length - 1].Equals(this.percentButton.Text[0]))
                {
                    this.operationsTextBox.Text = this.operationsTextBox.Text.Substring(0, this.operationsTextBox.Text.Length - 1) + button.Text;
                }
                else
                {
                    this.operationsTextBox.Text += button.Text;
                }
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            if (this.operationsTextBox.Text.Length == 0)
            {
                return;
            }

            if (sender is Button)
            {
                string operation;
                int indexOfOperation;
                double num1;
                double num2;
                double result;
    
                Button button = sender as Button;

                if (this.operationsTextBox.Text.IndexOf(button.Text[0]) != -1)
                {
                    return;
                }
                if (this.operationsTextBox.Text.IndexOf(this.additionButton.Text) == this.operationsTextBox.Text.Length - 1 || this.operationsTextBox.Text.IndexOf(this.subtractionButton.Text) == this.operationsTextBox.Text.Length - 1 || this.operationsTextBox.Text.IndexOf(this.multiplicationButton.Text) == this.operationsTextBox.Text.Length - 1 || this.operationsTextBox.Text.IndexOf(this.divisionButton.Text) == this.operationsTextBox.Text.Length - 1 || this.operationsTextBox.Text.IndexOf(this.powerButton.Text) == this.operationsTextBox.Text.Length - 1 || this.operationsTextBox.Text.IndexOf(this.rootButton.Text) == this.operationsTextBox.Text.Length - 1 || this.operationsTextBox.Text.IndexOf(this.percentButton.Text) == this.operationsTextBox.Text.Length - 1)
                {
                    return;
                }

                if (this.operationsTextBox.Text.IndexOf(this.additionButton.Text) != -1)
                {
                    indexOfOperation = this.operationsTextBox.Text.IndexOf(this.additionButton.Text);
                    operation = this.additionButton.Text;
                }
                else if (this.operationsTextBox.Text.IndexOf(this.subtractionButton.Text) != -1)
                {
                    indexOfOperation = this.operationsTextBox.Text.IndexOf(this.subtractionButton.Text);
                    operation = this.subtractionButton.Text;
                }
                else if (this.operationsTextBox.Text.IndexOf(this.multiplicationButton.Text) != -1)
                {
                    indexOfOperation = this.operationsTextBox.Text.IndexOf(this.multiplicationButton.Text);
                    operation = this.multiplicationButton.Text;
                }
                else if (this.operationsTextBox.Text.IndexOf(this.divisionButton.Text) != -1)
                {
                    indexOfOperation = this.operationsTextBox.Text.IndexOf(this.divisionButton.Text);
                    operation = this.divisionButton.Text;
                }
                else if (this.operationsTextBox.Text.IndexOf(this.powerButton.Text) != -1)
                {
                    indexOfOperation = this.operationsTextBox.Text.IndexOf(this.powerButton.Text);
                    operation = this.powerButton.Text;
                }
                else if (this.operationsTextBox.Text.IndexOf(this.rootButton.Text) != -1)
                {
                    indexOfOperation = this.operationsTextBox.Text.IndexOf(this.rootButton.Text);
                    operation = this.rootButton.Text;
                }
                else if (this.operationsTextBox.Text.IndexOf(this.percentButton.Text) != -1)
                {
                    indexOfOperation = this.operationsTextBox.Text.IndexOf(this.percentButton.Text);
                    operation = this.percentButton.Text;
                }
                else
                {
                    this.resultsTextBox.Text += operationsTextBox.Text;
                    this.operationsTextBox.Text += button.Text;
                    return;
                }

                num1 = double.Parse(this.operationsTextBox.Text.Substring(0, indexOfOperation));
                num2 = double.Parse(this.operationsTextBox.Text.Substring(indexOfOperation + 1, this.operationsTextBox.Text.Length - (indexOfOperation + 1)));

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    case "^":
                        {
                            result = num1;
                            for (int i = 1; i < num2; i++)
                            {
                                result *= num1;
                            }
                            break;
                        }
                    case "√":
                        result = Math.Pow(num1, 1 / num2);
                        break;
                    case "%":
                        result = (num1 / 100) * num2;
                        break;
                    default:
                        result = -1;
                        break;
                }

                Log log = new Log(firstNum: num1.ToString(), secondNum: num2.ToString(), resultNum: result.ToString(), operation: operation);
                this.operationsList.Add(log);
                string jsonPath = "C:\\Users\\PC\\Desktop\\Степит\\EB_DZ_40\\EB_DZ_40\\EB_DZ_40\\Operations.json";
                string newJson = JsonSerializer.Serialize(operationsList);
                File.WriteAllText(jsonPath, newJson);

                this.operationsListBox.Items.Clear();
                this.operationsListBox.Items.AddRange(this.operationsList.ToArray());
                this.resultsTextBox.Text = result.ToString();
            }
        }
    }
    public class Log
    {
        public string FirstNum { get; set; }
        public string SecondNum { get; set; }
        public string ResultNum { get; set; }
        public string Operation { get; set; }

        public Log(string firstNum, string secondNum, string resultNum, string operation)
        {
            this.FirstNum = firstNum;
            this.SecondNum = secondNum;
            this.ResultNum = resultNum;
            this.Operation = operation;
        }

        public Log() { }

        public override string ToString() => $"{this.FirstNum} {this.Operation} {this.SecondNum} = {ResultNum}";
    }
}
