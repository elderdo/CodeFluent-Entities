﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.SignalR.Proxy.Resources
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0786")]
    public sealed partial class ValueValidationFailureHandler : CodeFluent.Runtime.Rules.BaseValueValidationFailureHandler
    {
        
        private static SoftFluent.Samples.SignalR.Proxy.Resources.ValueValidationFailureHandler _current = new SoftFluent.Samples.SignalR.Proxy.Resources.ValueValidationFailureHandler();
        
        public ValueValidationFailureHandler()
        {
        }
        
        public static SoftFluent.Samples.SignalR.Proxy.Resources.ValueValidationFailureHandler Current
        {
            get
            {
                return SoftFluent.Samples.SignalR.Proxy.Resources.ValueValidationFailureHandler._current;
            }
        }
        
        public override string GetMessage(System.Globalization.CultureInfo culture, CodeFluent.Runtime.Rules.ValueValidator validator, string failureCode, object[] arguments)
        {
            string baseMessage = base.GetMessage(culture, validator, failureCode, arguments);
            string code = this.GetCode(validator, failureCode);
            string message = SoftFluent.Samples.SignalR.Proxy.Resources.Manager.GetString(culture, code, arguments);
            if ((message == code))
            {
                return baseMessage;
            }
            return message;
        }
    }
}
