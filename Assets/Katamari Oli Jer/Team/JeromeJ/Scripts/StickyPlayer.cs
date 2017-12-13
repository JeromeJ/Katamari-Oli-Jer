using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlayer : MonoBehaviour
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
        if (collision.transform.tag != "ground")
        {
            // Luke, je suis ton père !
            collision.transform.parent = this.transform;


            collision.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(collision.gameObject.GetComponent<Rigidbody>());
        }
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
