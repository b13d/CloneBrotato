using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bullet : MonoBehaviour
{
    Rigidbody2D _rb;

    [SerializeField]
    float _speed = 4f;

    float timeDestroy = 3f;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ - 90);

        _rb.velocity = transform.up * _speed;
        Invoke("DestroyBullet", timeDestroy);
    }
    

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            GameManager.instance.AddScore();

            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
