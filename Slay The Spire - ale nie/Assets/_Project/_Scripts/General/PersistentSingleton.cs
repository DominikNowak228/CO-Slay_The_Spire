using UnityEngine;

public abstract partial class Singleton<T> where T : MonoBehaviour
{
    public abstract class PersistentSingleton<T> : Singleton<T> where T: MonoBehaviour
    {
        protected override void Awake()
        {
            base.Awake();
            DontDestroyOnLoad(gameObject);
        }
    }
}
