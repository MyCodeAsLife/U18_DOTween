using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void Start()
    {
        const string ReplacementText = "������";
        const string AdditionText = " ����������";
        const string IteratingText = "�������";
        const float Duration = 3f;

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(ReplacementText, Duration));
        sequence.Append(_text.DOText(AdditionText, Duration).SetRelative());
        sequence.Append(_text.DOText(IteratingText, Duration, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Restart);
    }
}
