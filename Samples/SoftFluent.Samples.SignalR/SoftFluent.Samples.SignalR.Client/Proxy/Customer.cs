﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftFluent.Samples.SignalR.Proxy
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Monday, 03 November 2014 12:12.
    // Build:1.0.61214.0786
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0786")]
    [System.ComponentModel.DataObjectAttribute()]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, FirstName={FirstName}, Id={Id}")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CodeFluent.Runtime.CodeFluentRelationType))]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.softfluent.com/samples/signalr")]
    public partial class Customer : System.ICloneable, System.IComparable, System.IComparable<SoftFluent.Samples.SignalR.Proxy.Customer>, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, CodeFluent.Runtime.ServiceModel.ICodeFluentCollectionEntity<System.Guid>, System.ComponentModel.IDataErrorInfo, System.IEquatable<SoftFluent.Samples.SignalR.Proxy.Customer>, CodeFluent.Runtime.Utilities.IKeyable<System.Guid>, CodeFluent.Runtime.Diagnostics.ITraceable, System.ComponentModel.INotifyPropertyChanged
    {
        
        private System.Guid _id = CodeFluentPersistence.DefaultGuidValue;
        
        private string _firstName = default(string);
        
        private string _lastName = default(string);
        
        private bool _raisePropertyChangedEvents = true;
        
        [System.NonSerializedAttribute()]
        private bool _isDeserializing;
        
        [System.NonSerializedAttribute()]
        private bool _isSerializing;
        
#if SILVERLIGHT
[System.Runtime.Serialization.DataMemberAttribute(Order=2147483647)]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
public CodeFluent.Runtime.CodeFluentEntityState _entityState;
#else
[System.Runtime.Serialization.DataMemberAttribute(Order=2147483647)]
private CodeFluent.Runtime.CodeFluentEntityState _entityState;
#endif
#if SILVERLIGHT
protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
{
    if ((this.RaisePropertyChangedEvents == false))
    {
        return;
    }
    if ((this.PropertyChanged != null))
    {
        if ((System.Windows.Deployment.Current.Dispatcher.CheckAccess() == true))
        {
            this.PropertyChanged(this, e);
        }
        else
        {
            System.Windows.Deployment.Current.Dispatcher.BeginInvoke(this.PropertyChanged, this, e);
        }
    }
}
#else
protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
{
    if ((this.RaisePropertyChangedEvents == false))
    {
        return;
    }
    if ((this.PropertyChanged != null))
    {
        this.PropertyChanged(this, e);
    }
}
#endif
        
        public Customer()
        {
            this._id = System.Guid.NewGuid();
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        System.Guid CodeFluent.Runtime.Utilities.IKeyable<System.Guid>.Key
        {
            get
            {
                return this.Id;
            }
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public virtual string EntityKey
        {
            get
            {
                return this.Id.ToString();
            }
            set
            {
                this.Id = ((System.Guid)(ConvertUtilities.ChangeType(value, typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.FirstName;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.Guid))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=100)]
        public System.Guid Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<System.Guid>.Default.Equals(value, this._id) == true))
                {
                    return;
                }
                System.Guid oldKey = this._id;
                if ((value.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
                    this._id = System.Guid.NewGuid();
                }
                else
                {
                    this._id = value;
                }
                try
                {
                    this.OnCollectionKeyChanged(oldKey);
                }
                catch (System.ArgumentException )
                {
                    this._id = oldKey;
                    return;
                }
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Id"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=200)]
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("FirstName"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=300)]
        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("LastName"));
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        public virtual bool IsDefaultEntityKey
        {
            get
            {
                if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        bool CodeFluent.Runtime.ServiceModel.ICodeFluentEntity.IsDefaultEntityKey
        {
            get
            {
                return this.IsDefaultEntityKey;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        protected virtual bool IsDeserializing
        {
            get
            {
                return this._isDeserializing;
            }
            set
            {
                this._isDeserializing = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        protected virtual bool IsSerializing
        {
            get
            {
                return this._isSerializing;
            }
            set
            {
                this._isSerializing = value;
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        public event System.EventHandler<CodeFluent.Runtime.ServiceModel.CodeFluentEntityActionEventArgs> EntityAction;
        
        public event System.EventHandler<CodeFluent.Runtime.Utilities.KeyChangedEventArgs<System.Guid>> KeyChanged;
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        void CodeFluent.Runtime.ICodeFluentSummaryValidator.Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateLocal(culture, results);
        }
        
        protected virtual string ValidateLocal(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void ValidateLocal(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.ServiceModel.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.ServiceModel.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = SoftFluent.Samples.SignalR.Proxy.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.SignalR.Proxy.Customer.ExternalValidate", "Type \'SoftFluent.Samples.SignalR.Customer\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                string localValidate = SoftFluent.Samples.SignalR.Proxy.Resources.Manager.GetStringWithDefault(culture, "SoftFluent.Samples.SignalR.Proxy.Customer.Id.NullException", "\'Id\' property cannot be set to \'00000000-0000-0000-0000-000000000000\' for type \'S" +
                        "oftFluent.Samples.SignalR.Customer\'", null);
                CodeFluentPersistence.AddValidationError(results, localValidate);
            }
            this.OnEntityAction(new CodeFluent.Runtime.ServiceModel.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture, CodeFluent.Runtime.ServiceModel.BindingFlags invokeFlags)
        {
            if ((((invokeFlags & CodeFluent.Runtime.ServiceModel.BindingFlags.Local) 
                        == 0) 
                        == false))
            {
                return this.ValidateLocal(culture);
            }
            if ((((invokeFlags & CodeFluent.Runtime.ServiceModel.BindingFlags.Remote) 
                        == 0) 
                        == false))
            {
                return this.ValidateRemote(culture);
            }
            return null;
        }
        
        public string Validate(System.Globalization.CultureInfo culture)
        {
            return this.Validate(culture, CodeFluent.Runtime.ServiceModel.BindingFlags.Local);
        }
        
        protected virtual string ValidateRemote(System.Globalization.CultureInfo culture)
        {
            if ((culture == null))
            {
                throw new System.ArgumentNullException("culture");
            }
            string ret = SoftFluent.Samples.SignalR.Proxy.Customer.WcfClient.Current.Channel.Validate(this, culture.Name);
            return ret;
        }
        
        public virtual bool Delete()
        {
            bool ret = SoftFluent.Samples.SignalR.Proxy.Customer.WcfClient.Current.Channel.DeleteByKey(this.Id);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.SignalR.Proxy.Customer Load(System.Guid id)
        {
            if ((id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return null;
            }
            SoftFluent.Samples.SignalR.Proxy.Customer ret = SoftFluent.Samples.SignalR.Proxy.Customer.WcfClient.Current.Channel.Load(id);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, false)]
        public static SoftFluent.Samples.SignalR.Proxy.Customer LoadById(System.Guid id)
        {
            SoftFluent.Samples.SignalR.Proxy.Customer ret = SoftFluent.Samples.SignalR.Proxy.Customer.WcfClient.Current.Channel.LoadById(id);
            return ret;
        }
        
        public virtual bool SaveByValue()
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged))
            {
                return false;
            }
            this.Validate();
            bool ret = SoftFluent.Samples.SignalR.Proxy.Customer.WcfClient.Current.Channel.Save(this);
            return ret;
        }
        
        public virtual bool Save()
        {
            this.Validate();
            SoftFluent.Samples.SignalR.Proxy.Customer customer = this;
            if ((SoftFluent.Samples.SignalR.Proxy.Customer.SaveByRef(ref customer) == false))
            {
                return false;
            }
            customer.CopyTo(this, true);
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static SoftFluent.Samples.SignalR.Proxy.Customer LoadByEntityKey(string key)
        {
            if ((key == null))
            {
                throw new System.ArgumentNullException("key");
            }
            if ((key == string.Empty))
            {
                return null;
            }
            SoftFluent.Samples.SignalR.Proxy.Customer ret = SoftFluent.Samples.SignalR.Proxy.Customer.WcfClient.Current.Channel.LoadByEntityKey(key);
            return ret;
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.ServiceModel.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            SoftFluent.Samples.SignalR.Proxy.Customer customer = SoftFluent.Samples.SignalR.Proxy.Customer.LoadByEntityKey(this.EntityKey);
            if ((customer == null))
            {
                return false;
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                customer.CopyTo(this, true);
            }
            return true;
        }
        
        public SoftFluent.Samples.SignalR.Proxy.Customer Clone(bool deep)
        {
            SoftFluent.Samples.SignalR.Proxy.Customer customer = new SoftFluent.Samples.SignalR.Proxy.Customer();
            this.CopyTo(customer, deep);
            return customer;
        }
        
        public SoftFluent.Samples.SignalR.Proxy.Customer Clone()
        {
            SoftFluent.Samples.SignalR.Proxy.Customer localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("Id") == true))
            {
                this.Id = ((System.Guid)(ConvertUtilities.ChangeType(dict["Id"], typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
            if ((dict.Contains("LastName") == true))
            {
                this.LastName = ((string)(ConvertUtilities.ChangeType(dict["LastName"], typeof(string), default(string))));
            }
            if ((dict.Contains("FirstName") == true))
            {
                this.FirstName = ((string)(ConvertUtilities.ChangeType(dict["FirstName"], typeof(string), default(string))));
            }
            this.OnEntityAction(new CodeFluent.Runtime.ServiceModel.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(SoftFluent.Samples.SignalR.Proxy.Customer customer, bool deep)
        {
            if ((customer == null))
            {
                throw new System.ArgumentNullException("customer");
            }
            customer.Id = this.Id;
            customer.LastName = this.LastName;
            customer.FirstName = this.FirstName;
            this.OnEntityAction(new CodeFluent.Runtime.ServiceModel.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, customer));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["Id"] = this.Id;
            dict["LastName"] = this.LastName;
            dict["FirstName"] = this.FirstName;
            this.OnEntityAction(new CodeFluent.Runtime.ServiceModel.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
        
        int System.IComparable.CompareTo(object value)
        {
            SoftFluent.Samples.SignalR.Proxy.Customer customer = null;
customer = value as SoftFluent.Samples.SignalR.Proxy.Customer;
            if ((customer == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(customer);
            return localCompareTo;
        }
        
        public virtual int CompareTo(SoftFluent.Samples.SignalR.Proxy.Customer customer)
        {
            if ((customer == null))
            {
                throw new System.ArgumentNullException("customer");
            }
            int localCompareTo = this.Id.CompareTo(customer.Id);
            return localCompareTo;
        }
        
        public virtual bool Equals(SoftFluent.Samples.SignalR.Proxy.Customer customer)
        {
            if ((customer == null))
            {
                return false;
            }
            if ((this.Id.Equals(CodeFluentPersistence.DefaultGuidValue) == true))
            {
                return base.Equals(customer);
            }
            return (this.Id.Equals(customer.Id) == true);
        }
        
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
        
        public override bool Equals(object obj)
        {
            SoftFluent.Samples.SignalR.Proxy.Customer customer = null;
customer = obj as SoftFluent.Samples.SignalR.Proxy.Customer;
            return this.Equals(customer);
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.Diagnostics.ITraceable.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("Id=");
            writer.Write(this.Id);
            writer.Write(",");
            writer.Write("FirstName=");
            writer.Write(this.FirstName);
            writer.Write(",");
            writer.Write("LastName=");
            writer.Write(this.LastName);
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(SoftFluent.Samples.SignalR.Proxy.Customer customer)
        {
            if ((customer == null))
            {
                return false;
            }
            return customer.Save();
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(SoftFluent.Samples.SignalR.Proxy.Customer customer)
        {
            if ((customer == null))
            {
                return false;
            }
            return customer.Delete();
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(SoftFluent.Samples.SignalR.Proxy.Customer customer)
        {
            if ((customer == null))
            {
                return false;
            }
            return customer.Save();
        }
        
        [System.Runtime.Serialization.OnDeserializingAttribute()]
        protected internal void OnEntityDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
            this.IsDeserializing = true;
            this._id = CodeFluentPersistence.DefaultGuidValue;
            this._firstName = default(string);
            this._lastName = default(string);
            this._raisePropertyChangedEvents = true;
            this._id = System.Guid.NewGuid();
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
            this._raisePropertyChangedEvents = true;
        }
        
        [System.Runtime.Serialization.OnDeserializedAttribute()]
        protected internal void OnEntityDeserialized(System.Runtime.Serialization.StreamingContext context)
        {
            this.IsDeserializing = false;
        }
        
        [System.Runtime.Serialization.OnSerializedAttribute()]
        protected internal void OnEntitySerialized(System.Runtime.Serialization.StreamingContext context)
        {
            this.IsSerializing = false;
        }
        
        [System.Runtime.Serialization.OnSerializingAttribute()]
        protected internal void OnEntitySerializing(System.Runtime.Serialization.StreamingContext context)
        {
            this.IsSerializing = true;
        }
        
        public static bool SaveByRef(ref SoftFluent.Samples.SignalR.Proxy.Customer customer)
        {
            if ((customer == null))
            {
                return false;
            }
            if ((customer.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged))
            {
                return false;
            }
            bool ret = SoftFluent.Samples.SignalR.Proxy.Customer.WcfClient.Current.Channel.SaveByRef(ref customer);
            return ret;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        protected void OnCollectionKeyChanged(System.Guid key)
        {
            if ((this.KeyChanged != null))
            {
                this.KeyChanged(this, new CodeFluent.Runtime.Utilities.KeyChangedEventArgs<System.Guid>(key));
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0786")]
        public partial class WcfClient : CodeFluent.Runtime.ServiceModel.CodeFluentClient<SoftFluent.Samples.SignalR.Proxy.ICustomerService>, CodeFluent.Runtime.ServiceModel.ISafeClosable
        {
            
            private static SoftFluent.Samples.SignalR.Proxy.Customer.WcfClient _current = new SoftFluent.Samples.SignalR.Proxy.Customer.WcfClient();
            
            public new SoftFluent.Samples.SignalR.Proxy.ICustomerService Channel
            {
                get
                {
                    return base.Channel;
                }
            }
            
            public static SoftFluent.Samples.SignalR.Proxy.Customer.WcfClient Current
            {
                get
                {
                    return WcfClient._current;
                }
            }
            
            public virtual void SafeClose()
            {
                CodeFluent.Runtime.ServiceModel.ServiceModelUtilities.SafeClose<SoftFluent.Samples.SignalR.Proxy.ICustomerService>(this);
            }
            
            void CodeFluent.Runtime.ServiceModel.ISafeClosable.SafeClose()
            {
                this.SafeClose();
            }
            
            public static void Reset()
            {
                if ((WcfClient._current != null))
                {
                    WcfClient._current.SafeClose();
                }
                WcfClient._current = new SoftFluent.Samples.SignalR.Proxy.Customer.WcfClient();
            }
        }
    }
}
