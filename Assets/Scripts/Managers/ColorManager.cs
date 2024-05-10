using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColorPalette { Red, Orange, Yellow, Green, Blue, Indigo, Violet, Pink }

public static class ColorManager
{
    public static List<Color32> colorPalette = new List<Color32>()
    {
        new Color32(253, 121, 121, 255),    // Red
        new Color32(255, 200, 125, 255),    // Orange
        new Color32(255, 255, 135, 255),    // Yellow
        new Color32(167, 255, 134, 255),    // Green
        new Color32(134, 241, 255, 255),    // Blue
        new Color32(150, 150, 224, 255),    // Indigo
        new Color32(85, 85, 222, 255),      // Violet
        new Color32(253, 179, 253, 255)     // Pink
    };


    public static Color32 GetRandomColor()
    {
        int random = Random.Range(0, colorPalette.Count);
        return colorPalette[random];
    }


    public static Color32 GetColor(ColorPalette color)
    {
        switch (color)
        {
            case ColorPalette.Red:
                return colorPalette[0];

            case ColorPalette.Orange:
                return colorPalette[1];

            case ColorPalette.Yellow:
                return colorPalette[2];

            case ColorPalette.Green:
                return colorPalette[3];

            case ColorPalette.Blue:
                return colorPalette[4];

            case ColorPalette.Indigo:
                return colorPalette[5];

            case ColorPalette.Violet:
                return colorPalette[6];

            case ColorPalette.Pink:
                return colorPalette[7];

            default:
                return Color.clear;
        }
    }
}
