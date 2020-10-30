using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsacolmov : MonoBehaviour
{
    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed;
    private Vector3 startPos;

    float[] Hard = { -2.2f, -2.1f, -2f, -1.9f, -1.8f, -1.7f, -1.6f, -1.5f, -1.4f, -1.3f, -1.2f, -1.1f, 1, 1.1f, 1.2f, 1.3f, 1.4f, 1.5f, 1.6f, 1.7f, 1.8f, 1.8f, 1.9f, 2f, 2.2f };
    float[] Medium = { -1.7f, -1.6f, -1.5f, -1.4f, -1.3f, -1.2f, -1.1f, 1, 1.1f, 1.2f, 1.3f, 1.4f, 1.5f, 1.6f, 1.7f };
    float[] ez = { -1.4f, -1.3f, -1.2f, -1.1f, 1, 1.1f, 1.2f, 1.3f, 1.4f};





    void Start()
    {
        startPos = transform.position;
        if (lvlscor.lvlval < 10f)
        {
            speed = ez[Random.Range(0, 9)];
            
        }

        if (lvlscor.lvlval > 10 && lvlscor.lvlval<=50)
        {
            speed = Medium[Random.Range(0, 15)];
            
        }
        if (lvlscor.lvlval > 50)
        {
            speed = Hard[Random.Range(0, 25)];
            
        }

    }

    void Update()
    {
        


        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }









    }





