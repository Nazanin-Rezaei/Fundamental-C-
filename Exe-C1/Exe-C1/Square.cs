using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_C1
{
    internal class Square
    {
        private int length;
        private int area;

        public Square(int lenght)
        {
            this.length = lenght;
            Count();
        }
        private void Count()
        {
            this.area = this.length * this.length;
           
        }
        public int Lenght
        {
            get
            {
                return this.length;
            }
        }
        public int Area 
        { 
            get
            {
                return this.area;
            }
                }
       
    }
}
