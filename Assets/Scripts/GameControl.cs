using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour 
{
	public static GameControl instance;		            
	public ManagerUI managerUI;

	public bool gameOver = false;				
	public float scrollSpeed = -1.5f;

	private int LevelCoinsCount;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if(instance != this)
			Destroy (gameObject);
	}

    private void Start()
    {
		managerUI.ShowWindow("in_game_menu_window");
		managerUI.GetWindowComponent<InGameMenuWindow>("in_game_menu_window")?.UpdateView();
	}

	public void BirdDiedHandler()
	{
		gameOver = true;
		var gameOverMenu = managerUI.ShowWindow("game_over_menu_window").GetComponent<GameOverMenuWindow>();
		gameOverMenu?.UpdateView();
		gameOverMenu?.SetLevelCoinsCount(LevelCoinsCount);
	}

	public void CoinCollectedHandler()
	{
		GameSettings.CoinsCount+= GameSettings.CoinsFactor;
		LevelCoinsCount += GameSettings.CoinsFactor;

		managerUI.GetWindowComponent<InGameMenuWindow>("in_game_menu_window")?.SetCoinsCount(LevelCoinsCount);
	}

	public void PauseGameBtnHandler()
    {
		Time.timeScale = 0.0001f;
		managerUI.ShowWindow("pause_menu_window");
    }

	public void UnpauseGameBtnHandler()
	{
		Time.timeScale = 1;
		managerUI.ShowWindow("in_game_menu_window");
	}

	public void ExitGameBtnHandler()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(0);
	}

	public void RestartGameBtnHandler()
	{
		RestartGame();
	}

	private void RestartGame()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
