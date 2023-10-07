using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public Rigidbody2D collectable;
    public float speed = -5f;



    void Update()
    {
        if (transform.position.y <= -7)
        {
            Destroy(gameObject);
        }
    }
    public void SpawnCollectable()
    {
        Rigidbody2D collectableInstance;
        collectableInstance = Instantiate(collectable, new Vector3(Random.Range(-6, 6), 7, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        collectableInstance.name = "Collectable(Clone)";
        collectableInstance.velocity = new Vector2(0, speed);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Spongy")
        {
            Destroy(gameObject);
        }
    }
}

