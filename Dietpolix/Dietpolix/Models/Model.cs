using Dietpolix.Classes.Managers;
using Dietpolix.Classes;
using System.Collections.Generic;
using System.Text;
using System;

namespace Dietpolix.Models
{
    public class Model
    {
        public APIManager apimanager = new APIManager();
        public DatabaseManager databasemanager = new DatabaseManager();
        public PrintingManager printingmanager = new PrintingManager();

        public User user;
        public List<Product> listofproducts = new List<Product>();

        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_' || c==' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public int CalculateAge(string birth)
        {
            DateTime dateOfBirth = DateTime.Parse(birth);
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

        public double CountBMI(int weight, int height)
        {
            if ((weight!=0)&&(height!=0))
            {
                double BMI = (Double)weight / ((Double)height/100 * (Double)height/100);
                return Math.Round(BMI,1);
            }
            return 0;
        }

        // minimal need for calories per day
        public double CountBMR(int weight, int height, int age, string sex)        // sex is either f or m
        {
            double BMR = 0;
            if ((weight != 0) && (height != 0) && (age != 0) && (sex != ""))
            {
                double allBmr = (9.99 * weight) + (6.25 * height) - (4.92 * age);
                if (sex == "Male")
                {
                    BMR = allBmr + 5;
                    return Math.Round(BMR, 0);
                }

                if (sex == "Female")
                {
                    BMR = allBmr - 161;
                    return Math.Round(BMR, 0);
                }
            }
            return 0;
        }

        // maximum need for calories per day
        public double CountCPM(double BMR, string lifestyle, string aim)  
        // lifestyle -> 1-couchpotato, 2-programmer, etc.
        // aim -> 1-fatreduction, 2-musclemass
        {
            double CPM = 0;
            if ((BMR != 0) && (lifestyle != "") && (aim != ""))
            {
                switch(lifestyle)
                {
                    case "CouchPotato": CPM = BMR * 1.2; break;
                    case "Programmer": CPM = BMR * 1.4; break;
                    case "Balanced": CPM = BMR * 1.6; break;
                    case "Fit": CPM = BMR * 1.8; break;
                    case "Sportsman": CPM = BMR * 2.2; break;
                }
                if (aim == "FatReduction")
                {
                    CPM = CPM - 200;
                    return Math.Round(CPM,0);
                }
                if (aim == "MuscleMass")
                {
                    CPM = CPM + 300;
                    return Math.Round(CPM, 0);
                }
            }
            return 0;
        }
    }
}
