using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 4f;
    private float movX;
    private float movY;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        Vector3 direction = transform.right * movX + transform.forward * movY;
        controller.Move(direction * speed * Time.deltaTime);
    }
}
