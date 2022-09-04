using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {// mover o obstaculo da direita pra esquerda 
        transform.Translate(Vector3.left * speed);
    }
}
