using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFindKatamariManager : MonoBehaviour 
{
    /*
     * Automatically find the KatamariManager if it's on the same GameObject
     * 
     *  Tries to set it on Reset, if it fails, it tries again on Awake.
     * 
     */

    #region Public Members

    public KatamariManager m_katManager;

    #endregion

    #region Public Void

    #endregion

    #region System

    // TODO: Lookup what virtual is actually for...
    protected virtual void Reset()
    {
        Init();
    }

    protected virtual void Awake() 
    {
        Init();
    }

    #endregion

    #region Class Methods

    private void Init()
    {
        if (m_katManager == null)
            m_katManager = GetComponent<KatamariManager>();
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
