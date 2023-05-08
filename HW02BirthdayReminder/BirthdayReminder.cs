using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW02BirthdayReminder
{
    internal class BirthdayReminder
    {
        private List<Friend> friends;


        public BirthdayReminder() 
        {
            friends = new List<Friend>();
        }


        public void AddFriend(string name, DateTime birthday)
        {
            Friend friend = new Friend { Name = name, Birthday = birthday };
            friends.Add(friend);
            Console.WriteLine(friend.Name + " added");
        }

        public void RemoveFriend(string name)
        {
            Friend friend = friends.Find(f => f.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            
            if (friend != null) {
                friends.Remove(friend);
                Console.WriteLine($"Remove {friend.Name}");
            }
            else
            {
                Console.WriteLine("Friend not found");
            }

        }

        public void EditFriend(string name, DateTime birthday) 
        {
            Friend friend = friends.Find(f => f.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (friend != null)
            {
                friend.Birthday = birthday;
                Console.WriteLine($"{friend.Name} edited");
            }
            else
            {
                Console.WriteLine("Friend not found!");
            }
        }

        public void ViewFriends()
        {
            if (friends.Count ==0) {
            
            Console.WriteLine("You have no friends, so sad :c");
            return;
            }
            else
            {
                foreach(Friend friend in friends)
                {
                    Console.WriteLine($"Name: {friend.Name} has birthday at: {friend.Birthday.ToShortDateString()}");
                }
            }


        }

        public void CheckForUpcomingBirthdays(int NextDays)
        {
            DateTime today = DateTime.Today;
            foreach(Friend friend in friends)
            {
                DateTime nextBirthday = new DateTime(today.Year, friend.Birthday.Month, friend.Birthday.Day);

                if (nextBirthday < today)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }

                int DaysTillBirthday = (nextBirthday - today).Days;

                if (DaysTillBirthday < NextDays)
                {
                    Console.WriteLine($"Birthday of {friend.Name} at day {friend.Birthday.ToShortDateString()} will happen in {DaysTillBirthday} day(s)");
                }
            }    

                
        }

    }
}
