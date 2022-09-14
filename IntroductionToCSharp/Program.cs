
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
            app.DemoNamespaces();
            app.DemoClass();   
        }

        private void DemoClass()
        {
            double x = GDMath.GDConstants.MathStuff.PI;
            GDMath.DeadPixel.SocketConnection sock1 = new GDMath.DeadPixel.SocketConnection();
            GDMath.ThirdParty.SocketConnection sock2 = new GDMath.ThirdParty.SocketConnection();
        }

        private void DemoNamespaces()
        {
            //Demo.Class.Player p
            //  = new Demo.Class.Player("jane smith", 100);
            Player p = new Player("jane smith", 100);
        }
    }
}