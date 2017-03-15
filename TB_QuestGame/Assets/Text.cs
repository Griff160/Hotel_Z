using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// class to store static and to generate dynamic text for the message and input boxes
    /// </summary>
    public static class Text
    {
        public static List<string> HeaderText = new List<string>() { "Hotel Z" };
        public static List<string> FooterText = new List<string>() { "" };

        #region INTITIAL GAME SETUP

        public static string MissionIntro()
        {
            string messageBoxText =
            "You have woken up in your hotel room to the sounds of screeming " +
            "'The hotel is infested in ZOMBIES!' You quickly realize that " +
            "staying on the top floor was a terrible idea. Now you must escape. " +
            " \n" +
            "Press the Esc key to exit the game at any point.\n" +
            " \n" +
            "Your quest begins now.\n" +
            " \n" +
            "\tBut first lets find out a bit about you.\n" +
            " \n" +
            "\tPress any key to begin.\n";

            return messageBoxText;
        }

        /// <summary>
        /// TODO change text about starting location
        /// </summary>
        /// <returns></returns>
        public static string CurrentLocationInfo()
        {
            string messageBoxText =
            "You are now in the Norlon Corporation research facility located in " +
            "the city of Heraklion on the north coast of Crete. You have passed through " +
            "heavy security and descended an unknown number of levels to the top secret " +
            "research lab for the Aion Project.\n" +
            " \n" +
            "\tChoose from the menu options to proceed.\n";

            return messageBoxText;
        }

        #region Initialize Mission Text

        public static string InitializeMissionIntro()
        {
            string messageBoxText =
                "Now lets find out a little background on our Hero.\n" +
                " \n" +
                "You will be prompted for the information. Please enter the information below.\n" +
                " \n" +
                "\tPress any key to begin.";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerName()
        {
            string messageBoxText =
                "Enter your name Hero.\n" +
                " \n" +
                "Use the name you want us to call you during your escape attempt.";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerAge(Hero gameTraveler)
        {
            string messageBoxText =
                $"OK then, we will call you {gameTraveler.Name}.\n" +
                " \n" +
                "Enter your age below.\n" +
                " \n";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerRace(Hero gameTraveler)
        {
            string messageBoxText =
                $"{gameTraveler.Name}, it will be important for us to know what your background is.\n" +
                " \n" +
                "Enter your class below.\n" +
                " \n" +
                "Please use the choices listed below." +
                " \n";

            string raceList = null;

            foreach (Character.ClassType race in Enum.GetValues(typeof(Character.ClassType)))
            {
                if (race != Character.ClassType.None)
                {
                    raceList += $"\t{race}\n";
                }
            }

            messageBoxText += raceList;

            return messageBoxText;
        }

        public static string InitializeMissionEchoTravelerInfo(Hero gameTraveler)
        {
            string messageBoxText =
                $"Very good then {gameTraveler.Name}.\n" +
                " \n" +
                "Ok now that we know more about you, lets see how long you survive." +
                " \n" +
                $"\tTraveler Name: {gameTraveler.Name}\n" +
                $"\tTraveler Age: {gameTraveler.Age}\n" +
                $"\tTraveler Class: {gameTraveler.Class}\n" +
                " \n" +
                "Press any key to begin your escape.";

            return messageBoxText;
        }

        #endregion

        #endregion

        #region MAIN MENU ACTION SCREENS

        public static string TravelerInfo(Hero gameTraveler)
        {
            string messageBoxText =
                $"\tTraveler Name: {gameTraveler.Name}\n" +
                $"\tTraveler Age: {gameTraveler.Age}\n" +
                $"\tTraveler Class: {gameTraveler.Class}\n" +
                " \n";

            return messageBoxText;
        }

        //public static string Travel(int currentSpaceTimeLocationId, List<SpaceTimeLocation> spaceTimeLocations)
        //{
        //    string messageBoxText =
        //        $"{gameTraveler.Name}, Aion Base will need to know the name of the new location.\n" +
        //        " \n" +
        //        "Enter the ID number of your desired location from the table below.\n" +
        //        " \n";


        //    string spaceTimeLocationList = null;

        //    foreach (SpaceTimeLocation spaceTimeLocation in spaceTimeLocations)
        //    {
        //        if (race != Character.ClassType.None)
        //        {
        //            raceList += $"\t{race}\n";
        //        }
        //    }

        //    messageBoxText += raceList;

        //    return messageBoxText;
        //}

        #endregion
    }
}
