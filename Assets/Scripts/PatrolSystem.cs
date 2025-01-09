
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolSystem : MonoBehaviour
{
    [SerializeField] Enemy main;
    [SerializeField] float patrolSpeed;

    [SerializeField] Transform path;
    NavMeshAgent agent;
    List<Vector3> pathPointsList = new List<Vector3>();
    int currentIndex = -1;
    Vector3 currentPath;
    void Awake()
    {
        main.Patrol = this;
        agent = GetComponent<NavMeshAgent>();
        foreach (Transform pathPoints in path)
        {
            pathPointsList.Add(pathPoints.position);
        }
    }

    private void OnEnable()
    {
        agent.speed = patrolSpeed;
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            StopAllCoroutines();
            main.CombatStart(other.transform);
        }
    }
}
