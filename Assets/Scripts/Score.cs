using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // r�f�rence au composant textuel
    public int score;

    void Start()
    {
        // Assignez la r�f�rence � l'objet textuel dans l'�diteur Unity
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // Mettez � jour le texte avec le score actuel
        score = FindObjectOfType<GameManager>().score;
        scoreText.text = "Score : " + score.ToString();
    }
}


