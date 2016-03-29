﻿using HTMLEngine.CefGlue.CefSession;
using MVVM.HTML.Core.JavascriptEngine.JavascriptObject;
using Xilium.CefGlue;

namespace HTMLEngine.CefGlue.CefGlueHelper
{
    public static class CefFrameExtensionExtension
    {
        public static IWebView GetMainContext(this CefFrame @this)
        {
            return CefCoreSessionSingleton.Session.CefApp.GetContext(@this);
        }
    }
}
