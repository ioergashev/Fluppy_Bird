using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (GameControl.instance.gameOver)
			return;

		if (other.GetComponent<Bird>() != null)
		{ 
			GameControl.instance.CoinCollected();
			gameObject.SetActive(false);
		}
	}
}
