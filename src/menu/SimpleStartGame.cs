using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleStartGame : MonoBehaviour
{
    [Header("Configuración")]
    public string gameSceneName = "juego"; 
    public float loadDelay = 0.3f; // Pequeño delay para suavizar

    // Método para el botón "Iniciar"
    public void StartGame()
    {
        Debug.Log("🎮 Iniciando juego...");
        
        if (loadDelay > 0)
        {
            Invoke("LoadGameScene", loadDelay);
        }
        else
        {
            LoadGameScene();
        }
    }

    private void LoadGameScene()
    {
        if (!string.IsNullOrEmpty(gameSceneName))
        {
            // Cargar la escena del juego
            SceneManager.LoadScene(gameSceneName);
            Debug.Log($"✅ Cargando escena: {gameSceneName}");
        }
        else
        {
            Debug.LogError("❌ El nombre de la escena está vacío!");
        }
    }

    // Método para salir del juego
    public void QuitGame()
    {
        Debug.Log("👋 Saliendo del juego...");
        
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    // Para verificar en el Editor
    [ContextMenu("Verificar Escena")]
    public void CheckScene()
    {
        if (IsSceneInBuildSettings(gameSceneName))
        {
            Debug.Log($"✅ La escena '{gameSceneName}' SÍ está en Build Settings");
        }
        else
        {
            Debug.LogError($"❌ La escena '{gameSceneName}' NO está en Build Settings");
        }
    }

    private bool IsSceneInBuildSettings(string sceneName)
    {
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            string scenePath = SceneUtility.GetScenePathByBuildIndex(i);
            string sceneInBuild = System.IO.Path.GetFileNameWithoutExtension(scenePath);
            
            if (sceneInBuild == sceneName)
                return true;
        }
        return false;
    }
}