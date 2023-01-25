
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna_3
{
    class Program
    {
        static void Main (string[] args)
        {
            //створюється екземпляр HashTable, якому передаємо capacity
            HashTable table = new HashTable(2048);
            //додаємо значення в таблицю (ключ - значення)
            table.Put(new Key("APPL", 115), 163.4);
            table.Put(new Key("APP", 115), 160.4);
            table.Put(new Key("APPLi", 115), 161.4);
            table.Put(new Key("META", 256), 172.54);
            //отримуємо ціну передаючи в Get ключ
            double priceMeta = table.Get(new Key("META", 256));
            Console.WriteLine(priceMeta); //виводимо ціну
            bool isCont = table.ContainsKey(new Key("META", 256));
            Console.WriteLine(isCont);
            Console.WriteLine(table.Size());
            bool isRemove = table.Remove(new Key("APPL", 115));
            Console.WriteLine(isRemove);
            Console.WriteLine(table.Size());
        }
    }
}

