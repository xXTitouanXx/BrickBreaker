using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // référence au composant textuel
    public int score;

    void Start()
    {
        // Assignez la référence à l'objet textuel dans l'éditeur Unity
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // Mettez à jour le texte avec le score actuel
        score = FindObjectOfType<GameManager>().score;
        scoreText.text = "Score : " + score.ToString();
    }
}


