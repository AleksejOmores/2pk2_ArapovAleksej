namespace pz_27
{
    struct ZNAK
    {
        public string NAME;
        public string ZODIAC;
        public int[] BDAY;
        public ZNAK(string name, string zodiak, int[] bday)
        {
            NAME = name;
            ZODIAC = zodiak;
            BDAY = new int[bday.Length];
            BDAY = bday;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ZNAK[] book = new ZNAK[8];

            
        }
    }
}