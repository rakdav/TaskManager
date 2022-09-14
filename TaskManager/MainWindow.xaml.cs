using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaskManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Process[] process;
        private Timer timer;
        public MainWindow()
        {
            InitializeComponent();
            process =Process.GetProcesses();
            foreach(Process proc in process)
            {
                lbProcesses.Items.Add(proc.ProcessName);
            }
            timer= new Timer(3000);
            
        }

    }
}
