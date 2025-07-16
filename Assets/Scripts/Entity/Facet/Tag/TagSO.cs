
using UnityEngine;
[CreateAssetMenu(fileName = "NewTag",menuName = "Tag")]
public class TagSO : ScriptableObject
{
    [SerializeField] private TagDomain.TagDomains  domains;
    [SerializeField] private TagID.TagId tagID;
    
    public TagDomain.TagDomains Domains => domains;
    public TagID.TagId ID => tagID;
}
