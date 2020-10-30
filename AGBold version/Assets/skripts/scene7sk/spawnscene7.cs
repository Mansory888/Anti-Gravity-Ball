using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscene7 : MonoBehaviour
{



    public GameObject finishu;
    public GameObject bej;



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


    //bej object



    public void J1()
    {
        GameObject j1 = Instantiate(bej) as GameObject;
        j1.transform.position = new Vector2(0, 2.81f);


    }
    public void J2()
    {
        GameObject j2 = Instantiate(bej) as GameObject;
        j2.transform.position = new Vector2(0, 1.14f);

    }
    public void J3()
    {
        GameObject j3 = Instantiate(bej) as GameObject;
        j3.transform.position = new Vector2(0, -0.56f);

    }
    public void J4()
    {
        GameObject j4 = Instantiate(bej) as GameObject;
        j4.transform.position = new Vector2(0, -2.26f);

    }
    public void J5()
    {
        GameObject j5 = Instantiate(bej) as GameObject;
        j5.transform.position = new Vector2(0, -3.96f);

    }
    public void J6()
    {
        GameObject j6 = Instantiate(bej) as GameObject;
        j6.transform.position = new Vector2(0, -5.56f);

    }
    public void J7()
    {
        GameObject j7 = Instantiate(bej) as GameObject;
        j7.transform.position = new Vector2(0, -7.26f);

    }
    public void J8()
    {
        GameObject j8 = Instantiate(bej) as GameObject;
        j8.transform.position = new Vector2(0, -8.96f);

    }
}
