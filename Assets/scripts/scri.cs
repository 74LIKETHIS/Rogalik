using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
	[SerializeField] public float speed;
	[SerializeField] private Vector2 direction;
	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private Animator animator;

	public void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	public void Update()
	{
		direction.x = Input.GetAxisRaw("Horizontal");
		direction.y = Input.GetAxisRaw("Vertical");

		animator.SetFloat("Horizontal", direction.x);
		animator.SetFloat("speed", direction.sqrMagnitude);
	}

	public void FixedUpdate()
	{
		

		rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
	}

}
