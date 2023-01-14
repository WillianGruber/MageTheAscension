namespace MageTheAscension
{
    public class MageTheAscensionM20Sheet
    {
        //Character Concepts
        public string? Name { get; set; }
        public string? Players { get; set; }
        public string? Chronicle { get; set; }
        public string? Nature { get; set; }
        public string? Demeanor { get; set; }
        public string? Essence { get; set; }
        public string? Affiliation { get; set; }
        public string? Sect { get; set; }
        public string? Concept { get; set; }

        //Attributes
        ////Physical
        public int Strength { get; set; } = 1;
        public int Dexterity { get; set; } = 1;
        public int Stamina { get; set; } = 1;
        ////Social
        public int Charisma { get; set; } = 1;
        public int Manipulation { get; set; } = 1;
        public int Appearance { get; set; } = 1;
        ////Mental
        public int Perception { get; set; } = 1;
        public int Intelligence { get; set; } = 1;
        public int Wits { get; set; } = 1;

        //Abilities
        ////Talents
        public int Alertness { get; set; }
        public int Art { get; set; }
        public int Athletics { get; set; }
        public int Awareness { get; set; }
        public int Brawl { get; set; }
        public int Empathy { get; set; }
        public int Expression { get; set; }
        public int Intimidation { get; set; }
        public int Leadership { get; set; }
        public int Streetwise { get; set; }
        public int Subterfuge { get; set; }

        ////Skills
        public int Crafts { get; set; }
        public int Drive { get; set; }
        public int Etiquette { get; set; }
        public int Firearms { get; set; }
        public int MartialArts { get; set; }
        public int Meditation { get; set; }
        public int Melee { get; set; }
        public int Research { get; set; }
        public int Stealth { get; set; }
        public int Survival { get; set; }
        public int Technology { get; set; }

        ////Knowledges
        public int Academics { get; set; }
        public int Computer { get; set; }
        public int Cosmology { get; set; }
        public int Enigmas { get; set; }
        public int Esoterica { get; set; }
        public int Investigation { get; set; }
        public int Law { get; set; }
        public int Medicine { get; set; }
        public int Occult { get; set; }
        public int Politics { get; set; }
        public int Science { get; set; }

        //Spheres
        public int Correspondence { get; set; }
        public int Entropy { get; set; }
        public int Forces { get; set; }
        public int Life { get; set; }
        public int Matter { get; set; }
        public int Mind { get; set; }
        public int Prime { get; set; }
        public int Spirit { get; set; }
        public int Time { get; set; }

        //Advantages
        public int Arete { get; set; } = 1;
        public int WillpowerMax { get; set; }
        public int WillpowerActual { get; set; }
        public int Quintessence { get; set; }
        public int Paradox { get; set; }
        ////Health
        public int BashingDamage { get; set; }
        public int LethalDamage { get; set; }
        public int AggravatedDamage { get; set; }
    }
}
