using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    public float height = 0.1f;
    public float speed = 10;
    public float offset;

    private void Start()
    {
        offset = Random.Range(0f, 100f);
    }

    private void Update()
    {
        transform.localPosition = Vector3.up * Mathf.Sin(offset + Time.time * speed * 6.28f) * height;
    }
}
