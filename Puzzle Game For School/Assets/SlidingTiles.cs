using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingTiles : MonoBehaviour
{
    [SerializeField] private Transform blankSpot = null;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit)
            {
                if (Vector2.Distance(a: blankSpot.position, b: hit.transform.position) < 2.7)
                {
                   
                    Vector2 lastPosition = blankSpot.position;
                    blankSpot.position = hit.transform.position;
                    hit.transform.position = lastPosition;
              
                }
            }
        }

    }
}
