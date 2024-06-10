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
using System.Windows.Shapes;

namespace WpfAppTODO
{
    /// <summary>
    /// Interaktionslogik für AddToDoItem.xaml
    /// </summary>
    public partial class AddToDoItem : Window
    {
        public AddToDoItem()
        {
            InitializeComponent();
            //todoList.ItemsSource = AlleListen.ToDoItems1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtbxSubject.Text != "")
            {
                if (txtbxDescription.Text != "")
                {
                    if (date.SelectedDate.HasValue)
                    {
                        int id = AlleListen.ToDoItems1.Count() + 1;
                        DateTime date2 = date.SelectedDate ?? DateTime.Today;
                        AlleListen.ToDoItems1.Add( new ToDoItems(id, txtbxSubject.Text, txtbxDescription.Text, date.SelectedDate.Value));
                        AlleListen.aktuellenTODOList();
                        MessageBox.Show("Added to be done");
                        
                        this.Close();
                        
                    }
                    else MessageBox.Show("Date cannot be empty");

                }else MessageBox.Show("Description cannot be empty");

            }
            else MessageBox.Show("Subject cannot be empty");
        }

       
    }
}
