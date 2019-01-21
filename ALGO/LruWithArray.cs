using System;

namespace ALGO
{
    public class LruWithArray
    {
        private readonly int _capacity;

        public LruWithArray(int capacity)
        {
            _capacity = capacity;
            CachedList = new Array<int>(capacity);
        }

        public Array<int> CachedList { get; }

        public void Set(int val)
        {
            int idx = CachedList.IndexOf(val);

            if (idx != -1)
            {
                CachedList.Delete(idx);
                CachedList.Insert(0, val);
                return;
            }

            if (CachedList.Length == _capacity)
            {
                CachedList.Delete(CachedList.Length - 1);
            }
            
            CachedList.Insert(0, val);
        }
    }
}