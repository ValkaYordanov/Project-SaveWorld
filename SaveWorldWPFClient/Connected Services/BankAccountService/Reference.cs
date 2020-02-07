﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaveWorldWPFClient.BankAccountService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BankAccountB", Namespace="http://schemas.datacontract.org/2004/07/SaveWorldModel")]
    [System.SerializableAttribute()]
    public partial class BankAccountB : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AccountIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AccountNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CCVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ExpiryDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] RowVersionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AccountId {
            get {
                return this.AccountIdField;
            }
            set {
                if ((this.AccountIdField.Equals(value) != true)) {
                    this.AccountIdField = value;
                    this.RaisePropertyChanged("AccountId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AccountNo {
            get {
                return this.AccountNoField;
            }
            set {
                if ((this.AccountNoField.Equals(value) != true)) {
                    this.AccountNoField = value;
                    this.RaisePropertyChanged("AccountNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CCV {
            get {
                return this.CCVField;
            }
            set {
                if ((this.CCVField.Equals(value) != true)) {
                    this.CCVField = value;
                    this.RaisePropertyChanged("CCV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ExpiryDate {
            get {
                return this.ExpiryDateField;
            }
            set {
                if ((this.ExpiryDateField.Equals(value) != true)) {
                    this.ExpiryDateField = value;
                    this.RaisePropertyChanged("ExpiryDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] RowVersion {
            get {
                return this.RowVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.RowVersionField, value) != true)) {
                    this.RowVersionField = value;
                    this.RaisePropertyChanged("RowVersion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BankAccountService.IBankAccountService")]
    public interface IBankAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/GetBankAccount", ReplyAction="http://tempuri.org/IBankAccountService/GetBankAccountResponse")]
        SaveWorldWPFClient.BankAccountService.BankAccountB GetBankAccount(int accountNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/GetBankAccount", ReplyAction="http://tempuri.org/IBankAccountService/GetBankAccountResponse")]
        System.Threading.Tasks.Task<SaveWorldWPFClient.BankAccountService.BankAccountB> GetBankAccountAsync(int accountNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/GetBankAccountById", ReplyAction="http://tempuri.org/IBankAccountService/GetBankAccountByIdResponse")]
        SaveWorldWPFClient.BankAccountService.BankAccountB GetBankAccountById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/GetBankAccountById", ReplyAction="http://tempuri.org/IBankAccountService/GetBankAccountByIdResponse")]
        System.Threading.Tasks.Task<SaveWorldWPFClient.BankAccountService.BankAccountB> GetBankAccountByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/CheckBankAccount", ReplyAction="http://tempuri.org/IBankAccountService/CheckBankAccountResponse")]
        bool CheckBankAccount(int accNo, System.DateTime expiryDate, int CCV);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/CheckBankAccount", ReplyAction="http://tempuri.org/IBankAccountService/CheckBankAccountResponse")]
        System.Threading.Tasks.Task<bool> CheckBankAccountAsync(int accNo, System.DateTime expiryDate, int CCV);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/donateToSpecificDisaster", ReplyAction="http://tempuri.org/IBankAccountService/donateToSpecificDisasterResponse")]
        bool donateToSpecificDisaster(decimal amount, SaveWorldWPFClient.BankAccountService.BankAccountB userBankAcc, SaveWorldWPFClient.BankAccountService.BankAccountB disasterBankAcc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/donateToSpecificDisaster", ReplyAction="http://tempuri.org/IBankAccountService/donateToSpecificDisasterResponse")]
        System.Threading.Tasks.Task<bool> donateToSpecificDisasterAsync(decimal amount, SaveWorldWPFClient.BankAccountService.BankAccountB userBankAcc, SaveWorldWPFClient.BankAccountService.BankAccountB disasterBankAcc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/Update", ReplyAction="http://tempuri.org/IBankAccountService/UpdateResponse")]
        bool Update(SaveWorldWPFClient.BankAccountService.BankAccountB bankAccountBefore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/Update", ReplyAction="http://tempuri.org/IBankAccountService/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(SaveWorldWPFClient.BankAccountService.BankAccountB bankAccountBefore);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/donateMoneyToAllDisasters", ReplyAction="http://tempuri.org/IBankAccountService/donateMoneyToAllDisastersResponse")]
        bool donateMoneyToAllDisasters(decimal amount, int userBankId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankAccountService/donateMoneyToAllDisasters", ReplyAction="http://tempuri.org/IBankAccountService/donateMoneyToAllDisastersResponse")]
        System.Threading.Tasks.Task<bool> donateMoneyToAllDisastersAsync(decimal amount, int userBankId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankAccountServiceChannel : SaveWorldWPFClient.BankAccountService.IBankAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BankAccountServiceClient : System.ServiceModel.ClientBase<SaveWorldWPFClient.BankAccountService.IBankAccountService>, SaveWorldWPFClient.BankAccountService.IBankAccountService {
        
        public BankAccountServiceClient() {
        }
        
        public BankAccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BankAccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankAccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankAccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SaveWorldWPFClient.BankAccountService.BankAccountB GetBankAccount(int accountNumber) {
            return base.Channel.GetBankAccount(accountNumber);
        }
        
        public System.Threading.Tasks.Task<SaveWorldWPFClient.BankAccountService.BankAccountB> GetBankAccountAsync(int accountNumber) {
            return base.Channel.GetBankAccountAsync(accountNumber);
        }
        
        public SaveWorldWPFClient.BankAccountService.BankAccountB GetBankAccountById(int id) {
            return base.Channel.GetBankAccountById(id);
        }
        
        public System.Threading.Tasks.Task<SaveWorldWPFClient.BankAccountService.BankAccountB> GetBankAccountByIdAsync(int id) {
            return base.Channel.GetBankAccountByIdAsync(id);
        }
        
        public bool CheckBankAccount(int accNo, System.DateTime expiryDate, int CCV) {
            return base.Channel.CheckBankAccount(accNo, expiryDate, CCV);
        }
        
        public System.Threading.Tasks.Task<bool> CheckBankAccountAsync(int accNo, System.DateTime expiryDate, int CCV) {
            return base.Channel.CheckBankAccountAsync(accNo, expiryDate, CCV);
        }
        
        public bool donateToSpecificDisaster(decimal amount, SaveWorldWPFClient.BankAccountService.BankAccountB userBankAcc, SaveWorldWPFClient.BankAccountService.BankAccountB disasterBankAcc) {
            return base.Channel.donateToSpecificDisaster(amount, userBankAcc, disasterBankAcc);
        }
        
        public System.Threading.Tasks.Task<bool> donateToSpecificDisasterAsync(decimal amount, SaveWorldWPFClient.BankAccountService.BankAccountB userBankAcc, SaveWorldWPFClient.BankAccountService.BankAccountB disasterBankAcc) {
            return base.Channel.donateToSpecificDisasterAsync(amount, userBankAcc, disasterBankAcc);
        }
        
        public bool Update(SaveWorldWPFClient.BankAccountService.BankAccountB bankAccountBefore) {
            return base.Channel.Update(bankAccountBefore);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(SaveWorldWPFClient.BankAccountService.BankAccountB bankAccountBefore) {
            return base.Channel.UpdateAsync(bankAccountBefore);
        }
        
        public bool donateMoneyToAllDisasters(decimal amount, int userBankId) {
            return base.Channel.donateMoneyToAllDisasters(amount, userBankId);
        }
        
        public System.Threading.Tasks.Task<bool> donateMoneyToAllDisastersAsync(decimal amount, int userBankId) {
            return base.Channel.donateMoneyToAllDisastersAsync(amount, userBankId);
        }
    }
}
