using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableItemUI : MonoBehaviour {

	[SerializeField] private Text collectText;
	// Use this for initialization
	private void Awake()
	{
		collectText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		collectText.text = "Collectable Item: " + GameMaster.RemainingItem.ToString() + "/5";
	}
}
