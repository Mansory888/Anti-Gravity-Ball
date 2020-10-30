using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    float X;
    public spawn sp;
    
    
    int[] pattern = new int[] { 1, 2, 3, 4 };
    



    void Start()
    {
        int randValue = Random.Range(0, pattern.Length);
        


        
        X = pattern[randValue];



        if (X == 1 )//black on white
        {
            T1();
        }
        if (X == 2 )
        {
            T2();
        }
        if (X == 3 )
        {
            T3();
        }
        if (X == 4 )
        {
            T4();
        }

        


        










    }

    private void T1() //negru 
    {

        sp.B1();
        sp.B2();
        sp.B3();
        sp.B4();
        sp.B5();
        sp.R5();
    }

    private void T2()
    {
        sp.B1();
        sp.B2();
        sp.B3();
        sp.B4();
        sp.B5();
        sp.B6();
        sp.R6();
    }
    private void T3()
    {
        sp.B1();
        sp.B2();
        sp.B3();
        sp.B4();
        sp.B5();
        sp.B6();
        sp.B7();
        sp.R7();
    }
    private void T4()
    {
        sp.B1();
        sp.B2();
        sp.B3();
        sp.B4();
        sp.B5();
        sp.B6();
        sp.B7();
        sp.B8();
        sp.R8();
    }
    

}


    
