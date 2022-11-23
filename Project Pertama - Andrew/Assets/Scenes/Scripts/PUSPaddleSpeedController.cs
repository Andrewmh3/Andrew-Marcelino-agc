using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSPaddleSpeedController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public Collider2D right;
    public Collider2D left;

    private float Timer;

    public void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= manager.DeleteInterval)
        {
            manager.RemovePowerUp(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)

        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;

            right.GetComponent<PaddleController>().ActivatePUPaddleSpeed();
            left.GetComponent<PaddleController>().ActivatePUPaddleSpeed();
            manager.RemovePowerUp(gameObject);
        }
    }
}
