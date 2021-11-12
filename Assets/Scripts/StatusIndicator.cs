using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusIndicator : MonoBehaviour
{

	[SerializeField] private RectTransform healthBarRect;
	[SerializeField] private Text healthText;
	
	// Use this for initialization
	void Start () {
		if (healthBarRect == null)
		{
			Debug.LogError("TIDAK ADA OBJEK");
		}
		if (healthText == null)
		{
			Debug.LogError("TIDAK ADA OBJEK");
		}
		
	}

	public void SetHealth(int _cur, int _max)
	{
		float value = (float)_max / _cur;
		
		healthBarRect.localScale = new Vector3(value, healthBarRect.localScale.y, healthBarRect.localScale.z);
		healthText.text = "Health : " +_max+ "/" + _cur;

	}
}
