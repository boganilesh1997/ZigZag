using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
  public static UIManager instance;
  public GameObject zigzagPanel;
  public GameObject gameOverPanel;
  public Text socre;
  public Text Highscore1;
  public Text Highscore2;
  public GameObject tapText;
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
      Highscore1.text="High Score : " + PlayerPrefs.GetInt("highScore").ToString();
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void GameStart()
    {

      tapText.SetActive(false);
      zigzagPanel.GetComponent<Animator>().Play("pannelUp");


    }
    public void GameOver()
    {

      socre.text = PlayerPrefs.GetInt("score").ToString();
      Highscore2.text = PlayerPrefs.GetInt("highScore").ToString();
      gameOverPanel.SetActive(true);
    }
    public void Reset()
    {
       SceneManager.LoadScene(0);
    }
}
