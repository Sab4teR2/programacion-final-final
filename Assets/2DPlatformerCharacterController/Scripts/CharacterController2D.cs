using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class CharacterController2D : MonoBehaviour
{

    public float speed = 10.0f;
    void Update()
    {
        //Movimiento del jugador
        float translation = Input.GetAxis("Horizontal") * speed + Input.GetAxis("Vertical") * speed;
        translation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);

        



    }
}