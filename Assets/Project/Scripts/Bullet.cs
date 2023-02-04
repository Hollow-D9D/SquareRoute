using UnityEngine;

namespace Project.Scripts
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class Bullet : MonoBehaviour
	{
		#region Fields

		[SerializeField] private Rigidbody2D rigidbody2D;
		[SerializeField] private Vector2 forcePower = new Vector2(5, 0);

		#endregion

		#region Unity Lifecycle

		private void Start() => rigidbody2D.AddRelativeForce(forcePower, ForceMode2D.Impulse);
		
		private void OnCollisionEnter2D(Collision2D col) => Destroy(gameObject);

		#endregion
	}
}