using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grime : MonoBehaviour
{
    public Rigidbody2D grime;
    public float speed = -3f;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -7)
        {
            Destroy(gameObject);
        }
    }
    public void SpawnGrime()
    {
        Rigidbody2D grimeInstance;
        grimeInstance = Instantiate(grime, new Vector3(Random.Range(-6, 6), 7, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        grimeInstance.name = "Grime(Clone)";
        grimeInstance.velocity = new Vector2(0, speed);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Spongy")
        {
            Destroy(gameObject);
        }
    }
}
