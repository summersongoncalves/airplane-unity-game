using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// o gravity scale dessa classe deve ser setada no unity como 0 , pra não reagir a gravidade
/// e o body type como kinematic - quer dizer que ele não vai responder a física a não ser q eu configure
/// </summary>
public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.5f;
    [SerializeField]
    private float positionY;
    private Vector3 planePosition;
    private bool hasScored;
    // Update is called once per frame
    void Update()
    {// mover o obstaculo da direita pra esquerda 
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        Debug.Log($"{transform.position.x}");
        //Time.deltaTime tempo entre a última chamada update() e a atual 
        if(!hasScored && transform.position.x < planePosition.x) // marcar ponto se passar pelo obstaculo
        {
            
            Debug.Log($"Pontuou!! \n Posição barreira: {transform.position.x}");
            hasScored = true;
            Debug.Break();
        }
    }     
    private void Start()
    {
        planePosition = FindObjectOfType<Aviao>().transform.position;
    }

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-positionY, positionY));
    }
    /// <summary>
    /// Método do Unity dispara um evento quando trigger for ativado
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destroy();
    }

    public void Destroy()
    {
        Destroy(gameObject); // gameObject objeto da unity pra destuir este objeto
    }
}
