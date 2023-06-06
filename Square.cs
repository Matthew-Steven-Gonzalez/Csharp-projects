using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Square
    {
        private int side;

        private int area;

        public Square(int side) 
        {
            this.side =side;
            findArea();
        }

        private void findArea()
        {
            area = side * side;
        }

        public int side
        {
            get
            {
                return side;
            }
        }

        public int area
        {
            get
            {
                return area;
            }
        }
    }
}