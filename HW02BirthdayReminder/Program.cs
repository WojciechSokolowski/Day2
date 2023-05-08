using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02BirthdayReminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BirthdayReminder birthdayReminder = new BirthdayReminder();

            bool RunProgram = true;

            while (RunProgram)
            {

                Console.WriteLine("Birthday Reminder");
                Console.WriteLine("1. Add Friend");
                Console.WriteLine("2. Edit Friend");
                Console.WriteLine("3. Delete Friend");
                Console.WriteLine("4. View Friends");
                Console.WriteLine("5. Check Upcoming Birthdays");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        Console.WriteLine("Enter Freiend Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Friend's Birthday (MM / DD / YYYY): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
                        {
                            birthdayReminder.AddFriend(name, birthday);
                        }
                        else
                        {
                            Console.WriteLine("Invalid date format!");
                        }
                        break;

                    case "2":

                        Console.WriteLine("Enter Friend Name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Friend's New Birthday (MM / DD / YYYY): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime newbirthday))
                        {
                            birthdayReminder.EditFriend(name, newbirthday);
                        }
                        else
                        {
                            Console.WriteLine("Invalid date format!");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter Friend Name");
                        string DeleteName = Console.ReadLine();
                        birthdayReminder.RemoveFriend(DeleteName);
                        break;

                        case "4":
                        birthdayReminder.ViewFriends();
                        break;

                        case "5":
                        Console.WriteLine("Enter Number of Days in which Birthday may occur");
                        int days = Convert.ToInt32(Console.ReadLine());

                        birthdayReminder.CheckForUpcomingBirthdays(days);
                        break;

                        case "6":
                        RunProgram = false;
                        break;
                         
                }


            }

            Console.ReadKey();


        }
    }
}
