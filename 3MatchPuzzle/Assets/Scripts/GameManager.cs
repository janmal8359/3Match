using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager instance;
    
    public static GameManager Instance
    {
        get
        {
            return instance;
        }

        private set {}
    }
    #endregion

    public List<List<GameObject>> nodeLists = new List<List<GameObject>>();

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;
    }
}
