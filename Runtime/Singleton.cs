using UnityEngine;

namespace BcoffeeDev.Patterns
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;
        
        public static T Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
#if UNITY_6000_0_OR_NEWER
                _instance = (T)FindAnyObjectByType(typeof(T));
#else
                _instance = (T)FindObjectOfType(typeof(T));
#endif
                // any find result
                if (_instance != null)
                    return _instance;
                
                // create new instance
                _instance = new GameObject(typeof(T).Name).AddComponent<T>();
                return _instance;
            }
        }
    }
}