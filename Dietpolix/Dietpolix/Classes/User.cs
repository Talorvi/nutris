namespace Dietpolix.Classes
{
    public class User
    {
        public uint user_id { get; set; }
        public string login { get; set; }
        public string password { get;  set;}
        public string name { get; set; }
        public enum sex { Male, Female }
        public int age { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public enum lifestyle { CouchPotato , Programmer, Balanced, Fit, Sportsman }
        public enum aim { FatReduction, MuscleMass }
    }
}
