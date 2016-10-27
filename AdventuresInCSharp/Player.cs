namespace AdventuresInCSharp {
    public class Player {
        public string Name { get; set; }
        public int Level { get; set; }

        public int MaxHealth { get; set; }
        public Bounded<int> CurrentHealth { get; } = Bounded<int>.OfRange(0, 100); // Health can be from 0-100, starts at 100

        public int MaxXp { get; set; }
        public int XpToNext { get; set; }
        public int CurrentXp { get; set; }

        public Bounded<int> Money { get; } = Bounded<int>.OfRangeStartingAtMin(0, 9999); // Money can be 0-9999, starts at 0
        public Bounded<int> Strength { get; } = Bounded<int>.OfRangeStartingAtMin(5, 100);
        public Bounded<int> Defense { get; } = Bounded<int>.OfRangeStartingAtMin(5, 100);
        public Bounded<int> Speed { get; } = Bounded<int>.OfRangeStartingAtMin(5, 100);
    }
}
