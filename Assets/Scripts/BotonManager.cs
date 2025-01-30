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
        gameManager = FindObjectOfType<GameManager>(); // Busca el GameManager
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnBotonPulsado()
    {
        if (gameManager != null)
        {
            gameManager.RegistrarPulsacion(colorBoton); // Envía el color del botón al GameManager
        }
    }
}
