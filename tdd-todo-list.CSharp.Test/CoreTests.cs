using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTask()
        {
            //arrange
            TodoList todo = new TodoList();

            //act
            todo.Items.Add("Drink Redbull", false);

            //assert
            Assert.IsTrue(1 == todo.Items.Count);
        }

        [Test]
        public void ShowToDos() 
        { 
        
            //arrange
            TodoList todo = new TodoList();
            todo.Items.Add("Drink Redbull", true);
            

            //act

            //assert
            string result = todo.SeeTasks();
            Assert.IsTrue(result.Length > 0);

            //Assert.IsTrue(todo.Items.Any());

        }

        [Test]
        public void ChangeStatus()
        {
            //arrange
            TodoList todo = new TodoList();
            string task = "mow the lawn";
            todo.Items.Add(task, false);

            //act
            bool hasUpdatedTaskStatus = todo.UpdateTask(task);
            //assert
            Assert.IsTrue(hasUpdatedTaskStatus);
            //Assert.IsTrue(!todo.Items.Any());
        }

        [Test]
        public void FoundItem()
        {
            TodoList todo = new TodoList();
            string task = "Drink redbull";

            todo.Items.Add(task, false);
            todo.Items.Remove(task);

            string foundNone = todo.NotFound(task);

            Assert.IsTrue(foundNone == "Item not found!");
        }

        [Test] //- I want to be able to get only the complete tasks. returning the key if value == true 
        public void ShowCompleted()
        {   //arrange
            TodoList todo = new TodoList();
            

            //act
            todo.Items.Add("Drink redbull", false);
            todo.Items.Add("Sleep", true);
            todo.Items.Add("Code", true);
            string CompletedTasks = todo.CompletedTasks();

            //assert
            Assert.IsTrue(CompletedTasks == "SleepCode"); // hoe zorg ik dat hier een spatie tussen komt? 

           
        }

        [Test]
        public void ShowIncompleted()
        {
            TodoList todo = new TodoList();

            todo.Items.Add("Drink redbull", false);
            todo.Items.Add("Sleep", true);
            todo.Items.Add("Code", true);

            string incompletedTasks = todo.incompletedTasks();

            Assert.IsTrue(incompletedTasks == "Drink redbull");

        }

        [Test] // nog een keer naar kijken want nu wordt gewoon alels verwijdert en geen specifieke to do item 
        public void RemoveTask()
        {
            //arrange
            TodoList todo = new TodoList();
            string taak = "Drink Redbull";
            string taak2 = "Sleep";
            
            todo.Items.Add(taak, false);
            todo.Items.Add(taak2, true);


            //act
            todo.Items.Remove(taak);
            todo.Items.Remove(taak2);

            //assert
            Assert.IsTrue(0 == todo.Items.Count);

        }

        [Test]
        public void Ascending()
        {
            TodoList todo = new TodoList();

            todo.Items.Add("Drink redbull", true);
            todo.Items.Add("Sleep", true);
            todo.Items.Add("Code", true);

            string AscOrder = todo.ascendingOrder();

            Assert.IsTrue(AscOrder == "CodeDrink redbullSleep"); //how do i make sure there is a space inbetween?


        }

        [Test]
        public void Descending()
        {
            TodoList todo = new TodoList();
            
            todo.Items.Add("Drink redbull", true);
            todo.Items.Add("Sleep", true);
            todo.Items.Add("Code", true);

            string DescOrder = todo.descendingOrder();

            Assert.IsTrue(DescOrder == "SleepDrink redbullCode");

        
        }

        


    }
}