using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public int pointValue = 1;
    public float minSpeed = 10;
    public float maxSpeed = 50;
    public float MaxTorque = 10;
     private Rigidbody2D _targetRB;
    // Start is called before the first frame update
    void Start()
    {
        _targetRB = GetComponent<Rigidbody2D>();
        _targetRB.AddForce(Vector2.up * RandomizeForce(), ForceMode2D.Impulse);
        _targetRB.AddTorque(RandomTorque());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private float RandomizeForce()
    {
        return Random.Range(minSpeed, maxSpeed);
    }

    private float RandomTorque()
    {
        return Random.Range(-MaxTorque, MaxTorque);
    }
}
