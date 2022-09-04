using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.1f;
    // vector3 tem x,y,z
    private Vector3 startPosition;
    private float realImageSize;
    private void Awake()
    {
        startPosition = transform.position;
        var imageSize = GetComponent<SpriteRenderer>().size.x;
        var scale = transform.localScale.x;
        realImageSize = imageSize * scale;
    }
    void Update()
    {

        // deslocamento
        float displacement = Mathf.Repeat(speed * Time.time,realImageSize);
        //transform.Translate(Vector3.left * speed);
        transform.position = startPosition + Vector3.left * displacement;
    }
}
