using UnityEngine;

namespace BcoffeeDev.Patterns
{
    public class PersistentSingletonBehaviour<T> : MonoBehaviour where T : PersistentSingletonBehaviour<T>
    {
        public static T Instance { get; private set; }

        protected virtual void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
