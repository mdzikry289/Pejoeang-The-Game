using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{

	public static GameMaster gm;
    public static bool box1 = true;
    public static bool box2 = true;
    public static bool box3 = true;
    public static bool box4 = true;
    public static bool box5 = true;
    public static int _remainingItem = 0;

	public static int RemainingItem
	{
		get { return _remainingItem; }
	}

	public static int _remainingLives = 3;
	public static int RemainingLives
	{
		get { return _remainingLives; }
	}
	void Start()
	{
		if (gm == null)
		{
			gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>() ;
		}
        if (box1 == false)
        {
            GameObject.Find("Box1").SetActive(false);
        }
        if (box2 == false)
        {
            GameObject.Find("Box2").SetActive(false);
        }
        if (box3 == false)
        {
            GameObject.Find("Box3").SetActive(false);
        }
        if (box4 == false)
        {
            GameObject.Find("Box4").SetActive(false);
        }
        if (box5 == false)
        {
            GameObject.Find("Box5").SetActive(false);
        }
    }

    public Transform playerPrefabs;
	public Transform spawnPoint;
	public int spawnDelay = 0;

	[SerializeField] private GameObject gameOverUI;
	[SerializeField] private GameObject finishGameUI;
	
	public void EndGame ()
	{
		Debug.Log("GAME OVER");
		gameOverUI.SetActive(true);
	}

	public void FinishGame()
	{
		Debug.Log("FINISH");
		finishGameUI.SetActive(true);
	}
	
	public IEnumerator RespawnPlayer()
	{
		Debug.Log("TODO: Add waiting for spawn sound");
		yield return new WaitForSeconds(spawnDelay);

        Debug.Log("TODO: add Spawn Particle");
	}

	public static void AddItem(Player player)
	{
		_remainingItem += 1;
	}
	
	public static void KillPlayer(Player player)
	{
		if (_remainingLives <= 0)
		{
			gm.EndGame();
		} else
		{
            _remainingLives -= 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
