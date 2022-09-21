#region Demo - Namespaces

//namespaces are useful to bundle together thematically similar classes and variables
using GD.Demo;

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

            Console.WriteLine("**** DemoListFind ****");
            app.DemoListFind();
        }

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
            ages.ForEach((y) => Console.WriteLine(y));

            Console.WriteLine();

            List<int> adultAges = ages.FindAll(isAdult);
            adultAges.ForEach((y) => Console.WriteLine(y));

            Console.WriteLine();

            List<int> evenAges = ages.FindAll((age) => age % 2 == 0);
            evenAges.ForEach((y) => Console.WriteLine(y));
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
    }
}