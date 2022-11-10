using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    [SerializeField]
    Transform barrelRotator;
    [SerializeField]
    Transform firePoint;
    [SerializeField]
    GameObject bulletToFire;
    public int spelerNummer;
    bool isAanDeBeurt = false;
    public float speed;
    public float Move;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAanDeBeurt)
        {
            barrelRotator.RotateAround(Vector3.forward, Input.GetAxis("Vertical") * Time.deltaTime);
            Move = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(Move * speed, rb.velocity.y);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject b = Instantiate(bulletToFire, firePoint.position, firePoint.rotation);
                b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.up * 10, ForceMode2D.Impulse);
                Invoke("WisselBeurt", 0.1f);
            }
        }
    }

    void WisselBeurt()
    {
        GameObject.Find("TurnManager").GetComponent<TurnManager>().WisselBeurt();
    }

    public void ZetActief(bool b)
    {
        if (b == true)
        {
            isAanDeBeurt = true;
        }
        else
        {
            isAanDeBeurt = false;
        }
    }
}
