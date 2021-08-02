using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour{

    public GameManager gameManager;

    [SerializeField]
    private float velocity = 3.5f;

    private Rigidbody2D playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        jumpMove();
    }

    // karakter dikey yönlü bir hareket yapar. 
    private void jumpMove()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            playerRB.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.gameOver();
    }

    
}
