using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class completionScreen : MonoBehaviour
{

    private LevelSelect unlock;
    public static completionScreen Instance;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        unlock = GetComponent<LevelSelect>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSecondLevel()
    {
        SceneManager.LoadScene(3);
        unlock.level2Lock = false;
    }

    public void ReturnToRoom()
    {
        SceneManager.LoadScene(0);
        unlock.level2Lock = false;
    }

    public void StartThirdLevel()
    {
        SceneManager.LoadScene(5);
        unlock.level3Lock = false;
    }
}
