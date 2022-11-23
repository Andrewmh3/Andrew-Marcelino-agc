using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public PowerUpManager manager;
    public Vector2 speed;
    public Vector2 resetPosition;

    public int speedup ;
    public float timerspeedup;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();

        rig.velocity = speed;
    }
    public void Resetball()
    {
        transform.position = resetPosition;
    }

    public void ActivatePUSpeedUp(float magnitude) 
    {
        StartCoroutine( Activated(magnitude));
    }

    IEnumerator Activated(float magnitude)
    {
        rig.velocity *= 2;
        yield return new WaitForSeconds(manager.duration);
        rig.velocity /= 2;
    }
}