using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameMenuWindow : MonoBehaviour
{
    [SerializeField]
    private Text CoinsCountText;

    public void SetCoinsCount(int count)
    {
        CoinsCountText.text = count.ToString();
    }
}
