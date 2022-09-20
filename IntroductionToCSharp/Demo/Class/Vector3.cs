using System.Runtime.CompilerServices;

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

        #endregion Constants

        #region Variables

        private float x;
        private float y;
        private float z;

        #endregion Variables

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

        public float Y
        { get { return y; } set { y = value; } }

        public float Z
        { get { return z; } set { z = value; } }

        #endregion Properties

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

        #endregion Constructors

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

        //clone - shallow example
        public object GetShallowCopy()
        {
            return this;
        }

        //clone - deep example
        public object Clone()
        {
            //the new keyword tells me that I am returning the address (in RAM)
            //of a new and DISTINCT object i.e. a deep copy
            return new Vector3(x, y, z);
        }

        #endregion Common

        #region Operator Overload

        //lets overload the == (comparison) operator
        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            //return (lhs.X == rhs.X && lhs.Y == rhs.Y && lhs.Z == rhs.Z);

            if (lhs.X == rhs.X && lhs.Y == rhs.Y && lhs.Z == rhs.Z)
                return true;
            else
                return false;
        }

        public static bool operator !=(Vector3 lhs, Vector3 rhs)
        {
            //        return !(lhs == rhs);

            if (lhs.X != rhs.X || lhs.Y != rhs.Y || lhs.Z != rhs.Z)
                return true;
            else
                return false;
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);

            //make a new object for the result
            //Vector3 result = new Vector3();
            //result.X = lhs.X + rhs.X;
            //result.Y = lhs.Y + rhs.Y;
            //result.Z = lhs.Z + rhs.Z;
            //return result;
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        public static Vector3 operator *(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z);
        }

        public static Vector3 operator /(Vector3 lhs, Vector3 rhs)
        {
            if (rhs.X == 0 || rhs.Y == 0 || rhs.Z == 0)
                throw new DivideByZeroException("rhs contains zero value!");

            return new Vector3(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z);
        }

        /// <summary>
        /// Returns a new Vector3 based on scalar pre-multiplication
        /// e.g. Vector3 vOut = 10.5f * v1;
        /// </summary>
        /// <param name="multiplier">Scalar floating point</param>
        /// <param name="rhs">Vector3</param>
        /// <returns>Vector3</returns>
        public static Vector3 operator *(float multiplier, Vector3 rhs)
        {
            return new Vector3(multiplier * rhs.X,
                multiplier * rhs.Y,
                multiplier * rhs.Z);
        }

        /// <summary>
        /// Returns a new Vector3 based on scalar pre-multiplication
        /// e.g. Vector3 vOut = v1 * 10.5f;
        /// </summary>
        /// <param name="multiplier">Scalar floating point</param>
        /// <param name="rhs">Vector3</param>
        /// <returns>Vector3</returns>
        public static Vector3 operator *(Vector3 rhs, float multiplier)
        {
            return multiplier * rhs;
        }

        //public static void operator +=(Vector3 lhs, Vector3 rhs)
        //{
        //}

        #endregion Operator Overload

        #region Geometry Related

        public double Length()
        {
            //Math.Pow(x, 2);
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public Vector3 Normalize()
        {
            double len = Length();

            return new Vector3((float)(x / len),
                (float)(y / len),
                (float)(z / len));
        }

        /// <summary>
        /// e.g. double distance = v1.Distance(v2);
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        ///
        public double Distance(Vector3 other)
        {
            double dstSquared
                = Math.Pow(x - other.X, 2)
                + Math.Pow(y - other.Y, 2)
                 + Math.Pow(z - other.Z, 2);

            return Math.Sqrt(dstSquared);
        }

        #endregion Geometry Related
    }
}