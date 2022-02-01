using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sentry : MonoBehaviour
{
    private Transform spawnLocation;
    public GameObject alertLight;

    private void Start()
    {
        spawnLocation = this.transform;
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
