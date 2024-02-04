namespace TWIEditor.Attributes
{
    using System;
    using TWI.Attributes;
    using UnityEditor;
    using UnityEngine;

    [CustomPropertyDrawer(typeof(SubtypeFieldAttribute))]
    public class SubtypeFieldDrawer : PropertyDrawer
    {
        private Type subtype;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType != SerializedPropertyType.ObjectReference) throw new InvalidOperationException();
            else subtype ??= attribute is SubtypeFieldAttribute attrbute ? attrbute.subtype : throw new InvalidCastException();
            property.objectReferenceValue = EditorGUI.ObjectField(position, label, property.objectReferenceValue, subtype, true);
        }
    }
}
