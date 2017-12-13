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
        // Forward / Backward
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(Input.GetAxisRaw("Vertical") * Vector3.forward * moveSpeed);
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
   
    #endregion
}
