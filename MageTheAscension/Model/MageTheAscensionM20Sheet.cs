using System.Collections.Generic;

namespace MageTheAscension.Model
{
    public class MageTheAscensionM20Sheet
    {
        //Character Concepts
        public Characteristic Name { get; set; } = new Characteristic { Label = "Name", Text = string.Empty };
        public Characteristic Player { get; set; } = new Characteristic { Label = "Player", Text = string.Empty };
        public Characteristic Chronicle { get; set; } = new Characteristic { Label = "Chronicle", Text = string.Empty };
        public Characteristic Nature { get; set; } = new Characteristic { Label = "Nature", Text = string.Empty };
        public Characteristic Demeanor { get; set; } = new Characteristic { Label = "Demeanor", Text = string.Empty };
        public Characteristic Essence { get; set; } = new Characteristic { Label = "Essence", Text = string.Empty };
        public Characteristic Affiliation { get; set; } = new Characteristic { Label = "Affiliation", Text = string.Empty };
        public Characteristic Sect { get; set; } = new Characteristic { Label = "Sect", Text = string.Empty };
        public Characteristic Concept { get; set; } = new Characteristic { Label = "Concept", Text = string.Empty };

        //Attributes
        ////Physical
        public Characteristic Strength { get; set; } = new Characteristic { Label = "Strength", Text = string.Empty, Value = 1 };
        public Characteristic Dexterity { get; set; } = new Characteristic { Label = "Dexterity", Text = string.Empty, Value = 1 };
        public Characteristic Stamina { get; set; } = new Characteristic { Label = "Stamina", Text = string.Empty, Value = 1 };
        ////Social
        public Characteristic Charisma { get; set; } = new Characteristic { Label = "Charisma", Text = string.Empty, Value = 1 };
        public Characteristic Manipulation { get; set; } = new Characteristic { Label = "Manipulation", Text = string.Empty, Value = 1 };
        public Characteristic Appearance { get; set; } = new Characteristic { Label = "Appearance", Text = string.Empty, Value = 1 };
        ////Mental
        public Characteristic Perception { get; set; } = new Characteristic { Label = "Perception", Text = string.Empty, Value = 1 };
        public Characteristic Intelligence { get; set; } = new Characteristic { Label = "Intelligence", Text = string.Empty, Value = 1 };
        public Characteristic Wits { get; set; } = new Characteristic { Label = "Wits", Text = string.Empty, Value = 1 };

        //Abilities
        ////Talents
        public Characteristic Alertness { get; set; } = new Characteristic { Label = "Alertness", Text = string.Empty, Value = 0 };
        public Characteristic Art { get; set; } = new Characteristic { Label = "Art", Text = string.Empty, Value = 0 };
        public Characteristic Athletics { get; set; } = new Characteristic { Label = "Athletics", Text = string.Empty, Value = 0 };
        public Characteristic Awareness { get; set; } = new Characteristic { Label = "Awareness", Text = string.Empty, Value = 0 };
        public Characteristic Brawl { get; set; } = new Characteristic { Label = "Brawl", Text = string.Empty, Value = 0 };
        public Characteristic Empathy { get; set; } = new Characteristic { Label = "Empathy", Text = string.Empty, Value = 0 };
        public Characteristic Expression { get; set; } = new Characteristic { Label = "Expression", Text = string.Empty, Value = 0 };
        public Characteristic Intimidation { get; set; } = new Characteristic { Label = "Intimidation", Text = string.Empty, Value = 0 };
        public Characteristic Leadership { get; set; } = new Characteristic { Label = "Leadership", Text = string.Empty, Value = 0 };
        public Characteristic Streetwise { get; set; } = new Characteristic { Label = "Streetwise", Text = string.Empty, Value = 0 };
        public Characteristic Subterfuge { get; set; } = new Characteristic { Label = "Subterfuge", Text = string.Empty, Value = 0 };

        ////Skills
        public Characteristic Crafts { get; set; } = new Characteristic { Label = "Crafts", Text = string.Empty, Value = 0 };
        public Characteristic Drive { get; set; } = new Characteristic { Label = "Drive", Text = string.Empty, Value = 0 };
        public Characteristic Etiquette { get; set; } = new Characteristic { Label = "Etiquette", Text = string.Empty, Value = 0 };
        public Characteristic Firearms { get; set; } = new Characteristic { Label = "Firearms", Text = string.Empty, Value = 0 };
        public Characteristic MartialArts { get; set; } = new Characteristic { Label = "Martial Arts", Text = string.Empty, Value = 0 };
        public Characteristic Meditation { get; set; } = new Characteristic { Label = "Meditation", Text = string.Empty, Value = 0 };
        public Characteristic Melee { get; set; } = new Characteristic { Label = "Melee", Text = string.Empty, Value = 0 };
        public Characteristic Research { get; set; } = new Characteristic { Label = "Research", Text = string.Empty, Value = 0 };
        public Characteristic Stealth { get; set; } = new Characteristic { Label = "Stealth", Text = string.Empty, Value = 0 };
        public Characteristic Survival { get; set; } = new Characteristic { Label = "Survival", Text = string.Empty, Value = 0 };
        public Characteristic Technology { get; set; } = new Characteristic { Label = "Technology", Text = string.Empty, Value = 0 };

        ////Knowledges
        public Characteristic Academics { get; set; } = new Characteristic { Label = "Academics", Text = string.Empty, Value = 0 };
        public Characteristic Computer { get; set; } = new Characteristic { Label = "Computer", Text = string.Empty, Value = 0 };
        public Characteristic Cosmology { get; set; } = new Characteristic { Label = "Cosmology", Text = string.Empty, Value = 0 };
        public Characteristic Enigmas { get; set; } = new Characteristic { Label = "Enigmas", Text = string.Empty, Value = 0 };
        public Characteristic Esoterica { get; set; } = new Characteristic { Label = "Esoterica", Text = string.Empty, Value = 0 };
        public Characteristic Investigation { get; set; } = new Characteristic { Label = "Investigation", Text = string.Empty, Value = 0 };
        public Characteristic Law { get; set; } = new Characteristic { Label = "Law", Text = string.Empty, Value = 0 };
        public Characteristic Medicine { get; set; } = new Characteristic { Label = "Medicine", Text = string.Empty, Value = 0 };
        public Characteristic Occult { get; set; } = new Characteristic { Label = "Occult", Text = string.Empty, Value = 0 };
        public Characteristic Politics { get; set; } = new Characteristic { Label = "Politics", Text = string.Empty, Value = 0 };
        public Characteristic Science { get; set; } = new Characteristic { Label = "Science", Text = string.Empty, Value = 0 };

        //Spheres
        public Characteristic Correspondence { get; set; } = new Characteristic { Label = "Correspondence", Text = string.Empty, Value = 0 };
        public Characteristic Entropy { get; set; } = new Characteristic { Label = "Entropy", Text = string.Empty, Value = 0 };
        public Characteristic Forces { get; set; } = new Characteristic { Label = "Forces", Text = string.Empty, Value = 0 };
        public Characteristic Life { get; set; } = new Characteristic { Label = "Life", Text = string.Empty, Value = 0 };
        public Characteristic Matter { get; set; } = new Characteristic { Label = "Matter", Text = string.Empty, Value = 0 };
        public Characteristic Mind { get; set; } = new Characteristic { Label = "Mind", Text = string.Empty, Value = 0 };
        public Characteristic Prime { get; set; } = new Characteristic { Label = "Prime", Text = string.Empty, Value = 0 };
        public Characteristic Spirit { get; set; } = new Characteristic { Label = "Spirit", Text = string.Empty, Value = 0 };
        public Characteristic Time { get; set; } = new Characteristic { Label = "Time", Text = string.Empty, Value = 0 };

        //Advantages
        public Characteristic Arete { get; set; } = new Characteristic { Label = "Arete", Value = 1 };
        public Characteristic WillpowerMax { get; set; } = new Characteristic { Label = "WillpowerMax" };
        public Characteristic WillpowerActual { get; set; } = new Characteristic { Label = "WillpowerActual" };
        public Characteristic Quintessence { get; set; } = new Characteristic { Label = "Quintessence" };
        public Characteristic Paradox { get; set; } = new Characteristic { Label = "Paradox" };

        //Collections
        public List<Characteristic> Header { get; set; }
        public List<Characteristic> Physical { get; set; }
        public List<Characteristic> Social { get; set; }
        public List<Characteristic> Mental { get; set; }
        public List<Characteristic> Talents { get; set; }
        public List<Characteristic> Skills { get; set; }
        public List<Characteristic> Knowledges { get; set; }
        public List<Characteristic> Spheres { get; set; }

        public MageTheAscensionM20Sheet()
        {
            Header = new List<Characteristic> { Name, Player, Chronicle, Nature, Demeanor, Essence, Affiliation, Sect, Concept };
            Physical = new List<Characteristic> { Strength, Dexterity, Stamina };
            Social = new List<Characteristic> { Charisma, Manipulation, Appearance };
            Mental = new List<Characteristic> { Perception, Intelligence, Wits };
            Talents = new List<Characteristic> { Alertness, Art, Athletics, Awareness, Brawl, Empathy, Expression, Intimidation, Leadership, Streetwise, Subterfuge };
            Skills = new List<Characteristic> { Crafts, Drive, Etiquette, Firearms, MartialArts, Meditation, Melee, Research, Stealth, Survival, Technology };
            Knowledges = new List<Characteristic> { Academics, Computer, Cosmology, Enigmas, Esoterica, Investigation, Law, Medicine, Occult, Politics, Science };
            Spheres = new List<Characteristic> { Correspondence, Entropy, Forces, Life, Matter, Mind, Prime, Spirit, Time };
        }
    }
}
