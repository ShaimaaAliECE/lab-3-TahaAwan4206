using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
	public class MagicWand : Tool
	{

		public string name;
        public MagicWand(string name) : base(name)
        {
            this.name = name;
        }

        public override void doAction()
        {
            base.doAction();
        }
    }
}

