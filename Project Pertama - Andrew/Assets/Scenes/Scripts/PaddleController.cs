using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode UpKey;
    public KeyCode DownKey;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        MoveObject(GetInput());

    }


    private Vector2 GetInput()
    {

        if (Input.GetKey(UpKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(DownKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
        {
            rig.velocity = movement;
        }


}