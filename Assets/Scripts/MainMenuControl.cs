using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
	public static MainMenuControl instance;
	public ManagerUI managerUI;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);
	}

	private void Start()
	{
		managerUI.ShowWindow("main_menu_window");
	}

	public void PlayBtnHandler()
	{
		SceneManager.LoadScene(1);
	}

	public void ShopBtnHandler()
	{
		managerUI.ShowWindow("shop_window")?.GetComponent<ShopWindow>()?.UpdateView();
	}

	public void ShopBackBtnHandler()
	{
		managerUI.ShowWindow("main_menu_window");
	}
}
