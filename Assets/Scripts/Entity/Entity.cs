using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] public List<Facet> facets = new List<Facet>();
    private EntityInitializer init = new EntityInitializer();

    private void Awake()
    {
        init.Init(facets);
    }
}
