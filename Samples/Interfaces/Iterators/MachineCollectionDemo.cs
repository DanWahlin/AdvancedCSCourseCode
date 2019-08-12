using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

class MachineCollectionDemo
{

    public static void Main()
    {
        Machine m1 = new Machine();
        m1.MachineName = "Machine 1";
        m1.MachineID = 1;
        Machine m2 = new Machine();
        m2.MachineName = "Machine 2";
        m2.MachineID = 2;
        MachineCollection coll = new MachineCollection();
        coll.Add(m1);
        coll.Add(m2);
        foreach (Machine m in coll)
        {
            Console.WriteLine(m.MachineID.ToString());
        }
        Console.ReadLine();
    }
}
public class Machine
{
    string _MachineName;

    public string MachineName
    {
        get { return _MachineName; }
        set { _MachineName = value; }
    }
    int _MachineID;

    public int MachineID
    {
        get { return _MachineID; }
        set { _MachineID = value; }
    }
}
public class MachineCollection : IEnumerable
{
    List<Machine> machines = new List<Machine>();
    public void Add(Machine m)
    {
        machines.Add(m);
    }

    public bool Remove(Machine m)
    {
        return machines.Remove(m);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return machines.GetEnumerator();
    }
}




