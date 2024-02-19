using System;
using UnityEngine;

public interface IFoo
{ }

[Serializable]
public class FooA : IFoo
{
    public string PropA1;
    public int PropA2;

    [SerializeReference]
    public IFoo[] Foos;
}

[Serializable]
public class FooB : IFoo
{
    public float PropB1;
    public bool PropB2;
}