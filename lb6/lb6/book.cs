using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb6
{
    class book
    {
        public string nameLast { get; set; }
        public string nameFirst { get; set; }
        public string mail { get; set; }
        public int number { get; set; }

        public book()
        {
            nameLast = null;
            nameFirst = null;
            mail = null;
            number = 0;   
        }
        public book(string nameFirst, string nameLast, string mail, int number)
        {
            this.nameLast = nameLast;
            this.nameFirst = nameFirst;
            this.mail = mail;
            this.number = number;
        }

        public void print()
        {
            Console.WriteLine($"Имя -\t{nameFirst}\t\t Фамилия-\t {nameLast}\t\t Почтовый адрес-\t {mail}\t\t Телефон-\t {number}");
        }


    }
}
