using System;
using System.Reflection;

namespace CommandLine.Infrastructure;

internal class LocalizableAttributeProperty
{
	private string _propertyName;

	private string _value;

	private Type _type;

	private PropertyInfo _localizationPropertyInfo;

	public string Value
	{
		get
		{
			return GetLocalizedValue();
		}
		set
		{
			_localizationPropertyInfo = null;
			_value = value;
		}
	}

	public Type ResourceType
	{
		set
		{
			_localizationPropertyInfo = null;
			_type = value;
		}
	}

	public LocalizableAttributeProperty(string propertyName)
	{
		_propertyName = propertyName;
	}

	private string GetLocalizedValue()
	{
		if (!string.IsNullOrEmpty(_value) && !(_type == null))
		{
			if (_localizationPropertyInfo == null)
			{
				if (!_type.IsVisible)
				{
					throw new ArgumentException("Invalid resource type", _propertyName);
				}
				PropertyInfo property = _type.GetProperty(_value, BindingFlags.Static | BindingFlags.Public | BindingFlags.GetProperty);
				if (property == null || !property.CanRead || property.PropertyType != typeof(string))
				{
					throw new ArgumentException("Invalid resource property name", _propertyName);
				}
				_localizationPropertyInfo = property;
			}
			return (string)_localizationPropertyInfo.GetValue(null, null);
		}
		return _value;
	}
}
