using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menulvl : MonoBehaviour
{
    // Start is called before the first frame update
    public int lvlhigh;
    Text highlvletxt;
    void Start()
    {
        highlvletxt= GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        highlvletxt.text = PlayerPrefs.GetInt("hihg lvl", 0).ToString();
    }
}
