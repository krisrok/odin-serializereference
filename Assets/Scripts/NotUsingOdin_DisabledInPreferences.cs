using Sirenix.OdinInspector;
using UnityEngine;

public class NotUsingOdin_DisabledInPreferences : MonoBehaviour
{
    [DrawWithUnity]
    [SerializeReference]
    public IFoo Foo = new FooA() { Foos = new IFoo[] { new FooB() } };
}
