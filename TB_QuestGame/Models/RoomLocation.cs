using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    public class RoomLocation
    {
        #region FIELDS

        private string _commonName;
        private int _spaceTimeLocationID; // must be a unique value for each object
        private int _universalDate;
        private string _universalLocation;
        private string _description;
        private string _generalContents;
        private bool _accessable;
        private int _experiencePoints;
        private int _lives;

        #endregion

        #region PROPERTIES

        public string CommonName
        {
            get { return _commonName; }
            set { _commonName = value; }
        }

        public int RoomLocationID
        {
            get { return _spaceTimeLocationID; }
            set { _spaceTimeLocationID = value; }
        }

        public int UniversalDate
        {
            get { return _universalDate; }
            set { _universalDate = value; }
        }

        public string UniversalLocation
        {
            get { return _universalLocation; }
            set { _universalLocation = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string GeneralContents
        {
            get { return _generalContents; }
            set { _generalContents = value; }
        }

        public bool Accessable
        {
            get { return _accessable; }
            set { _accessable = value; }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set { _experiencePoints = value; }
        }

        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }
        #endregion


        #region CONSTRUCTORS



        #endregion


        #region METHODS



        #endregion
    }
}
