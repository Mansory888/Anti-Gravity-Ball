using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuscore : MonoBehaviour
{
    // Start is called before the first frame update
    public int socrehigh ;
    Text highscoretxt;
    



    private void Start()
    {
        highscoretxt = GetComponent<Text>();

    }


    // Update is called once per frame
    void Update()
    {
        highscoretxt.text = PlayerPrefs.GetInt("high score", 0).ToString();
        

        


    }
}
