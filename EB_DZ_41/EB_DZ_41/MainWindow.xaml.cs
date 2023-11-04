using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.Json;
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EB_DZ_41
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int currentQuestion = 0;
        public Question[] questions;

        public MainWindow()
        {
            InitializeComponent();

            string json = File.ReadAllText("Questions.json");
            questions = JsonSerializer.Deserialize<Question[]>(json);
            this.MoneyBox1.Background = new SolidColorBrush(Colors.Orange);
            this.DataContext = questions[this.currentQuestion];
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button && sender is not null)
            {
                Button button = sender as Button;

                if (button.Content.ToString() == questions[this.currentQuestion].RightAnswer)
                {
                    if (currentQuestion + 1 >= questions.Length)
                    {
                        this.questions[this.currentQuestion].QuestionText = "Congratulations! You Won!";
                        this.questions[this.currentQuestion].Answer1 = "You Won!";
                        this.questions[this.currentQuestion].Answer2 = "You Won!";
                        this.questions[this.currentQuestion].Answer3 = "You Won!";
                        this.questions[this.currentQuestion].Answer4 = "You Won!";
                        this.DataContext = this.questions[this.currentQuestion];
                        this.MoneyBox15.Background = new SolidColorBrush(Colors.White);
                        return;
                    }
                    currentQuestion++;

                    switch (currentQuestion)
                    {
                        case 1:
                            this.MoneyBox1.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox2.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 2:
                            this.MoneyBox2.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox3.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 3:
                            this.MoneyBox3.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox4.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 4:
                            this.MoneyBox4.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox5.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 5:
                            this.MoneyBox5.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox6.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 6:
                            this.MoneyBox6.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox7.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 7:
                            this.MoneyBox7.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox8.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 8:
                            this.MoneyBox8.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox9.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 9:
                            this.MoneyBox9.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox10.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 10:
                            this.MoneyBox10.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox11.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 11:
                            this.MoneyBox11.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox12.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 12:
                            this.MoneyBox12.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox13.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 13:
                            this.MoneyBox13.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox14.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 14:
                            this.MoneyBox14.Background = new SolidColorBrush(Colors.White);
                            this.MoneyBox15.Background = new SolidColorBrush(Colors.Orange);
                            break;
                    }

                    this.DataContext = this.questions[this.currentQuestion];
                }
                else if (button.Content.ToString() == "You Lost!")
                {

                    string json = File.ReadAllText("Questions.json");
                    questions = JsonSerializer.Deserialize<Question[]>(json);
                    this.currentQuestion = 0;
                    this.DataContext = this.questions[this.currentQuestion];
                }
                else if (button.Content.ToString() == "You Won!")
                {

                    string json = File.ReadAllText("Questions.json");
                    questions = JsonSerializer.Deserialize<Question[]>(json);
                    this.currentQuestion = 0;
                    this.DataContext = this.questions[this.currentQuestion];
                }
                else
                {
                    this.questions[this.currentQuestion].QuestionText = "You Lost!\nPress any button to restart";
                    this.questions[this.currentQuestion].Answer1 = "You Lost!";
                    this.questions[this.currentQuestion].Answer2 = "You Lost!";
                    this.questions[this.currentQuestion].Answer3 = "You Lost!";
                    this.questions[this.currentQuestion].Answer4 = "You Lost!";
                    this.DataContext = this.questions[this.currentQuestion];
                }
            }
        }
    }

    public class Question: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public string questionText;
        public string QuestionText
        {
            get => questionText;
            set => this.PropertyChangeMethod(out questionText, value);
        }
        public string answer1;
        public string Answer1
        {
            get => answer1;
            set => this.PropertyChangeMethod(out answer1, value);
        }
        public string answer2;
        public string Answer2
        {
            get => answer2;
            set => this.PropertyChangeMethod(out answer2, value);
        }
        public string answer3;
        public string Answer3
        {
            get => answer3;
            set => this.PropertyChangeMethod(out answer3, value);
        }
        public string answer4;
        public string Answer4
        {
            get => answer4;
            set => this.PropertyChangeMethod(out answer4, value);
        }
        public string RightAnswer { get; set; }

        private void PropertyChangeMethod<T>(out T field, T value, [CallerMemberName] string propName = "")
        {
            field = value;

            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
            }
        }

        public Question(string questionText, string answer1, string answer2, string answer3, string answer4, string rightAnswer)
        {
            QuestionText = questionText;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
            RightAnswer = rightAnswer;
        }
    }
}
