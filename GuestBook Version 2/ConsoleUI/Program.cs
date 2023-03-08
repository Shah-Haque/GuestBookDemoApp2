using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;

//Requirements For GuestBook
//  Capture information about each guests
//  (Assumption is at least one guest and unknown maximum)
//  information Firstname,LastName, message to host
//  Once done, loop through each guest and print their information
namespace ConsoleUI
{
    public class Program
    {
        private static List<GuestModel> Guests = new List<GuestModel>();

        static void Main(string[] args)
        {
            GetGuestInformation();

            PrintGuestInformation();

            Console.ReadLine();
        }


        private static void PrintGuestInformation()
        {
            foreach (GuestModel G in Guests)
            {
                Console.WriteLine(G.GuestInfo);
            }
        }

        private static void GetGuestInformation()
        {
            string MoreGuestsComing;
            do
            {
                GuestModel Guest = new GuestModel(); 

                Guest.FirstName = GetInformationFromConsole("What is your FirstName: ");

                Guest.LastName = GetInformationFromConsole("What is your LastName: ");

                Guest.MessageToHost = GetInformationFromConsole("What message would you like to tell your host: ");

                MoreGuestsComing = GetInformationFromConsole("Are more guests coming: {yes/no} ");

                Guests.Add(Guest);

                Console.Clear();

            } while (MoreGuestsComing.ToLower() == "yes");
        }

        private static string GetInformationFromConsole(string message)
        {
            string output;

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
} 