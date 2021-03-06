﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_TestGame
{
    class RabidWolf : Enemy
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int>
            {
                {"Bite", 5 },
                {"Headbutt", 5 },
                {"Whip", 10 }
            };

        public RabidWolf()
        {
            this.HealthPoints = 30;
            this.Name = "Rabid Wolf";
        }

        public void WolfAttack(PlayerClass p)
        {
            Attack(p, Attacks, this.Name);
            
        }

    }
}
