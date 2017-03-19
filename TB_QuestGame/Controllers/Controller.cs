using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// controller for the MVC pattern in the application
    /// </summary>
    public class Controller
    {
        #region FIELDS

        private ConsoleView _gameConsoleView;
        private Hero _gameHero;
        private Hotel _gameHotel; 
        private bool _playingGame;
        private RoomLocation _currentLocation;

        #endregion

        #region PROPERTIES


        #endregion

        #region CONSTRUCTORS

        public Controller()
        {
            //
            // setup all of the objects in the game
            //
            InitializeGame();

            //
            // begins running the application UI
            //
            ManageGameLoop();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// initialize the major game objects
        /// </summary>
        private void InitializeGame()
        {
            _gameHero = new Hero();
            _gameHotel = new Hotel();
            _gameConsoleView = new ConsoleView(_gameHero, _gameHotel);
            _playingGame = true;

            Console.CursorVisible = false;
        }

        /// <summary>
        /// method to manage the application setup and game loop
        /// </summary>
        private void ManageGameLoop()
        {
            HeroAction HeroActionChoice = HeroAction.None;

            //
            // display splash screen
            //
            _playingGame = _gameConsoleView.DisplaySpashScreen();

            //
            // player chooses to quit
            //
            if (!_playingGame)
            {
                Environment.Exit(1);
            }

            //
            // display introductory message
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Intro", Text.MissionIntro(), ActionMenu.MissionIntro, "");
            _gameConsoleView.GetContinueKey();

            //
            // initialize the mission traveler
            // 
            InitializeMission();

            //
            // prepare game play screen
            //
            _currentLocation = _gameHotel.GetRoomLocationById(_gameHero.RoomLocationID);
            _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentLocationInfo(), ActionMenu.MainMenu, "");

            //
            // game loop
            //
            while (_playingGame)
            {
                //
                // process all flags, events, and stats
                //
                UpdateGameStatus();

                //
                // get next game action from player
                //
                HeroActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.MainMenu);

                //
                // choose an action based on the user's menu choice
                //
                switch (HeroActionChoice)
                {
                    case HeroAction.None:
                        break;

                    case HeroAction.HeroInfo:
                        _gameConsoleView.DisplayHeroInfo();
                        break;

                    case HeroAction.LookAround:
                        _gameConsoleView.DisplayLookAround();
                        break;

                    case HeroAction.Travel:
                        //
                        // get new location choice and update the current location property
                        //                        
                        _gameHero.RoomLocationID = _gameConsoleView.DisplayGetNextRoomLocation();
                        _currentLocation = _gameHotel.GetRoomLocationById(_gameHero.RoomLocationID);

                        //
                        // set the game play screen to the current location info format
                        //
                        _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentLocationInfo(_currentLocation), ActionMenu.MainMenu, "");
                        break;

                    case HeroAction.HeroLocationsVisited:
                        _gameConsoleView.DisplayLocationsVisited();
                        break;

                    case HeroAction.ListRoomLocations:
                        _gameConsoleView.DisplayListOfRoomLocations();
                        break;

                    case HeroAction.Exit:
                        _playingGame = false;
                        break;

                    default:
                        break;
                }
            }

            //
            // close the application
            //
            Environment.Exit(1);
        }

        /// <summary>
        /// initialize the player info
        /// </summary>
        private void InitializeMission()
        {
            Hero traveler = _gameConsoleView.GetInitialHeroInfo();

            _gameHero.Name = traveler.Name;
            _gameHero.Age = traveler.Age;
            _gameHero.Class = traveler.Class;
            _gameHero.RoomLocationID = 1;

            _gameHero.ExperiencePoints = 0;
            _gameHero.Health = 100;
            _gameHero.Lives = 3;
        }

        private void UpdateGameStatus()
        {
            if (!_gameHero.HasVisited(_currentLocation.RoomLocationID))
            {
                //
                // add new location to the list of visited locations if this is a first visit
                //
                _gameHero.RoomLocationsVisited.Add(_currentLocation.RoomLocationID);

                //
                // update experience points for visiting locations
                //
                _gameHero.ExperiencePoints += _currentLocation.ExperiencePoints;

                //
                // update lives for visiting locations
                //
                _gameHero.Lives += _currentLocation.Lives;
            }
        }

        #endregion
    }
}
