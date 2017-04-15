using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(InventoryV3))]  // editor of this type

// 
// This combines the two Item properties in the inspector within Unity


public class InventoryEditor : Editor {

    private SerializedProperty itemImagesProperty;
    private SerializedProperty itemsProperty;

    private bool[] showItemSlots = new bool[InventoryV3.numItemSlots];

    private const string inventoryPropItemImagesName = "itemImages"; // needs to be the same as fields in inventory.cs
    private const string inventoryPropItemsName = "items";
	
    private void OnEnable()
    {
        itemImagesProperty = serializedObject.FindProperty(inventoryPropItemImagesName);
        itemsProperty = serializedObject.FindProperty(inventoryPropItemsName);
    }

    // 
    public override void OnInspectorGUI()
    {
        serializedObject.Update();  // first check to make sure the serialized object and data match

        for(int i = 0; i < InventoryV3.numItemSlots; i++)
        {
            ItemSlotGUI(i);
        }

        serializedObject.ApplyModifiedProperties();


    }

    private void ItemSlotGUI(int index)
    {
        EditorGUILayout.BeginVertical(GUI.skin.box); /// create vert layout group that is a box
        EditorGUI.indentLevel++;

        // foldout that displays GUI
        showItemSlots[index] = EditorGUILayout.Foldout(showItemSlots[index], "Item slot " + index);

        if (showItemSlots[index])
        {
            // display image and item
            EditorGUILayout.PropertyField(itemImagesProperty.GetArrayElementAtIndex(index));
            EditorGUILayout.PropertyField(itemsProperty.GetArrayElementAtIndex(index));

        }

        // cleanup
        EditorGUI.indentLevel--;
        EditorGUILayout.EndVertical();

    }


}
