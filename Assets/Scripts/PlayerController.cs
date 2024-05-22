using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D player;
    private Animator MyAnimation;
    [SerializeField] private float speed;

    void Start() {
        player = GetComponent<Rigidbody2D>();
        MyAnimation = GetComponent<Animator>();
    }

    void Update() {
        player.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;

        MyAnimation.SetFloat("MoveX", player.velocity.x);
        MyAnimation.SetFloat("MoveY", player.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 ||Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1) {
            MyAnimation.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
            MyAnimation.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));   
        } 
    }
}
