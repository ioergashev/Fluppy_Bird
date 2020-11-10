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

	private int AllCoinsCount
	{
		get => PlayerPrefs.GetInt("coins_count");
		set => PlayerPrefs.SetInt("coins_count", value);
	}

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
	}

	public void BirdDiedHandler()
	{
		gameOver = true;
		var gameOverMenu = managerUI.ShowWindow("game_over_menu_window").GetComponent<GameOverMenuWindow>();
		gameOverMenu?.SetAllCoinsCount(AllCoinsCount);
		gameOverMenu?.SetLevelCoinsCount(LevelCoinsCount);
	}

	public void CoinCollectedHandler()
	{
		LevelCoinsCount++;
		AllCoinsCount++;

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
