using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static GameManager instance;
  public bool gameOver;

    void Awake()
    {
      if(instance == null)
      {
        instance = this;
      }
    }
    // Start is called before the first frame update
    void Start()
    {
     gameOver = false;

    }
    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
      UIManager.instance.GameStart();
      ScoreManager.instance.startScore();
    }
    public void GameOver()
    {
      UIManager.instance.GameOver();
      ScoreManager.instance.StopScore();
      gameOver = true;
    }

}
