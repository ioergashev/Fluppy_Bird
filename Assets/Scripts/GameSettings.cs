using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public static int CoinsFactor
    {
        get => PlayerPrefs.GetInt("coins_factor", 1);
        set => PlayerPrefs.SetInt("coins_factor", value);
    }

    public static int CoinsCount
    {
        get => PlayerPrefs.GetInt("coins_count");
        set => PlayerPrefs.SetInt("coins_count", value);
    }

    public static int PlayerLevel
    {
        get => PlayerPrefs.GetInt("player_level", 1);
        set => PlayerPrefs.SetInt("player_level", value);
    }
}
