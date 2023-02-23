using System.IO.Pipes;
using System.Net.Sockets;

namespace D14_oop
{
    internal class Program
    {

         public class person
        {
            public string forNamn, efternamn, teleNum, address;
            public void print()
            {
                Console.WriteLine("Namn " + forNamn +efternamn);
                Console.WriteLine(" Telfon " + teleNum);
                Console.WriteLine("Adress " + address);
                Console.WriteLine();
            }
        }
        


        // now I will write a function to CW all objekts.
        static void printObjekts(person a)
        {
            Console.WriteLine("Namn " + a.forNamn + a.efternamn);
            Console.WriteLine(" Telfon "+ a.teleNum);
            Console.WriteLine("Adress " + a.address);

        }
        static void Main(string[] args)
        {
            person Arne = new person()
            { forNamn = "Arne", address = "kopparvagen falun", efternamn = " Svensson", teleNum = "0235456584" };
            person Berith = new person()
            { forNamn = "Berith", efternamn = " Qvist", address = "Norskensgatan 12", teleNum = "0231511215" };
            person Caesar = new person()
            { forNamn = " Caesar ", efternamn = "Augustus", address = "Kunggatan", teleNum = "07000221" };

            Arne.print();


             person[] folk = { Arne, Berith, Caesar };
            foreach (var item in folk)
            {
                item.print();

            }
        }
    }
}