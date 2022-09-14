
namespace IntroductionToCSharp.Demo.Class
{
    public class Vector3
    {
        //member variables
        private float x;
        private float y;
        private float z;

        //properties
        public float X 
        { 
            get 
            { 
                return x; 
            } 
            set 
            {
                //NMCG - remove this later
                if (value > 0)
                    x = value;
                else
                    x = 0;
            } 
        }
        public float Y { get { return y; } set { y = value; } }
        public float Z { get { return z; } set { z = value; } }

        //constructors
        public Vector3() : this(0,0,0)
        {
            //X = 0;
            //Y = 0;
            //Z = 0;
        }
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({x},{y},{z})";
        }

        //TODO - Equals, GetHashCode
    }
}
