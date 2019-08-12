using System;
using System.Collections;
using System.Collections.Generic;

class StateArrayDemo
{

    public static void Main()
    {
        StateCollection coll = new StateCollection();
        foreach (State s in coll)
        {
            Console.WriteLine(s.Name);
        }

        StateCollectionWithYield coll2 = new StateCollectionWithYield();
        foreach (State s in coll2)
        {
            Console.WriteLine(s.Name);
        }
        Console.ReadLine();
    }
}
public class State
{
    string _Name;
    string _Abbreviation;

    public State(string name, string abbr)
    {
        this.Name = name;
        this.Abbreviation = abbr;
    }

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    public string Abbreviation
    {
        get { return _Abbreviation; }
        set { _Abbreviation = value; }
    }
}

public class StateCollectionWithYield : IEnumerable {
    State[] states = null;
    public StateCollectionWithYield() {
        State az = new State("Arizona", "AZ");
        State ca = new State("California", "CA");
        State nm = new State("New Mexico", "NM");
        states = new State[] { az, ca, nm };
    }

    IEnumerator IEnumerable.GetEnumerator() {
        for (int i = 0; i < states.Length; i++)
        {
            yield return states[i];
        }
    }
}

public class StateCollectionWithGenerics : IEnumerable {
    List<State> states = new List<State>();
    public StateCollectionWithGenerics() {
        State az = new State("Arizona", "AZ");
        State ca = new State("California", "CA");
        State nm = new State("New Mexico", "NM");
        states.Add(az);
        states.Add(ca);
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return states.GetEnumerator();
    }
}

public class StateCollection : IEnumerable
{
    State[] states = null;
    public StateCollection()
    {
        State az = new State("Arizona", "AZ");
        State ca = new State("California", "CA");
        State nm = new State("New Mexico", "NM");
        states = new State[] { az, ca, nm };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new Enumerator(this);
    }

    private struct Enumerator : IEnumerator {
        int pos;
        State[] states;
        public Enumerator(StateCollection coll) {
            pos = -1;
            states = coll.states;
        }
        object IEnumerator.Current {
            get { return states[pos]; }
        }
        bool IEnumerator.MoveNext() {
            if (pos < states.Length - 1) {
                pos++;
                return true;
            } else {
                return false;
            }
        }
        void IEnumerator.Reset() { pos = 0; }
    }
}






