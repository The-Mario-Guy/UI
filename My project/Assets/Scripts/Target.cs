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

    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _targetRB = GetComponent<Rigidbody2D>();
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

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

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter2d(Collider2D other)
    {
        Destroy(this.gameObject);

        if(!other.gameObject.CompareTag("Bad"))
        {
            //Debug.Log("Game Over!");
            _gameManager.IsGameActive = false;
        }
    }
}
