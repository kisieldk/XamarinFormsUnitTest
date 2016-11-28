using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSample
{
	public interface IClipboard
	{
		string GetTextFromCliboard();
		void SaveTextToClipboard(string saveText);
	}
}
