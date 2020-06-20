using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(GameManager))]
    public class GameManagerEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            GameManager gameManager = (GameManager) target;

            if (GUILayout.Button("Reset Player State"))
            {
                PlayerPrefManager.ResetPlayerState(gameManager.startLives, false);
            }
            
            if (GUILayout.Button("Reset High Score"))
            {
                PlayerPrefManager.SetHighscore(0);
            }
            
            if (GUILayout.Button("Output Player State"))
            {
                PlayerPrefManager.ShowPlayerPrefs();
            }
            
        }
    }
}