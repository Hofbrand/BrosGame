using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
	//hp
	const int points = 10;

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			CharacterController2D player = collision.gameObject.GetComponent<CharacterController2D>();
			player.ApplyHeal(points);
			Destroy(gameObject);
		}
	}
}
