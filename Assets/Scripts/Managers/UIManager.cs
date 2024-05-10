using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject background;
    public GameObject startScreen;
    public GameObject gameModeScreen;

    private void Awake() => instance = this;

    private void Start()
    {
        background.SetActive(true);
        startScreen.SetActive(false);
        gameModeScreen.SetActive(true);
    }


    public void ShowGameModeScreen()
    {
        startScreen.SetActive(false);
        gameModeScreen.SetActive(true);
    }


    public void StartStoryMode()
    {
        background.SetActive(false);
        gameModeScreen.SetActive(false);
        LevelManager.instance.InitializeStoryBoard();

    }


    public void StartEndlessMode()
    {
        background.SetActive(false);
        gameModeScreen.SetActive(false);
        LevelManager.instance.InitializeEndlessBoard();
    }

}
