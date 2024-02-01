using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3App
{
	public class Treasure : Collectable
	{

        public int score;
        public int Score
        {
            set
            {
                this.score = value;
            }
            get
            {
                return this.score;
            }
        }

        public Treasure(string name, int score) : base(name)
        {
            this.Name = name;
            Score = score;
        }

        public virtual void UpdateTotalScore()
		{
			Board.totalScore += Score;
			Console.WriteLine("Total Score is updated to: " + Board.totalScore);
		}

        public override void AddMe(List<Collectable> collectable)
        {
			base.AddMe(collectable);
            UpdateTotalScore();

        }

    }
}

