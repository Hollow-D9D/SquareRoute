using UnityEngine;

namespace Project.Scripts.Player
{
	public class PlayerShooting : MonoBehaviour
	{

		#region Fields
		
		[SerializeField] private Transform bulletSpawn;
		[SerializeField] private GameObject bulletPrefab;
		private Vector3 mousePosition;
		private Vector3 lookVector;
		private GameObject bulletInstance;

		#endregion

		#region Unity Lifecycle

		private void Update()
		{
			mousePosition.x = Input.mousePosition.x;
			mousePosition.y = Input.mousePosition.y;
			lookVector = (mousePosition - transform.position).normalized;
			bulletSpawn.right = lookVector;
			if (Input.GetMouseButtonDown(0))
			{
				bulletInstance = Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation);
				bulletInstance.transform.right = lookVector;
			}
		}

		#endregion
	}
}