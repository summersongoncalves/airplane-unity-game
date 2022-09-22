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
    /// <summary>
    /// Este metodo e chamado pelo Unity assim que o objeto 
    /// for criado
    /// </summary>
    private void Awake()
    {
        phisic = GetComponent<Rigidbody2D>();
        
    }
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) // verifica se o botáo direito foi pressionado
        {
            this.PullUp();
        }
    }

    
    private void PullUp()
    {
        // toda força gera uma velocidade, então preciso anular a última força - zerando a velocidade
        phisic.velocity = Vector2.zero;
        this.phisic.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }
}
