using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour
{

    public Material normalMaterial;
    public Material emissiveMaterial;

    public void EmissiveLightActivate()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        Material oldMaterial = meshRenderer.material;
        meshRenderer.material = emissiveMaterial;

    }
    
    public void EmissiveLightDeactivate()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        Material oldMaterial = meshRenderer.material;
        meshRenderer.material = normalMaterial;

    }

}
