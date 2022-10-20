using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }//end of main

        static int CalculateAreaRect(int length, int width)
        { 
            return length * width;
        }
        static int CalculatePerimeter(int length, int width)
        {
            return (length + width) * 2;
        }
        static int CalculateCubeVolume(int length, int width, int height)
        {
            return (length * width + height);
        }//end of cube
        static int CalculateSAofCube(int lenght, int width, int height)
        {
            return (CalculateArea(lenght, height) * CalculateArea(lenght, width) * CalculateArea(width, height)) *2;
        
        }//end of rectangle mess   

        static int CalculateArea(int side1, int side2)
        { 
            return side1 * side2;
        }//end of calc area
        static int CalculatARea(int length, int width, int height)
        {
            return (length * height + length * width + width * height) * 2;    ///this is what Allen would do the first time
        }
    }
}