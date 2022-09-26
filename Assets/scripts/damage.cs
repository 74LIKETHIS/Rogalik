using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damage : MonoBehaviour
{
	public int collisionDamage;
	public string collisionTag;

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == collisionTag)
		{
			hp health = coll.gameObject.GetComponent<hp>();
		health.TakeHit(collisionDamage);
		}
	}
}
