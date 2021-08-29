using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    private platformmanager _platformManager;

    private void OnEnable()
    {
        _platformManager = GameObject.FindObjectOfType<platformmanager>();

    }

    private void OnBecameInvisible()
    {
        _platformManager.Recycleplatform(this.gameObject);
    }
}
