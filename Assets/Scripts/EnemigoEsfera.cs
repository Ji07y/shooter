using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemigoEsfera : MonoBehaviour
{
    public int vidasEnemigos = 2;
    private static int contadorEsferasDestruidas = 0;


    public TextMeshProUGUI textEsferasDestruidas;

    // Start is called before the first frame update

    public void Damage(int damageCantidad)
    {

        vidasEnemigos -= damageCantidad;
        if (vidasEnemigos <= 0)
        {
            contadorEsferasDestruidas++;
            gameObject.SetActive(false);
            textEsferasDestruidas.text = "Esferas destruidas: " + contadorEsferasDestruidas;
        }



    }
}
