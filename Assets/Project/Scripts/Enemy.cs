using General;
using Project.Scripts.Player;
using UnityEngine;

namespace Project.Scripts
{
	public class Enemy : MonoBehaviour
	{
		private PlayerHealth playerHealth;
		private int value;

		private void Start() => SL.GetSingle(out playerHealth);

		private void OnTriggerEnter2D(Collider2D col)
		{
			if (Random.Range(0, 2) == 1)
			{
				playerHealth.TakeDamage();
				Debug.Log(false);
			}
			Destroy(gameObject);
			
		}
	}
}