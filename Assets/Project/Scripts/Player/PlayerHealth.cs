using General;
using UnityEngine;

namespace Project.Scripts.Player
{
	public class PlayerHealth : MonoBehaviour, IService
	{
		private int healthCount = 2;
		[SerializeField] private GameObject[] healthIcons;

		private void Awake() => SL.AddSingle(this, SetMode.Force);

		public void TakeDamage()
		{
			healthIcons[healthCount].SetActive(false);
			healthCount--;
			if (healthCount < 0)
			{
				Debug.Log("Lost");
			}
		}
	}
}