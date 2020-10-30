using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscene6 : MonoBehaviour
{
    public GameObject finishu;
    public GameObject pink;

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

    //pink object

    public void Z1()
    {
        GameObject z1 = Instantiate(pink) as GameObject;
        z1.transform.position = new Vector2(0, 2.81f);


    }
    public void Z2()
    {
        GameObject z2 = Instantiate(pink) as GameObject;
        z2.transform.position = new Vector2(0, 1.14f);

    }
    public void Z3()
    {
        GameObject z3 = Instantiate(pink) as GameObject;
        z3.transform.position = new Vector2(0, -0.56f);

    }
    public void Z4()
    {
        GameObject z4 = Instantiate(pink) as GameObject;
        z4.transform.position = new Vector2(0, -2.26f);

    }
    public void Z5()
    {
        GameObject z5 = Instantiate(pink) as GameObject;
        z5.transform.position = new Vector2(0, -3.96f);

    }
    public void Z6()
    {
        GameObject z6 = Instantiate(pink) as GameObject;
        z6.transform.position = new Vector2(0, -5.56f);

    }
    public void Z7()
    {
        GameObject z7 = Instantiate(pink) as GameObject;
        z7.transform.position = new Vector2(0, -7.26f);

    }
    public void Z8()
    {
        GameObject z8 = Instantiate(pink) as GameObject;
        z8.transform.position = new Vector2(0, -8.96f);

    }


}
