using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalLevelHandler : MonoBehaviour
{
    private void Awake()
    {

    }
    
    public void ExitToRoom()
    {
        completionScreen.Instance.ReturnToRoom();
    }

    public void GoToNextLevel()
    {
        completionScreen.Instance.StartSecondLevel();
    }

    public void GoToThirdLevel()
    {
        completionScreen.Instance.StartThirdLevel();
    }

    public void StartLevelTwo()
    {
        completionScreen.Instance.GetComponent<LevelSelect>().StartLevel2();
    }

    public void StartLevelThree()
    {
        completionScreen.Instance.GetComponent<LevelSelect>().StartLevel3();
    }

    public void ReturnToFinalRoom()
    {
        SceneManager.LoadScene(8);
    }

    public void endGame()
    {
        Application.Quit();
    }

}
