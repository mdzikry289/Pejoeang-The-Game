using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour {

	public void Quit()
	{
        gamereset();
		Debug.Log("Quit Game");
		Application.Quit();
	}
    public void Back()
    {
        gamereset();
        Debug.Log("Quit Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Retry()
	{
        gamereset();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
	}

    public void gamereset()
    {
        GameMaster._remainingLives = 4;
        GameMaster._remainingItem = 0;
        GameMaster.box1 = true;
        GameMaster.box2 = true;
        GameMaster.box3 = true;
        GameMaster.box4 = true;
        GameMaster.box5 = true;
    }
}
