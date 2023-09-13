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

        //public Dictionary<string, bool> CompletedItems { get { return Items.Where(x => x.Value == true).ToDictionary(x => x.Key, x => x.Value); } }

        public string CompletedTasks()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                if (item.Value == true)
                    
                    sb.Append(item.Key + " ");
            }
            return sb.ToString().TrimEnd();
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

        public string NotFound(string task)
        {
            if (Items.ContainsKey(task))
            {
                return "Item found";
            }
            return "Item not found!";
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

        public string ascendingOrder()
        {
            StringBuilder sb = new StringBuilder();
            var sortedItems = Items.OrderBy(item => item.Key);

            foreach (var item in sortedItems)
            {
                sb.Append(item.Key);
            }
            return sb.ToString();
        }

        public string descendingOrder()
        {
            StringBuilder sb = new StringBuilder();
            var sortedItems = Items.OrderByDescending(item => item.Key);

            foreach(var item in sortedItems)
            {
                sb.Append(item.Key);
            }
            return sb.ToString();
            
        }
    }
}
