using System;
using System.Collections;
using System.Collections.Generic;


namespace Ders4Odev5
{
    class MyDictionary<T, U>
    {
        T[] _key;
        U[] _value;

        T[] _tempKey;
        U[] _tempValue;
        public MyDictionary()
        {
            _key = new T[0];
            _value = new U[0];
        }
        public void Add(T key, U value)
        {
            if (CheckKey(key))
            {
                Console.WriteLine("Duplicated Key Found. ");
            }
            else
            {
                _tempKey = _key;
                _tempValue = _value;

                _key = new T[_key.Length + 1];
                _value = new U[_value.Length + 1];

                for (int i = 0; i < _tempKey.Length; i++)
                {
                    _tempKey[i] = _key[i];
                    _tempValue[i] = _value[i];
                }
                _key[_key.Length - 1] = key;
                _value[_value.Length - 1] = value;
            }
        }
        public bool CheckKey(T key)
        {
            bool a = false;
            for (int i = 0; i < _key.Length; i++)
            {
                if (_key[i].Equals(key))
                {
                    a = true;
                } 
            } 
            return a;

        }

        public U Get(T key)
        {
            for (int i = 0; i < _key.Length; i++)
            {
                if (_key[i].Equals(key))
                {
                    return _value[i];
                }
            }
            return _value[_value.Length + 1];
        }

    }
}
