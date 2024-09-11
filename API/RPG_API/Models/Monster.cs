﻿using RPG_API.Models.Base;

namespace RPG_API.Models
{
    public enum Type
    {
        Easy,
        Medium,
        Hard,
        Boss
    }
    public class Monster : ModelBase
    {
        public Type Type { get; set; }

        public string Name { get; set; }
        public int XpGiven { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int Health { get; set; }
        public Quest? Quest { get; set; }
        public Map Map { get; set; }
    }
}
