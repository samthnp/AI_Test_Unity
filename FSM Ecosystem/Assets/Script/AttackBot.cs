using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBot : MonoBehaviour
{
    private Transform spawnLocation;

    public float rotationSpeed = 5f;

    public static bool isAlerted = false;

    private void Start()
    {
        spawnLocation = this.transform;
    }

    public void Spin()
    {
        transform.Rotate(0f,5f,0f, Space.Self);
        print("Spin");
    }

    public void Greet()
    {
        transform.Rotate(0f,0f,5f, Space.Self);
        print("Greet");
    }
    
}
