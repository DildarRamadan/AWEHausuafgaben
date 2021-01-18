using System;

namespace RPGNeedsCorrection
{
    internal class Adapter : Target
    {
        private Adaptee xAdaptee = new Adaptee();

        internal override bool IsDead
        {
            get
            {
                return xAdaptee.HP > 0 ? false : true;
            }
        }

        internal Adapter(Adaptee xAdaptee)
        {
            this.xAdaptee = xAdaptee;
        }

        internal override void Attack(Target xTarget)
        {
            Console.Write(xAdaptee.GetType() + " : ");
            xAdaptee.Attack(((Adapter)xTarget).xAdaptee);

            Console.WriteLine("----------------------------------------------------------------");
        }

        internal override void Breath()
        {
            xAdaptee.Breath();
        }

        internal override void MeDieDead()
        {
            xAdaptee.MeDieDead();
        }

        internal override Type IsType()
        {
            return xAdaptee.GetType();
        }
    }
}
