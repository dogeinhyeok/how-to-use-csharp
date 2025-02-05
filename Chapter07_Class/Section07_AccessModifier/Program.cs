/* 접근 한정자로 공개 수준 결정하기 */
try
{
	WaterHeater heater = new WaterHeater();
	heater.SetTemperature(20);
	heater.TurnOnWater();

	heater.SetTemperature(-2);
	heater.TurnOnWater();

	heater.SetTemperature(50); // 범위를 벗어나서 예외 발생
	heater.TurnOnWater();
}
catch (Exception e)
{
	Console.WriteLine(e.Message);
}

class WaterHeater
{
	protected int temperature; // 직접 값을 변경할 수 없습니다

	public void SetTemperature(int temperature)
	{
		if (temperature < -5 || temperature > 42)
		{
			throw new Exception("Out of temperature range");
		}

		this.temperature = temperature;
	}

	internal void TurnOnWater()
	{
		Console.WriteLine($"Turn on water : {temperature}");
	}
}