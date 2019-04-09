using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinirlar : MonoBehaviour {
    
	void OnTriggerExit(Collider col)
    {
        Destroy(col.gameObject);
    }
}
