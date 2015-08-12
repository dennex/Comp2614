using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace COMP2614.News
{
	internal class Buffer
	{
		private const int DEFAULT_CAPACITY = 10240;

		private int capacity;
		private byte[] data;
		private int bufDataStart, bufUnusedStart;

		public Buffer()
		{
			capacity = DEFAULT_CAPACITY;
			data = new byte[capacity];
			bufDataStart = bufUnusedStart = 0;
		}

		public Buffer(int capacity)
		{
			this.capacity = capacity;
			data = new byte[capacity];
			bufDataStart = bufUnusedStart = 0;
		}

//		public bool NewData { get { return freshEnd > freshStart; } }

		public int Length { get { return bufUnusedStart - bufDataStart; } } 

		public int Start { get { return bufDataStart; } }

		public int End { get { return bufUnusedStart; } }

		public void Clear()
		{
			bufDataStart = bufUnusedStart = 0;
		}

		public int Fill(Stream stream)
		{
			int bytesRead = stream.Read(data, bufUnusedStart, capacity-bufUnusedStart-1);

			// There's now fresh data to read from this object.
			bufUnusedStart += bytesRead;

			return bytesRead;
		}

		public int GetNewData(byte[] outputBuffer, int offset, char delimiter, bool storeDelimiter, out bool delimEncountered)
		{
			// To start with...
			delimEncountered = false;

			if (Length == 0) return 0;

			int outputBufIdx = offset;

			MemoryStream memStream = new MemoryStream(data, bufDataStart, data.Length - bufDataStart);
			byte [] b = new byte[1];
			int bytesRead = memStream.Read(b, 0, 1);
			int bytesStored = 0;
			while (bytesRead == 1 && b[0] != delimiter && b[0] != '\0' && bytesStored < outputBuffer.Length)
			{
				outputBuffer[outputBufIdx++] = b[0];
				bytesRead = memStream.Read(b, 0, 1);
				++bytesStored;
			}

			if (b[0] == delimiter)
			{
				delimEncountered = true;
				if (storeDelimiter)
				{
					outputBuffer[outputBufIdx++] = b[0];
					++bytesStored;
				}
			}

			if (bytesStored == Length)
			{
				Clear();
			}
			else
			{
				// Encountered delimiter, so update where to start reading from for next call.
				bufDataStart += bytesStored;
			}

			return bytesStored;
		}
	}
}
