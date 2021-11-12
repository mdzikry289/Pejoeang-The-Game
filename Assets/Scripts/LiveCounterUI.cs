using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class LiveCounterUI : MonoBehaviour
{

	[SerializeField] private Text liveText;
	// Use this for initialization
	private void Awake()
	{
		liveText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		liveText.text = "LIVES: " + GameMaster.RemainingLives.ToString();
	}
}
