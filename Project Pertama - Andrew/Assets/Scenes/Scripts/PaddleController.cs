using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode UpKey;
    public KeyCode DownKey;
    public PowerUpManager manager;

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

    public void ActivatePULongerPaddle()
    {
        StartCoroutine(Activatedlonger());
    }

    IEnumerator Activatedlonger()
    {
        transform.localScale += new Vector3(0, 2, 0);
        yield return new WaitForSeconds(manager.duration);
        transform.localScale -= new Vector3(0, 2, 0);
    }
   

    public void ActivatePUPaddleSpeed()
    {
        StartCoroutine(Activatedspeed());
    }

    IEnumerator Activatedspeed()
    {
        speed *= 2;
        yield return new WaitForSeconds(manager.duration);
        speed /= 2;
    }
}