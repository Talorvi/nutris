namespace Dietpolix.Classes
{
    public class User
    {
        public User() { }
        public User(string login, string name, string sex, int age, int weight, int height, string lifestyle, string aim)
        {
            this.login = login;
            this.name = name;
            //this.s
        }
        public uint user_id { get; set; }
        public string login { get; set; }
        public string password { get;  set;}
        public string name { get; set; }
        public enum sex { Male, Female }
        public int age { get; set; }
        public int weight { get { return weight; } set { weight = 0; } }
        public int height { get { return height; } set { height = 0; } }
        public enum lifestyle { CouchPotato , Programmer, Balanced, Fit, Sportsman }
        public enum aim { FatReduction, MuscleMass }
    }
}
