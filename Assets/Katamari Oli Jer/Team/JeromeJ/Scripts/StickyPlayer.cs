using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlayer : MonoBehaviour
{
    #region Public Members

    public float m_growth = .1f;

    #endregion

    #region Public void

    #endregion

    #region System

    private void Awake()
    {
        m_collider = GetComponent<SphereCollider>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag != "ground")
        {
            // Luke, je suis ton père !
            collision.transform.parent = this.transform;


            collision.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(collision.gameObject.GetComponent<Rigidbody>());

            m_collider.radius += m_growth;
        }
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private SphereCollider m_collider;

    #endregion
}
