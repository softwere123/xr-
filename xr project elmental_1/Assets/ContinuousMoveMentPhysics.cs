using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ContinuousMoveMentPhysics : MonoBehaviour
{
    public float speed = 1f;
    public InputActionProperty moveInputSoure;
    public Rigidbody rb;

    public Transform directionSourec;

    private Vector2 inputMoveAxis;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputMoveAxis = moveInputSoure.action.ReadValue<Vector2>(); //why used the vector 2? 
    }

    private void FixedUpdate()
    {
        Quaternion yaw = Quaternion.Euler(0, directionSourec.eulerAngles.y, 0);
        Vector3 direction = yaw * new Vector3(inputMoveAxis.x, 0, inputMoveAxis.y);

        rb.MovePosition(rb.position + direction * Time.fixedDeltaTime * speed);
    }

}
