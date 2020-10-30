using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvlbeaten : MonoBehaviour
{


    public int lvlbeat;
    private int HH;
    Text beatlvletxt;
    // Start is called before the first frame update
    void Start()
    {
        beatlvletxt= GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HH = PlayerPrefs.GetInt("hihg lvl", 0)-1;
        beatlvletxt.text =""+ HH;
    }
}
