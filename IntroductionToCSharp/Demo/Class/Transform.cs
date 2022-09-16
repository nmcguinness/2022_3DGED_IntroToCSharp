namespace IntroductionToCSharp.Demo.Class
{
    public class Transform
    {
        //member variables
        private Vector3 position;
        private Vector3 rotation;
        private Vector3 scale;

        //properties
        public Vector3 Position { get => position; set => position = value; }
        public Vector3 Rotation { get => rotation; set => rotation = value; }
        public Vector3 Scale { get => scale; set => scale = value; }


        //constructors
        public Transform(Vector3 position)
            : this(position, Vector3.Zero, Vector3.One) //let's use the new constants
        // : this(position, new Vector3(0,0,0), new Vector3(1,1,1))
        {

        }
        public Transform(Vector3 position, Vector3 rotation, Vector3 scale)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }

        //ToString, Equals, GetHashCode
        public override string ToString()
        {
            //we could create the string output as below, or use $"" string initialization on line 35
          //  string strOut = position.ToString() + "," + rotation.ToString() + ", " + scale.ToString();

            return $"p:{position}\nr:{rotation}\ns:{scale}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Transform transform &&
                position.Equals(transform.position) &&
                rotation.Equals(transform.rotation) &&
                scale.Equals(transform.scale);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(position, rotation, scale);
        }
    }
}
