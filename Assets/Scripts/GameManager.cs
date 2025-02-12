using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private string[] botonesPulsados = new string[20]; // Almacena la secuencia de botones pulsados
    private int contadorBotonesPulsados = 0; // Lleva la cuenta de botones pulsados
    public TextMeshProUGUI textoColores;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Almacena pulsaciones hasta 20, mostrando la elección al instante mediante el debug log
    public void RegistrarPulsacion(string color)
    {
        if (contadorBotonesPulsados < 20)
        {
            botonesPulsados[contadorBotonesPulsados] = color;
            contadorBotonesPulsados++;
            Debug.Log("Color registrado: " + color);
        }
        else
        {
            Debug.Log("¡Límite de 20 pulsaciones alcanzado!");
        }
    }


    // Muestra la secuencia de colores pulsados en el debug log
    public void MostrarSecuencia()
    {
        Debug.Log("Secuencia de colores pulsados:");
        for (int i = 0; i < contadorBotonesPulsados; i++)
        {
            Debug.Log(botonesPulsados[i]);
        }
    }


    public void IniciarMostrarSecuencia()
    {
        StartCoroutine(MostrarSecuenciaTexto()); // Llama a la corrutina para mostrar texto 
    }


    // Muestra la secuencia de colores pulsados mediante texto en pantalla
    public IEnumerator MostrarSecuenciaTexto()
    {
        textoColores.text = "";
        for (int i = 0; i < contadorBotonesPulsados; i++)
        {
            textoColores.text = botonesPulsados[i];
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(1f);
        textoColores.text = "";

        ReiniciarJuego(); // Una vez ha mostrado los colores, reinicia el juego.
    }


    // Reinicia el array y el contador para que se puedan almacenar nuevos colores
    private void ReiniciarJuego()
    {
        botonesPulsados = new string[20];
        contadorBotonesPulsados = 0;
        Debug.Log("El juego se ha reiniciado. Puedes empezar a pulsar colores de nuevo.");
    }
}
