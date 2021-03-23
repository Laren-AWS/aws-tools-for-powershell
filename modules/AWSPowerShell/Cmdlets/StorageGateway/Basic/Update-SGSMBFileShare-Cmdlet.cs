/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.StorageGateway;
using Amazon.StorageGateway.Model;

namespace Amazon.PowerShell.Cmdlets.SG
{
    /// <summary>
    /// Updates a Server Message Block (SMB) file share. This operation is only supported
    /// for file gateways.
    /// 
    ///  <note><para>
    /// To leave a file share field unchanged, set the corresponding input field to null.
    /// </para></note><important><para>
    /// File gateways require AWS Security Token Service (AWS STS) to be activated to enable
    /// you to create a file share. Make sure that AWS STS is activated in the AWS Region
    /// you are creating your file gateway in. If AWS STS is not activated in this AWS Region,
    /// activate it. For information about how to activate AWS STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
    /// and deactivating AWS STS in an AWS Region</a> in the <i>AWS Identity and Access Management
    /// User Guide</i>.
    /// </para><para>
    /// File gateways don't support creating hard or symbolic links on a file share.
    /// </para></important>
    /// </summary>
    [Cmdlet("Update", "SGSMBFileShare", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the AWS Storage Gateway UpdateSMBFileShare API operation.", Operation = new[] {"UpdateSMBFileShare"}, SelectReturnType = typeof(Amazon.StorageGateway.Model.UpdateSMBFileShareResponse))]
    [AWSCmdletOutput("System.String or Amazon.StorageGateway.Model.UpdateSMBFileShareResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.StorageGateway.Model.UpdateSMBFileShareResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateSGSMBFileShareCmdlet : AmazonStorageGatewayClientCmdlet, IExecutor
    {
        
        #region Parameter AccessBasedEnumeration
        /// <summary>
        /// <para>
        /// <para>The files and folders on this share will only be visible to users with read access.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AccessBasedEnumeration { get; set; }
        #endregion
        
        #region Parameter AdminUserList
        /// <summary>
        /// <para>
        /// <para>A list of users or groups in the Active Directory that have administrator rights to
        /// the file share. A group must be prefixed with the @ character. Acceptable formats
        /// include: <code>DOMAIN\User1</code>, <code>user1</code>, <code>@group1</code>, and
        /// <code>@DOMAIN\group1</code>. Can only be set if Authentication is set to <code>ActiveDirectory</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] AdminUserList { get; set; }
        #endregion
        
        #region Parameter AuditDestinationARN
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the storage used for audit logs.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String AuditDestinationARN { get; set; }
        #endregion
        
        #region Parameter CacheAttributes_CacheStaleTimeoutInSecond
        /// <summary>
        /// <para>
        /// <para>Refreshes a file share's cache by using Time To Live (TTL). TTL is the length of time
        /// since the last refresh after which access to the directory would cause the file gateway
        /// to first refresh that directory's contents from the Amazon S3 bucket or Amazon FSx
        /// file system. The TTL duration is in seconds.</para><para>Valid Values: 300 to 2,592,000 seconds (5 minutes to 30 days)</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CacheAttributes_CacheStaleTimeoutInSeconds")]
        public System.Int32? CacheAttributes_CacheStaleTimeoutInSecond { get; set; }
        #endregion
        
        #region Parameter CaseSensitivity
        /// <summary>
        /// <para>
        /// <para>The case of an object name in an Amazon S3 bucket. For <code>ClientSpecified</code>,
        /// the client determines the case sensitivity. For <code>CaseSensitive</code>, the gateway
        /// determines the case sensitivity. The default value is <code>ClientSpecified</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.StorageGateway.CaseSensitivity")]
        public Amazon.StorageGateway.CaseSensitivity CaseSensitivity { get; set; }
        #endregion
        
        #region Parameter DefaultStorageClass
        /// <summary>
        /// <para>
        /// <para>The default storage class for objects put into an Amazon S3 bucket by the file gateway.
        /// The default value is <code>S3_INTELLIGENT_TIERING</code>. Optional.</para><para>Valid Values: <code>S3_STANDARD</code> | <code>S3_INTELLIGENT_TIERING</code> | <code>S3_STANDARD_IA</code>
        /// | <code>S3_ONEZONE_IA</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DefaultStorageClass { get; set; }
        #endregion
        
        #region Parameter FileShareARN
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the SMB file share that you want to update.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String FileShareARN { get; set; }
        #endregion
        
        #region Parameter FileShareName
        /// <summary>
        /// <para>
        /// <para>The name of the file share. Optional.</para><note><para><code>FileShareName</code> must be set if an S3 prefix name is set in <code>LocationARN</code>.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String FileShareName { get; set; }
        #endregion
        
        #region Parameter GuessMIMETypeEnabled
        /// <summary>
        /// <para>
        /// <para>A value that enables guessing of the MIME type for uploaded objects based on file
        /// extensions. Set this value to <code>true</code> to enable MIME type guessing, otherwise
        /// set to <code>false</code>. The default value is <code>true</code>.</para><para>Valid Values: <code>true</code> | <code>false</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? GuessMIMETypeEnabled { get; set; }
        #endregion
        
        #region Parameter InvalidUserList
        /// <summary>
        /// <para>
        /// <para>A list of users or groups in the Active Directory that are not allowed to access the
        /// file share. A group must be prefixed with the @ character. Acceptable formats include:
        /// <code>DOMAIN\User1</code>, <code>user1</code>, <code>@group1</code>, and <code>@DOMAIN\group1</code>.
        /// Can only be set if Authentication is set to <code>ActiveDirectory</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] InvalidUserList { get; set; }
        #endregion
        
        #region Parameter KMSEncrypted
        /// <summary>
        /// <para>
        /// <para>Set to <code>true</code> to use Amazon S3 server-side encryption with your own AWS
        /// KMS key, or <code>false</code> to use a key managed by Amazon S3. Optional.</para><para>Valid Values: <code>true</code> | <code>false</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? KMSEncrypted { get; set; }
        #endregion
        
        #region Parameter KMSKey
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of a symmetric customer master key (CMK) used for Amazon
        /// S3 server-side encryption. Storage Gateway does not support asymmetric CMKs. This
        /// value can only be set when <code>KMSEncrypted</code> is <code>true</code>. Optional.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String KMSKey { get; set; }
        #endregion
        
        #region Parameter NotificationPolicy
        /// <summary>
        /// <para>
        /// <para>The notification policy of the file share. <code>SettlingTimeInSeconds</code> controls
        /// the number of seconds to wait after the last point in time a client wrote to a file
        /// before generating an <code>ObjectUploaded</code> notification. Because clients can
        /// make many small writes to files, it's best to set this parameter for as long as possible
        /// to avoid generating multiple notifications for the same file in a small time period.</para><note><para><code>SettlingTimeInSeconds</code> has no effect on the timing of the object uploading
        /// to Amazon S3, only the timing of the notification.</para></note><para>The following example sets <code>NotificationPolicy</code> on with <code>SettlingTimeInSeconds</code>
        /// set to 60.</para><para><code>{\"Upload\": {\"SettlingTimeInSeconds\": 60}}</code></para><para>The following example sets <code>NotificationPolicy</code> off.</para><para><code>{}</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NotificationPolicy { get; set; }
        #endregion
        
        #region Parameter ObjectACL
        /// <summary>
        /// <para>
        /// <para>A value that sets the access control list (ACL) permission for objects in the S3 bucket
        /// that a file gateway puts objects into. The default value is <code>private</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.StorageGateway.ObjectACL")]
        public Amazon.StorageGateway.ObjectACL ObjectACL { get; set; }
        #endregion
        
        #region Parameter ReadOnly
        /// <summary>
        /// <para>
        /// <para>A value that sets the write status of a file share. Set this value to <code>true</code>
        /// to set write status to read-only, otherwise set to <code>false</code>.</para><para>Valid Values: <code>true</code> | <code>false</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? ReadOnly { get; set; }
        #endregion
        
        #region Parameter RequesterPay
        /// <summary>
        /// <para>
        /// <para>A value that sets who pays the cost of the request and the cost associated with data
        /// download from the S3 bucket. If this value is set to <code>true</code>, the requester
        /// pays the costs; otherwise, the S3 bucket owner pays. However, the S3 bucket owner
        /// always pays the cost of storing data.</para><note><para><code>RequesterPays</code> is a configuration for the S3 bucket that backs the file
        /// share, so make sure that the configuration on the file share is the same as the S3
        /// bucket configuration.</para></note><para>Valid Values: <code>true</code> | <code>false</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RequesterPays")]
        public System.Boolean? RequesterPay { get; set; }
        #endregion
        
        #region Parameter SMBACLEnabled
        /// <summary>
        /// <para>
        /// <para>Set this value to <code>true</code> to enable access control list (ACL) on the SMB
        /// file share. Set it to <code>false</code> to map file and directory permissions to
        /// the POSIX permissions.</para><para>For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/smb-acl.html">Using
        /// Microsoft Windows ACLs to control access to an SMB file share</a> in the <i>AWS Storage
        /// Gateway User Guide</i>.</para><para>Valid Values: <code>true</code> | <code>false</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? SMBACLEnabled { get; set; }
        #endregion
        
        #region Parameter ValidUserList
        /// <summary>
        /// <para>
        /// <para>A list of users or groups in the Active Directory that are allowed to access the file
        /// share. A group must be prefixed with the @ character. Acceptable formats include:
        /// <code>DOMAIN\User1</code>, <code>user1</code>, <code>@group1</code>, and <code>@DOMAIN\group1</code>.
        /// Can only be set if Authentication is set to <code>ActiveDirectory</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] ValidUserList { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'FileShareARN'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.StorageGateway.Model.UpdateSMBFileShareResponse).
        /// Specifying the name of a property of type Amazon.StorageGateway.Model.UpdateSMBFileShareResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "FileShareARN";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the FileShareARN parameter.
        /// The -PassThru parameter is deprecated, use -Select '^FileShareARN' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^FileShareARN' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.FileShareARN), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-SGSMBFileShare (UpdateSMBFileShare)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.StorageGateway.Model.UpdateSMBFileShareResponse, UpdateSGSMBFileShareCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.FileShareARN;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AccessBasedEnumeration = this.AccessBasedEnumeration;
            if (this.AdminUserList != null)
            {
                context.AdminUserList = new List<System.String>(this.AdminUserList);
            }
            context.AuditDestinationARN = this.AuditDestinationARN;
            context.CacheAttributes_CacheStaleTimeoutInSecond = this.CacheAttributes_CacheStaleTimeoutInSecond;
            context.CaseSensitivity = this.CaseSensitivity;
            context.DefaultStorageClass = this.DefaultStorageClass;
            context.FileShareARN = this.FileShareARN;
            #if MODULAR
            if (this.FileShareARN == null && ParameterWasBound(nameof(this.FileShareARN)))
            {
                WriteWarning("You are passing $null as a value for parameter FileShareARN which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.FileShareName = this.FileShareName;
            context.GuessMIMETypeEnabled = this.GuessMIMETypeEnabled;
            if (this.InvalidUserList != null)
            {
                context.InvalidUserList = new List<System.String>(this.InvalidUserList);
            }
            context.KMSEncrypted = this.KMSEncrypted;
            context.KMSKey = this.KMSKey;
            context.NotificationPolicy = this.NotificationPolicy;
            context.ObjectACL = this.ObjectACL;
            context.ReadOnly = this.ReadOnly;
            context.RequesterPay = this.RequesterPay;
            context.SMBACLEnabled = this.SMBACLEnabled;
            if (this.ValidUserList != null)
            {
                context.ValidUserList = new List<System.String>(this.ValidUserList);
            }
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.StorageGateway.Model.UpdateSMBFileShareRequest();
            
            if (cmdletContext.AccessBasedEnumeration != null)
            {
                request.AccessBasedEnumeration = cmdletContext.AccessBasedEnumeration.Value;
            }
            if (cmdletContext.AdminUserList != null)
            {
                request.AdminUserList = cmdletContext.AdminUserList;
            }
            if (cmdletContext.AuditDestinationARN != null)
            {
                request.AuditDestinationARN = cmdletContext.AuditDestinationARN;
            }
            
             // populate CacheAttributes
            var requestCacheAttributesIsNull = true;
            request.CacheAttributes = new Amazon.StorageGateway.Model.CacheAttributes();
            System.Int32? requestCacheAttributes_cacheAttributes_CacheStaleTimeoutInSecond = null;
            if (cmdletContext.CacheAttributes_CacheStaleTimeoutInSecond != null)
            {
                requestCacheAttributes_cacheAttributes_CacheStaleTimeoutInSecond = cmdletContext.CacheAttributes_CacheStaleTimeoutInSecond.Value;
            }
            if (requestCacheAttributes_cacheAttributes_CacheStaleTimeoutInSecond != null)
            {
                request.CacheAttributes.CacheStaleTimeoutInSeconds = requestCacheAttributes_cacheAttributes_CacheStaleTimeoutInSecond.Value;
                requestCacheAttributesIsNull = false;
            }
             // determine if request.CacheAttributes should be set to null
            if (requestCacheAttributesIsNull)
            {
                request.CacheAttributes = null;
            }
            if (cmdletContext.CaseSensitivity != null)
            {
                request.CaseSensitivity = cmdletContext.CaseSensitivity;
            }
            if (cmdletContext.DefaultStorageClass != null)
            {
                request.DefaultStorageClass = cmdletContext.DefaultStorageClass;
            }
            if (cmdletContext.FileShareARN != null)
            {
                request.FileShareARN = cmdletContext.FileShareARN;
            }
            if (cmdletContext.FileShareName != null)
            {
                request.FileShareName = cmdletContext.FileShareName;
            }
            if (cmdletContext.GuessMIMETypeEnabled != null)
            {
                request.GuessMIMETypeEnabled = cmdletContext.GuessMIMETypeEnabled.Value;
            }
            if (cmdletContext.InvalidUserList != null)
            {
                request.InvalidUserList = cmdletContext.InvalidUserList;
            }
            if (cmdletContext.KMSEncrypted != null)
            {
                request.KMSEncrypted = cmdletContext.KMSEncrypted.Value;
            }
            if (cmdletContext.KMSKey != null)
            {
                request.KMSKey = cmdletContext.KMSKey;
            }
            if (cmdletContext.NotificationPolicy != null)
            {
                request.NotificationPolicy = cmdletContext.NotificationPolicy;
            }
            if (cmdletContext.ObjectACL != null)
            {
                request.ObjectACL = cmdletContext.ObjectACL;
            }
            if (cmdletContext.ReadOnly != null)
            {
                request.ReadOnly = cmdletContext.ReadOnly.Value;
            }
            if (cmdletContext.RequesterPay != null)
            {
                request.RequesterPays = cmdletContext.RequesterPay.Value;
            }
            if (cmdletContext.SMBACLEnabled != null)
            {
                request.SMBACLEnabled = cmdletContext.SMBACLEnabled.Value;
            }
            if (cmdletContext.ValidUserList != null)
            {
                request.ValidUserList = cmdletContext.ValidUserList;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.StorageGateway.Model.UpdateSMBFileShareResponse CallAWSServiceOperation(IAmazonStorageGateway client, Amazon.StorageGateway.Model.UpdateSMBFileShareRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Storage Gateway", "UpdateSMBFileShare");
            try
            {
                #if DESKTOP
                return client.UpdateSMBFileShare(request);
                #elif CORECLR
                return client.UpdateSMBFileShareAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.Boolean? AccessBasedEnumeration { get; set; }
            public List<System.String> AdminUserList { get; set; }
            public System.String AuditDestinationARN { get; set; }
            public System.Int32? CacheAttributes_CacheStaleTimeoutInSecond { get; set; }
            public Amazon.StorageGateway.CaseSensitivity CaseSensitivity { get; set; }
            public System.String DefaultStorageClass { get; set; }
            public System.String FileShareARN { get; set; }
            public System.String FileShareName { get; set; }
            public System.Boolean? GuessMIMETypeEnabled { get; set; }
            public List<System.String> InvalidUserList { get; set; }
            public System.Boolean? KMSEncrypted { get; set; }
            public System.String KMSKey { get; set; }
            public System.String NotificationPolicy { get; set; }
            public Amazon.StorageGateway.ObjectACL ObjectACL { get; set; }
            public System.Boolean? ReadOnly { get; set; }
            public System.Boolean? RequesterPay { get; set; }
            public System.Boolean? SMBACLEnabled { get; set; }
            public List<System.String> ValidUserList { get; set; }
            public System.Func<Amazon.StorageGateway.Model.UpdateSMBFileShareResponse, UpdateSGSMBFileShareCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.FileShareARN;
        }
        
    }
}
