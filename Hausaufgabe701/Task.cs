using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ToDoList
{

    public class Task
    {
        public string Name;
        public string Aufgabenbeschreibung;
        public DateTime? Deadline;

        
        public Task(string name, string aufgabenbeschreibung, DateTime? deadline)
        {
            Name = name;
            Aufgabenbeschreibung = aufgabenbeschreibung;
            Deadline = deadline;
        }

        public Task(string name)
        {
            Name = name;
        }

        public Task(string name, string aufgabenbeschreibung)
        {
            Name = name;
            Aufgabenbeschreibung = aufgabenbeschreibung;
        }

        public Task(string name, DateTime? deadline)
        {
            Name = name;
            Deadline = deadline;
        }

        public void NamenAndern()
        {
            Console.WriteLine("Neuer Name: ");
            Name = Console.ReadLine();
        }

        public void beschreibungAndern()
        {
            Console.WriteLine("Neue Beschreiubung: ");
            Aufgabenbeschreibung = Console.ReadLine();
        }
        
        public void datumAndern ()
        {
            Console.WriteLine("Neues Datum: ");
            Deadline = Convert.ToDateTime(Console.ReadLine());
        }

        public void ausgabe()
        {
            Console.WriteLine("Das ist der Neue Eintrag: " + Name + " "+ Aufgabenbeschreibung+ " " + Deadline);
        }
    }

    public class TaskList : List<Task>
    {

    }

   


}
