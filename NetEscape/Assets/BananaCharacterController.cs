using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaCharacterController : MonoBehaviour
{

    public BaseCharacterController2D controller;

    public float runSpeed = 40f;
    float horizontalMove = 0f;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }

    private void FixedUpdate()
    {
        // Move Banana
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
