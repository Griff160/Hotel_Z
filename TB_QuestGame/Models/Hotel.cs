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
            set { _roomLocations = value; }
        }

        #endregion

        #region ***** constructor *****

        //
        // default Hotel constructor
        //
        public Hotel()
        {
            //
            // add all of the hotel objects to the game
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

        #region ***** define methods to return game element objects and information *****

        /// <summary>
        /// determine if the Space-Time Location Id is valid
        /// </summary>
        /// <param name="roomLocationId">true if Space-Time Location exists</param>
        /// <returns></returns>
        public bool IsValidRoomLocationId(int roomLocationId)
        {
            List<int> roomLocationIds = new List<int>();

            //
            // create a list of space-time location ids
            //
            foreach (RoomLocation stl in _roomLocations)
            {
                roomLocationIds.Add(stl.RoomLocationID);
            }

            //
            // determine if the space-time location id is a valid id and return the result
            //
            if (roomLocationIds.Contains(roomLocationId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// determine if a location is accessible to the player
        /// </summary>
        /// <param name="roomLocationId"></param>
        /// <returns>accessible</returns>
        public bool IsAccessibleLocation(int roomLocationId)
        {
            RoomLocation roomLocation = GetRoomLocationById(roomLocationId);
            if (roomLocation.Accessable == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// return the next available ID for a SpaceTimeLocation object
        /// </summary>
        /// <returns>next SpaceTimeLocationObjectID </returns>
        public int GetMaxRoomLocationId()
        {
            int MaxId = 0;

            foreach (RoomLocation roomLocation in RoomLocations)
            {
                if (roomLocation.RoomLocationID > MaxId)
                {
                    MaxId = roomLocation.RoomLocationID;
                }
            }

            return MaxId;
        }

        /// <summary>
        /// get a SpaceTimeLocation object using an Id
        /// </summary>
        /// <param name="Id">space-time location ID</param>
        /// <returns>requested space-time location</returns>
        public RoomLocation GetRoomLocationById(int Id)
        {
            RoomLocation roomLocation = null;

            //
            // run through the space-time location list and grab the correct one
            //
            foreach (RoomLocation location in _roomLocations)
            {
                if (location.RoomLocationID == Id)
                {
                    roomLocation = location;
                }
            }

            //
            // the specified ID was not found in the universe
            // throw an exception
            //
            if (roomLocation == null)
            {
                string feedbackMessage = $"The Room {Id} does not exist in the hotel.";
                throw new ArgumentException(Id.ToString(), feedbackMessage);
            }

            return roomLocation;
        }

        #endregion


    }
}
