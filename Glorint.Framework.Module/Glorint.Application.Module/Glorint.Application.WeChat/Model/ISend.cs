﻿namespace Glorint.Application.WeChat
{
    public interface ISend<out T>
        where T : OperationResultsBase, new()
    {
        T Send();
    }
}