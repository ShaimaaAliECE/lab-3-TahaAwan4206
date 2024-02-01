using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3App
{
	public class Collectable : Displayable
	{

		public CollectionBoard Board;
		private string name;
		public string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name;
			}
		}
		
		public Collectable(string name)
		{
			Name = name;
		}

		public virtual void AddMe(List<Collectable> collectable) {
			Console.WriteLine(this.Name + " is collected, congrats!!!!");
		}
        public virtual void Display()
		{
			Console.WriteLine(this.GetType().Name + " " + this.Name + " is displayed");
		}



    }

	
}

