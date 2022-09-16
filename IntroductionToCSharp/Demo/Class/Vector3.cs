
namespace IntroductionToCSharp.Demo.Class
{
    public class Vector3 //: Object
    {
        #region Constants
        //readonly to prevent external change of any constants
        //static so outside the class we can call e.g. Vector3.Zero
        public static readonly Vector3 Zero = new Vector3(0, 0, 0);
        public static readonly Vector3 One = new Vector3(1, 1, 1);
        public static readonly Vector3 UnitY = new Vector3(0, 1, 0); 
        #endregion


        #region Variables
        private float x;
        private float y;
        private float z;
        #endregion

        #region Properties
        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public float Y { get { return y; } set { y = value; } }
        public float Z { get { return z; } set { z = value; } }
        #endregion

        #region Constructors
        public Vector3() : this(0, 0, 0)
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

        #endregion

        #region Common
        public override string ToString()
        {
            return $"({x},{y},{z})";
        }

        //the question mark following the data types means we can pass a null e.g.
        //someMethod(null, 30, null)
        //public void someMethod(Vector3? v, int x, bool? y)
        //{

        //}

        public override bool Equals(object? obj)
        {
            //we can replace the code immediately below with code on line 53
            //Vector3 vector;
            //if (obj is Vector3)
            //    vector = (Vector3)obj;

            return obj is Vector3 v &&
                   x == v.x &&
                   y == v.y &&
                   z == v.z;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y, z);
        } 
        #endregion

    }
}
