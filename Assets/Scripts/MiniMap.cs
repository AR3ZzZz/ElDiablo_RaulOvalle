using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    [SerializeField] Player player;
    Vector3 distanceToPlayer;

    void Start()
    {
        distanceToPlayer = transform.position - player.transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position =player.transform.position + distanceToPlayer;
    }
}
