using System;

namespace Glorint.Application.WeChat
{
    public interface IVerifyAttribute
    {
        bool Verify(Type type, object obj,out string message);
    }
}
