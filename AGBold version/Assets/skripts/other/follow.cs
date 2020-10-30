using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform player;
    
    private bool T;
   

    void Update()
    {
        if (player.position.y < transform.position.y && T ==false )
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }

       




    }
    void OnTriggerEnter2D(Collider2D col)
    {

       if (col.tag == "Finish")
        {

            T = true;


        }
    }
   


}