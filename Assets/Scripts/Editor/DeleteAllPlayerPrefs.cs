using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class DeleteAllPlayerPrefs : ScriptableObject
    {
        [MenuItem("Editor/Delete Player Prefs")]
        static void DeletePrefs()
        {
            if (EditorUtility.DisplayDialog("Delete all player preferences?", 
                "Are you sure to delete all the player preferences", 
                "Yes", "No"))
            {
                PlayerPrefs.DeleteAll();
            }
        }
    }
}