using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks

namespace todoAppWPF
{
    //<Summary>
    //Hanterar logiken för att lägga till, ta bort och ändra
    //</summary>
    public class todoList
    {
        private todoList<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(int index) 
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }

        public void GetAllTasks() 
        {
            return tasks;
        }
    }
}
