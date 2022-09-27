using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{    
    // FORÇA = ACELERAÇAO X MASSA
    // FORCA É GRAVIDADE
    [SerializeField]
    private float force = 6;
    private Rigidbody2D phisic;
    private SceneDirector sceneDirector;
    private Vector3 startPosition;
    /// <summary>
    /// Este metodo e chamado pelo Unity assim que o objeto 
    /// for criado
    /// </summary>
    private void Awake()
    {
        phisic = GetComponent<Rigidbody2D>(); // pego componente que está dentro do meu proprio objeto ou seja o avião       
        startPosition = transform.position;       

    }   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        phisic.simulated = false;
        sceneDirector.FinalizeGame();
    }
    private void Start()
    {
        sceneDirector = FindObjectOfType<SceneDirector>(); // isso é bem pesado então NÃO FAZER dentro do update()       
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) // verifica se o botáo direito foi pressionado
        {
            PullUp();
        }
    }
    
    private void PullUp()
    {
        // toda força gera uma velocidade, então preciso anular a última força - zerando a velocidade
        phisic.velocity = Vector2.zero;
        this.phisic.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }    
    public void Restart()
    {
        transform.position = startPosition;
        phisic.simulated = true;
    }
   
}
