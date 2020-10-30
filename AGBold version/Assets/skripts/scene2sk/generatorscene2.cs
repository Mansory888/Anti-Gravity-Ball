using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorscene2 : MonoBehaviour
{
    float X;
    public spawnscene2 sp;


    int[] pattern = new int[] { 1, 2, 3, 4 };




    void Start()
    {
        int randValue = Random.Range(0, pattern.Length);




        X = pattern[randValue];

        if (X == 1 )//yellow on black
        {
            U1();
        }
        if (X == 2 )
        {
            U2();
        }
        if (X == 3 )
        {
            U3();
        }
        if (X == 4 )
        {
            U4();
        }


    }


    private void U1()  //galben
    {

        sp.Y1();
        sp.Y2();
        sp.Y3();
        sp.Y4();
        sp.Y5();
        sp.R5();
    }
    private void U2()
    {
        sp.Y1();
        sp.Y2();
        sp.Y3();
        sp.Y4();
        sp.Y5();
        sp.Y6();
        sp.R6();
    }
    private void U3()
    {
        sp.Y1();
        sp.Y2();
        sp.Y3();
        sp.Y4();
        sp.Y5();
        sp.Y6();
        sp.Y7();
        sp.R7();
    }
    private void U4()
    {
        sp.Y1();
        sp.Y2();
        sp.Y3();
        sp.Y4();
        sp.Y5();
        sp.Y6();
        sp.Y7();
        sp.Y8();
        sp.R8();
    }















}
