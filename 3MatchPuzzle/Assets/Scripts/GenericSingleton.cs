using UnityEngine;

public abstract class GenericSingleton<T> where T : MonoBehaviour
{
    private static T instance;

    public static T Instance 
    {
        get 
        {
            return instance;
        }

         private set {}
    }

}
