using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3App
{
	public class Axe : Tool
	{
		public string name;
		public Axe(string name): base(name)
		{
			this.name = name;
		}

        public override void doAction()
        {
            base.doAction();
        }

        public override void AddMe(List<Collectable> collectable)
        {
            base.AddMe(collectable);
			base.doAction();
        }

        public override void Display()
        {
            base.Display();
        }

    }
}

