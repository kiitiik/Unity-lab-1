using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private InputField _inputField;
    [SerializeField] private Button _button;
    [SerializeField] private Text Text;

    private void Awake()
    {
        Debug.Assert(_inputField != null, $"Assign {nameof(_inputField)} field in the inspector");
        Debug.Assert(_button != null, $"Assign {nameof(_button)} field in the inspector");
        Debug.Assert(Text != null, $"Assign {nameof(Text)} field in the inspector");
        Debug.Assert(_inputField.contentType == InputField.ContentType.IntegerNumber, "InputType should be IntegerNumber");
        _button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        int result = ActionWithNumber(Convert.ToInt32(_inputField.text));
        Text.text = result.ToString();
    }

    private int ActionWithNumber(int input)
    {
        print(input);
        return input;
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveAllListeners();
    }
}
