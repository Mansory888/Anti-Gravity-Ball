using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemenusk : MonoBehaviour
{
    public GameObject parent;
    private int currentSceneIndex;
    public  static int numerofdeaths;

    
    public void deth()
    {
        parent.transform.GetChild(1).gameObject.SetActive(true);
        parent.transform.GetChild(0).gameObject.SetActive(false);
        numerofdeaths +=1;
        if (numerofdeaths >= 6)
        {
            admanager.instance.Showfullscreenad();
        }
    }
    public void win()
    {
        
        parent.transform.GetChild(2).gameObject.SetActive(true);
        parent.transform.GetChild(0).gameObject.SetActive(false);
    }


    public void restartgme()
    {

        scoresk.scoreval = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("saved scene", currentSceneIndex);

    }
    public void mainmenu()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("saved scene", currentSceneIndex);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        scoresk.scoreval = 0;
        
    }
}
