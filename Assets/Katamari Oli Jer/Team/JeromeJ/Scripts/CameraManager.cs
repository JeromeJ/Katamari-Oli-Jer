using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : AutoFindKatamariManager
{
    #region Public Members

    public Camera m_camera;
    public Transform m_katamariBody;
    public float m_cameraDistance = 10f;
    public SphereCollider m_sc;

    #endregion

    #region Public Void

    #endregion

    #region System

    protected override void Awake()
    {
        // m_sc = GetComponent<SphereCollider>();
    }


    private void Update()
    {
        float katamariScale = m_sc.radius * m_katamariBody.localScale.x;

        // float desiredDistance = m_cameraDistance * katamariScale * m_katManager.growth;
        // float desiredDistance = m_cameraDistance * (1 + m_katManager.growth);
        float desiredDistance = m_cameraDistance * katamariScale;

        // Explication:
        //
        // m_camera.transform.position = A + (B * -C)
        //
        //      A       Permet de recentrer la caméra par rapport au Katamari (Sinon elle reste centrée sur 0,0,0)
        //      B * -C  La direction de la caméra (B) multipliée par la distance voulue (C) (la direction de la caméra ne doit pas changer / est constante)
        //      -C      car on veut RECULER la caméra
        //
        //     Permet de faire un m_camera.transform.Translate(dir * Vector3.forward * distanceDesiree) mais appelé une seule fois
        //
        m_camera.transform.position = m_katamariBody.position + (m_camera.transform.forward * -desiredDistance);
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
