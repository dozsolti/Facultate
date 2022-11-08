using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager_Console
{
    class Program
    {
        static List<Task> DataBase = new List<Task>();
        static void Main(string[] args)
        {
            Task task1 = new Task(1, new DateTime(2019, 05, 24, 19, 00, 00), "Hotel Caro", "Spectacol", new List<string>() { "costum", "pantofi" }, "0", "1 h");
            Task task2 = new Task(2, new DateTime(2009, 05, 24, 19, 00, 00), "Hotel Mexico", "Spectacol", new List<string>() { "costum", "pantofi" }, "0", "1 h");
            //Console.WriteLine(task1);
            DataBase.Add(task1);
            DataBase.Add(task2);
            PrintDB();
            //PrintTask(1);
            //EditTask(1, new Task(1, new DateTime(2019, 05, 24, 19, 00, 00), "Hotel California", "Spectacol", new List<string>() { "costum", "pantofi" }, "0", "1 h"));
            //PrintTask(1);
            DeleteTask(2);
            PrintDB();
            Console.ReadKey();
        }

        static void PrintDB()
        {
            foreach (Task task in DataBase)
            {
                Console.WriteLine(task);
            }
        }

        static void PrintTask(int taskID)
        {
            Task task = DataBase.Find(t =>
            {
                if (t.ID == taskID)
                    return true;
                else
                    return false;
            });

            if(task!=null)
                Console.WriteLine(task);
            else
                Console.WriteLine("Task not found");
        }

        static void EditTask(int taskID, Task newTask)
        {
            int i = DataBase.FindIndex(t =>
            {
                if (t.ID == taskID)
                    return true;
                else
                    return false;
            });

            if (i != -1)
            {
                DataBase[i] = newTask;
            }
            else
                Console.WriteLine("Task not found");
        }

        static void DeleteTask(int taskID)
        {
            Task task = DataBase.Find(t =>
            {
                if (t.ID == taskID)
                    return true;
                else
                    return false;
            });

            if (task != null)
            {
                DataBase.Remove(task);
            }
            else
                Console.WriteLine("Task not found");

        }


    }
}
