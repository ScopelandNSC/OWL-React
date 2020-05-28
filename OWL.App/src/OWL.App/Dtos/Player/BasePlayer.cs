﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace OWL.App.Dtos.Player
{
    public class BasePlayer
    {
        public PlayerPersonalDetails personalDetails { get; set; }

        public PlayerHeroDetails heroDetails { get; set; }

        public IEnumerable<PlayerTeamDetails> teamDetails { get; set; }
    }
}