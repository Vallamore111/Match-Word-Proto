using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class LevelLayout
{
    public int width;
    public int height;
    public LetterLayout letterLayout;
    public StoneLayout stoneLayout;
}


[System.Serializable]
public class LetterLayout
{
	[System.Serializable]
	public struct rowData
	{
		public string[] row;
	}

	public rowData[] column;
}


[System.Serializable]
public class StoneLayout
{
	[System.Serializable]
	public struct rowData
	{
		public bool[] row;
	}

	public rowData[] column;
}

