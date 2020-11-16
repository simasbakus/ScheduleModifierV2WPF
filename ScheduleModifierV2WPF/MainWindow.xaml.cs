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

namespace ScheduleModifierV2WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly DocHandler doc = new DocHandler();
        readonly List<Employee> data = new List<Employee>();
        public MainWindow()
        {
            InitializeComponent();
            data = doc.RunPythonToGetData();
            EmployeesComboBox.ItemsSource = data;
        }

        private void EmployeesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(data[EmployeesComboBox.SelectedIndex].Name);
        }
    }
}
