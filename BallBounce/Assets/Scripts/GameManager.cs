using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    void Awake()
    {
        Instance = this;
    }


    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
