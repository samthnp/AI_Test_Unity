using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolGuard : MonoBehaviour
{
    Transform spawnLocation;
    public GameObject alertLight;

    private SkinnedMeshRenderer mesh;

    private void Start()
    {
        spawnLocation = this.transform;
        mesh = GetComponent<SkinnedMeshRenderer>();
    }

    public void HideMesh ()
    {
        mesh.enabled = false;
    }

    public void UnhideMesh()
    {
        mesh.enabled = true;
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

    public void AlertAttackBot()
    {
        AttackBot.isAlerted = true;
        print("Alert Attack Bot");
    }
}
