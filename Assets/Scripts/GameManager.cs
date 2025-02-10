using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private string[] botonesPulsados = new string[20];
    private int contadorBotonesPulsados = 0;
    public TextMeshProUGUI textoColores;

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
            Debug.Log("Color registrado: " + color);
        }
        else
        {
            Debug.Log("¡Límite de 20 pulsaciones alcanzado!");
        }
    }


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
        StartCoroutine(MostrarSecuenciaTexto()); 
    }


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
    }
}
