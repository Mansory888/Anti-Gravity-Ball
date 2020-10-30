using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bound : MonoBehaviour
{

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.71f, 1.90f),
            Mathf.Clamp(transform.position.y, -1f, 5f), transform.position.z);
    }

}
