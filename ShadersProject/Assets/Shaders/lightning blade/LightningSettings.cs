using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSettings : MonoBehaviour
{
    [SerializeField] private int minBolts = 3;
    [SerializeField] private int maxBlots = 7;
    [SerializeField] private float changeDuration = 0.1f;

    [SerializeField] private Material material;

    private void Awake()
    {
        InvokeRepeating(nameof(ChangeMaterialValues), changeDuration, changeDuration);
    }

    private void ChangeMaterialValues()
    {
        int bolts = Random.Range(minBolts, maxBlots);
        float angle = Random.Range(0, Mathf.PI);

        material.SetFloat("_Bolts", bolts);
        material.SetFloat("_Angle", angle);
    }
}
