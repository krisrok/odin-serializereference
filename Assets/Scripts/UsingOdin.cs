using UnityEngine;

public class UsingOdin : MonoBehaviour
{
    [SerializeReference]
    public IFoo Foo = new FooA() { Foos = new IFoo[] { new FooB() } };
}
