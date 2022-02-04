using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sentry : MonoBehaviour
{
    private Transform spawnLocation;
    public GameObject alertLight;

    public float rotationSpeed;

    private void Start()
    {
        spawnLocation = this.transform;
    }

    void Update()
    {
        this.transform.Rotate(0,0,rotationSpeed * Time.deltaTime);
        print("Rotate");
    }

    public void IncreaseRotationSpeed()
    {
        rotationSpeed = rotationSpeed + 50;
    }

    public void SelfDestruct()
    {
        Destroy(this.gameObject);
    }

    public void SpawnAlertLight()
    {
        print("Spawn light");
        alertLight = Instantiate(alertLight, spawnLocation.position, Quaternion.identity);
    }

    public void DestroyAlertLight()
    {
        print("Destroy light");
        Destroy(alertLight);
    }
}
