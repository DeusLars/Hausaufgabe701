
namespace ToDoList
{
    public class programm
    {
        static void Main()
        {
            TaskList taskList = new TaskList();
            int taskCounter = 0;
            while (true)
            {
                Console.WriteLine("Geben sie ein Namen ein fuer ein Task");
                string name = Console.ReadLine();

                Console.WriteLine(Environment.NewLine + "Geben sie eine Beschreibung ein");
                string beschschreibung = Console.ReadLine();

                Console.WriteLine(Environment.NewLine + "Geben sie ein Datum an");
                string deadlineInput = Console.ReadLine();
                DateTime deadline = Convert.ToDateTime(deadlineInput);

                Task taskMachen = new Task(name, beschschreibung,  deadline);
                taskList.Add(taskMachen);
                taskCounter++;


                Console.WriteLine(Environment.NewLine + "Task gespeichert");
                //Console.WriteLine("Ausgebe: " + taskList[0].Name + " " + taskList[0].Aufgabenbeschreibung + " " + taskList[0].Deadline); //VOR ABGABE ENTFERNEN 
                Console.WriteLine(Environment.NewLine + "Wollen sie einen Task bearbeiten, wenn ja 1 eingeben wenn nicht 0 ");
                int bearbeitungsFrage = Convert.ToInt32(Console.ReadLine());
                if (bearbeitungsFrage == 1)
                {
                    Console.WriteLine("Welchen?");
                    int bearbeitenTask = Convert.ToInt32(Console.ReadLine());
                    if (bearbeitenTask > 0)
                    {
                        bearbeitenTask--;
                    }
                    Console.WriteLine("Was wollen sie bearbeiten, 1 = Name, 2 = Beschreibung, 3 = Datum");
                    int bearbeitenTaskAttribut = Convert.ToInt32(Console.ReadLine());

                    if (bearbeitenTaskAttribut == 1)
                    {
                        taskList[bearbeitenTask].NamenAndern();
                        taskList[bearbeitenTask].ausgabe();
                    }
                    if (bearbeitenTaskAttribut == 2)
                    {
                        taskList[bearbeitenTask].beschreibungAndern();
                        taskList[bearbeitenTask].ausgabe();
                    }
                    if(bearbeitenTaskAttribut == 3)
                    {
                        taskList[bearbeitenTask].datumAndern();
                        taskList[bearbeitenTask].ausgabe();
                    }
                }
            }
        }
    }
}
