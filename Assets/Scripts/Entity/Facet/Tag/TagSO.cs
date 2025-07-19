using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewTag",menuName = "Tag")]
public class TagSO : ScriptableObject
{
    [SerializeField] private  List<TagRole.TagRoles>  roles;
    [SerializeField] private List<TagDomain.TagDomains>  domains;
    [SerializeField] private TagID.TagId tagID;
    
}
