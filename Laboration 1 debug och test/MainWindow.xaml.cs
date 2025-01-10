using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TodoList _todoList;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
     
        }

        private void UpdateTaskList()
        {

        }

        private void GetAllTasks()
        {
            throw new NotImplementedException();
        }

        private void RemoveButton_Click(Object sender, RoutedEventArgs e) 
        { 

        }
    }
}