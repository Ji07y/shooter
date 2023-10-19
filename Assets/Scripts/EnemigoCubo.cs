using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public int vidasEnemigos = 3;
    private static int contadorCubosDestruidos = 0;
    

    public TextMeshProUGUI textCubosDestruidos;
    
    

    public void Damage(int damageCantidad)
    {
       
            vidasEnemigos -= damageCantidad;
            
            if (vidasEnemigos <= 0)
            {
            contadorCubosDestruidos++;
            gameObject.SetActive(false);
                
             textCubosDestruidos.text = "Cubos Destruidos:" + contadorCubosDestruidos;
            }
        
        

    }
}
