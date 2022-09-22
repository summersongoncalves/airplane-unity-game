using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDirector : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverImage; // o diretor da scena sabe quem é a imagem pq ta setada manualmente no input habilitado na IDE
    public void FinalizeGame()
    {
        Time.timeScale = 0; // pauso o tempo da unity 
        gameOverImage.SetActive(true);
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
