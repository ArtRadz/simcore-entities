using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] public List<Facet> facets;
    private EntityInitializer init;
    public 

    private void Awake()
    {
        init.Init(facets);
    }
}
