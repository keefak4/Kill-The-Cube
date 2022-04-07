using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static UI UIsinglton;
    public Text textCoins;
    public GameObject panel;
    public Text panelTextScore;
    public Text gameOverText;
    public Text victoryText;
    private void Awake()
    {
        UIsinglton = this;
    }

}
