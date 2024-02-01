using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3App
{
	public class Tool : Collectable
	{
        public Tool(string name) : base(name)
        {
        }

        public virtual void doAction() {
			Console.WriteLine(this.GetType() + " is used");
		}


	}
}

