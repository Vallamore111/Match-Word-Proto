using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SequenceManager : MonoBehaviour
{
    public static SequenceManager instance;
    private float waitTime = 0.3f;


    private void Awake() => instance = this;

    public void StartMatchSequence() => StartCoroutine(MatchSequence());
    public void StartUndoSequence(Tile tile, Vector2Int index) => StartCoroutine(UndoSequence(tile, index));


    public IEnumerator MatchSequence()
    {
        StartCoroutine(DestructionSequence());
        yield return new WaitForSeconds(waitTime);

        Board.instance.FillHoles();
        yield return new WaitForSeconds(waitTime);

        Board.instance.GenerateBoard();
        yield return new WaitForSeconds(waitTime);

        if (!Board.instance.CheckForMatches()) yield break;
        StartCoroutine(MatchSequence());
    }


    public IEnumerator DestructionSequence()
    {
        foreach (var match in Board.allMatches)
        {
            if (match.GetComponent<Letter>() == null)
            { StartCoroutine(match.DestroyTile()); }
        }
        Board.allMatches.Clear();
        LetterManager.instance.FindWordStart();
        yield return null;
    }


    public IEnumerator UndoSequence(Tile tile, Vector2Int index)
    {
        tile.MoveWithChildren(index);
        yield return new WaitForSeconds(waitTime);

        TileManager.UpdateAllIndices();
        TileManager.FreeTiles();
    }
}