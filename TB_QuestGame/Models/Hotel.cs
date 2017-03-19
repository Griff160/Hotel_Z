using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public class Hotel
    {
        #region ***** define all lists to be maintained by the Universe object *****

        //
        // list of all space-time locations
        //
        private List<RoomLocation> _roomLocations;

        public List<RoomLocation> RoomLocations
        {
            get { return _roomLocations; }
            set { _RoomLocations = value; }
        }

        #endregion

        #region ***** constructor *****

        //
        // default Universe constructor
        //
        public Hotel()
        {
            //
            // add all of the universe objects to the game
            // 
            IntializeHotel();
        }

        #endregion

        #region ***** define methods to initialize all game elements *****

        /// <summary>
        /// initialize the Hotel with all of the room locations
        /// </summary>
        private void IntializeHotel()
        {
            _roomLocations = HotelObjects.RoomLocations;
        }

        #endregion


    }
}
