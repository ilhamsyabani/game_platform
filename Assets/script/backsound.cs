using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backsound : MonoBehaviour
{
    private static backsound instance = null;
     void Awake(){
         if(instance == null){
              instance = this;
              DontDestroyOnLoad(gameObject);
         }else if(instance != this){
              Destroy(this.gameObject);
              return;
         }
     }
}
