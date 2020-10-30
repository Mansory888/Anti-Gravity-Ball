using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoresk : MonoBehaviour
{
    // Start is called before the first frame update
    public static int scoreval = 0;
    Text scoretxt;
    public Text deathtxt;
    public Text wintext;
    
    



    private void Start()
    {
        scoretxt = GetComponent<Text>();

    }


    // Update is called once per frame
    void Update()
    {
        scoretxt.text = "" + scoreval;
        deathtxt.text = "Score: " + scoreval;
        wintext.text = "" + scoreval;

        if (scoreval>PlayerPrefs.GetInt("high score"))
        {
            
            PlayerPrefs.SetInt("high score", scoreval);

        }
        


    }
    

}
