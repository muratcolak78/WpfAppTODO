using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Controls;

namespace WpfAppTODO;

public static class AlleListen
{

  

    static List<ToDoItems> ToDoItems = new List<ToDoItems>()
    {
        new ToDoItems(1,"Hausaufgabe", "SQL Aufgabe wird gemacht werden", new DateTime(2024,07,12)),
        new ToDoItems(2,"Bank", "Bankkarte ist kaput", new DateTime(2024,07,13)),
        new ToDoItems(3,"Schule", "Familie besprechung um 17:30 uhr", new DateTime(2024,07,14))
    };

    internal static List<ToDoItems> ToDoItems1 { get => ToDoItems; set => ToDoItems = value; }

    public static void aktuellenDatei()
    {
        if (!File.Exists("todolist.json"))
        {
            JSONHelper.saveAsJson<ToDoItems>(ToDoItems1, "todolist.json");
            
        }else
        {
            ToDoItems1 = JSONHelper.readFromJson<ToDoItems>("todolist.json");
        }
    }
    public static void aktullenGridData(DataGrid dataGrid)
    {
        dataGrid.ItemsSource = null;
        dataGrid.ItemsSource = AlleListen.ToDoItems1;
    }

};





