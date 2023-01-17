using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    [SerializeField] private float speed;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        m_Rigidbody.velocity = transform.right * 10f;
        Invoke(nameof(DestoryBullet), 2);
    }

    private void FixedUpdate()
    {
        float angle = Mathf.Atan2(m_Rigidbody.velocity.y, m_Rigidbody.velocity.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    private void DestoryBullet()
    {
        Destroy(gameObject);
    }
}
