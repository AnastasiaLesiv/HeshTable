namespace Laboratorna_3
{
    class HashTable
    {
        
        private int capacity; //ємність
        private int size; //розмір - к-ть комірок
        
        private HashTableItem[] array;

        public HashTable (int capacity)
        {
            this.capacity = capacity;
            array = new HashTableItem[this.capacity];
        }
        //покласти значеня за ключем в таблицю
        public void Put (Key key,  double value)
        {
            //ділимо dayOfYear помодулю на capacity і отримуємо index, куди кладеться елемент 
            int index = Math.Abs(key.Hash() % capacity);
            //перевіряємо чи є в комірці дані, якщо ні, то кладемо туди отримане значення  
            if (array[index] == null)
            {
                array[index] = new HashTableItem(key, value, null);
            }
            //якщо так, то ми перебираємо всі елементи під цим індексом і перевіряємо чи не дорівнює
            // даний ключ одному з ключів під цим індексом, якщо дорівнює, так все і лишаємо, якщо ні, то кладемо значення як наступний елемент списку
            // під цим же індексом і збільшуємо size
            else
            {
                for (HashTableItem node = array[index]; node != null; node = node.Next())
                {
                    if (node.Key().Equals(key))
                    {
                        return;
                    }
                }

                array[index] = new HashTableItem(key, value, array[index]);
            }
           size++;
        }       
        //взяти значення з таблиці за ключем
        public double Get(Key key)
        {
            //ділимо dayOfYear по модулю на capacity і отримуємо index, за яким дістаємо елемент з таблиці
            int index = Math.Abs(key.Hash() % capacity);
            double result = 0;
            for (HashTableItem node = array[index]; node != null; node = node.Next())
            {
                //порівнюємо заданий користувачем ключ з табличним ключем, якщо true то повертаємо значення за заданим ключем
                if (node.Key().Equals(key))
                {
                    result = node.Value();
                    break;
                }
            }

            return result;
        }
        //перевірити чи є даний ключ в таблиці
        public bool ContainsKey(Key key)
        {
            //ділимо dayOfYear по модулю на capacity і отримуємо index, за яким дістаємо елемент з таблиці
            int index = Math.Abs(key.Hash() % capacity);
            //перевіряємо чи даний ключ є в таблиці, якщо так, то повертаємо true
            for (HashTableItem node = array[index]; node != null; node = node.Next())
            {
                if (node.Key().Equals(key))
                {
                    return true;
                }
            }
            //якщо ні - false
            return false;
        }
        //видалити елемент з таблиці за ключем
        public bool Remove (Key key)
        {
            //ділимо dayOfYear по модулю на capacity і отримуємо index, за яким видаляємо елемент з таблиці
            int index = Math.Abs(key.Hash() % capacity);
            
            if (array[index] == null) //якщо true, такого елементу немає
                return false;

            for (HashTableItem node = array[index]; node != null; node = node.Next()) //перебираємо всі елементи масиву
            {
                if (node.Key().Equals(key))//якщо ключ співпадає, видаляємо його з таблиці
                {
                    //((IList)array[index]).Remove(node);
                    Array.Clear(array, index, 1);
                    break;
                }
            }

            --size;
            return true;
        }
        //повернути кількість елементів в хеш-таблиці
        public int Size()
        {
            return size;
        }
    }
}
