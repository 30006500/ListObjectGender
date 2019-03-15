using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace ListObjectGenderJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=10");
            List<Person> data = new JavaScriptSerializer().Deserialize<List<Person>>(json);
            List<Person> male = new List<Person>();
            List<Person> female = new List<Person>();
            foreach (Person x in data)
            {
                if (x.gender == "male")
                {
                    male.Add(x);
                }

                else
                {
                    female.Add(x);
                }

            }



            
            Console.WriteLine("Male Records");
            Console.WriteLine("************");
            foreach (Person x in male)
            {
                 Console.WriteLine("Title: {0}\nName: {1} {2}\nGender: {3}\nRegion: {4}\nPhone: {5}\nBirthdate\nDMY: {6}\nMDY: {7}\nRAW: {8}\nCredit Card Details\nCard Number: {9}\nExpiration {10}\nPIN: {11}\nCVC: {12}\nPhotoURL: {13}\nAge: {14}\n", x.title, x.name, x.surname, x.gender, x.region, x.phone, x.birthday.dmy, x.birthday.mdy, x.birthday.raw, x.credit_card.number, x.credit_card.expiration, x.credit_card.pin, x.credit_card.security, x.photo, x.age);
            }

            Console.WriteLine("Female Records");
            Console.WriteLine("************");
            foreach (Person x in female)
            {
                Console.WriteLine("Title: {0}\nName: {1} {2}\nGender: {3}\nRegion: {4}\nPhone: {5}\nBirthdate\nDMY: {6}\nMDY: {7}\nRAW: {8}\nCredit Card Details\nCard Number: {9}\nExpiration {10}\nPIN: {11}\nCVC: {12}\nPhotoURL: {13}\nAge: {14}\n", x.title, x.name, x.surname, x.gender, x.region, x.phone, x.birthday.dmy, x.birthday.mdy, x.birthday.raw, x.credit_card.number, x.credit_card.expiration, x.credit_card.pin, x.credit_card.security, x.photo, x.age);
            }
            Console.ReadLine();
        }
        
    }
}
