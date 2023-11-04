using EB_DZ_45.ProfileData;
using EB_DZ_45.ProfileData.Mementos;
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

namespace EB_DZ_45
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Profile Profile { get; set; } = Profile.Instance;
        public MementoCaretaker Caretaker { get; set; } = MementoCaretaker.Instance;
        private Saves saveWindow;

        public MainWindow()
        {
            InitializeComponent();
            this.NameTextBox.DataContext = this.Profile;
            this.SurnameTextBox.DataContext = this.Profile;
            this.DescriptionTextBox.DataContext = this.Profile;
            this.AvatarImage.DataContext = this.Profile;

            if (this.Caretaker.Mementos.Count == 0)
            {
                this.LoadMementoButton.IsEnabled = false;
                this.LeftMementoButton.IsEnabled = false;
                this.RightMementoButton.IsEnabled = false;
            }
        }

        private void OpenSaves_Click(object sender, RoutedEventArgs e)
        {
            this.saveWindow = new Saves();
            Application.Current.MainWindow.IsEnabled = false;
            this.saveWindow.ShowInTaskbar = false;
            this.saveWindow.Owner = Application.Current.MainWindow;
            this.saveWindow.Show();
        }

        private void SaveProfile_Click(object sender, RoutedEventArgs e)
        {
            this.Caretaker.Save();

            if (this.Caretaker.Mementos.Count > 1)
            {
                this.LeftMementoButton.IsEnabled = true;
                this.RightMementoButton.IsEnabled = false;
                this.LoadMementoButton.IsEnabled = true;
            }
        }

        private void RandomizeAvatar_Click(object sender, RoutedEventArgs e)
        {
            int rand = Random.Shared.Next(0, 3);

            switch (rand)
            {
                case 0:
                    this.Profile.Avatar = new BitmapImage(new Uri("https://cdn.pixabay.com/photo/2014/11/30/14/11/cat-551554_640.jpg"));
                    break;
                case 1:
                    this.Profile.Avatar = new BitmapImage(new Uri("https://images.pexels.com/photos/1170986/pexels-photo-1170986.jpeg?cs=srgb&dl=pexels-evg-kowalievska-1170986.jpg&fm=jpg"));
                    break;
                case 2:
                    this.Profile.Avatar = new BitmapImage(new Uri("https://images.unsplash.com/photo-1608848461950-0fe51dfc41cb?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxleHBsb3JlLWZlZWR8Mnx8fGVufDB8fHx8fA%3D%3D&w=1000&q=80"));
                    break;
            }
        }

        private void MementoSwitch_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;

                if (button.Name == nameof(LeftMementoButton))
                {
                    this.Caretaker.Load(this.Caretaker.currentMemento - 1);

                    if (this.Caretaker.currentMemento <= 0)
                    {
                        this.LeftMementoButton.IsEnabled = false;
                    }
                    this.RightMementoButton.IsEnabled = true;
                }
                else if (button.Name == nameof(RightMementoButton))
                {
                    this.Caretaker.Load(this.Caretaker.currentMemento + 1);

                    if (this.Caretaker.currentMemento >= this.Caretaker.Mementos.Count - 1)
                    {
                        this.RightMementoButton.IsEnabled = false;
                    }
                    this.LeftMementoButton.IsEnabled = true;
                }
            }
        }
    }
}
