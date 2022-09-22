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
    // Update is called once per frame
    void Update()
    {// mover o obstaculo da direita pra esquerda 
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        //Time.deltaTime tempo entre a última chamada update() e a atual 
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

    private void Destroy()
    {
        Destroy(gameObject); // gameObject objeto da unity pra destuir este objeto
    }
}
