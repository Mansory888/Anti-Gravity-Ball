using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test4 : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    private int nextscene;
    public gamemenusk Sk;
    float timeLeft2 = 2;
    
    public lvlscor Lvlscor;
    

    bool starttimer;
    





    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();

        


    }
     
    void Update() 
    {
        if(starttimer == true)
        {
            timeLeft2 -= Time.deltaTime;
            

        }
       
        if (timeLeft2 < 0)
        {


            int index = Random.Range(1, 7);
            SceneManager.LoadScene(index);

        }
       

        if (Input.GetMouseButton(0))
        {
            
            m_Rigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
            

        }
        else
        {
            
             m_Rigidbody.constraints = RigidbodyConstraints2D.None;
            
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "death")
        {
            Debug.Log("game over");
            Sk.deth();
            Time.timeScale = 0;

            FindObjectOfType<AudioManager>().playSound("deathS");
            
            


        }
        if (collision.tag == "Finish")
        {
            starttimer = true;
           
            Sk.win();
            
            lvlscor.lvlval += 1;
            Lvlscor.GHT();

            FindObjectOfType<AudioManager>().playSound("win");







        }
        if (collision.tag == "Y")
        {
            scoresk.scoreval += 10;

            FindObjectOfType<AudioManager>().playSound("Pass");


        }


    }
    





}   


