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

    public void SetLevelCoinsCount(int count)
    {
        LevelCoinsCountText.text = count.ToString();
    }

    public void SetAllCoinsCount(int count)
    {
        AllCoinsCountText.text = count.ToString();
    }
}
