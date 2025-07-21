using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewFacet",menuName = "Facet")]

public class Facet : ScriptableObject
{
    
    public TagDomain Domain;
    public TagRole Role;
    public List<TagSO> Tags;

    // OnValidate is a tmp function for testing TODO refactor this please 
    void OnValidate()
    {
        // if (role != null && (role.Domains & TagDomain.TagDomains.Role) == 0)
        // {
        //     Debug.LogError($"Facet `{name}`: Assigned tag `{role.name}` lacks TagDomain.Role flag — clearing field.");
        //     role = null;  
        // }
        //
        // aspects.RemoveAll(a => a != null && (a.Domains & TagDomain.TagDomains.Aspect) == 0);
    }
}
