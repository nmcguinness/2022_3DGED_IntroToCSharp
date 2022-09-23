//namespaces are useful to bundle together thematically similar classes and variables
using GD.Demo;
using IntroductionToCSharp.Demo;

#region Demo - Namespaces

namespace GDMath
{
    //we can nest namespaces
    namespace GDConstants
    {
        public class MathStuff
        {
            public static readonly double PI = 3.15f;
        }
    }

    namespace DeadPixel
    {
        public class SocketConnection
        {
        }
    }

    namespace ThirdParty
    {
        public class SocketConnection
        {
        }
    }
}

#endregion Demo - Namespaces

namespace GD
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Program app = new Program();
            //Console.WriteLine("**** DemoNamespaces ****");
            //app.DemoNamespaces();

            //Console.WriteLine("**** DemoClass ****");
            //app.DemoClass();

            //Console.WriteLine("**** DemoAnotherClass ****");
            //app.DemoAnotherClass();

            //Console.WriteLine("**** DemoPlayer ****");
            //app.DemoPlayer();

            //Console.WriteLine("**** DemoShallowDeepCopy ****");
            //app.DemoShallowDeepCopy();

            //Console.WriteLine("**** DemoOperatorOverloading ****");
            //app.DemoOperatorOverloading();

            //Console.WriteLine("**** DemoList ****");
            //app.DemoList();

            //Console.WriteLine("**** DemoListPrint ****");
            //app.DemoListPrint();

            //Console.WriteLine("**** DemoListFind ****");
            //app.DemoListFind();

            //Console.WriteLine("**** DemoListFindPlayer ****");
            //app.DemoListFindPlayer();

            //Console.WriteLine("**** DemoListSortPlayer ****");
            //app.DemoListSortPlayer();

            //Console.WriteLine("**** DemoListSortPlayerType ****");
            //app.DemoListSortPlayerType();

            //Console.WriteLine("**** DemoFunc ****");
            //app.DemoFunc();

            //Console.WriteLine("**** DemoFuncAsParameter ****");
            //app.DemoFuncAsParameter();

            //Console.WriteLine("**** DemoAction ****");
            //app.DemoAction();

            //Console.WriteLine("**** DemoPlayerList ****");
            //app.DemoPlayerList();

            Console.WriteLine("**** DemoPlayerListInheritance ****");
            app.DemoPlayerListInheritance();
        }

        #region Demo - Inheritance from existing C# class

        private void DemoPlayerListInheritance()
        {
            var playerListInheritance = new PlayerListInheritance();

            playerListInheritance.Add(new Player("Zachariah Obediah", 100), true);
            playerListInheritance.Add(new Player("jack", 100), true);
            playerListInheritance.Add(new Player("jack", 100), true);
            playerListInheritance.Add(new Player("jill", 101, PlayerType.Assassin), false);
            playerListInheritance.Add(new Player("jill", 101, PlayerType.Assassin), false);

            //WriteLine will automatically call the ToString
            //Console.WriteLine(playerListInheritance.ToString());
            Console.WriteLine(playerListInheritance);
        }

        #endregion Demo - Inheritance from existing C# class

        #region Demo - Composition

        private void DemoPlayerList()
        {
            // PlayerList playerList = new PlayerList();
            var playerList = new PlayerList();

            playerList.Add(new Player("jack", 100));
            playerList.Add(new Player("jill", 101, PlayerType.Assassin));
            playerList.Add(new Player("Zack", 101, PlayerType.Thief)); //our only result
            playerList.Add(new Player("Alan", 101, PlayerType.Mage));

            //let's print out the players - use the new toy = indexer
            for (int i = 0; i < playerList.Count; i++)
            {
                Console.WriteLine(playerList[i]); //indexer
                // Console.WriteLine(playerList.Get(i));
            }

            Console.WriteLine();

            //don't give direct access to the list (i.e. using List property below)
            //List<Player> results = playerList.List.FindAll((p) => p.health > 50);

            //instead we search using FindAll - since that doesnt expose the list
            List<Player> results1 = playerList.FindAll((p) => p.health > 50);

            //use our new FindAll to find all players containing z (case-insensitive and with type Hunter || Thief
            Predicate<Player> pred = (player) =>
                        player.name.ToLower().Contains("z")
                        && (player.playerType == PlayerType.Hunter
                        || player.playerType == PlayerType.Thief);

            List<Player> results2 = playerList.FindAll(pred);
            results2.ForEach((p) => Console.WriteLine(p));
        }

        #endregion Demo - Composition

        #region Demo - Namespaces

        private void DemoNamespaces()
        {
            double x = GDMath.GDConstants.MathStuff.PI;
            GDMath.DeadPixel.SocketConnection sock1 = new GDMath.DeadPixel.SocketConnection();
            GDMath.ThirdParty.SocketConnection sock2 = new GDMath.ThirdParty.SocketConnection();
        }

        #endregion Demo - Namespaces

        #region Demo - Class

        private void DemoClass()
        {
            //Demo.Class.Player p
            //  = new Demo.Class.Player("jane smith", 100);
            Player p1 = new Player("jane smith", 100);
            Console.WriteLine(p1);

            //test the Equals for different
            Player p2 = new Player("bob jones", 100);
            bool areEquals = p1.Equals(p2);
            Console.WriteLine($"p1 and p2 are equals? {areEquals}");

            //test the Equals for same
            Player p3 = new Player("jane smith", 100);
            areEquals = p1.Equals(p3);
            Console.WriteLine($"p1 and p3 are equals? {areEquals}");

            //test the Equals for null
            Player p4 = null;
            areEquals = p3.Equals(p4);
            Console.WriteLine($"p3 and null are equals? {areEquals}");

            //test the Equals for same object twice (i.e. point to same in RAM)
            //this is an example of a SHALLOW COPY
            Player p5 = p1;
            areEquals = p1.Equals(p5);
            Console.WriteLine($"p1 and p5 are equals? {areEquals}");

            Console.WriteLine($"p1 hashCode is {p1.GetHashCode()}"); //jane
            Console.WriteLine($"p2 hashCode is {p2.GetHashCode()}"); //bob
            Console.WriteLine($"p3 hashCode is {p3.GetHashCode()}"); //jane
        }

        private void DemoAnotherClass()
        {
            Vector3 v1 = new Vector3(1, 2, 3);
            Console.WriteLine(v1);

            //properties - get
            double valueX = v1.X;

            //properties - set
            v1.X = 100;

            //check x has changed!
            Console.WriteLine(v1);
        }

        #endregion Demo - Class

        #region Demo - Composition

        private void DemoPlayer()
        {
            Vector3 position = new Vector3(-10, 100, 50);
            Vector3 rotation = new Vector3(0, 45, 0);
            Vector3 scale = new Vector3(1, 1, 1);

            Transform p1Transform = new Transform(position, rotation, scale);

            Transform p2Transform = new Transform(new Vector3(5, 10, 5));

            bool areEquals = p1Transform.Equals(p2Transform);
            Console.WriteLine($"areEquals? {areEquals}");

            //can we speed up the process of making vector3 objects like (1,1,1) or (0,1,0)?
            Vector3 up = Vector3.UnitY;

            //we can use the new constants to more rapidly create a transform
            Transform p3Transform = new Transform(Vector3.Zero, Vector3.Zero, Vector3.One);

            //lets see what our new transform object looks like as a string
            Console.WriteLine(p3Transform.ToString());
        }

        #endregion Demo - Composition

        #region Demo - Clone

        private void DemoShallowDeepCopy()
        {
            Console.WriteLine("shallow demo....");
            //shallow demo
            Vector3 v1 = new Vector3(1, 2, 3);
            Vector3 v2 = v1.GetShallowCopy() as Vector3;
            Console.WriteLine($"v1: {v1}");
            Console.WriteLine($"v2: {v2}");

            //since v2 points to v1 i.e. same object in RAM
            //changing v2 will change v1 e.g.
            v2.X = -1000;
            Console.WriteLine($"v1: {v1}");
            Console.WriteLine($"v2: {v2}");

            Console.WriteLine("deep demo....");
            //deep demo
            Vector3 v3 = new Vector3(10, 20, 30);

            //typecast using 'as' is more desirable because it returns a null instead of crashing at runtime
            //  Vector3 v4 = (Vector3)v3.Clone();
            Vector3 v4 = v3.Clone() as Vector3;

            Console.WriteLine($"v3: {v3}");
            Console.WriteLine($"v4: {v4}");

            //since v3 and v4 point to DISTINCT objects
            //changing v4 will NOT change v3 e.g.
            v4.Z = 9999;
            Console.WriteLine($"v3: {v3}");
            Console.WriteLine($"v4: {v4}");
            //Player - transform, mesh, material, controller
        }

        #endregion Demo - Clone

        #region Demo - Operator Overloading

        private void DemoOperatorOverloading()
        {
            Vector3 v1 = new Vector3(1, 2, 3);
            Vector3 v2 = new Vector3(1, 2, 3);
            Vector3 v3 = new Vector3(2, 4, 6);

            //on the rhs below we are using our new operator ==
            bool areEqual = v1 == v2;
            Console.WriteLine(areEqual);

            bool areDifferent = v1 != v3;
            Console.WriteLine(areDifferent);

            //lets add some arithmetic operators e.g. +, *
            Vector3 vSum = v1 + v3;
            Console.WriteLine(vSum);

            //uses scalar premultiply operator (e.g. *)
            Vector3 v4 = 12 * v1;
            Console.WriteLine(v4);

            Vector3 v5 = v1 * 100;
            Console.WriteLine(v5);

            //typecasting from larger byte size to smaller is dangerous!
            int x = 257;
            byte y = (byte)x;
            Console.WriteLine($"y is {y}");

            //lets try out Length, Normalize, Distance
            Vector3 v6 = new Vector3(1, 2, 3);
            double len = v6.Length();
            Console.WriteLine($"length of v6 is {len}");

            //v6Norm is a unit vector of v6 because its length = 1
            Vector3 v6Norm = v6.Normalize();
            Console.WriteLine(v6Norm);
        }

        #endregion Demo - Operator Overloading

        #region Demo - List

        private void DemoListSortPlayerType()
        {
            List<Player> players = new List<Player>
            {
                new Player("max", 99, PlayerType.Assassin),
                 new Player("pax", 25, PlayerType.Thief),
                  new Player("frank", 80, PlayerType.Hunter),
            };

            int direction = 1; //1 = Asc, -1 = Desc
            players.Sort((a, b) => direction * (a.playerType - b.playerType));
            players.ForEach((player) => Console.WriteLine(player));
        }

        private int SortByHealthAsc(Player a, Player b)
        {
            if (a.health == b.health)
                return 0;
            else if (a.health < b.health)
                return -1;
            else
                return 1;
        }

        private void DemoListSortPlayer()
        {
            List<Player> players = new List<Player>
            {
                new Player("Andy", 80),
                 new Player("bea", 100),
                  new Player("ciaran", 50),
                   new Player("daphne", 75),
            };
            players.Sort(SortByHealthAsc);
            players.ForEach((player) => Console.WriteLine(player));

            Console.WriteLine();
            int direction = -1;  //1 = Asc, -1 = Desc
            players.Sort((a, b) => direction * (a.health - b.health));
            players.ForEach((player) => Console.WriteLine(player));
        }

        //predicate used in a Find, FindAll, Remove, RemoveAll
        private bool HealthGreaterEqual(Player p)
        {
            return p.health >= 80 && p.health <= 90;
        }

        private void DemoListFindPlayer()
        {
            List<Player> players = new List<Player>
            {
                new Player("Andy", 80),
                 new Player("bea", 100),
                  new Player("ciaran", 50),
                   new Player("daphne", 75),
            };

            //find all players with health >=80
            List<Player> results = players.FindAll(HealthGreaterEqual);
            results.ForEach((player) => Console.WriteLine(player));

            //remove last results to re-use this list - why not!?
            results.Clear();
            Console.WriteLine();

            //lets do same thing but with control over thresholds
            int lowerThreshold = 80;
            int upperThreshold = 90;
            results = players.FindAll(
                (player) =>
                player.health >= lowerThreshold &&
                player.health <= upperThreshold
            );
            results.ForEach((player) => Console.WriteLine(player));

            //remove last results to re-use this list - why not!?
            results.Clear();
            Console.WriteLine();

            //find all players with name containing "a"
            string targetString = "an";
            results = players.FindAll(
                (p) =>
                p.name.ToLower().Contains(targetString)
                );
            results.ForEach((p) => Console.WriteLine($"Player: {p}"));

            //lets use another List method that uses a Predicate
            int findIndex = players.FindIndex(0, (p) => p.health == 50);
            Console.WriteLine($"Found player with health == 50 at {findIndex}");

            //remove last results to re-use this list - why not!?
            results.Clear();
            Console.WriteLine();

            //lets use another List method that uses a Predicate
            int removeCount = players.RemoveAll((p) => p.health != 100);
            players.ForEach((player) => Console.WriteLine(player));
        }

        public bool isAdult(int age)
        {
            return age >= 18;
        }

        private void DemoListFind()
        {
            List<int> ages = new List<int>
            {
                16, 18, 21, 19, 24, 32
            };
            ages.ForEach((age) => Console.WriteLine(age));

            Console.WriteLine();

            List<int> adultAges = ages.FindAll(isAdult);
            adultAges.ForEach((age) => Console.WriteLine(age));

            Console.WriteLine();

            List<int> evenAges = ages.FindAll((age) => age % 2 == 0);
            evenAges.ForEach((age) => Console.WriteLine(age));
        }

        public void print(int x)
        {
            Console.WriteLine(x);
        }

        private void DemoListPrint()
        {
            List<int> health = new List<int>
            {
                99, 45, 56, 12, 10, 0, 100
            };

            //print using a print() method
            //health.ForEach(print);

            //print using a lambda expression
            health.ForEach((x) => Console.WriteLine(x));

            //print squares of values
            health.ForEach((x) => Console.WriteLine(x * x));
        }

        private void DemoList()
        {
            List<string> nameList = new List<string>();
            nameList.Add("alan");
            nameList.Add("bob");
            nameList.Add("ciara");

            //print
            for (int i = 0; i < nameList.Count; i++)
                Console.WriteLine(nameList[i]);

            //print
            foreach (string name in nameList)
                Console.WriteLine(name);

            if (nameList.Contains("bob"))
                Console.WriteLine("bob was found!");

            nameList.Remove("ciara");
            nameList.RemoveAt(0);
            nameList.Clear();
        }

        #endregion Demo - List

        #region Func Action Predicate

        //Func - Func<a,b,...,d, returntype> - function with 1+ params and return type
        //Action - Action<a,b,..,d> - function with 1+ params and NO return type
        //Predicate - bool Predicate<a> - func with 1 params and boolen return type

        public void MultiplyByTwo(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i] * 2;
            }
        }

        public void Modify(List<int> numbers,
            Func<int, int> transform)
        {
            //pre-condition?

            for (int i = 0; i < numbers.Count; i++)
                numbers[i] = transform(numbers[i]);

            //post-condition?
        }

        public void DemoListFunc()
        {
            List<int> numbers = new List<int>
            {
                1,6,2,8,9,4
            };

            Modify(numbers, (number) => number * 2);
            Modify(numbers, (number) => number * 4 - 10);
        }

        /// <summary>
        /// Example of a Func
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int add(int x, int y)
        {
            return x + y;
        }

        public int divide(int x, int y)
        {
            if (y == 0) throw new DivideByZeroException("y cannot be zero!");
            return x / y;
        }

        private void DemoFunc()
        {
            //use Func to store the address of another function/method
            Func<int, int, int> theFunc = add;

            //call the function we point to using the variable name theFunc
            int result = theFunc(3, 4);
            Console.WriteLine(result);

            //we can make theFunc point to a different function
            theFunc = divide;
            result = theFunc(3, 4);
            Console.WriteLine(result);
        }

        private List<int> Transform(List<int> list, Func<int, int> func)
        {
            List<int> results = new List<int>();
            foreach (int x in list)
                results.Add(func(x));
            return results;
        }

        private void DemoFuncAsParameter()
        {
            List<int> numbers = new List<int> { 10, 17, 32, 56, 77 };
            Func<int, int> myFunc = (number) => number * number;
            List<int> results = Transform(numbers, myFunc);
            results.ForEach((number) => Console.WriteLine(number));
        }

        /// <summary>
        /// Example of an Action
        /// </summary>
        /// <param name="freq"></param>
        /// <param name="durationMs"></param>
        private void PlaySound(int freq, int durationMs)
        {
            Console.Beep(freq, durationMs);
        }

        private void DemoAction()
        {
            Action<int, int> myThing = PlaySound;
            //yes, I know the 1000 isnt used but stop focusing on this!
            myThing(5000, 2000);
        }

        #endregion Func Action Predicate
    }
}