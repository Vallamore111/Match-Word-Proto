using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BoardSize { _5x7, _6x8, _7x9, _8x10, _9x11, _10x12, _11x14 }
public class Board : MonoBehaviour
{
    public static Board instance;

    public static int boardWidth;
    public static int boardHeight;
    public static bool boardGenerated;
    public static List<Vector2Int> tileSlots;
    public static HashSet<Tile> allMatches;



    private void Awake()
    {
        instance = this;
        tileSlots = new List<Vector2Int>();
        allMatches = new HashSet<Tile>();
    }



    public void SetTileSlots()
    {
        boardWidth = LevelManager.currentLevel.levelLayout.width;
        boardHeight = LevelManager.currentLevel.levelLayout.height;

        for (int x = 0; x < boardWidth; x++)
        { 
            for (int y = 0; y < boardHeight; y++)
            {
                Vector2Int index = new Vector2Int(x, y);
                tileSlots.Add(index);
            }
        }
    }


    public void GenerateBoard()
    {
        foreach (var slot in tileSlots)
        {
            if (TileManager.FindTile(slot) != null) continue;

            TileManager.instance.CreateTile(slot);
        }
    }


    public bool CheckForMatches()
    {
        foreach (var tile in TileManager.allTiles)
        {
            Tile[] matches = MatchManager.FindMatchingBuddies(tile);

            if (matches == null) continue;

            allMatches.UnionWith(matches);
        }

        if (allMatches.Count > 0) return true;

        boardGenerated = true; 
        return false;
    }


    public void HandleMatchesImmediately()
    {
        foreach (var match in allMatches)
        {
            TileManager.allTiles.Remove(match);
            Destroy(match.gameObject);
        }
        allMatches.Clear();
    }


    public void FillHoles()
    {
        foreach (var slot in tileSlots)
        {
            if (TileManager.FindTile(slot) != null) continue;

            Tile nextBuddy = TileManager.FindTileAbove(slot);
            if (nextBuddy == null) continue;

            nextBuddy.MoveToTarget(slot);
        }
    }
}