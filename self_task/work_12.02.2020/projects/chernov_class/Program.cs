using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernov_Gladskih_ISP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("James",2,"Male");
            Console.WriteLine(student.ToString());
            
            Employee employee = new Employee("Mike", "actor", 3);
            Console.WriteLine(employee.ToString());

            Workshop workshop = new Workshop("GIN", 25);
            Console.WriteLine(workshop.ToString());

            Book book = new Book("Time", new string[] {"Tom Soer", "Van Gog", }, 5);
            Console.WriteLine(book.ToString());

            Record record = new Record("Ivanov Ivan Ivanovich", "Vlamdirov Vladimir Vladimirovich", new DateTime(23,05,07), 4);
            Console.WriteLine(record.ToString());

            Address address = new Address(0534, "RaconCity", "Lomonosov", 3, 17);
            Console.WriteLine(address.ToString());

            Product product = new Product("Сыр", 545, 327, 7);
            Console.WriteLine(product.ToString());

            StudyGroup studyGroup = new StudyGroup("GIN", 25, 21, "Engineer");
            Console.WriteLine(studyGroup.ToString());

            Banknote banknote = new Banknote(359, 500, "Пятьсот");
            Console.WriteLine(banknote.ToString());

            ComputerGame computerGame = new ComputerGame("GameOFTrone", "Ubisoft", 2019, "РПГ");
            Console.WriteLine(computerGame.ToString());

            Console.ReadKey();
        }
    }
}
