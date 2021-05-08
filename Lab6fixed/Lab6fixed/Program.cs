using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6fixed
{
    class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
            bool cybersportsman = true;
            char task;
            Console.Clear();

            if (cybersportsman == true)
            {
                Console.Clear();
                while (close == false)
                {
                    //Console.Clear();
                    Console.WriteLine("Choose human's game \n a- cs:go \n b - dota2 \n c - valorant \n d - just check program");
                    task = Console.ReadKey().KeyChar;

                    switch (task)
                    {

                        case 'a': // cs:go
                            Console.Clear();
                            Cser cser = new Cser();
                            Console.Clear();
                            cser.Career();
                            while (close == false)
                            {
                                Console.WriteLine("\nwhat to do? \n 1 - Show info \n 2 - change id \n 3 - change age\n 4 - change nickname\n 5 - Change his role in team\n 6 - change his K/D score \n 7 - kill \n" +
                                    " 8 - laugh\n 9 - tell a joke\n a - check his age\n p - punch\n s - sort titles\n c - close");
                                task = Console.ReadKey().KeyChar;
                                switch (task)
                                {
                                    case '1':
                                        Console.Clear();
                                        cser.ShowInfoV2();
                                        break;
                                    case '2':
                                        Console.Clear();
                                        cser.NewId();
                                        break;
                                    case '3':
                                        Console.Clear();
                                        cser.NewAge();
                                        break;
                                    case '4':
                                        Console.Clear();
                                        cser.NameChanger();
                                        break;
                                    case '5':
                                        Console.Clear();
                                        cser.RoleChanger();
                                        break;
                                    case '6':
                                        Console.Clear();
                                        cser.KillDeathChanger();
                                        break;
                                    case '7':
                                        Console.Clear();
                                        cser.Kill();
                                        Console.WriteLine("Now you are a killer");
                                        break;
                                    case '8':
                                        Console.Clear();
                                        cser.Laugh();
                                        break;
                                    case '9':
                                        Console.Clear();
                                        cser.Joke();
                                        break;
                                    case 'p':
                                        Console.Clear();
                                        cser.Punch();
                                        break;
                                    case 'a':
                                        Console.Clear();
                                        cser.Living(cser.age);
                                        break;
                                    case 's':
                                        Console.Clear();
                                        int[] titles = new int[3];
                                        int year = 2017;
                                        for (int i = 0; i <= 2; i++)
                                        {
                                            Console.WriteLine("Enter number of titles in " + year);
                                            titles[i] = Convert.ToInt32(Console.ReadLine());
                                            year++;
                                        }
                                        Array.Sort(titles);
                                        year = 2017;
                                        Console.WriteLine("Sorted number of titles");
                                        for (int i = 0; i <= 2; i++)
                                        {
                                            Console.Write(" " + titles[i]);
                                            year++;
                                        }
                                        break;
                                    case 'c':
                                        close = true;
                                        break;
                                    default:
                                        Console.WriteLine("Excellent choice");
                                        break;
                                }
                            }
                            break;
                        case 'b': // dota
                            Console.Clear();
                            Doter doter = new Doter();
                            Console.Clear();
                            doter.Career();
                            while (close == false)
                            {
                                Console.WriteLine("\nwhat to do? \n 1 - Show info \n 2 - change id \n 3 - change age\n 4 - change nickname\n 5 - Change his role in team\n 6 - change his K/D score \n 7 - kill \n" +
                                    " 8 - laugh\n 9 - tell a joke\n a - check his age\n p - punch\n s - sort titles\n c - close");
                                task = Console.ReadKey().KeyChar;
                                switch (task)
                                {
                                    case '1':
                                        Console.Clear();
                                        doter.ShowInfoV2();
                                        break;
                                    case '2':
                                        Console.Clear();
                                        doter.NewId();
                                        break;
                                    case '3':
                                        Console.Clear();
                                        doter.NewAge();
                                        break;
                                    case '4':
                                        Console.Clear();
                                        doter.NameChanger();
                                        break;
                                    case '5':
                                        Console.Clear();
                                        doter.RoleChanger();
                                        break;
                                    case '6':
                                        Console.Clear();
                                        doter.KillDeathChanger();
                                        break;
                                    case '7':
                                        Console.Clear();
                                        doter.Kill();
                                        Console.WriteLine("Now you are a killer");
                                        break;
                                    case '8':
                                        Console.Clear();
                                        doter.Laugh();
                                        break;
                                    case '9':
                                        Console.Clear();
                                        doter.Joke();
                                        break;
                                    case 'a':
                                        Console.Clear();
                                        doter.Living(doter.age);
                                        break;
                                    case 's':
                                        Console.Clear();
                                        int[] titles = new int[3];
                                        int year = 2017;
                                        for (int i = 0; i <= 2; i++)
                                        {
                                            Console.WriteLine("Enter number of titles in " + year);
                                            titles[i] = Convert.ToInt32(Console.ReadLine());
                                            year++;
                                        }
                                        Array.Sort(titles);
                                        year = 2017;
                                        Console.WriteLine("Sorted number of titles");
                                        for (int i = 0; i <= 2; i++)
                                        {
                                            Console.Write(" " + titles[i]);
                                            year++;
                                        }
                                        break;
                                    case 'p':
                                        Console.Clear();
                                        doter.Punch();
                                        break;
                                    case 'c':
                                        close = true;
                                        break;
                                    default:
                                        Console.WriteLine("Excellent choice");
                                        break;
                                }
                            }
                            break;
                        case 'c': //valorant
                            Console.Clear();
                            Valoranter val = new Valoranter();
                            Console.Clear();
                            val.Career();
                            while (close == false)
                            {
                                Console.WriteLine("\nwhat to do? \n 1 - Show info \n 2 - change id \n 3 - change age\n 4 - change nickname\n 5 - Change his role in team\n 6 - change his K/D score \n 7 - kill \n" +
                                     " 8 - laugh\n 9 - tell a joke\n a - check his age\n p - punch\n s - sort titles\n c - close");
                                task = Console.ReadKey().KeyChar;
                                switch (task)
                                {
                                    case '1':
                                        Console.Clear();
                                        val.ShowInfoV2();
                                        break;
                                    case '2':
                                        Console.Clear();
                                        val.NewId();
                                        break;
                                    case '3':
                                        Console.Clear();
                                        val.NewAge();
                                        break;
                                    case '4':
                                        Console.Clear();
                                        val.NameChanger();
                                        break;
                                    case '5':
                                        Console.Clear();
                                        val.RoleChanger();
                                        break;
                                    case '6':
                                        Console.Clear();
                                        val.KillDeathChanger();
                                        break;
                                    case '7':
                                        Console.Clear();
                                        val.Kill();
                                        Console.WriteLine("Now you are a killer");
                                        break;
                                    case '8':
                                        Console.Clear();
                                        val.Laugh();
                                        break;
                                    case '9':
                                        Console.Clear();
                                        val.Joke();
                                        break;
                                    case 'a':
                                        Console.Clear();
                                        val.Living(val.age);
                                        break;
                                    case 's':
                                        Console.Clear();
                                        int[] titles = new int[3];
                                        int year = 2017;
                                        for (int i = 0; i <= 2; i++)
                                        {
                                            Console.WriteLine("Enter number of titles in " + year);
                                            titles[i] = Convert.ToInt32(Console.ReadLine());
                                            year++;
                                        }
                                        Array.Sort(titles);
                                        year = 2017;
                                        Console.WriteLine("Sorted number of titles");
                                        for (int i = 0; i <= 2; i++)
                                        {
                                            Console.Write(" " + titles[i]);
                                            year++;
                                        }
                                        break;
                                    case 'p':
                                        Console.Clear();
                                        val.Punch();
                                        break;
                                    case 'c':
                                        close = true;
                                        break;
                                    default:
                                        Console.WriteLine("Excellent choice");
                                        break;
                                }
                            }
                            break;
                        case 'd':
                            var check = new List<Human>
                    {
                        new Cser(),
                        new Doter(),
                        new Valoranter()
                    }; Console.Clear();
                            foreach (var checking in check)
                            {
                                checking.Check();
                            }
                            break;
                        default:
                            Console.WriteLine("Excellent choice");
                            break;
                    }

                }
            }
        }
    }
}

