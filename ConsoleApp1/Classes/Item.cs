using System;

public class Item
{
	//Name of the item
	private string name;

	//Description of the item
	private string description;

	//Cost of the item.
	private int cost;


	public Item(string name, string description, int cost)
	{
		this.name = name;
		this.description = description;
		this.cost = cost;
	}
}
