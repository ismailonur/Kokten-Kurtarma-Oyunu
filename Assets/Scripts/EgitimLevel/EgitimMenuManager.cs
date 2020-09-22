using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EgitimMenuManager : MonoBehaviour
{
    public GameObject startButton, geridonButton;
    public GameObject fadePanel;

    void Start()
    {
        if (startButton != null)
        {
            startButton.GetComponent<RectTransform>().localScale = Vector3.zero;
        }

        if (geridonButton != null)
        {
            geridonButton.GetComponent<RectTransform>().localScale = Vector3.zero;
        }

        fadePanel.GetComponent<CanvasGroup>().DOFade(0, 1f).OnComplete(IlkAyariYap);
    }

    void IlkAyariYap()
    {
        ButonlariAc();
    }

    void ButonlariAc()
    {
        startButton.GetComponent<RectTransform>().DOScale(1, 1f).SetEase(Ease.OutBounce);
        geridonButton.GetComponent<RectTransform>().DOScale(1, 1f).SetEase(Ease.OutBounce);
    }
}
