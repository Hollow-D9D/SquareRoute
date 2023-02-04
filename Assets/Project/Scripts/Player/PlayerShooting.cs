using UnityEngine;

namespace Project.Scripts.Player
{
	public class PlayerShooting : MonoBehaviour
	{

		#region Fields
		
		[SerializeField] private Transform bulletSpawn;
		[SerializeField] private GameObject bulletPrefab;
		private Camera camera;
		private Vector3 mousePosition;
		private Vector3 lookVector;
		private GameObject bulletInstance;
		
		#endregion

		#region Unity Lifecycle

		private void Start() => camera=Camera.main;

		private void Update()
		{
			GetMousePos();
			lookVector = (mousePosition - camera.WorldToScreenPoint(transform.position)).normalized;
			transform.right = lookVector;
			if (Input.GetMouseButtonDown(0))
				Shoot();
		}

		#endregion

		#region Methods

		private void Shoot()
		{
			bulletInstance = Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation);
			bulletInstance.transform.right = lookVector;
		}

		private void GetMousePos()
		{
			mousePosition.x = Input.mousePosition.x;
			mousePosition.y = Input.mousePosition.y;
		}

		#endregion
	}
}