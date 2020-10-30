using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    
    public GameObject black;
    public GameObject finishu;
    


    // obstacol black
    public void B1()
    {
        GameObject b1 = Instantiate(black) as GameObject;
        b1.transform.position = new Vector2(0, 2.81f);


    }
    public void B2()
    {
        GameObject b2 = Instantiate(black) as GameObject;
        b2.transform.position = new Vector2(0, 1.14f);

    }
    public void B3()
    {
        GameObject b3 = Instantiate(black) as GameObject;
        b3.transform.position = new Vector2(0, -0.56f);

    }
    public void B4()
    {
        GameObject b4 = Instantiate(black) as GameObject;
        b4.transform.position = new Vector2(0, -2.26f);

    }
    public void B5()
    {
        GameObject b5 = Instantiate(black) as GameObject;
        b5.transform.position = new Vector2(0, -3.96f);

    }
    public void B6()
    {
        GameObject b6 = Instantiate(black) as GameObject;
        b6.transform.position = new Vector2(0, -5.56f);

    }
    public void B7()
    {
        GameObject b7 = Instantiate(black) as GameObject;
        b7.transform.position = new Vector2(0, -7.26f);

    }
    public void B8()
    {
        GameObject b8 = Instantiate(black) as GameObject;
        b8.transform.position = new Vector2(0, -8.96f);

    }
    // red finushu
    public void R5()
    {
        GameObject r5 = Instantiate(finishu) as GameObject;
        r5.transform.position = new Vector2(0, -5.56f);

    }
    public void R6()
    {
        GameObject r6 = Instantiate(finishu) as GameObject;
        r6.transform.position = new Vector2(0, -7.26f);

    }
    public void R7()
    {
        GameObject r7 = Instantiate(finishu) as GameObject;
        r7.transform.position = new Vector2(0, -8.96f);

    }
    public void R8()
    {
        GameObject r8 = Instantiate(finishu) as GameObject;
        r8.transform.position = new Vector2(0, -10.66f);

    }

    
}
