using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Tile : MonoBehaviour
{
    public Vector2Int index;
    public SpriteRenderer icon;
    [HideInInspector] public Tile[] buddies = new Tile[4];


    public void SetIndex(Vector2Int index) => this.index = index;
    public void SetColor(Color color) => icon.color = color;
    public virtual void SetName() => gameObject.name = "Tile [" + index.x + "," + index.y + "]";


    public virtual void InitializeTile(Vector2Int index)
    {
        SetIndex(index);
        SetPosition();
        SetColor(ColorManager.GetRandomColor());
        SetName();
    }


    public void UpdateIndex(Vector2Int newIndex)
    {
        SetIndex(newIndex);
        SetName();
        UpdateNearbyBuddies();
    }


    public void SetPosition()
    {
        Vector3 startPos = new Vector3(index.x, index.y + Board.boardHeight, 0);

        if (!Board.boardGenerated)
        {
            Vector3 snapPos = TileManager.GetPositionByIndex(index);
            transform.position = snapPos;
            return;
        }
        transform.position = startPos;
        MoveToTarget(index);
    }


    public void FindBuddies()
    {
        Vector2Int buddy_N = index + Vector2Int.up;
        Vector2Int buddy_S = index + Vector2Int.down;
        Vector2Int buddy_W = index + Vector2Int.left;
        Vector2Int buddy_E = index + Vector2Int.right;
        Vector2Int[] buddyTiles = { buddy_N, buddy_S, buddy_W, buddy_E };

        for (int i = 0; i < buddyTiles.Length; i++)
        { buddies[i] = TileManager.FindTile(buddyTiles[i]); }
    }


    private void UpdateNearbyBuddies()
    {
        FindBuddies();

        foreach (var buddy in buddies)
        {
            if (buddy == null) continue;
            buddy.FindBuddies();
        }
    }


    public IEnumerator DestroyTile()
    {
        float swellTime = 0.1f;
        float popTime = 0.075f;
        Transform trans = gameObject.transform;
        Vector3 swellSize = new Vector3(1.25f, 1.25f, 1f);
        Sequence sequence = DOTween.Sequence();

        Tween swell = trans.DOScale(swellSize, swellTime);
        Tween pop = trans.DOScale(Vector3.zero, popTime);

        sequence.Append(swell);
        sequence.Append(pop);

        yield return sequence.WaitForCompletion();
        TileManager.CleanUpTiles(this);
    }


    public void MoveToTarget(Vector2Int index)
    {
        float moveTime = 0.25f;
        Transform trans = gameObject.transform;
        Vector3 targetPos = new Vector3(index.x, index.y, 0);

        trans.DOMove(targetPos, moveTime);
        UpdateIndex(index);
    }


    public void MoveWithChildren(Vector2Int index)
    {
        float moveTime = 0.25f;
        Transform trans = gameObject.transform;
        Vector3 targetPos = new Vector3(index.x, index.y, 0);

        var movement = GetComponent<TileMovement>();
        Tween move = trans.DOMove(targetPos, moveTime);

        move.OnUpdate(() => movement.CyclePieces());
    }
}
