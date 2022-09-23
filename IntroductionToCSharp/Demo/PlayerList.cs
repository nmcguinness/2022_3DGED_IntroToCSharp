namespace GD.Demo
{
    /// <summary>
    /// Demo - indexers, generics, interfaces, structs
    /// </summary>
    public class PlayerList //store of Player objects
    {
        private List<Player> players;

        //get/set - No! Let's do something different i.e. indexer

        public Player this[int index]
        {
            get { return players[index]; }
        }

        public List<Player> List
        {
            get { return players; }
        }

        public int Count
        {
            get
            {
                return players.Count;
            }
        }

        //public int Size() { return players.Count;  }

        public PlayerList()
        {
            //notice its not until construction that we create the space for the list in RAM
            //players = new List<Player>();
        }

        //add, remove, search
        //public void Add(Player p)  //Vers. A
        //{
        //    players.Add(p);
        //}

        //public void Add(Player p) //Vers. B
        //{
        //    if (players == null)
        //        return;
        //    players.Add(p);
        //}

        //public void Add(Player p) //Vers. C
        //{
        //    if (players == null)
        //        throw new NullReferenceException("players cannot be null!");
        //    players.Add(p);
        //}

        //public void Add(Player p) //Vers. D
        //{
        //    if (players == null)
        //        players = new List<Player>();

        //    players.Add(p);
        //}

        public void Add(Player p) //Vers. E  - This is the winner!
        {
            //adv - we only create list when we add first
            //disadv - we have a CPU expenditure (time) when we add first
            if (players == null)
                players = new List<Player>();

            //the ? is just a succinct form of either of the code examples below
            //if(players != null)
            //    players.Add(p);
            //if (players is not null)
            //    players.Add(p);

            players?.Add(p);
        }

        public List<Player> FindAll(Predicate<Player> pred)
        {
            //List<Player> results = players.FindAll(pred);
            //return results;

            //why bother with a local results variable?
            return players.FindAll(pred);
        }

        //ToString, GetHashCode
    }
}