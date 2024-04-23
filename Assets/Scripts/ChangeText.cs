using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("������", 3f));
        sequence.Append(_text.DOText(" ����������", 3f).SetRelative());
        sequence.Append(_text.DOText("�����", 2f, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Restart);
    }
}
