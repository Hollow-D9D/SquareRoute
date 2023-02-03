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

		private void OnTriggerStay2D(Collider2D col)
		{
			if (Input.GetMouseButtonDown(1))
			{
				if (Random.Range(0, 2) == 1)
				{
					playerHealth.TakeDamage();
					Debug.Log(false);
				}
				else
					Debug.Log(true);

				Destroy(gameObject);
			}
		}
	}
}