using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    Score score;

    void Awake() 
    {
        if(!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else
        {
            Destroy(gameObject);
        }   
    }

    public Score GetScore => score;
}


/*
          ^._.^
   ,— /_   _\-.                    
 (    .___ | __. )                 ^._.^
{    } \  - | - /  }                /     )
 \   \   \  / \ /,  /              =‘—,,’
   ""    ||   || "
*/