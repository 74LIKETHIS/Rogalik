using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Rigidbody2D physic;

    public Transform player;

    public float speed;

    public float agrDistance;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        physic = GetComponent<Rigidbody2D>();
       

    }


    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if (distToPlayer < agrDistance)
        {
            StartHuntingX();
        }

        else
        {
            StopHunting();
        }
		if (distToPlayer < agrDistance)
		{
			StartHuntingY();
		}
        else
        {
            StopHunting();
        }
	}

    //void FixedUpdate()
    //{
    //    player.position = Vector2.MoveTowards(player.position, player.position,speed* Time.fixedDeltaTime);
    //}

    void StartHuntingX()
    {
        if (player.position.x < transform.position.x)
        {
            physic.velocity = new Vector2(-speed, 0);
            transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            physic.velocity = new Vector2(speed, 0);
            transform.localScale = new Vector2(1, 1);
        }



    }

    void StartHuntingY()
    {
		if (player.position.y < transform.position.y)
		{
			physic.velocity = new Vector2(0, -speed);

		}
		else
		{
			physic.velocity = new Vector2(0, speed);

		}
	}

    void StopHunting()
    {

        physic.velocity = new Vector2(0, 0);

    }
}
