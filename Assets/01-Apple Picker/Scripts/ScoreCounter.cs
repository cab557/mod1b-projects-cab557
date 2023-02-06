using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour {
     [Header("Dynamic")]                                                          // b
     public int    score = 0;

     public TextMeshProUGUI  uiText;                                                        // c

     void Start() {
         uiText = gameObject.GetComponent<TextMeshProUGUI>();                                           // d
     }

     void Update() {
         uiText.text = score.ToString( "#,0" ); // This 0 is a zero!              // e
     }
}

