using System;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(Vector3Value), menuName = "Strategy Game/" + nameof(Vector3Value), order = 0)]
public class ScriptableObjectValueBase<T> : ScriptableObject
{
	public T CurrentValue { get; private set; }
	public Action<T> OnNewValue;

	public void SetValue(T value)
	{
		CurrentValue = value;
		OnNewValue?.Invoke(value);
	}
}