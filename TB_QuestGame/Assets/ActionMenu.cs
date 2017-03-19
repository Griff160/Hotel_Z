using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// static class to hold key/value pairs for menu options
    /// </summary>
    public static class ActionMenu
    {
        public static Menu MissionIntro = new Menu()
        {
            MenuName = "MissionIntro",
            MenuTitle = "",
            MenuChoices = new Dictionary<char, HeroAction>()
                    {
                        { ' ', HeroAction.None }
                    }
        };

        public static Menu InitializeMission = new Menu()
        {
            MenuName = "InitializeMission",
            MenuTitle = "Initialize Mission",
            MenuChoices = new Dictionary<char, HeroAction>()
                {
                    { '1', HeroAction.Exit }
                }
        };

        public static Menu MainMenu = new Menu()
        {
            MenuName = "MainMenu",
            MenuTitle = "Main Menu",
            MenuChoices = new Dictionary<char, HeroAction>()
                {
                    { '1', HeroAction.HeroInfo },
                    { '2', HeroAction.LookAround },
                    { '3', HeroAction.Travel },
                    { '4', HeroAction.HeroLocationsVisited },
                    { '5', HeroAction.ListRoomLocations },
                    { '0', HeroAction.Exit },
                }
        };

        
    }
}
