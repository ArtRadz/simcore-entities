using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewTag",menuName = "Tag")]
public class TagSO : ScriptableObject
{
    [SerializeField] private  List<TagRole>  alowedRoles;
    [SerializeField] private List<TagDomain>  alowedDomains;
    [SerializeField] private TagID.TagId tagID;
    [SerializeField]private List<DrSlice> slices = new();
    public DrSlice GetSlice(TagDomain d, TagRole r) =>
        slices.Find(s => s.domain == d && s.role == r);
}
