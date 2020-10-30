using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desroy : MonoBehaviour
{
   
    

   
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "MainCamera")
        {
            
            Destroy(this.gameObject);


        }
    }
}
