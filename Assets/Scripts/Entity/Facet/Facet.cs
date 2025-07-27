using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewFacet",menuName = "Facet")]

public class Facet : ScriptableObject
{
    private FacetData data = new FacetData();
    
    public TagDomain Domain;
    public TagRole Role;
    public List<TagSO> Tags;

    public void Init()
    {
        foreach (TagSO tag in Tags)
        {
            data.FacetTagsByID[tag.tagID]=tag;
        }
    }
}
