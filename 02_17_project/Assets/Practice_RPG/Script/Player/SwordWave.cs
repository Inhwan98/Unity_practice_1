using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordWave : MonoBehaviour
{
    public float speed;

    [HideInInspector]
    public int waveDamage;
    [HideInInspector]
    public float waveRate;
    Rigidbody rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rigid.velocity = transform.forward * speed * Time.deltaTime;
        Destroy(gameObject, 1f);
    }
}
