using DG.Tweening;
using UnityEngine;

public class Sequences : MonoBehaviour
{
    private void Start()
    {
        const float PosY = 3f;
        const float PosX = 3f;
        const float FirstScale = 2f;
        const float SecondScale = 2f;
        const float TimePosition = 4f;
        const float DurationMove = 4f;
        const float DurationScale = 2f;
        const float DurationRotate = 2f;

        Vector3 firstRotate = new Vector3(60f, 15f, 0);
        Vector3 secondRotate = new Vector3(0f, 40f, 15);

        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMoveY(PosY, DurationMove).SetRelative());
        sequence.Insert(0f, transform.DORotate(firstRotate, DurationRotate));
        sequence.Insert(0f, transform.DOScale(FirstScale, DurationScale));
        sequence.Append(transform.DOMoveX(PosX, DurationMove).SetRelative());
        sequence.Insert(TimePosition, transform.DORotate(secondRotate, DurationRotate));
        sequence.Insert(TimePosition, transform.DOScale(SecondScale, DurationScale));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
