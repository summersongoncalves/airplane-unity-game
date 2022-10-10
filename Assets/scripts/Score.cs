using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int scores;
    [SerializeField]
    private Text scoreText;
    private AudioSource audioScore;
    /// <summary>
    /// Adiciona pontos 
    /// </summary>
    public void AddScores()
    {
        scores++;        
        scoreText.text = scores.ToString();
        audioScore.Play();
    }
    public void RestartScore()
    {
        scores = 0;
        scoreText.text = scores.ToString();

    }
    private void Awake()
    {
        audioScore = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
