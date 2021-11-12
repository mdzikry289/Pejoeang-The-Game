using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	[System.Serializable]
	public class PlayerStats
	{
		public int maxHealth = 100;
		private int _curHealth;

        public int curHealth
		{
			get { return _curHealth; }
			set { _curHealth = Mathf.Clamp(value, 0, maxHealth); }
		}


        public void Init()
		{
			curHealth = maxHealth;
        }
    }

	public PlayerStats Stats = new PlayerStats();
    
    public int fallBoundary = -20;

	[SerializeField] private StatusIndicator statusIndicator;
	[SerializeField] private Text collectText;
	private void Start()
	{
		Stats.Init();
		
		if (statusIndicator == null)
		{
			Debug.LogError("Tidak ada objek");
		}
		else
		{
			statusIndicator.SetHealth(Stats.curHealth, Stats.maxHealth);
		}
	}

	void Update()
	{
		
		if (transform.position.y <= fallBoundary)
		{
			DamagePlayer(9999999);
		}
	}

	public void DamagePlayer(int damage )
	{
		Stats.maxHealth -= damage;
		if (Stats.maxHealth <= 0)
		{
			GameMaster.KillPlayer(this);
		}
		statusIndicator.SetHealth(Stats.curHealth, Stats.maxHealth);
    }
    [SerializeField] private GameObject finishGameUI;
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Box"))
		{
			other.gameObject.SetActive(false);
            if (other.gameObject.name == "Box1")
            {
                GameMaster.box1 = false;
            }
            else if (other.gameObject.name == "Box2")
            {
                GameMaster.box2 = false;
            }
            else if (other.gameObject.name == "Box3")
            {
                GameMaster.box3 = false;
            }
            else if (other.gameObject.name == "Box4")
            {
                GameMaster.box4 = false;
            }
            else if (other.gameObject.name == "Box5")
            {
                GameMaster.box5 = false;
            }
            GameMaster.AddItem(this);
		}
		if (other.gameObject.CompareTag("Finish"))
		{
			
				finishGameUI.SetActive(true);
			
		}
	}
}
