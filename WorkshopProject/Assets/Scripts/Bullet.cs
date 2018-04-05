using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed;
    public float damage;
    public float lifeTime = 3f;

    private Vector3 dir;
    private float internTimer = 0;

    public void Init(Vector3 dir)
    {
        this.dir = dir;
        this.transform.localEulerAngles = new Vector3(0, 0, Mathf.Atan2(dir.y, dir.x) * 180 / Mathf.PI);
    }

    private void Update()
    {
        internTimer += Time.deltaTime;
        if (internTimer >= lifeTime)
            Destroy(this.gameObject);
    }

    void FixedUpdate () {
        this.transform.position = this.transform.position + dir * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            var health = collision.gameObject.GetComponent<EnemyHealth>();

            if(health != null)
            {
                health.ApplyDamage(damage);
                Destroy(this.gameObject);
            }
        }
    }

}
