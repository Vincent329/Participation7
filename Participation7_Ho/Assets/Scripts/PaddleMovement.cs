using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField]
    private float m_fMovementSpeed = 10;
    // Start is called before the first frame update

    private Rigidbody2D m_rb;
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_rb.isKinematic = false;
        m_rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        HandleInputs();   
    }

    private void HandleInputs()
    {
       if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * Time.deltaTime * m_fMovementSpeed);
            m_rb.AddForce(Vector3.left * m_fMovementSpeed);
        }
       else if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.right * Time.deltaTime * m_fMovementSpeed);
            m_rb.AddForce(Vector3.right * m_fMovementSpeed);
        }
    }
}
