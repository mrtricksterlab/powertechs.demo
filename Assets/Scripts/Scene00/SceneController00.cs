using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController00 : MonoBehaviour
{
    [SerializeField] private float StartDelay;
    [SerializeField] private Camera Camera;
    [SerializeField] private ShaderScreen Shader;

    // Start is called before the first frame update
    void Start()
    {
        Shader.Invoke("StartFadeOut", StartDelay);
        Invoke("StartCameraFlyOver", StartDelay + 2f);
        Shader.Invoke("StartFadeIn", StartDelay + 17f);
        Invoke("LoadNextScene", StartDelay + 18f);
    }

    private void StartCameraFlyOver()
    {
        Camera.GetComponent<Animator>().SetBool("FlyOverStarted", true);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }
}
