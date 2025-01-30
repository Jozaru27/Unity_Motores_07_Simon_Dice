using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private string[] botonesPulsados = new string[20]; // Almacena los nombres de los colores pulsados
    private int contadorBotonesPulsados = 0; // Lleva la cuenta de pulsaciones

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RegistrarPulsacion(string color)
    {
        if (contadorBotonesPulsados < 20)
        {
            botonesPulsados[contadorBotonesPulsados] = color;
            contadorBotonesPulsados++;
            Debug.Log("Color pulsado: " + color);
        }
        else
        {
            Debug.Log("¡Has alcanzado el máximo de 20 pulsaciones!");
        }
    }
}
