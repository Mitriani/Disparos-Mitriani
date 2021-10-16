using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject balaPrefab;
    void Start()
    {
        Disparo();
    }

    void Update()
    {
        
    }

    void Disparo()
    {
        Instantiate(balaPrefab, transform);
    }
}
