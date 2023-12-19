using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene02Controller : MonoBehaviour
{
    [SerializeField] private Camera Camera;
    [SerializeField] private ShaderScreen Shader;
    [SerializeField] private AudioSource SirenSound;
    [SerializeField] private GameObject SirenLight;

    // Start is called before the first frame update
    void Start()
    {
        SirenLight.SetActive(false);
        Shader.Invoke("StartFadeOut", 0f);
        Invoke("StartSiren", 45f);
    }
    void StartSiren()
    {
        SirenSound.Play();
        SirenLight.SetActive(true);
    }
}
