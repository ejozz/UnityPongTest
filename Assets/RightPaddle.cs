using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddle : MonoBehaviour
{
   float speed = 0.1f;
   // Start is called before the first frame update
   void Start()
   {

   }

   // Update is called once per frame
   void FixedUpdate()
   {
      if (Input.GetKey(KeyCode.UpArrow))
         transform.position = new Vector2(
             transform.position.x,
             Mathf.Clamp(transform.position.y + speed,-3.625f, 3.625f));
      else if (Input.GetKey(KeyCode.DownArrow))
         transform.position = new Vector2(
             transform.position.x,
             Mathf.Clamp(transform.position.y - speed, -3.625f, 3.625f));
   }
}
