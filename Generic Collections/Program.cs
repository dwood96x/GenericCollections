using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary<string,int>();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{d["Cats"]}, {d["Dogs"]}");
        }
    }
    struct KeyValue<KeyType, ValueType>
    {
        public KeyType key { get; }
        public ValueType value { get; }
        public KeyValue(KeyType _key, ValueType _value)
        {
            key = _key;
            value = _value;
        }
    }
    class MyDictionary<KeyType, ValueType>
    {
        private KeyValue<KeyType,ValueType>[] keys = new KeyValue<KeyType,ValueType>[50];
        private int NumOfKeys = 0;

        public ValueType this[KeyType key]
        {
            set
            {
                bool exist = false;
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].key.Equals(key))
                    {
                        keys[i] = new KeyValue<KeyType, ValueType>(key, keys[i].value);
                        exist = true;
                    }
                }
                if (exist == false)
                {
                    keys[NumOfKeys] = new KeyValue<KeyType, ValueType>(key, value);
                    NumOfKeys += 1;
                }
            }
            get
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].key.Equals(key))
                    {
                        return keys[i].value;
                    }
                }
                throw new KeyNotFoundException();
            }
        }
    }
}