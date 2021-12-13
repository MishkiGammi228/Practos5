using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_5
{
	class Pair
	{
		private int[] para;
		public Pair()
        {
			para = new int[2];
			para[0] = 0;
			para[1] = 0;
        }
		public Pair(int zn1, int zn2)
        {
			para[0] = zn1;
			para[1] = zn2;
        }
		public int zn1 { get => para[0]; set => para[0] = value; }
		public int zn2 { get => para[1]; set => para[1] = value; }
		public int[] PairArray { get => para; set => para = value; }
		public bool Compare1()
        {

			if (this.zn1 > this.zn2) return true;
			else return false;
        }
		public bool Compare2()
		{

			if (this.zn1 == this.zn2) return true;
			else return false;
		}
        public bool Compare3()
        {

            if (this.zn1 > this.zn2) return true;
            else return false;
        }
    }
}
