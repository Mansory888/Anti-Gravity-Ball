using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscene3 : MonoBehaviour
{
    public GameObject finishu;
    public GameObject white;

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





    //white obstacol


    public void W1()
    {
        GameObject w1 = Instantiate(white) as GameObject;
        w1.transform.position = new Vector2(0, 2.81f);


    }
    public void W2()
    {
        GameObject w2 = Instantiate(white) as GameObject;
        w2.transform.position = new Vector2(0, 1.14f);

    }
    public void W3()
    {
        GameObject w3 = Instantiate(white) as GameObject;
        w3.transform.position = new Vector2(0, -0.56f);

    }
    public void W4()
    {
        GameObject w4 = Instantiate(white) as GameObject;
        w4.transform.position = new Vector2(0, -2.26f);

    }
    public void W5()
    {
        GameObject w5 = Instantiate(white) as GameObject;
        w5.transform.position = new Vector2(0, -3.96f);

    }
    public void W6()
    {
        GameObject w6 = Instantiate(white) as GameObject;
        w6.transform.position = new Vector2(0, -5.56f);

    }
    public void W7()
    {
        GameObject w7 = Instantiate(white) as GameObject;
        w7.transform.position = new Vector2(0, -7.26f);

    }
    public void W8()
    {
        GameObject w8 = Instantiate(white) as GameObject;
        w8.transform.position = new Vector2(0, -8.96f);

    }


}
