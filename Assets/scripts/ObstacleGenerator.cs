using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    private float timeToGenerate;
    [SerializeField]
    private GameObject obstaclePrefab; // manual de instruções que é o obstaculo criado arrastado pra dentro da assets/script

    private float cronometer; // vai me informar quanto tempo ja passou 

    private void Awake()
    {
        cronometer = timeToGenerate;
    }
    // Update is called once per frame
    void Update()
    {
        // deltaTime diz quanto tempo ja passou desde o ultimo frame, 
        // aqui é basicamente um count down
        cronometer -= Time.deltaTime;
        if(cronometer <= 0)
        {            
            Instantiate(obstaclePrefab, transform.position, Quaternion.identity); //Prefab 
            //var renderer = obstaclePrefab.GetComponent<Renderer>();
            //Debug.Log(renderer.sortingOrder);
            
            cronometer = timeToGenerate;
        }
    }
}
