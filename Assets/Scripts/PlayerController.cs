using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float speed;
    bool collisionChecker = true;
    private Animator playerAnim;
    public Text gameOver;
    public Text score;
    float scoreCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        Text gameOver = GetComponent<Text>();
        Text score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        scoreCounter += Time.deltaTime;
        score.text = "score=" + Mathf.RoundToInt(scoreCounter).ToString();
        if (Input.GetKey(KeyCode.Space) && collisionChecker)
        {
            playerRB.AddForce(Vector2.up *speed, ForceMode2D.Impulse);
            collisionChecker = false;
            playerAnim.SetBool("run", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Ground")
        {
            collisionChecker = true;
            playerAnim.SetBool("run", true);
        }
        else
        {
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
