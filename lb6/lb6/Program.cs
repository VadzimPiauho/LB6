using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lb6
{
    class Program
    {
        [DllImport("msvcrt")]
        static extern int _getch();
        static void Main(string[] args)
        {
            List<book> book = new List<book>();
            bool go_on = true;
            int numberKey;
            try
            {
                while (go_on)
                {
                    Console.Clear();
                    Console.WriteLine("*************Меню**************");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("1 - Добавить запись");
                    Console.WriteLine("2 - Удалить запись");
                    //Console.WriteLine("3 - Поиск по одному признаку");
                    //Console.WriteLine("4 - Сортировать по фамилии");
                    Console.WriteLine("5 - Перейти к записи №");
                    Console.WriteLine("6 - Отобразить список");
                    Console.WriteLine("0 - Выход из программы");
                    Console.WriteLine("*******************************");

                    switch (_getch())
                    {
                        case '1':         
                            Console.WriteLine("Введите имя");
                            string nameFirst = Console.ReadLine();
                            Console.WriteLine("Введите фамилию");
                            string nameLast = Console.ReadLine();
                            Console.WriteLine("Введите почту");
                            string mail = Console.ReadLine();
                            Console.WriteLine("Введите телефон");
                            int number = Convert.ToInt32(Console.ReadLine());
                            book.Add(new book(nameFirst, nameLast, mail, number));
                            Console.WriteLine("Запись добавлена");
                            Thread.Sleep(1000);
                            break;
                        case '2':

                            Console.WriteLine("Введите номер записи которую необходимо удалить");
                            numberKey = Convert.ToInt32(Console.ReadLine());
                            if (numberKey > 0 && numberKey <= book.Count)
                            {   
                                book.Remove(book[numberKey-1]);
                                Console.WriteLine("Введенный номер записи удален");  
                            }
                            else
                            {
                                Console.WriteLine("Введенный номер записи не возможно удалить");
                                Thread.Sleep(1000);
                            }
                            Thread.Sleep(3000);
                            break;
                        case '3':
                             book.Sort();
                            
                            break;
                        case '4':
                            
                            
                            break;
                        case '5':
                            Console.WriteLine("Введите номер записи которую необходимо отобразить");
                            numberKey= Convert.ToInt32(Console.ReadLine());
                            if (numberKey>0 && numberKey<= book.Count)
                            {
                                book[numberKey-1].print();
                            }
                            else
                            {
                                Console.WriteLine("Введенный номер записи не возможно отобразить");
                                Thread.Sleep(1000);
                            }
                            Thread.Sleep(3000);
                            break;
                        case '6':
                            if (book.Count ==0)
                            {
                                Console.WriteLine("Записная книга пуста");
                                Thread.Sleep(2000);
                                break;
                            }
                            for (int i = 0; i < book.Count; i++)
                            {
                                book[i].print();
                                if (i == book.Count - 1)
                                {
                                    Console.WriteLine("Записная книга закончена. Нажмите любую клавишу");
                                    _getch();
                                }
                            }
                            _getch();
                            break;
                        case '0':
                            go_on = false;
                            break;
                        default:
                            Console.WriteLine("Неверный выбор");
                            Thread.Sleep(1000);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод Завершение программы");
                Environment.Exit(0);
            }   

        }
    }
}
