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

    static int todolistIndex ;
    static DataGrid grid = null;
    static bool fensterAus = false;

    static List<ToDoItems> ToDoItems = new List<ToDoItems>()
    {
        new ToDoItems(1,"Hausaufgabe", "SQL Aufgabe wird gemacht werden", new DateTime(2024,07,12)),
        new ToDoItems(2,"Bank", "Bankkarte ist kaput", new DateTime(2024,07,13)),
        new ToDoItems(3,"Schule", "Familie besprechung um 17:30 uhr", new DateTime(2024,07,14))
    };

    internal static List<ToDoItems> ToDoItems1 { get => ToDoItems; set => ToDoItems = value; }
    public static bool FensterAus { get => fensterAus; set => fensterAus = value; }
    public static DataGrid Grid { get => grid; set => grid = value; }
    public static int TodolistIndex { get => todolistIndex; set => todolistIndex = value; }

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
    public static void aktuellenTODOList()
    {
        setListIndex();
        JSONHelper.saveAsJson<ToDoItems>(ToDoItems1, "todolist.json");
        AlleListen.aktuellenDatei();
        AlleListen.Grid.ItemsSource = null;
        AlleListen.Grid.ItemsSource = AlleListen.ToDoItems1;

    }
    private static void setListIndex()
    {
        for (int i = 0;i<ToDoItems1.Count;i++)
        {
            ToDoItems1[i].Id = i+1;
        }
    }

};





