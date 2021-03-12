using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D enemyRB;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        enemyRB.velocity = Vector2.left*speed;
    }
    // Update is called once per frame

}
