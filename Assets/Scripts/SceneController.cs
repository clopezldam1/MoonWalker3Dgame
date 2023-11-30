using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

public class SceneController : MonoBehaviour
{
    /*
     Salir del juego
     */
    public void cerrarJuego()
    {
        Application.Quit();
    }

    /*
     Carga una escena cerrando la anterior
     */
    public static void cambiarEscena(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex, LoadSceneMode.Single);
    }
}
