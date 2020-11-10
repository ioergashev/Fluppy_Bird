using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopWindow : MonoBehaviour
{
    [SerializeField]
    private Text LevelText;
    [SerializeField]
    private Text CoinsCountText;

    private void SetCoinsCount(int count)
    {
        CoinsCountText.text = count.ToString();
    }

    private void SetPlayerLevel(int level)
    {
        LevelText.text = $"Level: {level}";
    }

    public void UpdateView()
    {
        SetPlayerLevel(GameSettings.PlayerLevel);
        SetCoinsCount(GameSettings.CoinsCount);
    }

    public void LevelUpBtnHandler()
    {
        if (GameSettings.CoinsCount > 0)
        {
            GameSettings.CoinsCount--;
            GameSettings.PlayerLevel++;
            GameSettings.CoinsFactor = GameSettings.PlayerLevel;

            UpdateView();
        }
    }
}
