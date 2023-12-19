using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene01Controller : MonoBehaviour
{
    [SerializeField] private Camera Camera;
    [SerializeField] private ShaderScreen Shader;

    // Start is called before the first frame update
    void Start()
    {
        Shader.Invoke("StartFadeOut", 0f);
        //Invoke("StartCameraFlyOver", 1f);
        Shader.Invoke("StartFadeIn", 7f);
        Invoke("LoadNextScene", 8f);
    }

    private void StartCameraFlyOver()
    {
        Camera.GetComponent<Animator>().SetBool("FlyOverStarted", true);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(2);
    }
}
