using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public static Player playerSinglton;
    public static int coinsScore = 0;
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
    public void Victory()
    {

    }
    public void GameOver()
    {
        coinsScore = 0;
    }
    public void Restart()
    {
        int bueldIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(bueldIndex);
    }
}
