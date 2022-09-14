namespace IntroductionToCSharp.Demo.Class
{
    /// <summary>
    /// Demo showing class constructors, this, ToString, Equals, GetHashCode, Clone
    /// </summary>
    public class Player
    {
        public string name;
        public int health;

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

        public override string ToString()
        {
          //  string s = name + "," + health;
         //   return s;

            return $"{name},{health}";  //string initialization
        }


    }
}
