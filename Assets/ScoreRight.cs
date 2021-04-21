using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRight : MonoBehaviour
{
   public int score = 0;
   private Text ScoreText;
   // Start is called before the first frame update
   void Start()
   {
      ScoreText = GetComponent<Text>();

   }

   // Update is called once per frame
   void Update()
   {
      ScoreText.text = score.ToString();
   }
}
