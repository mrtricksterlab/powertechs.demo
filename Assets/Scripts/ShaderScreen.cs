using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScreen : MonoBehaviour
{
    [SerializeField] private bool startScreen;
    [SerializeField] private GameObject firstLogo;
    [SerializeField] private GameObject transLogo;

    public void StartFadeOut()
    {
        firstLogo.SetActive(startScreen);
        transLogo.SetActive(!startScreen);
        GetComponent<Animator>().SetTrigger("FadeOutStarted");
    }

    public void StartFadeIn()
    {
        firstLogo.SetActive(false);
        transLogo.SetActive(true);
        GetComponent<Animator>().SetTrigger("FadeInStarted");
    }
}
