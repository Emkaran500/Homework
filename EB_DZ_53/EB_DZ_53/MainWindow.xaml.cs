using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace EB_DZ_53
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class ProcessInfo
    {
        public string? Name { get; set; }
        public string? Memory { get; set; }
        public string? Disk { get; set; }

        public ProcessInfo(Process process) 
        {
            this.Name = process.ProcessName;
            this.Memory = ((double)process.PagedMemorySize64 / 1000000).ToString() + " mb";
            this.Disk = ((double)process.WorkingSet64 / 1000000).ToString() + " mb";
        }
    }

    public partial class MainWindow : Window
    {
        private Timer Timer { get; set; }
        public ObservableCollection<ProcessInfo> Processes { get; set; } = new ObservableCollection<ProcessInfo>();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            this.Timer = new Timer(callback: (list) =>
            {
                if (list is ObservableCollection<ProcessInfo> processList)
                {
                    Dispatcher.Invoke(() => this.Processes.Clear());

                    var processes = Process.GetProcesses();

                    foreach (var process in processes)
                    {
                        var processInfo = new ProcessInfo(process);

                        Dispatcher.Invoke(() => this.Processes.Add(processInfo));
                    }
                }
            }, this.Processes, 0, 2000);
        }
    }
}
