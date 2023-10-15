using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    internal class Circle
    {
        private float _pi = 3.141f;
        private int _Radius;

        public float Pi
        {
            get { return _pi; }
            set { _pi = 3.141f; }
        }

        public int Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }

        public Circle(int Radius)
        {
            _Radius = Radius;
        }

        /// <summary>
        /// Räknar ut arean på en cirkel
        /// </summary>
        public void GetArea()
        {
            float i = _Radius * _Radius * _pi;
            Console.WriteLine(i);
        }
    }
}
