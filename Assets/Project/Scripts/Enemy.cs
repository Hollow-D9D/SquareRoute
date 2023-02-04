using General;
using Project.Scripts.Player;
using UnityEngine;

namespace Project.Scripts
{
	public class Enemy : MonoBehaviour
	{

		#region MyRegion

		[SerializeField] private int value;
		private PlayerHealth playerHealth;
		private float sqrt;

		#endregion

		#region Unity Lifecycle

		private void Start() => SL.GetSingle(out playerHealth);

		private void OnTriggerEnter2D(Collider2D col)
		{
			if (col.GetComponent<CharacterMovement>())
			{
				sqrt = Mathf.Sqrt(value);
				if (sqrt == (int)sqrt)
				{
					//TODO score logic
				}
				else
				{
					playerHealth.TakeDamage();
				}

				Destroy(gameObject);
			}
			else
				value--;

		}

		#endregion
	}
}