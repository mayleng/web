﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.18444 版自动生成。
// 
#pragma warning disable 1591

namespace TestWebService.MyWebReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback SumOperationCompleted;
        
        private System.Threading.SendOrPostCallback SubOperationCompleted;
        
        private System.Threading.SendOrPostCallback MultOperationCompleted;
        
        private System.Threading.SendOrPostCallback DivOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetPlayerNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPlayerNameOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::TestWebService.Properties.Settings.Default.TestWebService_MyWebServiceReference_WebService1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event SumCompletedEventHandler SumCompleted;
        
        /// <remarks/>
        public event SubCompletedEventHandler SubCompleted;
        
        /// <remarks/>
        public event MultCompletedEventHandler MultCompleted;
        
        /// <remarks/>
        public event DivCompletedEventHandler DivCompleted;
        
        /// <remarks/>
        public event SetPlayerNameCompletedEventHandler SetPlayerNameCompleted;
        
        /// <remarks/>
        public event GetPlayerNameCompletedEventHandler GetPlayerNameCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("HelloWorld", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndHelloWorld(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Sum", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Sum(int a, int b) {
            object[] results = this.Invoke("Sum", new object[] {
                        a,
                        b});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSum(int a, int b, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Sum", new object[] {
                        a,
                        b}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndSum(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void SumAsync(int a, int b) {
            this.SumAsync(a, b, null);
        }
        
        /// <remarks/>
        public void SumAsync(int a, int b, object userState) {
            if ((this.SumOperationCompleted == null)) {
                this.SumOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSumOperationCompleted);
            }
            this.InvokeAsync("Sum", new object[] {
                        a,
                        b}, this.SumOperationCompleted, userState);
        }
        
        private void OnSumOperationCompleted(object arg) {
            if ((this.SumCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SumCompleted(this, new SumCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Sub", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Sub(int a, int b) {
            object[] results = this.Invoke("Sub", new object[] {
                        a,
                        b});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSub(int a, int b, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Sub", new object[] {
                        a,
                        b}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndSub(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void SubAsync(int a, int b) {
            this.SubAsync(a, b, null);
        }
        
        /// <remarks/>
        public void SubAsync(int a, int b, object userState) {
            if ((this.SubOperationCompleted == null)) {
                this.SubOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubOperationCompleted);
            }
            this.InvokeAsync("Sub", new object[] {
                        a,
                        b}, this.SubOperationCompleted, userState);
        }
        
        private void OnSubOperationCompleted(object arg) {
            if ((this.SubCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubCompleted(this, new SubCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Mult", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double Mult(double a, double b) {
            object[] results = this.Invoke("Mult", new object[] {
                        a,
                        b});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginMult(double a, double b, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Mult", new object[] {
                        a,
                        b}, callback, asyncState);
        }
        
        /// <remarks/>
        public double EndMult(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void MultAsync(double a, double b) {
            this.MultAsync(a, b, null);
        }
        
        /// <remarks/>
        public void MultAsync(double a, double b, object userState) {
            if ((this.MultOperationCompleted == null)) {
                this.MultOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMultOperationCompleted);
            }
            this.InvokeAsync("Mult", new object[] {
                        a,
                        b}, this.MultOperationCompleted, userState);
        }
        
        private void OnMultOperationCompleted(object arg) {
            if ((this.MultCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MultCompleted(this, new MultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Div", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double Div(double a, double b) {
            object[] results = this.Invoke("Div", new object[] {
                        a,
                        b});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDiv(double a, double b, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Div", new object[] {
                        a,
                        b}, callback, asyncState);
        }
        
        /// <remarks/>
        public double EndDiv(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void DivAsync(double a, double b) {
            this.DivAsync(a, b, null);
        }
        
        /// <remarks/>
        public void DivAsync(double a, double b, object userState) {
            if ((this.DivOperationCompleted == null)) {
                this.DivOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDivOperationCompleted);
            }
            this.InvokeAsync("Div", new object[] {
                        a,
                        b}, this.DivOperationCompleted, userState);
        }
        
        private void OnDivOperationCompleted(object arg) {
            if ((this.DivCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DivCompleted(this, new DivCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SetPlayerName", RequestNamespace="http://tempuri.org/", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetPlayerName(string strName) {
            this.Invoke("SetPlayerName", new object[] {
                        strName});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSetPlayerName(string strName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SetPlayerName", new object[] {
                        strName}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndSetPlayerName(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void SetPlayerNameAsync(string strName) {
            this.SetPlayerNameAsync(strName, null);
        }
        
        /// <remarks/>
        public void SetPlayerNameAsync(string strName, object userState) {
            if ((this.SetPlayerNameOperationCompleted == null)) {
                this.SetPlayerNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetPlayerNameOperationCompleted);
            }
            this.InvokeAsync("SetPlayerName", new object[] {
                        strName}, this.SetPlayerNameOperationCompleted, userState);
        }
        
        private void OnSetPlayerNameOperationCompleted(object arg) {
            if ((this.SetPlayerNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetPlayerNameCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPlayerName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetPlayerName() {
            object[] results = this.Invoke("GetPlayerName", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetPlayerName(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPlayerName", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetPlayerName(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetPlayerNameAsync() {
            this.GetPlayerNameAsync(null);
        }
        
        /// <remarks/>
        public void GetPlayerNameAsync(object userState) {
            if ((this.GetPlayerNameOperationCompleted == null)) {
                this.GetPlayerNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPlayerNameOperationCompleted);
            }
            this.InvokeAsync("GetPlayerName", new object[0], this.GetPlayerNameOperationCompleted, userState);
        }
        
        private void OnGetPlayerNameOperationCompleted(object arg) {
            if ((this.GetPlayerNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPlayerNameCompleted(this, new GetPlayerNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SumCompletedEventHandler(object sender, SumCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SumCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SumCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SubCompletedEventHandler(object sender, SubCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SubCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void MultCompletedEventHandler(object sender, MultCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void DivCompletedEventHandler(object sender, DivCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DivCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DivCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void SetPlayerNameCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetPlayerNameCompletedEventHandler(object sender, GetPlayerNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPlayerNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPlayerNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591