﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_TestGame
{
    class Paladin : PlayerClass
    {
        public int Stamina { get; set; }

        public Paladin(string name, string faction) : base(name, faction)
        {
            //this.Name = name;
            //this.Faction = faction;
            //this.Level = 1;
            this.Stamina = 40;
            this.HealthPoints = 160;
            this.Speed = 9;

        }
    }
}
