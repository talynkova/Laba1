using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Phones pb = new Phones();
            Book(pb);
        }
        public static void Book(Phones pb)
        {
            Phones ph = new Phones();
            List<string> items = new List<string>();
            Console.WriteLine("Здравствуйте, вы работаете с телефонной книгой! Пожалуйста, выберите команду:" + "\n" + "0-создать запись " + "\n" + "1-редактировать запись" + "\n" + "2-удалить запись" + "\n" + "3-просмотреть запись" + "\n" + "4-просмотреть все записи");
            int command;
            bool f;
            while (true)
            {
                f = Int32.TryParse(Console.ReadLine(), out command);
                if (!f || (command != 0 && command != 1 && command != 2 && command != 3 && command != 4))
                    Console.WriteLine("Пожалуйста, введите 0,1,2,3 или 4");

                else break;
            }

            switch (command)
            {
                case 0:
                    TelephoneBook tb = new TelephoneBook();


                    Console.WriteLine("Пожалуйста, введите имя");
                    string name1;
                    while (true)
                    {
                        name1 = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(name1))
                        {
                            Console.WriteLine("Имя-обязательное полe. Пожалуйста, введите его");

                        }
                        else break;
                    }
                    tb.Name = name1;


                    Console.WriteLine("Пожалуйста, введите фамилию");
                    string surname1;
                    while (true)
                    {
                        surname1 = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(surname1))
                        {
                            Console.WriteLine("Фамилия-обязательное полe. Пожалуйста, введите ее");

                        }
                        else break;
                    }
                    tb.Surname = surname1;


                    bool number11;
                    ulong number1;
                    Console.WriteLine("Пожалуйста, введите номер");

                    while (true)
                    {
                        number11 = UInt64.TryParse(Console.ReadLine(), out number1);
                        if (!number11)
                        {
                            Console.WriteLine("Номер-обязательное полe. Пожалуйста, введите его");

                        }
                        else break;
                    }
                    tb.Number = number1;


                    Console.WriteLine("Пожалуйста, введите страну");
                    string country1;
                    while (true)
                    {
                        country1 = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(country1))
                        {
                            Console.WriteLine("Страна-обязательное полe. Пожалуйста, введите ее");

                        }
                        else break;
                    }
                    tb.Country = country1;
                    Console.WriteLine("Пожалуйста, введите отчество");
                    string str1 = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(str1)) str1 = "не указано";
                    tb.ThirdName = str1;



                    string input;
                    DateTime dob;

                    Console.WriteLine("Введите дату рождения в формате дд.ММ.гггг (день.месяц.год):");
                    input = Console.ReadLine();

                    if (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out dob))
                        tb.Date = true;
                    else
                    {
                        tb.BirthDate = dob;
                        tb.Date = false;
                    }


                    Console.WriteLine("Пожалуйста, введите организацию");
                    string str2 = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(str2)) str2 = "не указано";
                    tb.Company = str2;

                    Console.WriteLine("Пожалуйста, введите должность");
                    string str3 = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(str3)) str3 = "не указано";
                    tb.Position = str3;


                    Console.WriteLine("Пожалуйста, введите иные заметки");
                    string str4 = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(str4)) str4 = "не указано";
                    tb.Notes = str4;

                    pb.NewItem(tb);
                    break;
                case 1:
                    Console.WriteLine("Выберете способ поиска записи. Если ищете по фамилии, напечатайте 0, если по номеру телефона, напечатайте 1");
                    int a;
                    bool b;
                    while (true)
                    {
                        b = Int32.TryParse(Console.ReadLine(), out a);
                        if (!b || (a != 0 && a != 1))
                            Console.WriteLine("Пожалуйста, введите 0 или 1");

                        else break;
                    }


                    if (a == 0)
                    {
                        Console.WriteLine("Введите фамилию");
                        string stroka;
                        while (true)
                        {
                            stroka = Console.ReadLine();
                            if (String.IsNullOrWhiteSpace(stroka))
                            {
                                Console.WriteLine("Пожалуйста, введите фамилию");
                            }
                            else break;
                        }
                        int ind = pb.LookFor2(stroka);
                        if (ind != -1)
                            pb.LookForChange2(stroka);

                        else Console.WriteLine("Такой записи нет");

                    }
                    if (a == 1)
                    {
                        Console.WriteLine("Введите номер");
                        ulong nomer;
                        while (true)
                        {
                            number11 = UInt64.TryParse(Console.ReadLine(), out nomer);
                            if (!number11)
                            {
                                Console.WriteLine("Пожалуйста, введите номер");
                            }
                            else break;
                        }
                        int ind = pb.LookFor1(nomer);
                        if (ind != -1)
                            pb.LookForChange1(nomer);
                        else Console.WriteLine("Такой записи нет");

                    }

                    break;
                case 2:
                    Console.WriteLine("Выберите способ выбора записи. Если выбираете по фамилии, напечатайте 0, если по номеру телефона, напечатайте 1");

                    while (true)
                    {
                        b = Int32.TryParse(Console.ReadLine(), out a);
                        if (!b || (a != 0 && a != 1))
                            Console.WriteLine("Пожалуйста, введите 0 или 1");

                        else break;
                    }

                    if (a == 0)
                    {
                        Console.WriteLine("Введите фамилию");
                        string stroka;
                        while (true)
                        {
                            stroka = Console.ReadLine();
                            if (String.IsNullOrWhiteSpace(stroka))
                            {
                                Console.WriteLine("Пожалуйста, введите фамилию");

                            }
                            else break;
                        }
                        int ind = pb.LookFor2(stroka);
                        if (ind != -1)
                        {
                            pb.DeletePhone1(stroka);
                            Console.WriteLine("Удалено");
                        }
                        else Console.WriteLine("Такой записи нет");

                    }
                    if (a == 1)
                    {
                        Console.WriteLine("Введите номер");
                        ulong nomer;
                        while (true)
                        {
                            number11 = UInt64.TryParse(Console.ReadLine(), out nomer);
                            if (!number11)
                            {
                                Console.WriteLine("Пожалуйста, введите номер");
                            }
                            else break;
                        }
                        int ind = pb.LookFor1(nomer);
                        if (ind != -1)
                        {
                            pb.DeletePhone2(nomer);
                            Console.WriteLine("Удалено");
                        }

                        else Console.WriteLine("Такой записи нет");

                    }
                    break;
                case 3:
                    Console.WriteLine("Выберите способ выбора записи. Если выбираете по фамилии, напечатайте 0, если по номеру телефона, напечатайте 1");

                    while (true)
                    {
                        b = Int32.TryParse(Console.ReadLine(), out a);
                        if (!b || (a != 0 && a != 1))
                            Console.WriteLine("Пожалуйста, введите 0 или 1");

                        else break;
                    }

                    if (a == 0)
                    {
                        Console.WriteLine("Введите фамилию");
                        string stroka;
                        while (true)
                        {
                            stroka = Console.ReadLine();
                            if (String.IsNullOrWhiteSpace(stroka))
                            {
                                Console.WriteLine("Пожалуйста, введите фамилию");

                            }
                            else break;
                        }
                        int ind = pb.LookFor2(stroka);
                        if (ind != -1)
                            pb.LookForPrint2(stroka);

                        else Console.WriteLine("Такой записи нет");

                    }
                    if (a == 1)
                    {
                        Console.WriteLine("Введите номер");
                        ulong nomer;
                        while (true)
                        {
                            number11 = UInt64.TryParse(Console.ReadLine(), out nomer);
                            if (!number11)
                            {
                                Console.WriteLine("Пожалуйста, введите номер");

                            }
                            else break;
                        }
                        int ind = pb.LookFor1(nomer);
                        if (ind != -1)
                            pb.LookForPrint1(nomer);
                        else Console.WriteLine("Такой записи нет");

                    }

                    break;

                case 4:

                    pb.Printer(pb.items);
                    break;
            }
            Console.WriteLine("Выберите дальнейшие действия.Выход-0, остаться-1 ");
            string str;
            while (true)
            {
                str = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(str) || (str != "0" && str != "1"))
                    Console.WriteLine("Пожалуйста, введите 0 или 1");

                else break;
            }
            if (str == "1")
            {
                Console.Clear();
                Book(pb);
            }
            else return;
        }

    }


    public class TelephoneBook
    {
        private string name;
        private string surname;
        private string thirdName;
        private ulong number;
        private string country;
        private DateTime birthDate;
        private string company;
        private string position;
        private string notes;
        private bool date;
        public string Name { get { return name; } set { this.name = value; } }
        public string Surname { get { return surname; } set { this.surname = value; } }
        public string ThirdName { get { return thirdName; } set { this.thirdName = value; } }
        public ulong Number { get { return number; } set { this.number = value; } }
        public string Country { get { return country; } set { this.country = value; } }
        public DateTime BirthDate { get { return birthDate; } set { this.birthDate = value; } }
        public string Company { get { return company; } set { this.company = value; } }
        public string Position { get { return position; } set { this.position = value; } }
        public string Notes { get { return notes; } set { this.notes = value; } }
        public bool Date { get { return date; } set { this.date = value; } }

    }

    public class Phones
    {
        public List<TelephoneBook> items = new List<TelephoneBook>();
        public void NewItem(TelephoneBook tb)
        {
            items.Add(tb);

        }

        public void LookForPrint1(ulong s)
        {

            for (int i = 0; i < items.Count; ++i)
                if (items[i].Number == s)
                {
                    Console.WriteLine("Фамилия: " + items[i].Surname);
                    Console.WriteLine("Имя: " + items[i].Name);
                    Console.WriteLine("Отчество: " + items[i].ThirdName);
                    Console.WriteLine("Номер: " + items[i].Number);
                    Console.WriteLine("Страна: " + items[i].Country);
                    if (items[i].Date == false)
                        Console.WriteLine("Дата рождения: " + items[i].BirthDate);
                    else Console.WriteLine("Дата рождения: не указано");
                    Console.WriteLine("Компания: " + items[i].Company);
                    Console.WriteLine("Должность: " + items[i].Position);
                    Console.WriteLine("Другие заметки: " + items[i].Notes);

                }

        }
        public int LookFor2(string s)
        {
            for (int i = 0; i < items.Count; ++i)
                if (items[i].Surname == s)
                    return i;
            return -1;
        }
        public int LookFor1(ulong s)
        {
            for (int i = 0; i < items.Count; ++i)
                if (items[i].Number == s)
                    return i;
            return -1;
        }

        public void LookForPrint2(string s)
        {

            for (int i = 0; i < items.Count; ++i)
                if (items[i].Surname == s)
                {
                    Console.WriteLine("Фамилия: " + items[i].Surname);
                    Console.WriteLine("Имя: " + items[i].Name);
                    Console.WriteLine("Отчество: " + items[i].ThirdName);
                    Console.WriteLine("Номер: " + items[i].Number);
                    Console.WriteLine("Страна: " + items[i].Country);
                    if (items[i].Date == false) Console.WriteLine("Дата рождения " + items[i].BirthDate);
                    else Console.WriteLine("Дата рождения: не указано");
                    Console.WriteLine("Компания: " + items[i].Company);
                    Console.WriteLine("Должность: " + items[i].Position);
                    Console.WriteLine("Другие заметки: " + items[i].Notes);

                }

        }
        public void LookForChange1(ulong s)
        {
            bool f = true;
            for (int i = 0; i < items.Count; ++i)
                if (items[i].Number == s)
                {
                    f = false;
                    Console.WriteLine("Пожалуйста, введите имя");
                    string name = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(name))
                        items[i].Name = name;
                    Console.WriteLine("Пожалуйста, введите фамилию");
                    string surname = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(surname))
                        items[i].Surname = surname;

                    bool number11;
                    ulong number1;
                    Console.WriteLine("Пожалуйста, введите номер");
                    number11 = UInt64.TryParse(Console.ReadLine(), out number1);
                    if (number11)
                        items[i].Number = number1;

                    Console.WriteLine("Пожалуйста, введите страну");
                    string country1 = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(country1))
                        items[i].Country = country1;

                    Console.WriteLine("Пожалуйста, введите отчество");
                    string str1 = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(str1))
                        items[i].ThirdName = str1;

                    string input;
                    DateTime dob;
                    Console.WriteLine("Введите дату рождения в формате дд.ММ.гггг (день.месяц.год):");
                    input = Console.ReadLine();
                    if (DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out dob))
                    {
                        items[i].BirthDate = dob;
                        items[i].Date = false;
                    }

                    Console.WriteLine("Пожалуйста, введите организацию");
                    string str2 = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(str2))
                        items[i].Company = str2;

                    Console.WriteLine("Пожалуйста, введите должность");
                    string str3 = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(str3))
                        items[i].Position = str3;


                    Console.WriteLine("Пожалуйста, введите иные заметки");
                    string str4 = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(str4))
                        items[i].Notes = str4;
                }
            if (f == true) Console.WriteLine("Такой записи нет");

        }
        public void LookForChange2(string s)
        {
            bool f = true;
            for (int i = 0; i < items.Count; ++i)
                if (items[i].Surname == s)
                {

                    Console.WriteLine("Пожалуйста, введите имя");
                    string name = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(name))
                        items[i].Name = name;
                    Console.WriteLine("Пожалуйста, введите фамилию");
                    string surname = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(surname))
                        items[i].Surname = surname;

                    bool number11;
                    ulong number1;
                    Console.WriteLine("Пожалуйста, введите номер");
                    number11 = UInt64.TryParse(Console.ReadLine(), out number1);
                    if (number11)
                        items[i].Number = number1;

                    Console.WriteLine("Пожалуйста, введите страну");
                    string country1 = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(country1))
                        items[i].Country = country1;

                    Console.WriteLine("Пожалуйста, введите отчество");
                    string str1 = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(str1))
                        items[i].ThirdName = str1;

                    string input;
                    DateTime dob;
                    Console.WriteLine("Введите дату рождения в формате дд.ММ.гггг (день.месяц.год):");
                    input = Console.ReadLine();
                    if (DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out dob))
                    {
                        items[i].BirthDate = dob;
                        items[i].Date = false;
                    }


                    Console.WriteLine("Пожалуйста, введите организацию");
                    string str2 = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(str2))
                        items[i].Company = str2;

                    Console.WriteLine("Пожалуйста, введите должность");
                    string str3 = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(str3))
                        items[i].Position = str3;


                    Console.WriteLine("Пожалуйста, введите иные заметки");
                    string str4 = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(str4))
                        items[i].Notes = str4;
                    f = false;

                }
            if (f == true) Console.WriteLine("Такой записи нет");
        }
        public void Printer(List<TelephoneBook> items)
        {
            if (items.Count > 0)
            {
                foreach (var item in items)
                {
                    Console.WriteLine("Фамилия: " + item.Surname);
                    Console.WriteLine("Имя: " + item.Name);
                    Console.WriteLine("Номер: " + item.Number);
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Список контактов пуст");
        }

        public void DeletePhone1(string s)
        {
            bool f = true;
            for (int i = 0; i < items.Count; ++i)
                if (items[i].Surname == s)
                {
                    items.Remove(items[i]);
                    f = false;
                }
            if (f == true)
                Console.WriteLine("Такой записи нет");
        }
        public void DeletePhone2(ulong s)
        {
            bool f = true;
            for (int i = 0; i < items.Count; ++i)
                if (items[i].Number == s)
                {
                    items.Remove(items[i]);
                    f = false;
                }
            if (f == true)
                Console.WriteLine("Такой записи нет");
        }

    }
}
