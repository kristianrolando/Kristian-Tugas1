using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public float speed = 1.2f;

    private void Start()
    {
        Invoke("SelfDestruct", 15f);
    }
    private void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
    public void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
