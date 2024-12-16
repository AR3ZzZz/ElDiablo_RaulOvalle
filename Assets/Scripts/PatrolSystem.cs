using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolSystem : MonoBehaviour
{
    [SerializeField] Transform path;

    List<Transform> pathPointsList = new List<Transform>();
    void Start()
    {
        foreach (Transform pathPoints in path)
        {

        }
    }

    void Update()
    {
        
    }
}
