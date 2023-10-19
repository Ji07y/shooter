using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour
{
    public float tiempoInicial = 10.0f; 
    private float tiempoRestante;
    public TextMeshProUGUI textM;
    

    void Start()
    {
        tiempoRestante = tiempoInicial;

        textM.text = "10.00";
    }

    void Update()
    {
        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime; 
            textM.text = tiempoRestante.ToString("F2");

        }
        else
        {
            tiempoRestante = 0; 
            
            textM.text = "GameOver";
                    
        }
    }
}
