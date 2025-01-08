
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolSystem : MonoBehaviour
{
    [SerializeField] Transform path;
    NavMeshAgent agent;
    List<Vector3> pathPointsList = new List<Vector3>();
    int currentIndex;
    Vector3 currentPath;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        foreach (Transform pathPoints in path)
        {
            pathPointsList.Add(pathPoints.position);
        }
    }

    private void Start()
    {
        StartCoroutine(PatrolAndWait());
    }

    private IEnumerator PatrolAndWait()
    {
        while (true)
        {
            CalcularDestino();
            agent.SetDestination(currentPath);
            yield return new WaitUntil(() => agent.remainingDistance <= 0);
            yield return Random.Range(0, 4f);
        }
    }

    private void CalcularDestino()
    {
        currentIndex ++;

        if (currentIndex >= pathPointsList.Count)
        {
            currentIndex = 0;
        }
        currentPath = pathPointsList[currentIndex];
    }

    void Update()
    {
        
    }
}
