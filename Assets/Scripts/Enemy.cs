using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	private void OnCollisionEnter2D(Collision2D other)
	{
		Player _player = other.collider.GetComponent<Player>();
		if (_player != null)
		{
			_player.DamagePlayer(25);
		}
	}
}
