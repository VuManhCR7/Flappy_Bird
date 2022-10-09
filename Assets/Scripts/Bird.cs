using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float thrust = 1f;

    void Awake()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.AddForce(transform.up * thrust);
        rb2D.AddForce(transform.up * thrust, ForceMode2D.Impulse);
    }
}
