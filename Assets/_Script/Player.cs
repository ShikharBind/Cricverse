using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    input _input;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        _input = new input();
    }

    // Update is called once per frame
    void Update()
    {
        SetInput();
        Move();
    }

    void SetInput() {
        _input.x = Input.GetAxis("Horizontal");
        _input.z = Input.GetAxis("Vertical");
    }

    void Move() {
        Vector3 dir = new Vector3(_input.x,0,_input.z).normalized;
        transform.position += dir * speed * Time.deltaTime;
    }
}


public class input {
    public float x;
    public float z;
}
