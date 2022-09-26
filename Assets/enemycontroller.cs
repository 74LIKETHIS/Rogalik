using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemycontroller : MonoBehaviour
{
    public Transform playerTr;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //agent.UpdateRotation = false;
        //agent.UpdateUpAxis = false;
        
    }

    
    void Update()
    {
        agent.SetDestination(playerTr.position);
    }
}
