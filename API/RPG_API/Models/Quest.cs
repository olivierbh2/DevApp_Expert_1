﻿using RPG_API.Models.Base;

namespace RPG_API.Models
{
    public class Quest : ModelBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Reward { get; set; }
        public int? ItemId { get; set; }
        public Item? item { get; set; }
        public ICollection<Character> Characters { get; set; }
        public ICollection<Monster> Monster { get; set; }

    }
}
