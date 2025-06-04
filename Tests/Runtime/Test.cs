using UnityEngine;

namespace BcoffeeDev.Patterns.Samples
{
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            SampleSingleton.Instance.HelloWorld();
        }
    }
}