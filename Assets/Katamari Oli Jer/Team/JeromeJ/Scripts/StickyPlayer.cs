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
        m_collider = GetComponent<SphereCollider>(); // Pas bien
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag != "ground")
        {
            float katamariScale = m_collider.radius * transform.localScale.x;
            float targetScale = 0.3333333f * (collision.transform.localScale.x + collision.transform.localScale.y + collision.transform.localScale.z); 

            if(katamariScale > targetScale)
                StickToMe(collision);
        }
    }

    #endregion

    #region Class Methods

    private void StickToMe(Collision collision)
    {
        // Luke, je suis ton père !
        collision.transform.parent = this.transform;

        collision.gameObject.GetComponent<Collider>().enabled = false;
        Destroy(collision.gameObject.GetComponent<Rigidbody>());

        Vector3 newPos = transform.position;

        newPos.y            += m_katManager.growth; transform.position = newPos;
        m_collider.radius   += m_katManager.growth;
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private SphereCollider m_collider;

    #endregion
}
