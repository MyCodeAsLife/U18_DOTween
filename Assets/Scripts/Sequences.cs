using DG.Tweening;
using UnityEngine;

public class Sequences : MonoBehaviour
{
    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMoveY(3f, 4f).SetRelative());
        sequence.Insert(0f, transform.DORotate(new Vector3(60f, 15f, 0), 2f));
        sequence.Insert(0f, transform.DOScale(2f, 2f));
        sequence.Append(transform.DOMoveX(3f, 4f).SetRelative());
        sequence.Insert(4f, transform.DORotate(new Vector3(0f, 40f, 15), 2f));
        sequence.Insert(4f, transform.DOScale(1f, 2f));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
