using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Raycast : MonoBehaviour
{
  
    private int contD = 0;
    private int disparosRealizados = 0;
 
    public TextMeshProUGUI textDisparos;
    public TextMeshProUGUI textTemporizador;

    void Update()
    {
        RaycastHit hit;
        Ray myRay = new Ray(transform.position, transform.forward);


        Debug.DrawRay(myRay.origin, myRay.direction * 30, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            Disparo();
        }
    }

    private void Disparo()
    {
        RaycastHit hit;
        Ray myRay = new Ray(transform.position, transform.forward);


        Debug.DrawRay(myRay.origin, myRay.direction * 30, Color.red);
        

        disparosRealizados++;
        textDisparos.text = "Disparos: " + disparosRealizados.ToString();
       

        if (Physics.Raycast(myRay, out hit))
        {
          

            disparosRealizados = contD + disparosRealizados;
            textDisparos.text = "Disparos: " + disparosRealizados.ToString();

            contD = 0; 
            if (hit.transform.CompareTag("ene"))
            {
                contD++;
                Enemigos vida = hit.transform.GetComponent<Enemigos>();

                if (vida != null)
                {
                    vida.Damage(contD);
                }

               Debug.Log(hit.transform.tag);
            }

            contD = 0;
            if (hit.transform.CompareTag("sph"))
            {
                
                EnemigoEsfera vida = hit.transform.GetComponent<EnemigoEsfera>();

                contD++;
                if (vida != null)
                {
                    vida.Damage(contD);
                }

                Debug.Log(hit.transform.tag);
            }

            

        }

    }
}
