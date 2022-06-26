namespace Kiwi.Core
{
	public class QueuedBool
	{
		public void SetCondition(Condition _condition)
		{
			condition = _condition;
		}

		public void SetOnAfterSuccessfulSet(OnAfterSuccessfulSet _onAfterSuccessfulSet)
		{
			onAfterSuccessfulSet = _onAfterSuccessfulSet;
		}
		
		public void SetValue(bool _value)
		{
			if (!_value || value)
				return;
			if (condition != null && !condition.Invoke())
				return;

			value = true;
			
			onAfterSuccessfulSet?.Invoke();
		}
		
		public bool GetValue()
		{
			if (!value)
				return false;

			value = false;

			return true;
		}

		public bool GetValueNoReset()
		{
			return value;
		}

		public delegate bool Condition();
		public delegate void OnAfterSuccessfulSet();
		
		Condition condition;
		OnAfterSuccessfulSet onAfterSuccessfulSet;

		bool value;
	}
}