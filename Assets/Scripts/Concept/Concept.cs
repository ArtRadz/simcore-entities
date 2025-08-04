using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewConcept", menuName = "MyGame/Concept")]
public class Concept : ScriptableObject
{
    [SerializeField] private ConceptTag conceptID;
    [SerializeField] private List<Link> links;

    public Dictionary<ConceptTag, List<Link>> GetMsg()
    {
        Dictionary<ConceptTag, List<Link>> msgDict = new Dictionary<ConceptTag, List<Link>>();
        msgDict.Add(conceptID, links);
        return msgDict;
    }
}