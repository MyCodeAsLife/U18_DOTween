using DG.Tweening;
using UnityEngine;

public class Sequences : MonoBehaviour
{
    private void Start()
    {
        float posY = 3f;
        float posX = 3f;
        float firstScale = 2f;
        float secondScale = 2f;
        float durationMove = 4f;
        float durationScale = 2f;
        float durationRotate = 2f;
        Vector3 firstRotate = new Vector3(60f, 15f, 0);
        Vector3 secondRotate = new Vector3(0f, 40f, 15);

        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMoveY(posY, durationMove).SetRelative());
        sequence.Insert(0f, transform.DORotate(firstRotate, durationRotate));
        sequence.Insert(0f, transform.DOScale(firstScale, durationScale));
        sequence.Append(transform.DOMoveX(posX, durationMove).SetRelative());
        sequence.Insert(4f, transform.DORotate(secondRotate, durationRotate));
        sequence.Insert(4f, transform.DOScale(secondScale, durationScale));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
