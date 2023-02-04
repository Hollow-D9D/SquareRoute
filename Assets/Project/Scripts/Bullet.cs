using General;
using Project.Scripts.Player;
using UnityEngine;

namespace Project.Scripts
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class Bullet : MonoBehaviour
	{
		#region Fields

		[SerializeField] private Rigidbody2D rigidbody2D;
		[SerializeField] private Vector2 forcePower = new Vector2(5, 0);
		private PlayerShooting playerShooting;

		#endregion

		#region Unity Lifecycle

		private void Start()
		{
			SL.GetSingle(out playerShooting);
			rigidbody2D.AddRelativeForce(forcePower, ForceMode2D.Impulse);
		}

		private void OnCollisionEnter2D(Collision2D col)
		{
			playerShooting.RemoveBullet(gameObject);
			Destroy(gameObject);
		}

		#endregion
	}
}