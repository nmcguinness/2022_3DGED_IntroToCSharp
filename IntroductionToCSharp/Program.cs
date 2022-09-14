
//used by Player since its in a different namespace than where its called i.e. Program
using IntroductionToCSharp.Demo.Class;

#region Demo - Namespace
//namespaces are useful to bundle together thematically similar classes and variables
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
#endregion

namespace IntroductionToCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();
            Console.WriteLine("**** DemoNamespaces ****");
            app.DemoNamespaces();

            Console.WriteLine("**** DemoClass ****");
            app.DemoClass();

            Console.WriteLine("**** DemoAnotherClass ****");
            app.DemoAnotherClass();
        }

        private void DemoAnotherClass()
        {
            Vector3 v1 = new Vector3(1,2,3);
            Console.WriteLine(v1);

            //properties - get
            float valueX = v1.X;

            //properties - set
            v1.X = 100;
            
            //check x has changed!
            Console.WriteLine(v1);
        }

        private void DemoNamespaces()
        {
            double x = GDMath.GDConstants.MathStuff.PI;
            GDMath.DeadPixel.SocketConnection sock1 = new GDMath.DeadPixel.SocketConnection();
            GDMath.ThirdParty.SocketConnection sock2 = new GDMath.ThirdParty.SocketConnection();
        }

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
    }
}