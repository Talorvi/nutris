﻿namespace Dietpolix.Classes
{
    public class User
    {
        public uint user_id { get; set; }
        public string login { get; set; }
        public string password { get;  set;}
        public string name { get; set; }
        public enum sex { male, female }
    }
}
