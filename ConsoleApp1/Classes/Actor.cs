using System;

public class Actor
{
	//name of Actor
	private string name;

	//amount of HP 
	private int hP;

	//amount of strength;
	private int sTR;

	//amount of defense;
	private int dEF;

	public Actor(string name, int hP, int sTr, int dEF)
	{
		this.name = name;
		this.hP = hP;
		this.sTR = sTr;
		this.dEF = dEF;
	}

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int HP
    {
        get { return hP; }
        set { hP = value; }
    }

    public int STR
    {
        get { return sTR; }
        set { sTR = value; }
    }

    public int DEF
    {
        get { return dEF; }
        set { dEF = value; }
    }
}
