using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorscene4 : MonoBehaviour
{
    float X;
    public spawnscene4 sp;


    int[] pattern = new int[] { 1, 2, 3, 4 };

    void Start()
    {
        int randValue = Random.Range(0, pattern.Length);




        X = pattern[randValue];


        if (X == 1 ) //blue on orange
        {
            Q1();
        }
        if (X == 2 )
        {
            Q2();
        }
        if (X == 3 )
        {
            Q3();
        }
        if (X == 4 )
        {
            Q4();
        }
















    }

    //blue


    private void Q1()
    {

        sp.N1();
        sp.N2();
        sp.N3();
        sp.N4();
        sp.N5();
        sp.R5();
    }

    private void Q2()
    {
        sp.N1();
        sp.N2();
        sp.N3();
        sp.N4();
        sp.N5();
        sp.N6();
        sp.R6();
    }
    private void Q3()
    {
        sp.N1();
        sp.N2();
        sp.N3();
        sp.N4();
        sp.N5();
        sp.N6();
        sp.N7();
        sp.R7();
    }
    private void Q4()
    {
        sp.N1();
        sp.N2();
        sp.N3();
        sp.N4();
        sp.N5();
        sp.N6();
        sp.N7();
        sp.N8();
        sp.R8();
    }








}
