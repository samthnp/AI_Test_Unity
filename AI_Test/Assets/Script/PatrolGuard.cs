using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolGuard : MonoBehaviour
{
    Transform spawnLocation;
    public GameObject alertLight;

    private void Start()
    {
        spawnLocation = this.transform;
    }

    public void SpawnAlertLight()
    {
        print("Spawn light");
        alertLight = Instantiate(alertLight, spawnLocation.position, Quaternion.identity);
        AttachLightToParent();
    }

    private void AttachLightToParent()
    {
        alertLight.transform.parent = gameObject.transform;
    }

    public void DestroyAlertLight()
    {
        print("Destroy light");
        Destroy(alertLight);
    }
}
