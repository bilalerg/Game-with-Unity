using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab = default;

    OyunKontrol oyunKontrol;
    void Start()
    {
        float yon = Random.Range(0f, 1.0f);

        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        oyunKontrol = Camera.main.GetComponent<OyunKontrol>();


        if (yon < 0f)
        {
            rb2d.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            rb2d.AddTorque(yon * 20.0f);
        }
        else
        {
            rb2d.AddForce(new Vector2(Random.Range(1.0f, 2.5f), Random.Range(2.5f, -1.0f)), ForceMode2D.Impulse);
            rb2d.AddTorque(-yon * 20.0f);
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Kursun")
        {
            oyunKontrol.AsteroidYokOldu(gameObject);
            Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}


