using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Scene02Controller : MonoBehaviour
{
    [SerializeField] private Camera Camera;
    [SerializeField] private ShaderScreen Shader;
    [SerializeField] private AudioSource SirenSound;
    [SerializeField] private GameObject SirenLight;
    [SerializeField] private float SirenDelay = 15f;
    [SerializeField] private Volume GlobalVolume;
    [SerializeField] private float BlurDelay = 21f;

    // Start is called before the first frame update
    void Start()
    {
        SirenLight.SetActive(false);
        Shader.Invoke("StartFadeOut", 0f);
        Invoke("StartSiren", SirenDelay);
        Invoke("StartBlur", BlurDelay);
    }
    void StartSiren()
    {
        SirenSound.Play();
        SirenLight.SetActive(true);
    }
    void StartBlur()
    {
    }
}
