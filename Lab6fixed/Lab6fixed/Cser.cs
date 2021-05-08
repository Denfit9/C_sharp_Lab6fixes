using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6fixed
{
    class Cser : Human
    {
        protected string role;
        protected double kd;
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public double KD
        {
            get { return kd; }
            set { kd = value; }
        }
        public enum TeamRole
        {
            rifler = 1,
            awper,
            captain,
            support
        }
        public static double PlayerKD()
        {

            string kd;
            double fullkd;
            while (true)
            {
                Console.WriteLine("\nEnter his K/D score   (ex. 2,43)");
                kd = Console.ReadLine();
                if (!double.TryParse(kd, out fullkd))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToDouble(kd) >= 5)
                {
                    Console.WriteLine("That is just impossible");
                }
                else break;
            }
            return fullkd;
        }

        public static string RoleChoosing()
        {
            string plrole = "";
            char index;
            bool choice = false;
            Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        plrole = Convert.ToString(TeamRole.awper);
                        choice = true;
                        break;

                    case '2':
                        plrole = Convert.ToString(TeamRole.rifler);
                        choice = true;
                        break;
                    case '3':
                        plrole = Convert.ToString(TeamRole.captain);
                        choice = true;
                        break;
                    case '4':
                        plrole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            return plrole;
        }
        public void RoleChanger()
        {
            Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
            string plrole = "";
            char index;
            bool choice = false;
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        plrole = Convert.ToString(TeamRole.awper);
                        choice = true;
                        break;

                    case '2':
                        plrole = Convert.ToString(TeamRole.rifler);
                        choice = true;
                        break;
                    case '3':
                        plrole = Convert.ToString(TeamRole.captain);
                        choice = true;
                        break;
                    case '4':
                        plrole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            role = plrole;
        }
        public void KillDeathChanger()
        {
            string kd2;
            double fullkd;
            while (true)
            {
                Console.WriteLine("Enter his new K/D score   (ex. 2,43)");
                kd2 = Console.ReadLine();
                if (!double.TryParse(kd2, out fullkd))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToDouble(kd2) >= 5)
                {
                    Console.WriteLine("That is just impossible");
                }
                else break;
            }
            kd = fullkd;
        }
        public Cser()
        {
            role = RoleChoosing();
            kd = PlayerKD();
        }
        public void ShowInfoV2()
        {
            Console.Clear();
            Console.WriteLine("Name is: " + name + "\nSurname is: " + surname + "\nAge is: " + age + condition + "\nNationality is: " + nationality +
                "\nHis player id is: " + playerid + "\nHis in-game nickname is: " + nickname);
            Console.WriteLine("His role is: " + role);
            Console.WriteLine("His K/D score is: " + kd);
        }
        public override void Career()
        {
            Console.WriteLine("So he is a cs:go pro-player.");
        }
        public override void Check()
        {
            Console.WriteLine("cs:go profile creator is working correctly");
        }
    }
}
