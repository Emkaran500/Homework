namespace EB_DZ_39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LetterButton_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                this.richTextBox.Text += button.Text;
            }
        }

        private void capsButton_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                if (button.Text == "caps lock")
                {
                    this.cButton.Text = this.cButton.Text.ToUpper();
                    this.vButton.Text = this.vButton.Text.ToUpper();
                    this.bButton.Text = this.bButton.Text.ToUpper();
                    this.nButton.Text = this.nButton.Text.ToUpper();
                    this.mButton.Text = this.mButton.Text.ToUpper();
                    this.xButton.Text = this.xButton.Text.ToUpper();
                    this.zButton.Text = this.zButton.Text.ToUpper();
                    this.capsButton1.Text = this.capsButton1.Text.ToUpper();
                    this.capsButton2.Text = this.capsButton2.Text.ToUpper();
                    this.sButton.Text = this.sButton.Text.ToUpper();
                    this.dButton.Text = this.dButton.Text.ToUpper();
                    this.fButton.Text = this.fButton.Text.ToUpper();
                    this.gButton.Text = this.gButton.Text.ToUpper();
                    this.hButton.Text = this.hButton.Text.ToUpper();
                    this.jButton.Text = this.jButton.Text.ToUpper();
                    this.kButton.Text = this.kButton.Text.ToUpper();
                    this.lButton.Text = this.lButton.Text.ToUpper();
                    this.hatchButton.Text = this.hatchButton.Text.ToUpper();
                    this.aButton.Text = this.aButton.Text.ToUpper();
                    this.enterButton.Text = this.enterButton.Text.ToUpper();
                    this.qButton.Text = this.qButton.Text.ToUpper();
                    this.wButton.Text = this.wButton.Text.ToUpper();
                    this.eButton.Text = this.eButton.Text.ToUpper();
                    this.rButton.Text = this.rButton.Text.ToUpper();
                    this.tButton.Text = this.tButton.Text.ToUpper();
                    this.yButton.Text = this.yButton.Text.ToUpper();
                    this.uButton.Text = this.uButton.Text.ToUpper();
                    this.iButton.Text = this.iButton.Text.ToUpper();
                    this.oButton.Text = this.oButton.Text.ToUpper();
                    this.pButton.Text = this.pButton.Text.ToUpper();
                }
                else if (button.Text == "CAPS LOCK")
                {
                    this.cButton.Text = this.cButton.Text.ToLower();
                    this.vButton.Text = this.vButton.Text.ToLower();
                    this.bButton.Text = this.bButton.Text.ToLower();
                    this.nButton.Text = this.nButton.Text.ToLower();
                    this.mButton.Text = this.mButton.Text.ToLower();
                    this.xButton.Text = this.xButton.Text.ToLower();
                    this.zButton.Text = this.zButton.Text.ToLower();
                    this.capsButton1.Text = this.capsButton1.Text.ToLower();
                    this.capsButton2.Text = this.capsButton2.Text.ToLower();
                    this.sButton.Text = this.sButton.Text.ToLower();
                    this.dButton.Text = this.dButton.Text.ToLower();
                    this.fButton.Text = this.fButton.Text.ToLower();
                    this.gButton.Text = this.gButton.Text.ToLower();
                    this.hButton.Text = this.hButton.Text.ToLower();
                    this.jButton.Text = this.jButton.Text.ToLower();
                    this.kButton.Text = this.kButton.Text.ToLower();
                    this.lButton.Text = this.lButton.Text.ToLower();
                    this.hatchButton.Text = this.hatchButton.Text.ToLower();
                    this.aButton.Text = this.aButton.Text.ToLower();
                    this.enterButton.Text = this.enterButton.Text.ToLower();
                    this.qButton.Text = this.qButton.Text.ToLower();
                    this.wButton.Text = this.wButton.Text.ToLower();
                    this.eButton.Text = this.eButton.Text.ToLower();
                    this.rButton.Text = this.rButton.Text.ToLower();
                    this.tButton.Text = this.tButton.Text.ToLower();
                    this.yButton.Text = this.yButton.Text.ToLower();
                    this.uButton.Text = this.uButton.Text.ToLower();
                    this.iButton.Text = this.iButton.Text.ToLower();
                    this.oButton.Text = this.oButton.Text.ToLower();
                    this.pButton.Text = this.pButton.Text.ToLower();
                }
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                this.richTextBox.Text += "\n";
            }
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (this.richTextBox.Text.Length == 0)
                return;

            this.richTextBox.Text = this.richTextBox.Text.Substring(0, this.richTextBox.Text.Length - 1);
        }
    }
}