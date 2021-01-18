using System;

namespace RPGNeedsCorrection
{
    internal class Adaptee
    {
        private int _HP;
        internal int HP
        {
            get
            {
                return _HP;
            }
            set
            {
                if (_HP > value)
                {
                    Console.WriteLine($"({this.GetType()}) SHIEEEET I GOT FCKED UP! {HP}");
                }
                else if (_HP < value)
                {
                    Console.WriteLine($"({this.GetType()}) BRAH ITS MAGIC I GOT HEALED! {HP}");
                }

                this._HP = value;
            }
        }

        internal int MP
        {
            get;
            set;
        }

        internal Adaptee(int HP = 0, int MP = 0)
        {
            this._HP = HP;
            this.MP = MP;
        }

        internal virtual void Breath()
        {
            Console.WriteLine("I CAN BREATH!");
        }

        internal virtual void Attack(Adaptee xTarget)
        {
            xTarget.HP -= 15;
            Console.WriteLine("I FCKED THAT GUY UP!");
        }

        internal virtual void Heal(Adaptee xTarget)
        {
            xTarget.HP += 5;
            Console.WriteLine($"I gotcha back, mate {xTarget.GetType()}");
        }

        internal virtual void MeDieDead()
        {
            Console.WriteLine("Rest in pieces me.");
        }
    }
}
