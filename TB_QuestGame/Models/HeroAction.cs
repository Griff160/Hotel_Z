﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// enum of all possible player actions
    /// </summary>
    public enum HeroAction
    {
        None,
        MissionSetup,
        LookAround,
        LookAt,
        PickUpItem,
        PickUpTreasure,
        PutDownItem,
        PutDownTreasure,
        Travel,
        HeroInfo,
        HeroInventory,
        HeroTreasure,
        HeroLocationsVisited,
        ListRoomLocations,
        ListItems,
        ListTreasures,
        Exit
    }
}
