using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidRandomOlustur : MonoBehaviour {
    public GameObject Asteroid;
    public Vector3 randomPos;
    float zaman  = 0;
    public float ikiAsteroidArasindakiSure;
	// Use this for initialization
	void Start () {
        if (Time.time>zaman)
        {
            olustur();
        }
        
	}
    void Update()
    {
        if (Time.time > zaman)
        {
            olustur();
            zaman = Time.time + ikiAsteroidArasindakiSure;
        }

    }
    void olustur()
    {
        Vector3 vec =new Vector3 (Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
        Instantiate(Asteroid, vec, Quaternion.identity);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag=="Sinir")
        {
            Destroy(Asteroid);
        }
    }

}
