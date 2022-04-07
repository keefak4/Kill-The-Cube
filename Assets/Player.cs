using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public static Player playerSinglton;
    public static int score = 0;
    public static List<SquareMove> squares;
    public static int squareCount;
    private void Awake()
    {
        playerSinglton = this;
        squares = new List<SquareMove>();
    }
    
    private void Update()
    {
        if(squares.Count == 0)
        {
            Victory();
        }
        squareCount = squares.Count;
    }
    public static void Victory()
    {
        UI.ShowVictoryPanel();
    }
    public static void GameOver()
    {
        UI.ShowGameOverPanel();
        score = 0;
    }
    public static void Restart()
    {
        int bueldIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(bueldIndex);
    }
}
