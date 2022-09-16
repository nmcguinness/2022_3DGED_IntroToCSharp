using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp.Demo.Class
{
    public class Playerv2
    {
        #region Variables
        private string name;
        private Transform transform;
        private Vector3 surfaceColor;
        #endregion

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
        #endregion





    }
}
