using System.Collections.Generic;

namespace EB_DZ_40
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.operationsTextBox = new System.Windows.Forms.RichTextBox();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.rootButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.operationsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Enabled = false;
            this.resultsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsTextBox.Location = new System.Drawing.Point(12, 46);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultsTextBox.Size = new System.Drawing.Size(229, 34);
            this.resultsTextBox.TabIndex = 0;
            this.resultsTextBox.Text = "";
            // 
            // operationsTextBox
            // 
            this.operationsTextBox.Enabled = false;
            this.operationsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsTextBox.Location = new System.Drawing.Point(12, 6);
            this.operationsTextBox.Name = "operationsTextBox";
            this.operationsTextBox.Size = new System.Drawing.Size(229, 34);
            this.operationsTextBox.TabIndex = 1;
            this.operationsTextBox.Text = "";
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenButton.Location = new System.Drawing.Point(12, 86);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(41, 39);
            this.sevenButton.TabIndex = 2;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightButton.Location = new System.Drawing.Point(59, 86);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(41, 39);
            this.eightButton.TabIndex = 3;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineButton.Location = new System.Drawing.Point(106, 86);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(41, 39);
            this.nineButton.TabIndex = 4;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionButton.Location = new System.Drawing.Point(153, 86);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(41, 39);
            this.divisionButton.TabIndex = 5;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourButton.Location = new System.Drawing.Point(12, 131);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(41, 39);
            this.fourButton.TabIndex = 7;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveButton.Location = new System.Drawing.Point(59, 131);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(41, 39);
            this.fiveButton.TabIndex = 8;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixButton.Location = new System.Drawing.Point(106, 131);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(41, 39);
            this.sixButton.TabIndex = 9;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplicationButton.Location = new System.Drawing.Point(153, 131);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(41, 39);
            this.multiplicationButton.TabIndex = 10;
            this.multiplicationButton.Text = "*";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // rootButton
            // 
            this.rootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rootButton.Location = new System.Drawing.Point(200, 131);
            this.rootButton.Name = "rootButton";
            this.rootButton.Size = new System.Drawing.Size(41, 39);
            this.rootButton.TabIndex = 11;
            this.rootButton.Text = "√";
            this.rootButton.UseVisualStyleBackColor = true;
            this.rootButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneButton.Location = new System.Drawing.Point(12, 176);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(41, 39);
            this.oneButton.TabIndex = 12;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoButton.Location = new System.Drawing.Point(59, 176);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(41, 39);
            this.twoButton.TabIndex = 13;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeButton.Location = new System.Drawing.Point(106, 176);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(41, 39);
            this.threeButton.TabIndex = 14;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtractionButton.Location = new System.Drawing.Point(153, 176);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(41, 39);
            this.subtractionButton.TabIndex = 15;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // percentButton
            // 
            this.percentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentButton.Location = new System.Drawing.Point(200, 176);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(41, 39);
            this.percentButton.TabIndex = 16;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = true;
            this.percentButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroButton.Location = new System.Drawing.Point(12, 221);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(41, 39);
            this.zeroButton.TabIndex = 17;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decimalButton.Location = new System.Drawing.Point(59, 221);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(41, 39);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ",";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(106, 221);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(41, 39);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // additionButton
            // 
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionButton.Location = new System.Drawing.Point(153, 221);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(41, 39);
            this.additionButton.TabIndex = 20;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultButton.Location = new System.Drawing.Point(200, 221);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(41, 39);
            this.resultButton.TabIndex = 21;
            this.resultButton.Text = "=";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerButton.Location = new System.Drawing.Point(200, 86);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(41, 39);
            this.powerButton.TabIndex = 23;
            this.powerButton.Text = "^";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // operationsListBox
            // 
            this.operationsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsListBox.FormattingEnabled = true;
            this.operationsListBox.ItemHeight = 15;
            this.operationsListBox.Location = new System.Drawing.Point(247, 6);
            this.operationsListBox.Name = "operationsListBox";
            this.operationsListBox.Size = new System.Drawing.Size(170, 244);
            this.operationsListBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 264);
            this.Controls.Add(this.operationsListBox);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.rootButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.operationsTextBox);
            this.Controls.Add(this.resultsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultsTextBox;
        private System.Windows.Forms.RichTextBox operationsTextBox;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button rootButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.ListBox operationsListBox;
        private List<Log> operationsList;
    }
}

