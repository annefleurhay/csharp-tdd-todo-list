using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        public Dictionary<string, bool> Items { get; set; } = new Dictionary<string, bool>();

        public string CompletedTasks()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                if (item.Value == true)
                    
                    sb.Append(item.Key);
            }
            return sb.ToString();
        }

        

        public string incompletedTasks()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                if ( item.Value == false)
                
                    sb.Append(item.Key);
                
            }
            return sb.ToString();
        }

        public string SeeTasks()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items) 
            {
                sb.Append(item.Key);
                    
            }
            return sb.ToString();
        }

        public string Found(string task)
        {
            return task;
        }


        public bool UpdateTask(string task)
        {

            foreach (var item in Items)
            {
                if (Items.ContainsKey(task)) {
                    Items[task] = true;
                    return true;
                }
            }
            
            return false;
        }

        
    }
}
