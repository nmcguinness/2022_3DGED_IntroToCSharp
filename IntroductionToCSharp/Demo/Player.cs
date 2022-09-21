namespace GD.Demo
{
    /// <summary>
    /// Simple representation of a Player to demonstrate constructors, this, ToString, Equals, GetHashCode
    /// </summary>
    public class Player
    {
        #region Variables

        public string name;
        public int health;

        #endregion Variables

        #region Constructors

        ////public Player()
        ////{
        ////    this.name = "";
        ////    this.health = 0;
        ////}

        public Player() : this("", 0)
        {
        }

        public Player(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        #endregion Constructors

        #region Common

        public override string ToString()
        {
            //  string s = name + "," + health;
            //   return s;

            //string initialization
            return $"n:{name},h:{health}";
        }

        public bool Equals(Player other)
        {
            if (this == other)
                return true;

            if (other == null)
                return false;

            if (name.Equals(other.name) && health == other.health)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, health);
        }

        #endregion Common
    }
}