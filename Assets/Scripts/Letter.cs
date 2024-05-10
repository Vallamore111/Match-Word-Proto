using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : Tile
{
    public TextMesh letterMesh;
    public bool startOfWord;


    public override void SetName() => gameObject.name = "Tile [" + index.x + "," + index.y + "]: " + letterMesh.text;


    public void SetLetter(string letter)
    {
        letterMesh.text = letter;
        if (LetterManager.levelWord == string.Empty) return;

        if (letter == LetterManager.levelWord[0].ToString())
        { startOfWord = true; }
    }


    public override void InitializeTile(Vector2Int index)
    {
        SetIndex(index);
        SetPosition();
        SetColor(LetterManager.letterColor);
        SetName();
    }

}
