using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorscene7 : MonoBehaviour
{
    float X;
    public spawnscene7 sp;


    int[] pattern = new int[] { 1, 2, 3, 4 };




    void Start()
    {
        int randValue = Random.Range(0, pattern.Length);




        X = pattern[randValue];


        if (X == 1) //bej on purple
        {
            J1();
        }
        if (X == 2)
        {
            J2();
        }
        if (X == 3 )
        {
            J3();
        }
        if (X == 4 )
        {
            J4();
        }
    }
    //bej

    private void J1()
    {

        sp.J1();
        sp.J2();
        sp.J3();
        sp.J4();
        sp.J5();
        sp.R5();
    }

    private void J2()
    {
        sp.J1();
        sp.J2();
        sp.J3();
        sp.J4();
        sp.J5();
        sp.J6();
        sp.R6();
    }
    private void J3()
    {
        sp.J1();
        sp.J2();
        sp.J3();
        sp.J4();
        sp.J5();
        sp.J6();
        sp.J7();
        sp.R7();
    }
    private void J4()
    {
        sp.J1();
        sp.J2();
        sp.J3();
        sp.J4();
        sp.J5();
        sp.J6();
        sp.J7();
        sp.J8();
        sp.R8();

    }
}
