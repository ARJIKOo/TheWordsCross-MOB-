using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RandomImage : MonoBehaviour
{
    [SerializeField] private Sprite[] images;
    private Image imageComponents;

    private void OnEnable()
    {
        imageComponents = GetComponent<Image>();
        ChangeImage();
    }

    public void ChangeImage()
    {
        if (images != null && images.Length > 0)
        {
            int randomIndex = Random.Range(0, images.Length);
            imageComponents.sprite = images[randomIndex];
        }
    }
}
