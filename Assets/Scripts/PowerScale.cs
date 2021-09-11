using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;

[RequireComponent(typeof(Slider))]
public class PowerScale : MonoBehaviour
{
    public Slider Slider { get; private set; }
    
    private TweenerCore<float, float, FloatOptions> _basicChanges;
    
    private void Start()
    {
        Slider = GetComponent<Slider>();
        ChangeSliderValue();
    }

    private void ChangeSliderValue()
    {
        _basicChanges = Slider.DOValue(Slider.maxValue, 1f).SetLoops(-1, LoopType.Yoyo);
    }

    public void StopSliderChanges()
    {
        _basicChanges?.Kill();
    }

    public void DisableSlider()
    {
        gameObject.SetActive(false);
    }
}