using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6fixed
{
    class Human : IComparer<Human>, IAlive
    {
        public void Laugh()
        {
            Console.WriteLine("Ha-ha so funny *laughes*");
        }
        public void Joke()
        {
            Console.WriteLine("Helvetica and Times New Roman walk into a bar.\n“Get out of here!” shouts the bartender. “We don’t serve your type.”");
        }
        public void Punch()
        {
            Console.WriteLine("Ouch! Punched right in his face");
        }
        public void Living(int age)
        {
            int Year = 2021;
            int Born = 0;
            Born = Year - age;
            Console.WriteLine("He was born around " + Born);

        }
        protected string name;
        protected string surname;
        public int age;
        protected string nationality;
        protected int playerid;
        protected string condition;
        protected string nickname;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {

            get { return age; }
            set
            { age = value; }

        }
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        public int Playerid
        {
            get { return playerid; }
            set { playerid = value; }
        }
        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }
        public int Compare(Human num1, Human num2)
        {
            if (num1.age > num2.age)
            {
                return 1;
            }
            else if (num1.age == num2.age)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public static string LineCheck()
        {
            string data;
            do
            {
                int correctness = 0;
                data = Console.ReadLine();
                if (data.Length == 0)
                {
                    Console.Write("Empty line detected\n");
                    continue;
                }
                for (int i = 0; i < data.Length; i++)
                {
                    if (!char.IsLetter(data[i]))
                    {
                        Console.Write("Use only characters \n");
                        correctness = 1;
                        break;
                    }
                }
                if (correctness != 0) continue;
                else break;
            } while (true);
            return data;

        }
        public static string TeamNicknameLineCheck()
        {
            string data;
            do
            {
                data = Console.ReadLine();
                if (data.Length == 0)
                {
                    Console.Write("Empty line detected\n");
                    continue;
                }
                else break;
            } while (true);

            return data;
        }

        public static int AgeCheck()
        {
            string age;
            int ageint;
            while (true)
            {
                age = Console.ReadLine();
                if (!int.TryParse(age, out ageint))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToInt32(age) < 16)
                {
                    Console.WriteLine("He is too young to be a pro player");
                }
                else if (Convert.ToInt32(age) > 40)
                {
                    Console.WriteLine("Nah he is too old to be a pro player now");
                }
                else break;
            }
            return ageint;
        }
        public static int IdCheck()
        {
            string playerid;
            int completeid;
            while (true)
            {
                playerid = Console.ReadLine();
                if (!int.TryParse(playerid, out completeid))
                {
                    Console.Write("Try again\n ");

                }
                else break;
            }
            return completeid;
        }
        public void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine("Name is: " + name + "\nSurname is: " + surname + "\nAge is: " + age + condition + "\nNationality is: " + nationality +
                "\nHis player id is: " + playerid + "\nHis in-game nickname is: " + nickname);
        }
        public void NewAge()
        {
            int age_new;
            Console.WriteLine("Enter new player's age:");
            string age_new2;
            while (true)
            {
                age_new2 = Console.ReadLine();
                if (!int.TryParse(age_new2, out age_new))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToInt32(age) < 16)
                {
                    Console.WriteLine("He is too young to be a pro player");
                }
                else if (Convert.ToInt32(age) > 40)
                {
                    Console.WriteLine("Nah he is too old to be a pro player now");
                }
                else break;
            }
            age = age_new;
        }
        public void NewId()
        {
            int new_id;
            Console.WriteLine("Enter new player's id:");
            string id_new;
            while (true)
            {
                id_new = Console.ReadLine();
                if (!int.TryParse(id_new, out new_id))
                {
                    Console.Write("Try again\n ");

                }
                else break;

            }
            playerid = new_id;
        }
        public void NameChanger()
        {
            Console.WriteLine("Enter new nickname");
            string data;
            do
            {
                data = Console.ReadLine();
                if (data.Length == 0)
                {
                    Console.Write("Empty line detected\n");
                    continue;
                }
                else break;
            } while (true);

            nickname = data;
        }
        public Human()
        {

            Console.WriteLine("Name of the player");
            Name = Human.LineCheck();
            Console.WriteLine("Surname of the player:");
            Surname = Human.LineCheck();
            Console.WriteLine("Age is");
            Age = Human.AgeCheck();
            Console.WriteLine("Nationality is");
            Nationality = LineCheck();
            Console.WriteLine("His Id is");
            Playerid = IdCheck();
            Console.WriteLine("Player's nickname is");
            Nickname = TeamNicknameLineCheck();
        }
        public void Kill()
        {
            condition = " (dead)";

        }
        public virtual void Career()
        {
            Console.WriteLine("");
        }
        public virtual void Check()
        {
            Console.WriteLine("");
        }
    }
}
