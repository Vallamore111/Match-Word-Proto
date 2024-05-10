using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MatchManager
{
    public static Tile[] FindMatchingBuddies(Tile tile)
    {
        if (tile.GetComponent<Stone>() != null) return null;
        tile.FindBuddies();

        Tile[] buddies = tile.buddies;
        Color color = tile.icon.color;

        bool match_N = buddies[0] != null && buddies[0].icon.color == color;
        bool match_S = buddies[1] != null && buddies[1].icon.color == color;
        bool match_W = buddies[2] != null && buddies[2].icon.color == color;
        bool match_E = buddies[3] != null && buddies[3].icon.color == color;

        if (match_N && match_S)
            return new Tile[] { buddies[0], tile, buddies[1] };

        if (match_W && match_E)
            return new Tile[] { buddies[2], tile, buddies[3] };

        return null;
    }


    public static void CheckForWord(Vector2Int startIndex, string word)
    {
        int wordLength = word.Length;
        Vector2Int[] wordHorizontal = new Vector2Int[wordLength];
        Vector2Int[] wordVertical = new Vector2Int[wordLength];

        wordHorizontal[0] = startIndex;
        wordVertical[0] = startIndex;

        for (int i = 1; i < wordLength; i++)
        {
            Vector2Int indexHorizontal = startIndex + Vector2Int.right * i;
            wordHorizontal[i] = indexHorizontal;

            Vector2Int indexVertical = startIndex + Vector2Int.down * i;
            wordVertical[i] = indexVertical;
        }

        for (int i = 0; i < wordHorizontal.Length; i++)
        {
            var nextTile = LetterManager.FindLetterTile(wordHorizontal[i]);

            if (nextTile == null) break;
            if (nextTile.letterMesh.text != word[i].ToString()) break;

            if (i + 1 == wordHorizontal.Length)
            {
                Debug.Log("Horizontal Match");
                return;
            }
        }

        for (int i = 0; i < wordVertical.Length; i++)
        {
            var nextTile = LetterManager.FindLetterTile(wordVertical[i]);

            if (nextTile == null) break;
            if (nextTile.letterMesh.text != word[i].ToString()) break;

            if (i + 1 == wordVertical.Length)
            {
                Debug.Log("Vertical Match");
                return;
            }
        }
    }
}
