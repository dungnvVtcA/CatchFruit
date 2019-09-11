using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectPooling : MonoBehaviour
{
    [SerializeField]
    private float timeSecond;

    private void OnEnable()
    {
        Invoke("Destroy", timeSecond);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }
}
