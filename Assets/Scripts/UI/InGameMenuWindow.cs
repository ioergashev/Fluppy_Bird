using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameMenuWindow : MonoBehaviour
{
    [SerializeField]
    private Text CoinsCountText;
    [SerializeField]
    private Text CoinsFactorText;

    public void SetCoinsCount(int count)
    {
        CoinsCountText.text = count.ToString();
    }

    public void SetCoinsFactor(int value)
    {
        CoinsFactorText.text = $"x{value}";
    }

    public void UpdateView()
    {
        SetCoinsFactor(GameSettings.CoinsFactor);
    }
}
