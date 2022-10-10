using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDirector : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverImage; // o diretor da scena sabe quem é a imagem pq ta setada manualmente no input habilitado na IDE
    private Aviao airPlane;
    private Score score;
    public void FinalizeGame()
    {
        Time.timeScale = 0; // pauso o tempo da unity 
        gameOverImage.SetActive(true);
    }
    // Awake é chamado quando o objeto for criado,
    // o método start é chamado antes do update , assim que a cena for criada.

    // Start is called before the first frame update
    void Start()
    {
        airPlane = FindObjectOfType<Aviao>(); // isso é bem pesado então NÃO FAZER dentro do update() 
        score = FindObjectOfType<Score>(); // pq busca a dependencia dentro da cena inteira.
    }
    public void RestartGame()
    {
        gameOverImage.SetActive(false);
        Time.timeScale = 1;
        airPlane.Restart();
        DestroyAllObstacles();
        score.RestartScore();

    }

    private void DestroyAllObstacles()
    {
        var obstacles = FindObjectsOfType<Obstacle>();
        foreach (var item in obstacles)
        {
            item.Destroy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
