using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class GetSet
    {
        private int x;

        private int y;

        private int z;

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int Z { get; set; }


        public void SetX(int x) //устанавливаем значение х
        {
            if (x < 1)
            {
                this.x = 1;
                return;
            }
            if (x > 10)
            {
                this.x = 5;
                return;
            }
            this.x = x;
        }
        public int GetX() //получаем значение х
        {
            return x;
        }
    }
}
