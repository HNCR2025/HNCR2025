using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cube : MonoBehaviour
{
    private Renderer cubeRenderer;
    private Color defaultColor = Color.white;
    public int index; // Indice usato per ordinare i cubi
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.material.color = defaultColor;
    }

    public void Accendi(Color colore)
    {
        cubeRenderer.material.color = colore;
        Debug.Log("Cubo acceso: " + index);
    }

    public void Spegni()
    {
        cubeRenderer.material.color = defaultColor;
        Debug.Log("Cubo spento: " + index);
    }
}
