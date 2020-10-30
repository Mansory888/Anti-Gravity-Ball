using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscene4 : MonoBehaviour
{
    public GameObject finishu;
    public GameObject blue;

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
    //blue obstacol



    public void N1()
    {
        GameObject n1 = Instantiate(blue) as GameObject;
        n1.transform.position = new Vector2(0, 2.81f);


    }
    public void N2()
    {
        GameObject n2 = Instantiate(blue) as GameObject;
        n2.transform.position = new Vector2(0, 1.14f);

    }
    public void N3()
    {
        GameObject n3 = Instantiate(blue) as GameObject;
        n3.transform.position = new Vector2(0, -0.56f);

    }
    public void N4()
    {
        GameObject n4 = Instantiate(blue) as GameObject;
        n4.transform.position = new Vector2(0, -2.26f);

    }
    public void N5()
    {
        GameObject n5 = Instantiate(blue) as GameObject;
        n5.transform.position = new Vector2(0, -3.96f);

    }
    public void N6()
    {
        GameObject n6 = Instantiate(blue) as GameObject;
        n6.transform.position = new Vector2(0, -5.56f);

    }
    public void N7()
    {
        GameObject n7 = Instantiate(blue) as GameObject;
        n7.transform.position = new Vector2(0, -7.26f);

    }
    public void N8()
    {
        GameObject n8 = Instantiate(blue) as GameObject;
        n8.transform.position = new Vector2(0, -8.96f);

    }

}
