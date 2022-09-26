using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public Slider Slider;
	public hp playerHealth;
	

	private void Start()
	{
		Slider = GetComponent<Slider>();
		SetMaxHealth(playerHealth.maxHealth);
	}

	private void Update()
	{
		SetHealth(playerHealth.health);
	}

	public void SetMaxHealth(int health)
	{
		Slider.maxValue = health;
		Slider.value = health;
	}
	public void SetHealth(int health)
	{
		Slider.value = health;
	}
}
