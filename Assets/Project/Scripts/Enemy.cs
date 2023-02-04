using General;
using Project.Scripts.Player;
using TMPro;
using UnityEngine;

namespace Project.Scripts
{
	public class Enemy : MonoBehaviour
	{

		#region MyRegion

		[SerializeField] private int value;
		[SerializeField] private TextMeshProUGUI valueText;
		private PlayerHealth playerHealth;
		private PlayerShooting playerShooting;
		private float sqrt;

		#endregion

		#region Unity Lifecycle

		private void Start()
		{
			SL.GetSingle(out playerHealth);
			SL.GetSingle(out playerShooting);
			SetValue();
		}


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
			{
				if (playerShooting.ShootState == ShootState.Substraction)
					value--;
				else
					value++;
				SetValue();
			}

		}

		#endregion
		
		private void SetValue() => valueText.text = value.ToString();
	}
}