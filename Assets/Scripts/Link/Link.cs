using UnityEngine;

[CreateAssetMenu(fileName = "NewLink", menuName = "Link")]
public class Link : ScriptableObject
{
    [SerializeField] private ConceptTag InstigatorTag;
    [SerializeField] private ConceptTag TargetTag;
    [SerializeField] private ActionTag ActionTag;
    [SerializeField] private float Weight;
    public ((ConceptTag, ConceptTag), (ActionTag, float)) GetLinkData()
    {
        return ((InstigatorTag, TargetTag), (ActionTag, Weight));
    }
}   
