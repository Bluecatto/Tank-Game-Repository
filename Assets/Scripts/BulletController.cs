using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float bulletTtl = 5;
    // Start is called before the first frame update
    void Update()
    {
         bulletTtl -= Time.deltaTime;
        if (bulletTtl <= 0)
        {
            Destroy(gameObject);

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<TankController>().spelerNummer == 1)
            {
                GameObject.Find("Canvas").GetComponent<ScoreScript>().Addp2Score();
            }
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<TankController>().spelerNummer == 2)
            {
                GameObject.Find("Canvas").GetComponent<ScoreScript>().Addp1Score();
            }
        }

        Destroy (gameObject);


    }

}
