using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour


    
{

    #region Public Members
    public float moveSpeed = 0.3f;
    public float rotationSpeed = 8f;

    public Transform m_transform;
    public float m_movementSpeed;

    #endregion

    #region Public Void

    #endregion

    #region System
    private void Move()
    {
        /*
        m_previousPosition = m_transform.position;
        m_previousposition.x += imput.Getaxis("Horizontal");
        m_transform.position = m_transform previousPosition;
        */
    }

    private void Awake()
    {
       
    }
    void Start () 
    {
        if (Input.GetKey(KeyCode.UpArrow))

        {

            transform.Translate(Vector3.forward * moveSpeed);

        }

        else if (Input.GetKey(KeyCode.DownArrow))

        {

            transform.Translate(-Vector3.forward * moveSpeed);

        }
    }
	
	void Update () 
    {
      
	}

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members
   
    #endregion
}
