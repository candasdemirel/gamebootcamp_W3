using UnityEngine;
using UnityEngine.SceneManagement;

public class ExampleSceneLoader : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            LoadScene();
        }

        if (Input.GetKeyUp(KeyCode.Y))
        {
            UnLoadScene();
        }
    }
    private void LoadScene()
    {
        SceneManager.LoadScene((int)Scenes.UIScene, LoadSceneMode.Additive);
    }

    private void UnLoadScene()
    {
        SceneManager.UnloadSceneAsync((int)Scenes.UIScene);
    }
}

public enum Scenes
{
    SampleScene,
    UIScene
}
