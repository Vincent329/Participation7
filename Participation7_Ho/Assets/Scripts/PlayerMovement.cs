using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnPoint;

    [SerializeField]
    private float m_fMovementSpeed = 10;

    private SpriteRenderer spriteRender;
    private Rigidbody2D m_rb;

    [SerializeField]
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        spriteRender = GetComponent<SpriteRenderer>();
        gameObject.transform.position = spawnPoint.transform.position;
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        HandleInput();
    }
    public GameObject getSpawnPoint()
    {
        return spawnPoint;
    }
    private void HandleInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_rb.AddForce(Vector3.left * m_fMovementSpeed);
            if (spriteRender != null)
            {
                spriteRender.flipX = false;
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            m_rb.AddForce(Vector3.right * m_fMovementSpeed);
            if (spriteRender != null)
            {
                spriteRender.flipX = true;
            }
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            Debug.Log("Jump");
            m_rb.AddForce(Vector3.up * m_fMovementSpeed, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision... ow");
        isGrounded = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hide Behind the platform");
        Rigidbody2D tempRigidBody = GetComponent<Rigidbody2D>();
        gameObject.transform.position = new Vector3(Random.Range(-8f, 8f), 6f, 0f);
        tempRigidBody.velocity = Vector2.zero;

    }

}
