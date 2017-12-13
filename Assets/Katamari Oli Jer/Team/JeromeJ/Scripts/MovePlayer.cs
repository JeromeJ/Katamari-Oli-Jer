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

        m_rigidbody.freezeRotation = (Input.GetAxis("Vertical") == 0);

        // Forward / Backward
        if (Input.GetAxis("Vertical") != 0)
        {
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
    private Transform m_transform;

    [SerializeField]
    private Rigidbody m_rigidbody;


    #endregion
}
