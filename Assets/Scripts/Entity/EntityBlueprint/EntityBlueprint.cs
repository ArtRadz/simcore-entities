using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewEntity",menuName = "Entity")]
public class EntityBlueprint : ScriptableObject
{
    public List<Facet> facets;
}
