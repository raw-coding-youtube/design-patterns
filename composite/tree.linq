<Query Kind="Program" />

void Main()
{
	var top = new Node("top");
	
	top.Nodes.Add(new Node("2nd level - 0"));
	var lvl21 = new Node("2nd level - 1");
	top.Nodes.Add(lvl21);
	var lvl2 = new Node(">> 2nd level - 2");
	top.Nodes.Add(lvl2);
	
	lvl21.Nodes.Add(new Node("3rd level - 0"));
	lvl21.Nodes.Add(new Node("3rd level - 1"));
	lvl21.Nodes.Add(new Node("3rd level - 2"));
	
	
	top.ComputeNodes("nothing");
}

public class Node
{
	public Node(string data)
	{
		this.NodeData = data;
	}
	
	public string NodeData { get; set; }

	public List<Node> Nodes { get; set; } = new List<Node>() {};


	public void ComputeNodes(string parentScope) {
		var data = NodeData.Dump("start --" + parentScope);
		
		foreach (var n in Nodes)
		{
			n.ComputeNodes(data);
		}
		
		NodeData.Dump("end");
	}
}