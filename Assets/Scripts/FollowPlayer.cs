using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    Zombi zombi;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
        zombi = GetComponent<Zombi>();
    }

    void Update()
    {
        if (zombi.CanWalk)
        {
            // ゾンビがプレイヤーに向かってくる
            agent.destination = player.transform.position;
        }
        else
        {
            agent.isStopped = true;
        }
    }
}
