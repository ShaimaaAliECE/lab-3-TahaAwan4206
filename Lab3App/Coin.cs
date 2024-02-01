using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3App
{
    public class Coin : Treasure 
    {
        public int value;
        public new string Name;
        public new int score;
        public new int Score
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
        public int Value
        {
            set
            {
                this.value = value;
            }
            get
            {
                return this.value;
            }
        }

        public Coin(string name, int score, int value):base(name, score)
        {
            this.Name = name;
            this.Score = score;
            this.Value = value;
        }

        public void UpdateTotalValue()
        {
            Board.totalValue = Board.totalValue + Value;
        }

        public override void Display()
        {
            base.Display();
        }

        public override void AddMe(List<Collectable> collectable)
        {
            base.AddMe(collectable); 
            UpdateTotalValue();
        }


    }
}

