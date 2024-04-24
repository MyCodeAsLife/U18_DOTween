using DG.Tweening;
using UnityEngine;

public class RotateChanger : MonoBehaviour
{
    private void Start()
    {
        const float Duration = 2f;

        Vector3 newRotate = new Vector3(60f, 15f, 0);

        transform.DORotate(newRotate, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
