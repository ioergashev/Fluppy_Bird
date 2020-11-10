using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMenuWindow : MonoBehaviour
{
    [SerializeField]
    private Text LevelCoinsCountText;
    [SerializeField]
    private Text AllCoinsCountText;
    [SerializeField]
    private Text CoinsFactorText;

    public void SetLevelCoinsCount(int count)
    {
        LevelCoinsCountText.text = count.ToString();
    }

    public void SetAllCoinsCount(int count)
    {
        AllCoinsCountText.text = count.ToString();
    }

    public void SetCoinsFactor(int value)
    {
        CoinsFactorText.text = $"x{value}";
    }

    public void UpdateView()
    {
        SetCoinsFactor(GameSettings.CoinsFactor);
        SetAllCoinsCount(GameSettings.CoinsCount);
    }
}
