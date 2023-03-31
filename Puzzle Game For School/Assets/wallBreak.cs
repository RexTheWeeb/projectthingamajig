using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wallBreak : MonoBehaviour
{
    public GameObject wall;

    public void BeginPuzzle()
    {
        Destroy(wall);  
    }

    public void resetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
