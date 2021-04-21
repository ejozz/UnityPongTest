using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    static float initialSpeed = 4;
    float speed = initialSpeed;
    Rigidbody2D rb;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      direction = Vector2.one.normalized;
    }

   // Update is called once per frame

   private void FixedUpdate()
   {
      rb.velocity = direction * speed;
   }


   private void OnCollisionEnter2D(Collision2D collision)
   {
      if(collision.gameObject.CompareTag("Wall"))
      {
         direction.y = -direction.y;
      }
      else if (collision.gameObject.CompareTag("Paddle"))
      {
         direction.x = -direction.x;
         speed += 0.25f;
      }
      else if (collision.gameObject.CompareTag("Goal"))
      {
         if(direction.x<0)
            GameObject.Find("ScoreLeft").GetComponent<ScoreLeft>().score++;
         else
            GameObject.Find("ScoreRight").GetComponent<ScoreRight>().score++;


         speed = initialSpeed;
         gameObject.transform.localPosition = new Vector3(0, 0, 0);
         direction.x = -direction.x;
         direction.y = -direction.y;
      }
   }

}
