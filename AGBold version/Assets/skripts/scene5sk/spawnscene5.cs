using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscene5 : MonoBehaviour
{
    public GameObject finishu;
    public GameObject purple;


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



    // pruple obstacol



    public void P1()
    {
        GameObject p1 = Instantiate(purple) as GameObject;
        p1.transform.position = new Vector2(0, 2.81f);


    }
    public void P2()
    {
        GameObject p2 = Instantiate(purple) as GameObject;
        p2.transform.position = new Vector2(0, 1.14f);

    }
    public void P3()
    {
        GameObject p3 = Instantiate(purple) as GameObject;
        p3.transform.position = new Vector2(0, -0.56f);

    }
    public void P4()
    {
        GameObject p4 = Instantiate(purple) as GameObject;
        p4.transform.position = new Vector2(0, -2.26f);

    }
    public void P5()
    {
        GameObject p5 = Instantiate(purple) as GameObject;
        p5.transform.position = new Vector2(0, -3.96f);

    }
    public void P6()
    {
        GameObject p6 = Instantiate(purple) as GameObject;
        p6.transform.position = new Vector2(0, -5.56f);

    }
    public void P7()
    {
        GameObject p7 = Instantiate(purple) as GameObject;
        p7.transform.position = new Vector2(0, -7.26f);

    }
    public void P8()
    {
        GameObject p8 = Instantiate(purple) as GameObject;
        p8.transform.position = new Vector2(0, -8.96f);

    }
}
