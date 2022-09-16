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
            : this(position, new Vector3(0,0,0), new Vector3(1,1,1))
        {

        }
        public Transform(Vector3 position, Vector3 rotation, Vector3 scale)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }







        //Equals, GetHashCode
    }
}
