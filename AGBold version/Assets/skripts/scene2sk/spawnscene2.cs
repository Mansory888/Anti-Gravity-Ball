using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscene2 : MonoBehaviour
{
    public GameObject finishu;
    public GameObject yellow;



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

    // yellow obstacol

    public void Y1()
    {
        GameObject y1 = Instantiate(yellow) as GameObject;
        y1.transform.position = new Vector2(0, 2.81f);


    }
    public void Y2()
    {
        GameObject y2 = Instantiate(yellow) as GameObject;
        y2.transform.position = new Vector2(0, 1.14f);

    }
    public void Y3()
    {
        GameObject y3 = Instantiate(yellow) as GameObject;
        y3.transform.position = new Vector2(0, -0.56f);

    }
    public void Y4()
    {
        GameObject y4 = Instantiate(yellow) as GameObject;
        y4.transform.position = new Vector2(0, -2.26f);

    }
    public void Y5()
    {
        GameObject y5 = Instantiate(yellow) as GameObject;
        y5.transform.position = new Vector2(0, -3.96f);

    }
    public void Y6()
    {
        GameObject y6 = Instantiate(yellow) as GameObject;
        y6.transform.position = new Vector2(0, -5.56f);

    }
    public void Y7()
    {
        GameObject y7 = Instantiate(yellow) as GameObject;
        y7.transform.position = new Vector2(0, -7.26f);

    }
    public void Y8()
    {
        GameObject y8 = Instantiate(yellow) as GameObject;
        y8.transform.position = new Vector2(0, -8.96f);

    }


}
