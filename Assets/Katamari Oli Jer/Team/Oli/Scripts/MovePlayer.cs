using System.Collections;
using System.Collections.Generic;
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed);
        }

        //second
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotationSpeed);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * -rotationSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))

        {
            transform.Rotate(Vector3.up * rotationSpeed);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))

        {

            transform.Rotate(Vector3.up * -rotationSpeed);

            transform.Rotate(new Vector3(0, -rotationSpeed, 0));
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
