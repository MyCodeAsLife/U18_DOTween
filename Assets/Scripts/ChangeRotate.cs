using DG.Tweening;
using UnityEngine;

public class ChangeRotate : MonoBehaviour
{
    private void Start()
    {
        Vector3 newRotate = new Vector3(60f, 15f, 0);
        float duration = 2f;

        transform.DORotate(newRotate, duration).SetLoops(-1, LoopType.Yoyo);
    }
}
