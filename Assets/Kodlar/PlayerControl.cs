using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    Rigidbody fizik;
    Vector3 vec;
    public int hiz;
    public float minX, maxX, minZ, maxZ, eğim;
    float beklemeSuresi = 0;
    public GameObject Kursun;
    public Transform KursununCikisYeri;
    public float mermiAtisSerilik;
    int skor = 0;
    public Text text;
    float yatay;
    float dikey;
    // Use this for initialization
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        //&& Input.GetButtonUp("Fire1")
        if ((Input.GetButton("Jump") || Input.GetButtonUp("Fire1")) && Time.time > beklemeSuresi)
        {
            beklemeSuresi = Time.time + mermiAtisSerilik;
            Instantiate(Kursun, KursununCikisYeri.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        yatay = Input.GetAxisRaw("Horizontal");
        dikey = Input.GetAxisRaw("Vertical");
        //if (Mathf.Sqrt(Input.acceleration.x) >= 0.25)
        //{
        yatay = Input.acceleration.x;
        //}

        //if (Input.acceleration.z >= -0.82)//aşağı hareket 
        //{
        //    text.text =  "1";
        //    dikey = -(Input.acceleration.z + 1);
        //}
        //else /*if (Input.acceleration.z <= -0.87)//yukarı hareket */
        //{
        //    text.text = "2";

        //    dikey = (Input.acceleration.z + 1);
        //}



        vec = new Vector3(yatay, 0, dikey);

        //klavyeden yön vermeyi bıraktığımız anda durur
        fizik.velocity = vec * hiz;

        //klavyeden yön vermeyi bıraktığımız anda durmaz kayaar
        //fizik.AddForce(vec * hiz);

        //borderlar oluşturmaya yarar
        fizik.position = new Vector3
            (
            Mathf.Clamp(fizik.position.x, minX, maxX),
            0.0f,
            Mathf.Clamp(fizik.position.z, minZ, maxZ)
            );

        fizik.rotation = Quaternion.Euler(fizik.velocity.z * -eğim, 0, fizik.velocity.x * -eğim);
    }

    public void SkorArttır(int artanSkor)
    {
        skor = skor + artanSkor;
        text.text = "Skor :" + skor;
    }
}
