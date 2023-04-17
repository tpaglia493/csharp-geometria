using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangle
    {//ATTRIBUTES
        public int baseLength;
        public int height;
        public int area;
        public int perimeter;

        //STATES


        //CONSTRUCTOR
        public Rectangle(int baseLength, int height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

    //METHODS   
        public int GetArea() 
        {
            area = (baseLength * height);
            return area; 
        }
        public int GetPerimeter() {
            perimeter = (baseLength + height) * 2;
            return perimeter;
        }
    }
}

