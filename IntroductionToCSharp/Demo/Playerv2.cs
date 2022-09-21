namespace GD.Demo
{
    /// <summary>
    /// Example of composition (i.e. a Playerv2 is composed of another objects (e.g. Transform))
    /// </summary>
    public class Playerv2
    {
        #region Variables

        private string name;
        private Transform transform;
        private Vector3 surfaceColor;

        #endregion Variables

        #region Properties

        public string Name
        {
            get { return name; }
            //finally, some validation and lets prevent name from being externally changed
            protected set { name = value.Trim().ToLower(); }
        }

        public Transform Transform
        {
            get { return transform; }
            //lets prevent transform from being externally changed
            protected set { transform = value; }
        }

        public Vector3 SurfaceColor
        {
            get { return surfaceColor; }
            set { surfaceColor = value; }
        }

        #endregion Properties

        #region Constructors

        public Playerv2(string name, Transform transform)
         //we will pass white (i.e. (1,1,1) for surfaceColor)
         : this(name, Vector3.One, transform)
        {
        }

        public Playerv2(string name, Vector3 surfaceColor, Transform transform)
        {
            //since we now have added validation on name we should call property i.e. Name
            Name = name;
            SurfaceColor = surfaceColor;
            Transform = transform;
        }

        #endregion Constructors

        #region Common

        public override string? ToString()
        {
            return $"{name}\n{surfaceColor}\n{transform}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Playerv2 playerv &&
                   name.Equals(playerv.name) &&
                   transform.Equals(playerv.transform) &&
                   surfaceColor.Equals(playerv.surfaceColor);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, transform, surfaceColor);
        }

        #endregion Common
    }
}