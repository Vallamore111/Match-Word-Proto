using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;


public class TileMovement : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private Vector2Int startIndex;
    private Vector3 startPos;
    private Vector3 dragDelta;
    private bool dragging;
    private bool dragVertical;
    private bool dragHorizontal;
    private float xMinLimit;
    private float xMaxLimit;
    private float yMinLimit;
    private float yMaxLimit;



    public void OnPointerDown(PointerEventData eventData)
    {
        Tile clickedTile = GetComponent<Tile>();
        TileManager.FindColumnAndRow(clickedTile);
        startIndex = clickedTile.index;
        startPos = CameraManager.mainCamera.ScreenToWorldPoint(eventData.position);
    }


    public void OnDrag(PointerEventData eventData)
    {
        Vector3 newPos = CameraManager.mainCamera.ScreenToWorldPoint(eventData.position);

        LockDragAxis(startPos, newPos);
        MovePieces(newPos);
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        EndMove();

        if (Board.instance.CheckForMatches())
        {
            TileManager.FreeTiles();
            SequenceManager.instance.StartMatchSequence();
        }
        else 
        {
            Tile clickedTile = GetComponent<Tile>();
            SequenceManager.instance.StartUndoSequence(clickedTile, startIndex);        
        }
    }


    private void LockDragAxis(Vector3 clickPos, Vector3 dragPos)
    {
        float dragThreshold = 0.1f;
        dragDelta = dragPos - clickPos;
        startPos = dragPos;

        if (dragging) return;

        dragVertical = Mathf.Abs(dragDelta.y) > Mathf.Abs(dragDelta.x) && Mathf.Abs(dragDelta.y) >= dragThreshold;
        dragHorizontal = Mathf.Abs(dragDelta.x) > Mathf.Abs(dragDelta.y) && Mathf.Abs(dragDelta.x) >= dragThreshold;

        if (dragVertical || dragHorizontal) dragging = true;

        SetChildrenTiles();
        GetDragLimits();
    }


    private void SetChildrenTiles()
    {
        List<Tile> children = new List<Tile>();

        if (dragHorizontal)
        { children = TileManager.rowTiles; }

        if (dragVertical)
        { children = TileManager.columnTiles; }

        foreach (var tile in children)
        {
            if (tile.transform.parent != this.transform)
            { tile.transform.parent = this.transform; }
        }
    }


    private void GetDragLimits()
    {
        xMinLimit = 0;
        xMaxLimit = Board.boardWidth - 1;

        yMinLimit = 0;
        yMaxLimit = Board.boardHeight - 1;

        foreach (Transform child in transform)
        {
            if (child.GetComponent<Stone>() == null) continue;

            if (transform.position.x - child.position.x > xMinLimit)
            { xMinLimit = transform.position.x - child.position.x; }

            if ((transform.position.x + (xMaxLimit - child.position.x)) < xMaxLimit)
            { xMaxLimit = transform.position.x + (xMaxLimit - child.position.x); }

            if (transform.position.y - child.position.y > yMinLimit)
            { yMinLimit = transform.position.y - child.position.y; }

            if ((transform.position.y + (yMaxLimit - child.position.y)) < yMaxLimit)
            { yMaxLimit = transform.position.y + (yMaxLimit - child.position.y); }
        }
    }


    private void MovePieces(Vector3 dragPos)
    {
        Vector3 tilePos = transform.position;

        if (dragHorizontal)
        { tilePos.x = Mathf.Clamp(dragPos.x, xMinLimit, xMaxLimit); }

        if (dragVertical)
        { tilePos.y = Mathf.Clamp(dragPos.y, yMinLimit, yMaxLimit); }

        transform.position = tilePos;
        CyclePieces();
    }


    public void CyclePieces()
    {
        Vector3 cyclePos = transform.position;
        float cycleThreshold = 0.5f;

        foreach (Transform child in transform)
        {
            if (child.position.y < -cycleThreshold)
            {
                float yPos = Board.boardHeight + child.position.y;
                cyclePos.y = yPos;
                child.position = cyclePos;
            }

            if (child.position.y > Board.boardHeight - cycleThreshold)
            {
                float yPos = 0 - (Board.boardHeight - child.position.y);
                cyclePos.y = yPos;
                child.position = cyclePos;
            }

            if (child.position.x < -cycleThreshold)
            {
                float xPos = Board.boardWidth + child.position.x;
                cyclePos.x = xPos;
                child.position = cyclePos;
            }

            if (child.position.x > Board.boardWidth - cycleThreshold)
            {
                float xPos = 0 - (Board.boardWidth - child.position.x);
                cyclePos.x = xPos;
                child.position = cyclePos;
            }
        }
    }

    private void EndMove()
    {
        dragging = false;

        Tile tile = GetComponent<Tile>();
        TileManager.LockToBoardSlot(tile);

        TileManager.columnTiles.Clear();
        TileManager.rowTiles.Clear();

        TileManager.UpdateAllIndices();
    }
}