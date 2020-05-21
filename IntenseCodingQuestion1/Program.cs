/*
 * This project is for showing wheather parking slots are available and to accpet valet parking.
 * Developed By C Akhil Chowdary and B Hemanth on 20/05/2020 
 */
using System;

namespace IntenseCodingQuestion1
{
    //Enum to show Parking Status
    internal enum ParkingStatus
    {
        Empty,
        Full
    }

    public class Slots
    {
        public int RegularParkingSlots;
        public int HandicappedParkingSlots;
        public int CompactParkingSlots;

    }
    class Program
    {

        static void Main(string[] args)
        {
            Slots slots = new Slots();
            
            //Inputting Regular Slots
            Console.WriteLine("Please Provide no. of Regular Parking Slots");
            bool isRegularParkingConverted = int.TryParse(Console.ReadLine(), out slots.RegularParkingSlots);
            while (!isRegularParkingConverted)
            {
                Console.WriteLine("Please Enter an integer value");
                isRegularParkingConverted = int.TryParse(Console.ReadLine(), out slots.RegularParkingSlots);
            }

            //Inputting Handicapped Slots
            Console.WriteLine("Please Provide no. of Handicapped Parking Slots");
            bool isHandicappedParkingConverted = int.TryParse(Console.ReadLine(), out slots.HandicappedParkingSlots);
            while (!isHandicappedParkingConverted)
            {
                Console.WriteLine("Please Enter an integer value");
                isHandicappedParkingConverted = int.TryParse(Console.ReadLine(), out slots.HandicappedParkingSlots);
            }


            //Inputting Compact Slots
            Console.WriteLine("Please Provide no. of Compact Parking Slots");
            bool isCompactParkingCOnverted = int.TryParse(Console.ReadLine(), out slots.CompactParkingSlots);
            while (!isCompactParkingCOnverted)
            {
                Console.WriteLine("Please Enter an integer value");
                isCompactParkingCOnverted = int.TryParse(Console.ReadLine(), out slots.CompactParkingSlots);
            }


            //Displaying No. of slots per each Parking type
            Console.WriteLine("Regular Slots    : " + slots.RegularParkingSlots);
            Console.WriteLine("Handicapped Slots: " + slots.HandicappedParkingSlots);
            Console.WriteLine("Compact Slots    : " + slots.CompactParkingSlots);


            int HandicappedParkingTracker = 0; //Tracker for Handicapped slots
            int RegularParkingTracker = 0; //Tracker for Regular slots
            int CompactparkingTracker = 0; //Tracker for Compact slots
            int ClientNumber = 0; //Keeping a track for no of requests made to the program
            string Park; //Variable to store if client's input to park or not
            string ParkingType; //Variable to check type of parking

            //infinite loop
            while (1 > 0)
            {
                ClientNumber++;

                //Checking if the client is handicapped or Senior Citizen
                Console.WriteLine("Client :" + ClientNumber);
                Console.WriteLine("Is the client a handicapped or senior citizen?(Y/N)");
                string isHandicappedOrSeniorCitizen = Console.ReadLine();

                string isValetParking; //Variable to check if user wants Valet Parking or not

                //Code for Handicapped Parking
                if (isHandicappedOrSeniorCitizen == "Y" || isHandicappedOrSeniorCitizen == "y")
                {
                    Console.WriteLine("He is eligible handicapped parking");

                    Console.WriteLine("Do you want to park?(Y/N)");
                    Park = Console.ReadLine();

                    //If client chooses to park
                    if (Park == "Y" || Park == "y")
                    {

                        //If the slot has empty space for parking
                        if (HandicappedParkingTracker < slots.HandicappedParkingSlots)
                        {
                            HandicappedParkingTracker++;

                            Console.WriteLine("Handicapped Parking is " + Enum.GetName(typeof(ParkingStatus), 0) + ", You can Park!");

                            //Valet Parking 
                            Console.WriteLine("Do you prefer valet parking?(Y/N)");
                            isValetParking = Console.ReadLine();
                            if (isValetParking == "Y" || isValetParking == "y")
                            {
                                Console.WriteLine("Thank You! We'll take care of your parking");
                            }
                            else
                                Console.WriteLine("Please use the parking lot carefully");

                        }
                        else
                            Console.WriteLine("Handicapped Parking is " + Enum.GetName(typeof(ParkingStatus), 1) + ",Please wait for some time");

                    }

                    //If client chooses not to park
                    else if (Park == "N" || Park == "n")
                        continue;

                    //If Client enters wrong input for parking
                    else
                        Console.WriteLine("Please provide valid option for parking");
                }

                //If the client is nor Handicapped or Senior Citizen
                else if (isHandicappedOrSeniorCitizen == "N" || isHandicappedOrSeniorCitizen == "n")
                {
                    Console.WriteLine("He is not eligible handicapped parking");
                    Console.WriteLine("Do you want to park?(Y/N)");
                    Park = Console.ReadLine();

                    //If client chooses to park
                    if (Park == "Y" || Park == "y")
                    {
                        //Asking for the type of parking
                        Console.WriteLine("Which type of parking do you choose?");
                        Console.WriteLine("1. Regular");
                        Console.WriteLine("2. Compact");

                        ParkingType = Console.ReadLine();
                        switch (ParkingType)
                        {
                            //Regular Parking
                            case "1":
                                {
                                    Console.WriteLine("welcome to regular parking");
                                    if (RegularParkingTracker < slots.RegularParkingSlots)
                                    {
                                        RegularParkingTracker++;

                                        Console.WriteLine("Regular Parking is " + Enum.GetName(typeof(ParkingStatus), 0) + ", You can park");
                                        Console.WriteLine("Do you prefer valet parking?(Y/N)");
                                        isValetParking = Console.ReadLine();
                                        if (isValetParking == "Y" || isValetParking == "y")
                                        {
                                            Console.WriteLine("Thank You! We'll take care of your parking");
                                        }
                                        else
                                            Console.WriteLine("Please use the parking lot carefully");

                                    }
                                    else
                                        Console.WriteLine("Regular Parking is " + Enum.GetName(typeof(ParkingStatus), 1) + ", Please wait for some time");

                                    continue;
                                }

                            //Compact Parking
                            case "2":
                                {
                                    Console.WriteLine("welcome to compact parking");
                                    if (CompactparkingTracker < slots.CompactParkingSlots)
                                    {
                                        CompactparkingTracker++;

                                        Console.WriteLine("Compact Parking is " + Enum.GetName(typeof(ParkingStatus), 0) + ", You can Park");
                                        Console.WriteLine("Do you prefer valet parking?(Y/N)");
                                        isValetParking = Console.ReadLine();
                                        if (isValetParking == "Y" || isValetParking == "y")
                                        {
                                            Console.WriteLine("Thank You! We'll take care of your parking");
                                        }
                                        else
                                            Console.WriteLine("Please use the parking lot carefully");

                                    }
                                    else
                                        Console.WriteLine("Compact Parking is " + Enum.GetName(typeof(ParkingStatus), 1) + ", Please wait for some time");

                                    continue;
                                }

                            //For wrong inputs
                            default:
                                {
                                    Console.WriteLine("Please enter valid type of parking");

                                    continue;
                                }
                        }
                    }

                    //If Client chooses not to park
                    else if (Park == "N" || Park == "n")
                        Console.WriteLine();

                    //If client provides wrong input to parking
                    else
                        Console.WriteLine("Please provide valid parking option");

                }

                //If client provides wrong input to Handicapped or Senior Citizen
                else
                    Console.WriteLine("Please provide valid client details");

                Console.WriteLine("------------------------------------");
            }
        }
    }
}
