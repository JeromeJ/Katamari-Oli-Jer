using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatamariController : MonoBehaviour
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    void Start ()
    {
        
    }

    void Update ()
    {
        	
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "collectible")
            collision.transform.parent = this.transform;
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
