using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public Vector3 startPoint;
    void Start()
    {
        startPoint = new Vector3(-8, 0, -9);
    }

    void Update()
    {
        if(transform.position.y < -50)
        {
            transform.position = startPoint;
        }
    }
}
