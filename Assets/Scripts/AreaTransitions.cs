using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTransitions : MonoBehaviour{
    private CameraController Cam;
    public Vector2 NewMinPosition;
    public Vector2 NewMaxPosition;
    public Vector3 MovePlayer;

    void Start() {
        Cam = Camera.main.GetComponent<CameraController>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Cam.minPosition = NewMinPosition;
            Cam.maxPosition = NewMaxPosition;

            other.transform.position += MovePlayer;
        }
    }
}