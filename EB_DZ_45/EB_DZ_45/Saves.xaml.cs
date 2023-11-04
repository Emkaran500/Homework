using EB_DZ_45.ProfileData;
using EB_DZ_45.ProfileData.Mementos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace EB_DZ_45
{
    /// <summary>
    /// Логика взаимодействия для Saves.xaml
    /// </summary>
    public partial class Saves : Window
    {
        private ListBoxItem selectedListBoxItem;
        private Profile Profile { get; set; } = Profile.Instance;
        private MementoCaretaker Caretaker { get; set; } = MementoCaretaker.Instance;

        public Saves()
        {
            InitializeComponent();
            this.DataContext = this.Caretaker;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Application.Current.MainWindow.IsEnabled = true;
            Application.Current.MainWindow.Activate();
        }

        private void ChangeProfile_Click(object sender, RoutedEventArgs e)
        {
            if (this.selectedListBoxItem != null)
            {
                int mementoIndex = this.ProfilesListBox.ItemContainerGenerator.IndexFromContainer(this.selectedListBoxItem);
                this.Caretaker.Load(mementoIndex);
            }
        }

        private void ProfilesList_GotFocus(object sender, RoutedEventArgs e)
        {
            object selectedItem = this.ProfilesListBox.SelectedItem;
            this.selectedListBoxItem = (ListBoxItem)this.ProfilesListBox.ItemContainerGenerator.ContainerFromItem(selectedItem);
        }

        private void ProfilesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ListBox)
            {
                ListBox listBox = sender as ListBox;
                object selectedItem = this.ProfilesListBox.SelectedItem;
                this.selectedListBoxItem = (ListBoxItem)this.ProfilesListBox.ItemContainerGenerator.ContainerFromItem(selectedItem);
            }
        }
    }
}
