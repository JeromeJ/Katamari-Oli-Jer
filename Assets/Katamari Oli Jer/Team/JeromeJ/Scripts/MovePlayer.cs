using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    #region Public Members
    public float moveSpeed = 0.2f;
    public float rotationSpeed = 3f;

    #endregion

    #region Public Void

    #endregion


    #region System
    private void Move()
    {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.blue);
        Debug.DrawRay(transform.position, Vector3.forward * 10, Color.red);
        Debug.DrawRay(transform.position, m_rigidbody.transform.forward * 10, Color.green);

        m_rigidbody.freezeRotation = (Input.GetAxis("Vertical") == 0);

        // Forward / Backward
        if (Input.GetAxis("Vertical") != 0)
        {
            // Rotates the body: AddForce BUT the positions are frozen
            m_rigidbody.AddForce(Input.GetAxisRaw("Vertical") * transform.forward * moveSpeed * 1000);

            transform.Translate(Input.GetAxis("Vertical") * Vector3.forward * moveSpeed);
        }

        // Turn left / Right
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(Input.GetAxisRaw("Horizontal") * Vector3.up * rotationSpeed);
        }
    }

    private void Awake()
    {
        // m_rigidbody.constraints = m_rigidbody.constraints | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        m_rigidbody.constraints = m_rigidbody.constraints | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
    }


    void Start () 
    {
       
    }
	
	void Update () 
    {
        Move();
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    [SerializeField]
    private Rigidbody m_rigidbody;


    #endregion
}
