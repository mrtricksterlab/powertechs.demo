using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    [SerializeField] private AudioSource Soundtrack;

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        Soundtrack.GetComponent<Animator>().enabled = false;
        Invoke("FadeOutSound", 30f);
    }

    void FadeOutSound()
    {
        Soundtrack.GetComponent<Animator>().enabled = true;
    }
}
