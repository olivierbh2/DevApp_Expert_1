﻿namespace RPG_API.Models
{
    public class CharacterDTOLogin
    {
        public string Name { get; set; }
        public int Xp { get; set; }
        public static CharacterDTOLogin CharacterToDTO(CharacterDTOLogin c)
        {
            return new CharacterDTOLogin { Name = c.Name, Xp = c.Xp };
        }

    }
}
