using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour
{
    public float speed = 4.0f;
    private Rigidbody rigb;

    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody>();    
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    private void FixedUpdate() {
        float moveHorz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorz, 0.0f, moveVert);
        rigb.AddForce(movement * speed);
    }
}
