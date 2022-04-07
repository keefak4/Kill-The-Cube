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
    private void Update()
    {
        textCoins.text = Player.score.ToString();
    }
    public void OnClickRestart()
    {
        Player.Restart();
    }
    public static void ShowVictoryPanel()
    {
        UIsinglton.panel.SetActive(true);
        UIsinglton.victoryText.gameObject.SetActive(true);
        UIsinglton.panelTextScore.text = Player.score.ToString();
    }
    public static void ShowGameOverPanel()
    {
        UIsinglton.panel.SetActive(true);
        UIsinglton.gameOverText.gameObject.SetActive(true);
        UIsinglton.panelTextScore.text = Player.score.ToString();
    }

}
