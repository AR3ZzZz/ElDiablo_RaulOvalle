using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetector : MonoBehaviour
{
    [SerializeField] private float colorChange;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Material wallMaterial = other.GetComponent<MeshRenderer>().material;
            Color tranparency = new Color(wallMaterial.color.r, wallMaterial.color.g, wallMaterial.color.b, .05f);
            wallMaterial.DOColor(tranparency, colorChange);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Material wallMaterial = other.GetComponent<MeshRenderer>().material;
            Color opaque = new Color(wallMaterial.color.r, wallMaterial.color.g, wallMaterial.color.b, 1f);
            wallMaterial.DOColor(opaque, colorChange);
        }
    }
}
