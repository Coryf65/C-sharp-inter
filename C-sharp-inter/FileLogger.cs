namespace C_sharp_inter;

public class FileLogger : ILogger
{
	private readonly string _path;
	private enum MessageType
	{
		Info,
		Warning,
		Error
	}

	public FileLogger(string path)
	{
		_path = path;
	}

	public void LogError(string message)
	{
		Log(MessageType.Error, message);
	}

	public void LogInfo(string message)
	{
		Log(MessageType.Info, message);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="messageType">Type of meesage being logged</param>
	/// <param name="message"></param>
	private void Log(MessageType messageType, string message)
	{
		using (StreamWriter streamWriter = new(_path, true))
		{
			streamWriter.WriteLine($"[{messageType}] :  {message}");
		}
	}
}
