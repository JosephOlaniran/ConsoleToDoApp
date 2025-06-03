using ConsoleToDoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoApp
{
    internal class Program
    {
        static List<TodoItem> tasks = new List<TodoItem>();

        static void Main(string[] args)
        {
            Menu();


        }

        static void Menu()
        {
            Console.WriteLine("Console To-Do App");
            Console.WriteLine("What would you like to do first?");
            Console.WriteLine();
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task as Completed");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Choose an option: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.Clear();
                    AddTasks();
                    break;
                case 2:
                    Console.Clear();
                    ViewTasks();
                    break;
                case 3:
                    Console.Clear();
                    MarkCompleted();
                    break;
                case 4:
                    Console.Clear();
                    DeleteTask();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
            
          

        static void AddTasks()
        {
            Console.WriteLine("What task Would you like to add?");
            Console.WriteLine();
            string desc = Console.ReadLine();
                    tasks.Add(new TodoItem(desc));
                    Console.Clear() ;
                    Console.WriteLine("Task added");

                    Console.WriteLine();
                    BackButton();



         }

        static void ViewTasks()
        {
            Console.WriteLine("Your Current tasks and status");
            Console.WriteLine();
            if (tasks.Count == 0)
            {
                Console.WriteLine("No Task yet.");
            }
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            Console.WriteLine();
            BackButton();


        }

        static void MarkCompleted()
        {
            Console.Write("Enter task number to complete: ");

            // Try to read the input and convert it to an integer
            //if successfull, store it in the variable id
            //Also check if the number is within the valid range of tasks
            if (int.TryParse(Console.ReadLine(), out int id) && id >= 1 && id <= tasks.Count)
            {
                Console.Clear();
                tasks[id - 1].IsCompleted = true; //subract 1 because index is at zero and set the isCompleted property of the task to truw
                Console.WriteLine("Task is now completed");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("invalid Number");
            }
            Console.WriteLine();
            BackButton();

        }

       static void DeleteTask()
        {
            Console.Write("Enter task number to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id) && id >=1 && id <= tasks.Count)
            {
                Console.Clear();
                tasks.RemoveAt(id - 1); //subract 1 because index is at zero and remove at given index
                Console.WriteLine("Task Deleted");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("invalid Number");
            }
            Console.WriteLine();
            BackButton();
        }

        static void BackButton()
        {
            //takes user back to menu
            Console.WriteLine("Do you want to go back to the Menu: Y/N");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                Console.Clear();
                Menu();
            }

            else
            {
                Console.WriteLine("End");
            }

        }
    }

}
