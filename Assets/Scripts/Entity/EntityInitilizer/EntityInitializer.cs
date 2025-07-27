using System.Collections.Generic;

public class EntityInitializer
{
    public void Init(List<Facet> facets)
    {
        foreach (Facet facet in facets)
        {
            facet.Init();
        }
    }
}