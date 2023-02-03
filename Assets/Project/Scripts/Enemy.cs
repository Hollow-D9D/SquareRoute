using UnityEngine;

namespace Project.Scripts
{
	public class Enemy : MonoBehaviour
	{
		private int value;

		private void OnTriggerStay2D(Collider2D col)
		{
			if (Input.GetMouseButtonDown(1))
			{
				Destroy(gameObject);
			}
		}
	}
}
