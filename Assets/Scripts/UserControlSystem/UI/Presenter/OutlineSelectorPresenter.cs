using UnityEngine;

public class OutlineSelectorPresenter : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectable;

    private IOutlineSelector[] _outlineSelectors;
    private ISelectable _currentSelectable;

    private void Start()
    {
        _selectable.OnNewValue += onSelected;
        onSelected(_selectable.CurrentValue);
    }

    private void onSelected(ISelectable selectable)
    {
        if (_currentSelectable == selectable)
        {
            return;
        }
        _currentSelectable = selectable;

        setSelected(_outlineSelectors, false);
        _outlineSelectors = null;

        if (selectable != null)
        {
            _outlineSelectors = (selectable as Component).GetComponentsInParent<IOutlineSelector>();
            setSelected(_outlineSelectors, true);
        }

        static void setSelected(IOutlineSelector[] selectors, bool value)
        {
            if (selectors != null)
            {
                for (int i = 0; i < selectors.Length; i++)
                {
                    selectors[i].SetSelected(value);
                }
            }
        }
    }
}