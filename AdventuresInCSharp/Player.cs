namespace AdventuresInCSharp
{
    public class Player
    {
        private static string _name;
        public static string Name //change to this format.
        {
            get { return _name; }
            set { _name = value; }
        }
        private static int _level;
        public static int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        private static int _healthMax;
        public static int MaxHealth
        {
            get { return _healthMax; }
            set { _healthMax = value; }
        }
        private static int _healthCurrentMax;
        public static int CurrentMaxHealth
        {
            get { return _healthCurrentMax; }
            set { _healthCurrentMax = value; }
        }
        private static int _healthCurrent;
        public static int CurrentHealth
        {
            get { return _healthCurrent; }
            set { _healthCurrent = value; }
        }
        private static int _xpMax;
        public static int MaxXp
        {
            get { return _xpMax; }
            set { _xpMax = value; }
        }
        private static int _xpToNext;
        public static int XpToNext
        {
            get { return _xpToNext; }
            set { _xpToNext = value; }
        }
        private static int _xpCurrent;
        public static int CurrentXp
        {
            get { return _xpCurrent; }
            set { _xpCurrent = value; }
        }
        private static int _moneyMax;
        public static int MaxMoney
        {
            get { return _moneyMax; }
            set { _moneyMax = value; }
        }
        private static int _moneyCurrent;
        public static int CurrentMoney
        {
            get { return _moneyCurrent; }
            set { _moneyCurrent = value; }
        }
        private static int _strBase;
        public static int BaseStrength
        {
            get { return _strBase; }
            set { _strBase = value; }
        }
        private static int _strMax;
        public static int MaxStrength
        {
            get { return _strMax; }
            set { _strMax = value; }
        }
        private static int _strCurrent;
        public static int CurrentStrength
        {
            get { return _strCurrent; }
            set { _strCurrent = value; }
        }
        private static int _defBase;
        public static int BaseDefense
        {
            get { return _defBase; }
            set { _defBase = value; }
        }
        private static int _defMax;
        public static int MaxDefense
        {
            get { return _defMax; }
            set { _defMax = value; }
        }
        private static int _defCurrent;
        public static int CurrentDefense
        {
            get { return _defCurrent; }
            set { _defCurrent = value; }
        }
        private static int _spdBase;
        public static int BaseSpeed
        {
            get { return _spdBase; }
            set { _spdBase = value; }
        }
        private static int _spdMax;
        public static int MaxSpeed
        {
            get { return _spdMax; }
            set { _spdMax = value; }
        }
        private static int _spdCurrent;
        public static int CurrentSpeed
        {
            get { return _spdCurrent; }
            set { _spdCurrent = value; }
        }

        // To Be Removed...
        /*---------------------------------------------------
                // _name
                public static string getName()
                {
                    return _name;
                }

                public static void setName(string name)
                {
                    _name = name;
                }

                // _level... lvl 30 will be the max lvl.. at 536,870,912 XP
                public static int getLevel()
                {
                    return _level;
                }

                public static void setLevel(int level)
                {
                    _level = level;
                }

                // _healthMax
                public static int getHealthMax()
                {
                    return _healthMax;
                }

                public static void setHealthMax()
                {
                    _healthMax = 1000;
                }

                // _healthCurrentMax
                public static int getHealthCurrentMax()
                {
                    return _healthCurrentMax;
                }

                public static void setHealthCurrentMax(int x)
                {
                    _healthCurrentMax = _level * 10 + x; // level x 10 + Armor Mods... ie.. level 2 with +2 mod will equal 22
                }

                // _healthCurrent
                public static int getHealthCurrent()
                {
                    return _healthCurrent;
                }

                public static void setHealthCurrent(int x)
                {
                    _healthCurrent = x;
                }

                // _xpMax
                public static int getXpMax()
                {
                    return _xpMax;
                }

                public static void setXpMax(int x)
                {
                    _xpMax = 999999999;
                }

                // _xpToNext
                public static int getXpToNext()
                {
                    return _xpToNext;
                }

                public static void setXpToNext()
                {
                    _xpToNext = 2 ^ (_level + 1);
                }

                // _xpCurrent
                public static int getXpCurrent()
                {
                    return _xpCurrent;
                }

                public static void setXpCurrent(int x)
                {
                    _xpCurrent = x;
                }

                // _moneyMax
                public static int getMoneyMax()
                {
                    return _moneyMax;
                }

                public static void setMoneyMax(int x)
                {
                    _moneyMax = x;
                }

                // _moneyCurrent
                public static int getMoneyCurrent()
                {
                    return _moneyCurrent;
                }

                public static void setMoneyCurrent(int x)
                {
                    _moneyCurrent = x;
                }

                // _strBase
                public static int getStrBase()
                {
                    return _strBase;
                }

                public static void setStrBase()
                {
                    _strBase = 1;
                }

                // _strMax
                public static int getStrMax()
                {
                    return _strMax;
                }

                public static void setStrMax()
                {
                    _strMax = 1000;
                }

                // _strCurrent
                public static int getStrCurrent()
                {
                    return _strCurrent;
                }

                public static void setStrCurrent(int x)
                {
                    _strCurrent = _level + _strBase + x;
                }

                // _defBase
                public static int getDefBase()
                {
                    return _defBase;
                }

                public static void setDefBase()
                {
                    _defBase = 1;
                }

                // _defMax
                public static int getDefMax()
                {
                    return _defMax;
                }

                public static void setDefMax()
                {
                    _defMax = 1000;
                }

                // _defCurrent
                public static int getDefCurrent()
                {
                    return _defCurrent;
                }

                public static void setDefCurrent(int x)
                {
                    _defCurrent = _level + _defBase + x;
                }

                // _spdBase
                public static int getSpdBase()
                {
                    return _spdBase;
                }

                public static void setSpdBase()
                {
                    _spdBase = 1;
                }

                // _spdMax
                public static int getSpdMax()
                {
                    return _spdMax;
                }

                public static void setSpdMax()
                {
                    _spdMax = 1000;
                }

                // _spdCurrent
                public static int getSpdCurrent()
                {
                    return _spdCurrent;
                }

                public static void setSpdCurrent(int x)
                {
                    _spdCurrent = _level + _spdBase + x;
                }
          --------------------------------------------------*/
    }
}