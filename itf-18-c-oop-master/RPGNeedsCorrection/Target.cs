using System;

namespace RPGNeedsCorrection
{
    internal class Target
    {
        internal virtual bool IsDead
        {
            get;
        } = false;

        internal virtual void Breath()
        {
            Console.WriteLine("I CAN DO BASIC HUMAN THINGS!");
        }

        internal virtual void Attack(Target xTarget)
        {
            Console.WriteLine("I COULD POTENTIALLY FCK THAT GUY UP!");
        }

        internal virtual void MeDieDead()
        {
            Console.WriteLine("Rest in basic pieces me.");
        }

        internal virtual Type IsType()
        {
            return this.GetType();
        }
    }
}
