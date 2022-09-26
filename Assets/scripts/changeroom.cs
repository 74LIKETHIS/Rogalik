using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeroom : MonoBehaviour
{
    public Vector3 cameraChangePos;
	public Vector3 playerChangePos;
	private Camera cam;

	public void Start()
	{
		cam = Camera.main.GetComponent<Camera>();

	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			other.transform.position += playerChangePos;
			cam.transform.position += cameraChangePos;
		}
	}
}
