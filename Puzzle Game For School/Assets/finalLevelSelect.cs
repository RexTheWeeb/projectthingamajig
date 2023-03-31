using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalLevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartLevel1Final()
    {
        SceneManager.LoadScene(1);
    }

    public void StartLevel2Final()
    {
  
       SceneManager.LoadScene(3);
        
    }

    public void StartLevel3Final()
    {
       
        SceneManager.LoadScene(6);
      
    }
}
