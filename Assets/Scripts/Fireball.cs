using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject player;
    Vector3 dir;


    void Start()
    {
        dir = (player.transform.position - transform.position).normalized;
        

    }

    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
        Debug.Log(dir);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Destroy(gameObject);
            Debug.Log("pp");
        }
        else if(other.CompareTag("Untagged") || other.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            Debug.Log("kkk");
        }
    }
}
