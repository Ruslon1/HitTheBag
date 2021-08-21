using System;
using System.Collections;
using UnityEngine;
using TMPro;

public interface IRenderImpactStrength
{
    IEnumerator Display(float sliderValue);
}

public class RenderImpactStrength : MonoBehaviour, IRenderImpactStrength
{
    [SerializeField] private TMP_Text _counter;


    private float _maxValue = 999f;

    private WaitForSeconds _waitingTime = new WaitForSeconds(0.02f);
    private readonly WaitForSeconds _finalWaitingTime = new WaitForSeconds(0.1f);

    public IEnumerator Display(float sliderValue)
    {
        float targetImpactStrength = _maxValue * sliderValue;
        float currentImpactStrength = 0f;

        yield return new WaitForSeconds(5f);

        while (currentImpactStrength <= targetImpactStrength)
        {
            _counter.text = Math.Floor(currentImpactStrength).ToString();
            currentImpactStrength++;

            if (currentImpactStrength > targetImpactStrength / 1.06f)
                _waitingTime = _finalWaitingTime;


            yield return _waitingTime;
        }
    }
}