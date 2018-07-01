using System;

namespace Dietpolix.Classes
{
    public class User
    {
        public sex _sex { get; }
        public lifestyle _lifestyle { get; }
        public aim _aim { get; }
        public User() { }
        public User(string login, string name, string sex, string age, int weight, int height, string lifestyle, string aim)
        {
            this.login = login;
            this.name = name;
            _sex = (sex)Enum.Parse(typeof(sex),sex);
            this.age = age;
            this.weight = weight;
            this.height = height;
            _lifestyle = (lifestyle)Enum.Parse(typeof(lifestyle), lifestyle);
            _aim = (aim)Enum.Parse(typeof(aim), aim);
        }
        public uint user_id { get; set; }
        public string login { get; set; }
        public string password { get;  set;}
        public string name { get; set; }
        public enum sex { Male, Female }
        public string age { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public enum lifestyle { CouchPotato , Programmer, Balanced, Fit, Sportsman }
        public enum aim { FatReduction, MuscleMass }
    }
}
