using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class navigation : MonoBehaviour
{
   public GameObject petunjuk ;

    public void home(){
         SceneManager.LoadScene("home");
    }

    public void abjad(){
         SceneManager.LoadScene("abjad");
    }

    public void fokal(){
         SceneManager.LoadScene("fokal");
    }

    public void kagamca1(){
         SceneManager.LoadScene("kagamca 1");
    }

    public void kagamca2(){
         SceneManager.LoadScene("kagamca 2");
    }

    public void baca(){
         SceneManager.LoadScene("baca");
    }
    
    public void tutup(){
        petunjuk.SetActive(false);
    }
 
    public void next(){
        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }

    public void back(){
        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() - 1).gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
