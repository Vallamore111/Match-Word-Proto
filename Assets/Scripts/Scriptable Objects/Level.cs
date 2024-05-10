using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(menuName = "Level", fileName = "New Level")]
public class Level : ScriptableObject
{
    public int levelNumber;
    public string word;
    public ColorPalette letterColor;
    public BoardSize boardSize;
    public LevelLayout levelLayout;


    private void OnValidate()
    {
        switch (boardSize)
        {
            case BoardSize._5x7:
                levelLayout.width = 5;
                levelLayout.height = 7;
                break;

            case BoardSize._6x8:
                levelLayout.width = 6;
                levelLayout.height = 8;
                break;

            case BoardSize._7x9:
                levelLayout.width = 7;
                levelLayout.height = 9;
                break;

            case BoardSize._8x10:
                levelLayout.width = 8;
                levelLayout.height = 10;
                break;

            case BoardSize._9x11:
                levelLayout.width = 9;
                levelLayout.height = 11;
                break;

            case BoardSize._10x12:
                levelLayout.width = 10;
                levelLayout.height = 12;
                break;

            case BoardSize._11x14:
                levelLayout.width = 11;
                levelLayout.height = 14;
                break;

            default:
                break;
        }
    }
}


