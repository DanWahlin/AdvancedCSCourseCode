using System;
using System.Collections;
using System.Collections.Generic;
public class CityCollection : IEnumerable<string>
{
    string[] cities = { "Boston", "Hamburg", "Phoenix" };
    IEnumerator<string> IEnumerable<string>.GetEnumerator()
    {
        return new Enumerator(this);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<string>)this).GetEnumerator();
    }
    //Nested class definition 
    class Enumerator : IEnumerator<string>
    {
        CityCollection coll;
        int pos;
        public Enumerator(CityCollection collection)
        {
            coll = collection;
            pos = -1;
        }
        void IEnumerator.Reset()
        {
            pos = -1;
        }
        bool IEnumerator.MoveNext()
        {
            pos++;
            return (pos < coll.cities.Length);
        }
        string IEnumerator<string>.Current
        {
            get
            {
                if (pos == -1)
                    throw new InvalidOperationException();
                return coll.cities[pos];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return ((IEnumerator<string>)this).Current;
            }
        }
        public void Dispose() { }
    }
}

