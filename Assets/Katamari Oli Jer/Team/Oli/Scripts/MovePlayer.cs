using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour


    
{

    #region Public Members
    public float moveSpeed = .3f;
    public float rotationSpeed = 8f;

    #endregion

    #region Public Void

    #endregion


    #region System
   

    private void Awake()
    {
       
    }
    void Start () 
    {
       
    }
	
	void Update () 
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * -rotationSpeed);
        }
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members
   
    #endregion
}
