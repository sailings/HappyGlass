using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public GameObject LockObj;
    public Text LevelText;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;

    public int LevelNumber = 1;
    public bool Locked = true;
    public int Stars = 0;

    public GameObject StarsUI;

    // Start is called before the first frame update
    void Start()
    {
        StarsUI.SetActive(false);
        LockObj.SetActive(Locked);
        LevelText.text = LevelNumber.ToString();
        Star1.SetActive(Stars > 0);
        Star2.SetActive(Stars > 1);
        Star3.SetActive(Stars > 2);
        GetComponent<EventTrigger>().enabled = !Locked;

        if (!Locked)
        {
            if (GameState.LevelReached > LevelNumber)
                StarsUI.SetActive(true);
        }
    }

    public void Play()
    {
        GameState.IsGameSuccess = false;
        GameState.LevelPlaying = LevelNumber;
        SceneManager.LoadScene("Level_"+LevelNumber);
    }

}
