using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public int pointValue = 1;
    public float minSpeed = 10;
    public float maxSpeed = 20;
    public float MaxTorque = 10;
     private Rigidbody2D _targetRB;
    // Start is called before the first frame update
    void Start()
    {
        _targetRB = GetComponent<Rigidbody2D>();
        _targetRB.AddForce(Vector2.up * minSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
