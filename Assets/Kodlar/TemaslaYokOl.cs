using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TemaslaYokOl : MonoBehaviour {
    public GameObject patlama;
    public GameObject patlama2;
    public GameObject patlamaSesi;
    public GameObject playerPatlamaSesi;
    GameObject oyunKontrol;
    PlayerControl kontrol;
    void Start()
    {
        oyunKontrol = GameObject.FindGameObjectWithTag("Player");
        kontrol = oyunKontrol.GetComponent<PlayerControl>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag!="Sinir" && other.tag != "Player")
        {
            Destroy(other.gameObject);
            Instantiate(patlama, transform.position, transform.rotation);
            Instantiate(patlamaSesi, transform.position, transform.rotation);
            Destroy(gameObject);
            kontrol.SkorArttır(10);
        }
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Instantiate(patlama2, transform.position, transform.rotation);
            Instantiate(playerPatlamaSesi, transform.position, transform.rotation);
            Destroy(gameObject);
            kontrol.SkorArttır(10);
            SceneManager.LoadScene("SampleScene");
        }
    }
}
