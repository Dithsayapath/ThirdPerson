using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed = 5f;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        float inputZ = Input.GetAxis("Jump");
        movement = new Vector3(inputX, 0, inputY) * speed * Time.deltaTime;
        //transform.position = new Vector3.Jump;
        transform.position += movement;
    }
}
