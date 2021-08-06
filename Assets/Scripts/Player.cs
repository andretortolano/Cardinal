using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    [SerializeField] float speed = 300f;

    private void handleMovement()
    {
        if (isLocalPlayer)
        {
            float speedXTime = Time.deltaTime * speed;
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal * speedXTime, moveVertical * speedXTime, 0);
            transform.position = transform.position + movement;
        }
    }

    void Update() {
        handleMovement();
    }
}
