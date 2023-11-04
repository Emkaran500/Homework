using EB_DZ_44.Weapon.Decorators.Base;
using EB_DZ_44.Weapon.WeaponModels.Base;
using EB_DZ_44.Weapon.WeaponModels;
using System.Windows;
using EB_DZ_44.Weapon.Decorators;

namespace EB_DZ_44
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Gun Weapon { get; set; } = new OpticsDecorator(new Rifle());

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Weapon;
        }

        private void Silencer_Click(object sender, RoutedEventArgs e)
        {
            this.Weapon = new SilencerDecorator(this.Weapon);
            this.DataContext = Weapon;
        }
        
        private void Foregrip_Click(object sender, RoutedEventArgs e)
        {
            this.Weapon = new ForegripDecorator(this.Weapon);
            this.DataContext = Weapon;
        }
        
        private void Optics_Click(object sender, RoutedEventArgs e)
        {
            this.Weapon = new OpticsDecorator(this.Weapon);
            this.DataContext = Weapon;
        }
    }
}
