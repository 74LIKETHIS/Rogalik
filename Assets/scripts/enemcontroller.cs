using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemcontroller : MonoBehaviour
{
	[SerializeField] public Transform playerTr;
	[SerializeField] private NavMeshAgent agent;
	[SerializeField] public float stopDistantion;
	[SerializeField] public float retritDistantion;
	[SerializeField] private Animator animator;
	[SerializeField] public bool Attack;

	public void Start()
	{
		animator = GetComponent<Animator>();
		agent = GetComponent<NavMeshAgent>();
		agent.updateRotation = false;
		agent.updateUpAxis = false;

	}


	public void Update()
	{
		agent.SetDestination(playerTr.position);
		playerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		if (Vector2.Distance(transform.position, playerTr.position) > stopDistantion)
		{
			Flip();

			agent.SetDestination(playerTr.position);
			if(Attack == false)
			{
				animator.SetBool("walk", true);
				animator.SetBool("idle", false);
			}

		}
		else if (Vector2.Distance(transform.position, playerTr.position) < stopDistantion && Vector2.Distance(transform.position, playerTr.position) > retritDistantion)
		{
			
			animator.SetBool("walk", false);
			animator.SetBool("idle", true);
		}

	}

	public void Flip()
	{
		if (playerTr.transform.position.x < transform.position.x)
		{
			transform.localRotation = Quaternion.Euler(0, 180, 0);
		}
		else if (playerTr.transform.position.x > transform.position.x)
		{
			transform.localRotation = Quaternion.Euler(0, 0, 0);
		}
	}
}
