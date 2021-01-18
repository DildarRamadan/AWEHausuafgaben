namespace AdapterPattern
{
    internal class Adapter : Target
    {
        private Adaptee xAdaptee = new Adaptee();

        public override void Request()
        {
            // Possibly do some other work
            //  and then call SpecificRequest
            xAdaptee.SpecificRequest();
        }
    }
}
