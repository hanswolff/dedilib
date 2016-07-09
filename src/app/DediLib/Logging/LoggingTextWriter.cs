﻿using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DediLib.Logging
{
    public class LoggingTextWriter : TextWriter
    {
        private readonly ILogger _logger;
        private readonly LogLevel _logLevel;
        private readonly StringBuilder _line = new StringBuilder();

        public LoggingTextWriter(ILogger logger, LogLevel logLevel = LogLevel.Debug)
        {
            if (logger == null) throw new ArgumentNullException(nameof(logger));
            _logger = logger;

            _logLevel = logLevel;
        }

        public override void Write(bool value)
        {
            _line.Append(value);
        }

        public override void Write(char value)
        {
            _line.Append(value);
        }

        public override void Write(char[] buffer)
        {
            _line.Append(buffer);
        }

        public override void Write(char[] buffer, int index, int count)
        {
            _line.Append(buffer, index, count);
        }

        public override void Write(decimal value)
        {
            _line.Append(value);
        }

        public override void Write(double value)
        {
            _line.Append(value);
        }

        public override void Write(float value)
        {
            _line.Append(value);
        }

        public override void Write(int value)
        {
            _line.Append(value);
        }

        public override void Write(long value)
        {
            _line.Append(value);
        }

        public override void Write(object value)
        {
            _line.Append(value);
        }

        public override void Write(string value)
        {
            _line.Append(value);
        }

        public override void Write(string format, object arg0)
        {
            _line.Append(String.Format(format, arg0));
        }

        public override void Write(string format, object arg0, object arg1)
        {
            _line.Append(String.Format(format, arg0, arg1));
        }

        public override void Write(string format, object arg0, object arg1, object arg2)
        {
            _line.Append(String.Format(format, arg0, arg1, arg2));
        }

        public override void Write(string format, params object[] arg)
        {
            _line.Append(String.Format(format, arg));
        }

        public override void Write(uint value)
        {
            _line.Append(value);
        }

        public override void Write(ulong value)
        {
            _line.Append(value);
        }

        public override async Task WriteAsync(char value)
        {
            _line.Append(value);
        }

        public override async Task WriteAsync(char[] buffer, int index, int count)
        {
            _line.Append(buffer, index, count);
        }

        public override async Task WriteAsync(string value)
        {
            _line.Append(value);
        }

        public override void WriteLine()
        {
            if (_line.Length <= 0) return;

            var logText = _line.ToString();
            _line.Clear();

            switch (_logLevel)
            {
                case LogLevel.Debug:
                    _logger.Debug(logText);
                    break;
                case LogLevel.Info:
                    _logger.Info(logText);
                    break;
                case LogLevel.Warn:
                    _logger.Warning(logText);
                    break;
                case LogLevel.Error:
                    _logger.Error(logText);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override void WriteLine(bool value)
        {
            _line.Append(value);
            WriteLine();
        }

        public override void WriteLine(char value)
        {
            _line.Append(value);
            WriteLine();
        }

        public override void WriteLine(char[] buffer)
        {
            _line.Append(buffer);
            WriteLine();
        }

        public override void WriteLine(char[] buffer, int index, int count)
        {
            _line.Append(buffer, index, count);
            WriteLine();
        }

        public override void WriteLine(decimal value)
        {
            _line.Append(value);
            WriteLine();
        }

        public override void WriteLine(double value)
        {
            _line.Append(value);
            WriteLine();
        }

        public override void WriteLine(float value)
        {
            _line.Append(value);
            WriteLine();
        }

        public override void WriteLine(int value)
        {
            _line.Append(value);
            WriteLine();
        }

        public override void WriteLine(long value)
        {
            _line.Append(value);
            WriteLine();
        }

        public override void WriteLine(object value)
        {
            _line.Append(value);
            WriteLine();
        }

        public override void WriteLine(string value)
        {
            _line.Append(value);
            WriteLine();
        }

        public override void WriteLine(string format, object arg0)
        {
            _line.Append(String.Format(format, arg0));
            WriteLine();
        }

        public override void WriteLine(string format, object arg0, object arg1)
        {
            _line.Append(String.Format(format, arg0, arg1));
            WriteLine();
        }

        public override void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            _line.Append(String.Format(format, arg0, arg1, arg2));
            WriteLine();
        }

        public override void WriteLine(string format, params object[] arg)
        {
            _line.Append(String.Format(format, arg));
            WriteLine();
        }

        public override void WriteLine(uint value)
        {
            _line.Append(value);
            WriteLine();
        }

        public override void WriteLine(ulong value)
        {
            _line.Append(value);
            WriteLine();
        }

        public override async Task WriteLineAsync()
        {
            WriteLine();
        }

        public override async Task WriteLineAsync(char value)
        {
            await WriteAsync(value);
            WriteLine();
        }

        public override async Task WriteLineAsync(char[] buffer, int index, int count)
        {
            await WriteAsync(buffer, index, count);
            WriteLine();
        }

        public override async Task WriteLineAsync(string value)
        {
            await WriteAsync(value);
            WriteLine();
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
