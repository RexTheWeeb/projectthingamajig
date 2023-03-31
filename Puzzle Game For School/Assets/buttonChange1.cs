using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonChange1 : MonoBehaviour
{
    public GameObject menuSelect;
    private LevelSelect script;
    public Image originalPic;
    public Sprite newPic;

    void Start()
    {
        script = menuSelect.GetComponent <LevelSelect>();   
    }
    public void newImage()
    {
        if(script.level2Lock == false)
        {
            originalPic.sprite = newPic;
        }
    }
}
