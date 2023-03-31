using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public bool level2Lock;
    public bool level3Lock;

    private void Start()
    {
        level2Lock = true;
        level3Lock = true;
    }

    public void StartLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void StartLevel2()
    {
       if(level2Lock == false)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void StartLevel3()
    {
        if (level3Lock == false)
        {
            SceneManager.LoadScene(6);
        }
    }
}
