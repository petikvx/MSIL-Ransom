namespace GraphComposite;

public class GraphCompositeBuilderConfiguration
{
	private bool isHierarchical = true;

	private bool isAcyclic = true;

	public bool Hierarchical => isHierarchical;

	public bool Acyclic => isAcyclic;

	public GraphCompositeBuilderConfiguration()
	{
		isHierarchical = true;
		isAcyclic = true;
	}

	public GraphCompositeBuilderConfiguration(bool hierarchical, bool acyclic)
	{
		isHierarchical = hierarchical;
		isAcyclic = acyclic;
	}
}
