using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteCh : MonoBehaviour
{
    public SpriteRenderer Rend;
    private Sprite ball8, simpleball, earth, moon, football, tenis, baseball, basketball, china, hazard;
    static private float GAT;


    
    void Start()
    {
        
        Rend = GetComponent<SpriteRenderer>();
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


        
        


    }
    private void Update()
    {
       

        if (GAT == 1)
        {
            Rend.sprite = ball8;
        }
        if (GAT == 2)
        {
            Rend.sprite = simpleball;
        }
        if (GAT == 3)
        {
            Rend.sprite = earth;
        }
        if (GAT == 4)
        {
            Rend.sprite = moon;
        }
        if (GAT == 5)
        {
            Rend.sprite = football;
        }
        if (GAT == 6)
        {
            Rend.sprite = tenis;
        }
        if (GAT == 7)
        {
            Rend.sprite = baseball;
        }
        if (GAT == 8)
        {
            Rend.sprite = basketball;
        }
        if (GAT == 9)
        {
            Rend.sprite = china;
        }
        if (GAT == 10)
        {
            Rend.sprite = hazard;
        }
    }
    public void Shit()
    {
        GAT = 1;
    }
    public void Shit2()
    {
        GAT = 2;
    }
    public void Shit3()
    {
        GAT = 3;
    }
    public void Shit4()
    {
        GAT = 4;
    }
    public void Shit5()
    {
        GAT = 5;
    }
    public void Shit6()
    {
        GAT = 6;
    }
    public void Shit7()
    {
        GAT = 7;
    }
    public void Shi8()
    {
        GAT = 8;
    }
    public void Shit9()
    {
        GAT = 9;
    }
    public void Shit10()
    {
        GAT = 10;
    }





}
