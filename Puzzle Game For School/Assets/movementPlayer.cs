using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movementPlayer : MonoBehaviour
{
    private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rb;
    

    Vector2 movement;
    Vector2 mousePosition;

    // Start is called before the first frame update
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePosition - rb.position;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<death>(out death deathCompnent))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }

    }
}
