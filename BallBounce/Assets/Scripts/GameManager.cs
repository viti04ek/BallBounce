using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int _score = 0;
    public Text ScoreText;

    public GameObject GameStartUI;


    void Awake()
    {
        Instance = this;
    }


    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void ScoreUp()
    {
        _score++;
        ScoreText.text = _score.ToString();
    }


    public void GameStart()
    {
        GameStartUI.SetActive(false);
        Instance.ScoreText.gameObject.SetActive(true);
    }
}
