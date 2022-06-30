using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2159176#content
namespace ArraysUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            //single dimentional arrays
            var numbers = new int[5];

            //object initialization syntax:
            var numbers2 = new int[5] { 1, 2, 3, 4, 5 };

            //Syntax for Rectangular 2D:
            var matrix = new int[3, 5];
            //with object initialization syntax
            var matrix2 = new int[3, 5]
            {
                {1,2,3,4,5 },
                {6,7,8,9,10},
                {11,12,13,14,15}
            };
            //accessing an element:
            var element = matrix[0, 0];

            //Syntax for Rectangular 3D:
            var colors = new int[3, 5, 4];

            //Syntax for Jagged:
            // first square bracket is for specifying elements in top level array
            var array = new int[3][];
            //initializing every element of an array to a different array:
            array[0] = new int[4];
            array[1] = new int[5];
            array[2] = new int[3];
            //accessing an element in jagged array
            array[0][0] = 1;
        }
    }
}