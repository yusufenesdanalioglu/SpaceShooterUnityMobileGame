using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotasyon : MonoBehaviour {
    Rigidbody fizik;
	void Start () {
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere;
	}
	
}
