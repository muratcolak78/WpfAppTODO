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

namespace WpfAppTODO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            AlleListen.aktuellenDatei();
            AlleListen.Grid = todoList;
            todoList.ItemsSource = AlleListen.ToDoItems1;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            int id = AlleListen.TodolistIndex;
            
            AlleListen.ToDoItems1.RemoveAt(id - 1);
            AlleListen.aktuellenTODOList();
            MessageBox.Show("todo is deleted");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddToDoItem addWindow = new AddToDoItem();
            addWindow.Show();
           
            if (AlleListen.FensterAus)
            {
                AlleListen.aktullenGridData(todoList);

            }
           
        }

        private void todoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (todoList.SelectedItem is ToDoItems items)
            {
                AlleListen.TodolistIndex = items.Id;
                

            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            int id = AlleListen.TodolistIndex-1;
            ToDoItems items = AlleListen.ToDoItems1[id];
            AlleListen.ToDoItems1.RemoveAt(id);
            AlleListen.ToDoItems1.Insert(0, items);
            AlleListen.aktuellenTODOList();


        }
    }
}