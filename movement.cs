using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class movement : MonoBehaviour
{

    CharacterController controller;
    public float speed ;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(Time.deltaTime*speed*move);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
}
