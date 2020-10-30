using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvlscor : MonoBehaviour
{
    // Start is called before the first frame update
    public static int lvlval ;
    //public  static int L;
    Text lvltxt;
    public Text Deathlvl;
    
   



    private void Start()
    {
        lvltxt = GetComponent<Text>();

    }


    // Update is called once per frame
    void Update()
    {
        

        lvltxt.text = "" + PlayerPrefs.GetInt("hihg lvl");
        Deathlvl.text = "Level: " + PlayerPrefs.GetInt("hihg lvl");

        



        lvlval=PlayerPrefs.GetInt("hihg lvl");


     

    }
    
    public void GHT()
    {
        PlayerPrefs.SetInt("hihg lvl", lvlval);
    }
}
