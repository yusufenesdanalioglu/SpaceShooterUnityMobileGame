using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public float hiz;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward*hiz;
    }
}
