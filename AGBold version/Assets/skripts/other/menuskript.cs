using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuskript : MonoBehaviour
{
    int[] Rscene = new int[] { 1, 2, 3, 4, 5, 6, 7};
    float S;

    public SpriteRenderer rend;
    private Sprite ball8, simpleball,earth,moon,football,tenis,baseball,basketball,china,hazard;
    
    public spriteCh sprit;
    protected float O;
    private int scenetocont;
    private int Skin;
    
    public GameObject parent;


    private void Update()
    {
        if (PlayerPrefs.GetInt("hihg lvl") >= 5)
        {
            parent.transform.GetChild(13).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("hihg lvl") >= 10)
        {
            parent.transform.GetChild(14).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("hihg lvl") >= 15)
        {
            parent.transform.GetChild(15).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("hihg lvl") >= 20)
        {
            parent.transform.GetChild(16).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("hihg lvl") >= 25)
        {
            parent.transform.GetChild(17).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("hihg lvl") >=30)
        {
            parent.transform.GetChild(18).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("hihg lvl") >= 35)
        {
            parent.transform.GetChild(19).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("hihg lvl") >= 40)
        {
            parent.transform.GetChild(20).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("hihg lvl") >= 45)
        {
            parent.transform.GetChild(21).gameObject.SetActive(false);
        }
        


    }




    private void Start()
    {


        admanager.instance.requestbanner();


        ball8 = Resources.Load<Sprite>("8ball");
        simpleball = Resources.Load<Sprite>("simple");
        earth = Resources.Load<Sprite>("earth");
        moon = Resources.Load<Sprite>("moon");
        football = Resources.Load<Sprite>("football");
        tenis = Resources.Load<Sprite>("teniss");
        baseball = Resources.Load<Sprite>("baseball");
        basketball = Resources.Load<Sprite>("basketball");
        china = Resources.Load<Sprite>("china");
        hazard = Resources.Load<Sprite>("hazard");

        scenetocont = PlayerPrefs.GetInt("saved scene");

        Skin= PlayerPrefs.GetInt("skin", Skin);

        if (Skin == 1)
        {
            rend.sprite = ball8;

            sprit.Shit();
            
        }
        if (Skin == 2)
        {
            sprit.Shit2();
            rend.sprite = simpleball;
            
        }
        if (Skin == 3)
        {
            rend.sprite = earth;
            sprit.Shit3();
            
        }
        if (Skin == 4)
        {
            rend.sprite = moon;
            sprit.Shit4();
            
        }
        if (Skin == 5)
        {
            rend.sprite = football;
            sprit.Shit5();
        }
        if (Skin == 6)
        {
            rend.sprite = tenis;
            sprit.Shit6();
        }
        if (Skin == 7)
        {
            rend.sprite = baseball;
            sprit.Shit7();
        }
        if (Skin == 8)
        {
            rend.sprite = basketball;
            sprit.Shi8();
        }
        if (Skin == 9)
        {
            rend.sprite = china;
            sprit.Shit9();
        }
        if (Skin == 10)
        {
            rend.sprite = hazard;
            sprit.Shit10();
        }

    }






    public void playgame()
    {

        int randValue = Random.Range(0, Rscene.Length);

        S = Rscene[randValue];


        admanager.instance.destroyban();

        if (scenetocont != 0)
        {
            SceneManager.LoadScene(scenetocont);
        }
        else
        {




            if (S == 1)
            {
                SceneManager.LoadScene(1);
                Debug.Log("1");
            }
            if (S == 2)
            {
                SceneManager.LoadScene(2);
                Debug.Log("2");
            }
            if (S == 3)
            {
                SceneManager.LoadScene(3);
                Debug.Log("3");
            }
            if (S == 4)
            {
                SceneManager.LoadScene(4);
                Debug.Log("4");
            }
            if (S == 5)
            {
                SceneManager.LoadScene(5);
                Debug.Log("5");
            }
            if (S == 6)
            {
                SceneManager.LoadScene(6);
                Debug.Log("6");
            }
            if (S == 7)
            {
                SceneManager.LoadScene(7);
                Debug.Log("7");
            }


        }
                                
               

                


               
    }

    //ball skin changing


    public void biliardball()
    {
        if(PlayerPrefs.GetInt("hihg lvl") >= 5)
        {
            rend.sprite = ball8;

            sprit.Shit();
            Skin = 1;
            PlayerPrefs.SetInt("skin", Skin);
            FindObjectOfType<AudioManager>().playSound("skin pick");
            


        }
        
    }
    public void simpleB()
    {
        
            sprit.Shit2();
            rend.sprite = simpleball;
            Skin = 2;
            PlayerPrefs.SetInt("skin", Skin);
            FindObjectOfType<AudioManager>().playSound("skin pick");
            
        
    }
    public void Earth()
    {
        if (PlayerPrefs.GetInt("hihg lvl") >= 10)
        {
            rend.sprite = earth;
            sprit.Shit3();
            Skin = 3;
            PlayerPrefs.SetInt("skin", Skin);
            FindObjectOfType<AudioManager>().playSound("skin pick");
            
        }
    }
    public void Moon()
    {
        if (PlayerPrefs.GetInt("hihg lvl") >= 15)
        {
            rend.sprite = moon;
            sprit.Shit4();
            Skin = 4;
            PlayerPrefs.SetInt("skin", Skin);
            FindObjectOfType<AudioManager>().playSound("skin pick");
            
        }
    }
    public void Foot()
    {
        if (PlayerPrefs.GetInt("hihg lvl") >= 20)
        {
            rend.sprite = football;
            sprit.Shit5();
            Skin = 5;
            PlayerPrefs.SetInt("skin", Skin);
            FindObjectOfType<AudioManager>().playSound("skin pick");
            
        }
    }
    public void Tenis()
    {
        if (PlayerPrefs.GetInt("hihg lvl") >= 25)
        {
            rend.sprite = tenis;
            sprit.Shit6();
            Skin = 6;
            PlayerPrefs.SetInt("skin", Skin);
            FindObjectOfType<AudioManager>().playSound("skin pick");
            
        }
    }
    public void Baseball()
    {
        if (PlayerPrefs.GetInt("hihg lvl") >= 30)
        {
            rend.sprite = baseball;
            sprit.Shit7();
            Skin = 7;
            PlayerPrefs.SetInt("skin", Skin);
            FindObjectOfType<AudioManager>().playSound("skin pick");
            
        }
    }
    public void Basketball()
    {
        if (PlayerPrefs.GetInt("hihg lvl") >= 35)
        {
            rend.sprite = basketball;
            sprit.Shi8();
            Skin = 8;
            PlayerPrefs.SetInt("skin", Skin);
            FindObjectOfType<AudioManager>().playSound("skin pick");
            
        }
    }
    public void China()
    {
        if (PlayerPrefs.GetInt("hihg lvl") >= 40)
        {
            rend.sprite = china;
            sprit.Shit9();
            Skin = 9;
            PlayerPrefs.SetInt("skin", Skin);
            FindObjectOfType<AudioManager>().playSound("skin pick");
            
        }
    }
    public void HAzard()
    {
        if (PlayerPrefs.GetInt("hihg lvl") >= 45)
        {
            rend.sprite = hazard;
            sprit.Shit10();
            Skin = 10;
            PlayerPrefs.SetInt("skin", Skin);
            FindObjectOfType<AudioManager>().playSound("skin pick");
            
        }
    }


    
    public void Mute()
    {
        AudioListener.pause = true;
        AudioListener.volume = 0;


    }
    public void Unmute()
    {
        AudioListener.pause = false;
        AudioListener.volume = 1;
    }




}
