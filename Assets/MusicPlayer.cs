using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music1 : MonoBehaviour
{
   
       
    static Music1 instance = null;
    private void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);

        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);

        }

      
    }

}
