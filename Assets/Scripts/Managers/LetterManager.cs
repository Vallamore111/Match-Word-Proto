using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterManager : MonoBehaviour
{
    public GameObject letterPrefab;
    public static LetterManager instance;
    public static string levelWord;
    public static Color letterColor;
    public static List<Letter> activeLetters;


    private void Awake()
    {
        instance = this;
        activeLetters = new List<Letter>();
    }


    public void SetUpLetters()
    {
        letterColor = ColorManager.GetColor(LevelManager.currentLevel.letterColor);
        levelWord = LevelManager.currentLevel.word;

        foreach (var slot in Board.tileSlots)
        {
            string letter = LevelManager.CheckLetterLayout(slot);

            if (TileManager.FindTile(slot) != null) continue;
            if (letter == string.Empty) continue;

            CreateLetterTile(letter, slot);
        }
    }


    public void CreateLetterTile(string text, Vector2Int index)
    {
        var obj = Instantiate(letterPrefab, Board.instance.transform);
        var letter = obj.GetComponent<Letter>();
        letter.SetLetter(text);
        letter.InitializeTile(index);
        activeLetters.Add(letter);
        TileManager.allTiles.Add(letter);
    }


    public static Letter FindLetterTile(Vector2Int index)
    {
        foreach (var tile in activeLetters)
        {
            if (tile.index == index)
            { return tile; }
        }
        return null;
    }


    public void FindWordStart()
    {
        Vector2Int startIndex;

        foreach (var tile in activeLetters)
        {
            if (!tile.startOfWord) continue;

            startIndex = tile.index;
            MatchManager.CheckForWord(startIndex, levelWord);
        }
    }

        
}
