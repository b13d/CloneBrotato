using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform targetPlayer;
    
    void Start()
    {
        targetPlayer = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        Debug.Log(targetPlayer);

        transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, Time.deltaTime);
    }
}
