using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlayer : AutoFindKatamariManager
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    protected override void Awake()
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

            m_collider.radius += m_katManager.growth;
        }
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private SphereCollider m_collider;

    #endregion
}
