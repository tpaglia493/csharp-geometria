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
        public int heigth;
        public int area;
        public int perimeter;

        //STATES


        //CONSTRUCTOR
        public Rectangle(int baseLength, int heigth)
        {
            this.baseLength = baseLength;
            this.heigth = heigth;
        }

    //METHODS   
        public int GetArea() 
        {
            area = (baseLength * heigth);
            return area; 
        }
        public int GetPerimeter() {
            perimeter = (baseLength + heigth) * 2;
            return perimeter;
        }

        public void PrintRectangleDescription()
        {
            Console.WriteLine($"—— Rettangolo ——");
            Console.WriteLine($"base: {baseLength} cm");
            Console.WriteLine($"altezza: {heigth} cm");
            Console.WriteLine($"Perimetro: {perimeter} cm");
            Console.WriteLine($"Area: {area} cm^2");
        }
        
        public void DrawPerimeter() 
        {
            string baseLine = " ";
            string blankSpace = "";
            string heigthLine = "";
            for(int i = 1; i <= baseLength; i++) 
            {
                baseLine +="--";
                blankSpace += "  ";
            }
            for(int i = 1; i <= heigth; i++) 
            {
                heigthLine = "|"+blankSpace+"|";
            }
            for(int i = 0; i <= heigth+1; i++)
            {
                if(i==0 || i == heigth + 1)
                {
                    Console.WriteLine(baseLine);
                }
                else { Console.WriteLine(heigthLine);
            }

        }


    }
    }
}

