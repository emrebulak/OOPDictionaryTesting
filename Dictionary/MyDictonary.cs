using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictonary<TKey, TValue>
    {
        TKey[] _tKey;
        TValue[] _tValue;

        TKey[] _tempKey;
        TValue[] _tempValue;

        public MyDictonary()
        {
            _tKey = new TKey[0];
            _tValue = new TValue[0];
        }

        public void Add(TKey Key, TValue Value)
        {
            _tempKey = _tKey;
            _tempValue = _tValue;

            _tKey = new TKey[_tKey.Length + 1];
            _tValue = new TValue[_tValue.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _tKey[i] = _tempKey[i];
                _tValue[i] = _tempValue[i];

            }

            _tKey[_tKey.Length - 1] = Key;
            _tValue[_tKey.Length - 1] = Value;

        }

        public int Count
        {
            get { return _tKey.Length; }
        }


    }
}
