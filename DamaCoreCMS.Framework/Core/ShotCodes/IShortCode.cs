﻿

namespace DamaCoreCMS.Framework.Core.ShotCodes
{
    /// <summary>
    /// Interface for implementing ShortCode.
    /// You must have set ShortCodeName. Which will be unique name.
    /// ShortCode of the content will be replaced by the returned string of Render() method.
    /// ShortCode Syntax:-
    /// [ShortCodeName ParamName="Value", ParamName2="Value", ParamName3="Value" ShortCodeName]
    /// </summary>
    public interface IShortCode
    {
        string ShortCodeName { get; }
        string Render(params object[] paramiters);
    }
}
