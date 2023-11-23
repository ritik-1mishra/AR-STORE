using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mtrlswap : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public Material material1;
    public Material material2;
    public Material material3;

    private Renderer objectRenderer;

    void Start()
    {
        
        objectRenderer = GetComponent<Renderer>();

        
        button1.onClick.AddListener(() => ChangeMaterial(material1));
        button2.onClick.AddListener(() => ChangeMaterial(material2));
        button3.onClick.AddListener(() => ChangeMaterial(material3));
    }

    void ChangeMaterial(Material newMaterial)
    {
        
        objectRenderer.material = newMaterial;
    }
}
