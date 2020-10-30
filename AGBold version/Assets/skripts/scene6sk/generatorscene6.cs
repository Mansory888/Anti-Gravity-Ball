using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorscene6 : MonoBehaviour
{
    float X;
    public spawnscene6 sp;


    int[] pattern = new int[] { 1, 2, 3, 4 };



    void Start()
    {
        int randValue = Random.Range(0, pattern.Length);




        X = pattern[randValue];


        if(X == 1 ) //pink on blue
        {
            Z1();
        }
        if (X == 2 )
        {
            Z2();
        }
        if (X == 3 )
        {
            Z3();
        }
        if (X == 4 )
        {
            Z4();
        }
    }
    //pink

    private void Z1()
    {

        sp.Z1();
        sp.Z2();
        sp.Z3();
        sp.Z4();
        sp.Z5();
        sp.R5();
    }

    private void Z2()
    {
        sp.Z1();
        sp.Z2();
        sp.Z3();
        sp.Z4();
        sp.Z5();
        sp.Z6();
        sp.R6();
    }
    private void Z3()
    {
        sp.Z1();
        sp.Z2();
        sp.Z3();
        sp.Z4();
        sp.Z5();
        sp.Z6();
        sp.Z7();
        sp.R7();
    }
    private void Z4()
    {
        sp.Z1();
        sp.Z2();
        sp.Z3();
        sp.Z4();
        sp.Z5();
        sp.Z6();
        sp.Z7();
        sp.Z8();
        sp.R8();
    }


}
