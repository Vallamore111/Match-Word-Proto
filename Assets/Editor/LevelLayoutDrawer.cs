using UnityEngine;
using UnityEditor;


[CustomPropertyDrawer(typeof(LevelLayout))]
public class LevelLayoutDrawer : PropertyDrawer 
{
	int boardWidth;
	int boardHeight;
	Rect newPosition;
	float propertySize = 20f;


	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		SerializedProperty width = property.FindPropertyRelative("width");
		SerializedProperty height = property.FindPropertyRelative("height");
		SerializedProperty stoneLayout = property.FindPropertyRelative("stoneLayout");
		SerializedProperty letterLayout = property.FindPropertyRelative("letterLayout");

		boardWidth = width.intValue;
		boardHeight = height.intValue;
		newPosition = position;

		EditorGUI.PrefixLabel(position, label, EditorStyles.boldLabel);

		DrawLayoutProperty(newPosition, letterLayout);
		DrawLayoutProperty(newPosition, stoneLayout);
	}



	public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
	{
		int propertyCount = 2; 
		float padding = 5f;
		float totalSize = (propertySize + padding) * (boardHeight + propertyCount) * propertyCount;
		return totalSize;
	}



	public void DrawLayoutProperty(Rect position, SerializedProperty property)
	{
		float yPosCache;
		float xPosCache;
		float padding = 5f;
		float gapBetweenLayouts = propertySize * 0.75f;
		SerializedProperty column = property.FindPropertyRelative("column");

		DrawLabel(position, property);

		position.y += (propertySize + padding) * (boardHeight + 1);
		yPosCache = position.y;
		xPosCache = position.x;

		if (column.arraySize != boardWidth) column.arraySize = boardWidth;

		for (int i = 0; i < boardWidth; i++)
		{
			SerializedProperty row = column.GetArrayElementAtIndex(i).FindPropertyRelative("row");
			position.height = propertySize;
			position.width = propertySize;

			if (row.arraySize != boardHeight) row.arraySize = boardHeight;

			for (int j = 0; j < boardHeight; j++)
			{
				EditorGUI.PropertyField(position, row.GetArrayElementAtIndex(j), GUIContent.none);
				position.y -= propertySize + padding;
			}
			position.y = yPosCache;
			position.x += propertySize + padding;
		}

		position.x = xPosCache;
		position.y += gapBetweenLayouts;
		newPosition = position;
	}


	public void DrawLabel(Rect position, SerializedProperty property)
	{
		Rect labelPos = position;
		labelPos.height = propertySize;
		labelPos.width = Screen.width;
		labelPos.y += propertySize;
		EditorGUI.LabelField(labelPos, property.displayName);
	}
}
