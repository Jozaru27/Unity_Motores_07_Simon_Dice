using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonManager : MonoBehaviour
{

    public string colorBoton; 
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Para botones de colores
    public void OnBotonColorClick()
    {
        if (gameManager != null)
        {
            gameManager.RegistrarPulsacion(colorBoton);
            Debug.Log("Botón pulsado: " + colorBoton);
        }
    }


    // Para el botón "Terminar"
    public void OnBotonTerminarClick()
    {
        if (gameManager != null)
        {
            gameManager.MostrarSecuencia();
            gameManager.IniciarMostrarSecuencia();
        }
    }
}