using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpAdd : MonoBehaviour
{
	public int collisionHealth;
	public string collisionTag;

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == collisionTag)
		{
			hp health = coll.gameObject.GetComponent<hp>();
			health.SetHealth(collisionHealth);
			Destroy(gameObject);
		}
	}
}
