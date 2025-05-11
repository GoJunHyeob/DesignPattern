using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

public class SingletonComponent : MonoBehaviour
{
    private static SingletonComponent instance;

    public static SingletonComponent Instance
    {
        get
        {
            if (instance == null)
            {
               SetupInstance();
            }

            return instance;

        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            Debug.Log("MakeSingleton");
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("AlreadyIsSingleton");
        }
    }

    private static void SetupInstance()
    {
        instance = FindAnyObjectByType<SingletonComponent>();
        if (instance == null)
        {
            GameObject gameObj = new GameObject();
            gameObj.name = "Singletone";
            instance = gameObj.AddComponent<SingletonComponent>();
            DontDestroyOnLoad(gameObj);
            Debug.Log("MakeSingleton");
        }

    }
}
