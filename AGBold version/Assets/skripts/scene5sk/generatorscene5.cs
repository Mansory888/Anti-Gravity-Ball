using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorscene5 : MonoBehaviour
{
    float X;
    public spawnscene5 sp;


    int[] pattern = new int[] { 1, 2, 3, 4 };


    void Start()
    {
        int randValue = Random.Range(0, pattern.Length);




        X = pattern[randValue];


        if (X == 1 ) //puple  on ice
        {
            P1();
        }
        if (X == 2 )
        {
            P2();
        }
        if (X == 3 )
        {
            P3();
        }
        if (X == 4 )
        {
            P4();
        }
    }


    //purple


    private void P1()
    {

        sp.P1();
        sp.P2();
        sp.P3();
        sp.P4();
        sp.P5();
        sp.R5();
    }

    private void P2()
    {
        sp.P1();
        sp.P2();
        sp.P3();
        sp.P4();
        sp.P5();
        sp.P6();
        sp.R6();
    }
    private void P3()
    {
        sp.P1();
        sp.P2();
        sp.P3();
        sp.P4();
        sp.P5();
        sp.P6();
        sp.P7();
        sp.R7();
    }
    private void P4()
    {
        sp.P1();
        sp.P2();
        sp.P3();
        sp.P4();
        sp.P5();
        sp.P6();
        sp.P7();
        sp.P8();
        sp.R8();
    }



}
