using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnPoint;

    [SerializeField]
    private Vector2 position;
    [SerializeField]
    private float m_fMovementSpeed = 10;

    private SpriteRenderer spriteRender;
    private Rigidbody2D m_rb;
    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        spriteRender = GetComponent<SpriteRenderer>();
        gameObject.transform.position = spawnPoint.transform.position;
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_rb.AddForce(Vector3.right * m_fMovementSpeed);
            if (spriteRender != null)
            {
                spriteRender.flipX = true;
            }
        }
    }
}
