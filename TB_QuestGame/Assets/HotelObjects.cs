using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{ 
    class HotelObjects
    {
        public static List<RoomLocation> RoomLocations = new List<RoomLocation>()
        {
            //
            // TODO switch to my location data
            //

            new RoomLocation
            {
                CommonName = "Aion Base Lab",
                RoomLocationID = 1,
                UniversalDate = 386759,
                UniversalLocation = "P-3, SS-278, G-2976, LS-3976",
                Description = "The Norlon Corporation research facility located in " +
                    "the city of Heraklion on the north coast of Crete and the top secret " +
                    "research lab for the Aion Project.\n",
                GeneralContents = "The lab is a large, well lit room, and staffed " +
                    "by a small number of scientists, all wearing light blue uniforms with the " +
                    "hydra-like Norlan Corporation logo. \n",
                Accessable = true,
                ExperiencePoints = 10,
                Lives = 0
            },

            new RoomLocation
            {
                CommonName = "Felandrian Plains",
                RoomLocationID = 2,
                UniversalDate = 386759,
                UniversalLocation = "P-2, SS-85, G-2976, LS-3976",
                Description = "The Felandrian Plains are a common destination for tourist. " +
                    "Located just north of the equatorial line on the planet of Corlon, they " +
                    "provide excellent habitat for a rich ecosystem of flora and fauna.",
                GeneralContents = "- stuff in the room -",
                Accessable = true,
                ExperiencePoints = -10,
                Lives = 0
            },

            new RoomLocation
            {
                CommonName = "Xantoria Market",
                RoomLocationID = 3,
                UniversalDate = 386759,
                UniversalLocation = "P-6, SS-3978, G-2976, LS-3976",
                Description = "The Xantoria market, once controlled by the Thorian elite, is now an " +
                              "open market managed by the Xantorian Commerce Coop. It is a place " +
                              "where many races from various systems trade goods.",
                GeneralContents = "- stuff in the room -",
                Accessable = false,
                ExperiencePoints = 20,
                Lives = 0
            },

            new RoomLocation
            {
                CommonName = "Norlon Corporate Headquarters",
                RoomLocationID = 4,
                UniversalDate = 386759,
                UniversalLocation = "P-3, SS-278, G-2976, LS-3976",
                Description = "The Norlon Corporation Headquarters is located in just outside of Detroit Michigan." +
                              "Norlon, founded in 1985 as a bio-tech company, is now a 36 billion dollar company " +
                              "with huge holdings in defense and space research and development.",
                GeneralContents = "- stuff in the room -",
                Accessable = true,
                ExperiencePoints = 10,
                Lives = 0
            },

            new RoomLocation
            {
                CommonName = "Northwestern Michigan College",
                RoomLocationID = 5,
                UniversalDate = 2017,
                UniversalLocation = "P-3, SS-1, G-1, LS-1",
                Description = "Founded in 1951, Northwestern Michigan College, known as NMC to local residents, " +
                              "is a community college in Traverse City, Grand Traverse County, Michigan.  " +
                              "Its annual enrollment is around 5,100 students. ",
                GeneralContents = "You find a magical textbook on C# programming and gain 1 life! ",
                Accessable = true,
                ExperiencePoints = 100,
                Lives = 1
            }
        };

    }
}
