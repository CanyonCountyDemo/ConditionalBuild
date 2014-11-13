using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConditionalMessage
{
  public class ConMessage
  {
    public static string GetMessage()
    {
#if DEBUG
      return "This is a Debug build";
#else
      return "This is a Release build";
#endif
    }
  }
}
