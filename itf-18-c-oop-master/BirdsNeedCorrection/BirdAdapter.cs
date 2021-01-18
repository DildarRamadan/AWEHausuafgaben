namespace BirdsNeedCorrection
{
    internal class BirdAdapter : ToyDuck
    {
        public Bird DuHastVersuchtEinenVogelEinzusperren{ get; set; }
        public BirdAdapter(Bird bird)
        {
            DuHastVersuchtEinenVogelEinzusperren = bird;
        }

        public void Squeak()
        {
            DuHastVersuchtEinenVogelEinzusperren.MakeSound();
        }
    }
}
