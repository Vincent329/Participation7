using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanCollision : MonoBehaviour
{
    // we want to detect the situation when the snowman is hitting the ground

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {

        }

        Debug.Log("Collision... ow");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hide Behind the platform");
        Rigidbody2D tempRigidBody = GetComponent<Rigidbody2D>();
        gameObject.transform.position = new Vector3(Random.Range(-8f, 8f) , 6f, 0f);
        tempRigidBody.velocity = Vector2.zero;
        
    }
}
