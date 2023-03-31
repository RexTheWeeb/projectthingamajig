using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonChange2 : MonoBehaviour
{
    public GameObject menuSelect;
    private LevelSelect script;
    public Sprite updatedSprite;
    public SpriteRenderer spriterender;

    void Start()
    {
        script = menuSelect.GetComponent<LevelSelect>();   
    }
    void ChangeSprite()
    {
        if(script.level3Lock == false)
        {
            spriterender.sprite = updatedSprite;
        }
    }
}
