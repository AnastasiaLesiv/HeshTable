

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna_3
{
    public class HashTableItem 
    {
        private Key key; //ключ
        private double value; //значення
        private HashTableItem next; //наступний елемент
        private HashTableItem previous; //попередній елемент

        public Key Key() => key;
        public double Value() => value;
        public HashTableItem Next() => next;
        public HashTableItem Previous() => previous;

        public HashTableItem (Key key, double value, HashTableItem next)
        {
            this.key = key;
            this.next = next;
            this.value = value;
        }

        
    }
}
