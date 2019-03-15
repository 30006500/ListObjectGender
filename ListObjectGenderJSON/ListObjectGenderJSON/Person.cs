using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListObjectGenderJSON
{
    class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string region { get; set; }
        public string title { get; set; }
        public string phone { get; set; }
        public Birthday birthday { get; set; }
        public CreditCard credit_card { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string photo { get; set; }

    }

    public class Birthday
    {
        public string dmy { get; set; }
        public string mdy { get; set; }
        public string raw { get; set; }
    }

    public class CreditCard
    {
        public string expiration { get; set; }
        public string number { get; set; }
        public string pin { get; set; }
        public string security { get; set; }

    }
}
