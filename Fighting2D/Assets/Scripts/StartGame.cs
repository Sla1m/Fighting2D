using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public void Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

	public void Quit()
	{
		Application.Quit();
	}

	public void Arena()
	{
		SceneManager.LoadScene ("Arena");
	}

	public void Win()
	{
		SceneManager.LoadScene ("Game");
	}

	public void Home()
	{
		SceneManager.LoadScene ("Home");
	}

	public void Traning()
	{
		SceneManager.LoadScene ("TraningPlace");
	}

	public void Shop()
	{
		SceneManager.LoadScene ("Shop");
	}

	public void Event()
	{
		SceneManager.LoadScene ("Event");
	}

}
