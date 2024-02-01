using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3App
{
	public class Diamond : Treasure
	{

		public string name;
		public new int score;

        public Diamond(string name, int score): base(name, score)
		{
			this.name = name;
			this.score = score;
		}

		public override void Display()
		{
			base.Display();
		}



	}
}

