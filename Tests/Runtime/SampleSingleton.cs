using BcoffeeDev.Patterns;
using UnityEngine;

namespace BcoffeeDev.Patterns.Samples
{
    public class SampleSingleton : PersistentSingleton<SampleSingleton>
    {
        public void HelloWorld()
        {
            Debug.Log("Hello World.");
        }
    }
}