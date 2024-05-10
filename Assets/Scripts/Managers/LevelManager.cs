using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public static Level currentLevel;
    public List<Level> levels = new List<Level>();


    private void Awake()
    {
        instance = this;
    }


    public void InitializeStoryBoard()
    {
        currentLevel = levels[1];

        Board.instance.SetTileSlots();
        LetterManager.instance.SetUpLetters();
        StoneManager.instance.SetUpStones();
        Board.instance.GenerateBoard();
        CameraManager.FitCameraToBoard();

        if (!Board.instance.CheckForMatches()) return;

        Board.instance.HandleMatchesImmediately();
        InitializeStoryBoard();
    }


    public void InitializeEndlessBoard()
    {
        currentLevel = levels[0];
        var column = currentLevel.levelLayout.letterLayout.column;

        for (int i = 0; i < column.Length; i++)
            for (int j = 0; j < column[i].row.Length; j++)
                currentLevel.levelLayout.letterLayout.column[i].row[j] = Lexicon.alphabet[Random.Range(0, Lexicon.alphabet.Length)].ToString();

        Board.instance.SetTileSlots();
        LetterManager.instance.SetUpLetters();
        Board.instance.GenerateBoard();
        CameraManager.FitCameraToBoard();

/*        if (!Board.instance.CheckForMatches()) return;

        Board.instance.HandleMatchesImmediately();
        InitializeStoryBoard();
*/    }


    public static string CheckLetterLayout(Vector2Int index)
    {
        string letter = currentLevel.levelLayout.letterLayout.column[index.x].row[index.y];
        if (letter != string.Empty) 
            return letter;
        else return string.Empty;
    }


    public static bool CheckStoneLayout(Vector2Int index)
    {
        if (currentLevel.levelLayout.stoneLayout.column[index.x].row[index.y]) 
            return true;
        else return false;
    }
}
