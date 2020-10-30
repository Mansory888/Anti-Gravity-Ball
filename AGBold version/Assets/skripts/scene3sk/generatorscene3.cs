using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorscene3 : MonoBehaviour
{
    float X;
    public spawnscene3 sp;


    int[] pattern = new int[] { 1, 2, 3, 4 };




    void Start()
    {
        int randValue = Random.Range(0, pattern.Length);




        X = pattern[randValue];

        if (X == 1 )//white on red
        {
            K1();
        }
        if (X == 2 )
        {
            K2();
        }
        if (X == 3 )
        {
            K3();
        }
        if (X == 4 )
        {
            K4();
        }

    }



    //white


    private void K1()
    {

        sp.W1();
        sp.W2();
        sp.W3();
        sp.W4();
        sp.W5();
        sp.R5();
    }

    private void K2()
    {
        sp.W1();
        sp.W2();
        sp.W3();
        sp.W4();
        sp.W5();
        sp.W6();
        sp.R6();
    }
    private void K3()
    {
        sp.W1();
        sp.W2();
        sp.W3();
        sp.W4();
        sp.W5();
        sp.W6();
        sp.W7();
        sp.R7();
    }
    private void K4()
    {
        sp.W1();
        sp.W2();
        sp.W3();
        sp.W4();
        sp.W5();
        sp.W6();
        sp.W7();
        sp.W8();
        sp.R8();
    }





}
