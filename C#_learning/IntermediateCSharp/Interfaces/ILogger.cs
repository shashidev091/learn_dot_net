﻿using System;
namespace Interfaces
{
	public interface ILogger
	{
		void LogError(string message);
		void LogInfo(string message);
	}
}

