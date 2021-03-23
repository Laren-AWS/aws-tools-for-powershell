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
using Amazon.SageMaker;
using Amazon.SageMaker.Model;

namespace Amazon.PowerShell.Cmdlets.SM
{
    /// <summary>
    /// Creates a running app for the specified UserProfile. Supported apps are <code>JupyterServer</code>
    /// and <code>KernelGateway</code>. This operation is automatically invoked by Amazon
    /// SageMaker Studio upon access to the associated Domain, and when new kernel configurations
    /// are selected by the user. A user may have multiple Apps active simultaneously.
    /// </summary>
    [Cmdlet("New", "SMApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon SageMaker Service CreateApp API operation.", Operation = new[] {"CreateApp"}, SelectReturnType = typeof(Amazon.SageMaker.Model.CreateAppResponse))]
    [AWSCmdletOutput("System.String or Amazon.SageMaker.Model.CreateAppResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.SageMaker.Model.CreateAppResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewSMAppCmdlet : AmazonSageMakerClientCmdlet, IExecutor
    {
        
        #region Parameter AppName
        /// <summary>
        /// <para>
        /// <para>The name of the app.</para>
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
        public System.String AppName { get; set; }
        #endregion
        
        #region Parameter AppType
        /// <summary>
        /// <para>
        /// <para>The type of app. Supported apps are <code>JupyterServer</code> and <code>KernelGateway</code>.
        /// <code>TensorBoard</code> is not supported.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.SageMaker.AppType")]
        public Amazon.SageMaker.AppType AppType { get; set; }
        #endregion
        
        #region Parameter DomainId
        /// <summary>
        /// <para>
        /// <para>The domain ID.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String DomainId { get; set; }
        #endregion
        
        #region Parameter ResourceSpec_InstanceType
        /// <summary>
        /// <para>
        /// <para>The instance type that the image version runs on.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.SageMaker.AppInstanceType")]
        public Amazon.SageMaker.AppInstanceType ResourceSpec_InstanceType { get; set; }
        #endregion
        
        #region Parameter ResourceSpec_SageMakerImageArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the SageMaker image that the image version belongs to.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ResourceSpec_SageMakerImageArn { get; set; }
        #endregion
        
        #region Parameter ResourceSpec_SageMakerImageVersionArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the image version created on the instance.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ResourceSpec_SageMakerImageVersionArn { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>Each tag consists of a key and an optional value. Tag keys must be unique per resource.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.SageMaker.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter UserProfileName
        /// <summary>
        /// <para>
        /// <para>The user profile name.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String UserProfileName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'AppArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SageMaker.Model.CreateAppResponse).
        /// Specifying the name of a property of type Amazon.SageMaker.Model.CreateAppResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "AppArn";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AppName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AppName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AppName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.AppName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-SMApp (CreateApp)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SageMaker.Model.CreateAppResponse, NewSMAppCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AppName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AppName = this.AppName;
            #if MODULAR
            if (this.AppName == null && ParameterWasBound(nameof(this.AppName)))
            {
                WriteWarning("You are passing $null as a value for parameter AppName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.AppType = this.AppType;
            #if MODULAR
            if (this.AppType == null && ParameterWasBound(nameof(this.AppType)))
            {
                WriteWarning("You are passing $null as a value for parameter AppType which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.DomainId = this.DomainId;
            #if MODULAR
            if (this.DomainId == null && ParameterWasBound(nameof(this.DomainId)))
            {
                WriteWarning("You are passing $null as a value for parameter DomainId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ResourceSpec_InstanceType = this.ResourceSpec_InstanceType;
            context.ResourceSpec_SageMakerImageArn = this.ResourceSpec_SageMakerImageArn;
            context.ResourceSpec_SageMakerImageVersionArn = this.ResourceSpec_SageMakerImageVersionArn;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.SageMaker.Model.Tag>(this.Tag);
            }
            context.UserProfileName = this.UserProfileName;
            #if MODULAR
            if (this.UserProfileName == null && ParameterWasBound(nameof(this.UserProfileName)))
            {
                WriteWarning("You are passing $null as a value for parameter UserProfileName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
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
            var request = new Amazon.SageMaker.Model.CreateAppRequest();
            
            if (cmdletContext.AppName != null)
            {
                request.AppName = cmdletContext.AppName;
            }
            if (cmdletContext.AppType != null)
            {
                request.AppType = cmdletContext.AppType;
            }
            if (cmdletContext.DomainId != null)
            {
                request.DomainId = cmdletContext.DomainId;
            }
            
             // populate ResourceSpec
            var requestResourceSpecIsNull = true;
            request.ResourceSpec = new Amazon.SageMaker.Model.ResourceSpec();
            Amazon.SageMaker.AppInstanceType requestResourceSpec_resourceSpec_InstanceType = null;
            if (cmdletContext.ResourceSpec_InstanceType != null)
            {
                requestResourceSpec_resourceSpec_InstanceType = cmdletContext.ResourceSpec_InstanceType;
            }
            if (requestResourceSpec_resourceSpec_InstanceType != null)
            {
                request.ResourceSpec.InstanceType = requestResourceSpec_resourceSpec_InstanceType;
                requestResourceSpecIsNull = false;
            }
            System.String requestResourceSpec_resourceSpec_SageMakerImageArn = null;
            if (cmdletContext.ResourceSpec_SageMakerImageArn != null)
            {
                requestResourceSpec_resourceSpec_SageMakerImageArn = cmdletContext.ResourceSpec_SageMakerImageArn;
            }
            if (requestResourceSpec_resourceSpec_SageMakerImageArn != null)
            {
                request.ResourceSpec.SageMakerImageArn = requestResourceSpec_resourceSpec_SageMakerImageArn;
                requestResourceSpecIsNull = false;
            }
            System.String requestResourceSpec_resourceSpec_SageMakerImageVersionArn = null;
            if (cmdletContext.ResourceSpec_SageMakerImageVersionArn != null)
            {
                requestResourceSpec_resourceSpec_SageMakerImageVersionArn = cmdletContext.ResourceSpec_SageMakerImageVersionArn;
            }
            if (requestResourceSpec_resourceSpec_SageMakerImageVersionArn != null)
            {
                request.ResourceSpec.SageMakerImageVersionArn = requestResourceSpec_resourceSpec_SageMakerImageVersionArn;
                requestResourceSpecIsNull = false;
            }
             // determine if request.ResourceSpec should be set to null
            if (requestResourceSpecIsNull)
            {
                request.ResourceSpec = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.UserProfileName != null)
            {
                request.UserProfileName = cmdletContext.UserProfileName;
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
        
        private Amazon.SageMaker.Model.CreateAppResponse CallAWSServiceOperation(IAmazonSageMaker client, Amazon.SageMaker.Model.CreateAppRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon SageMaker Service", "CreateApp");
            try
            {
                #if DESKTOP
                return client.CreateApp(request);
                #elif CORECLR
                return client.CreateAppAsync(request).GetAwaiter().GetResult();
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
            public System.String AppName { get; set; }
            public Amazon.SageMaker.AppType AppType { get; set; }
            public System.String DomainId { get; set; }
            public Amazon.SageMaker.AppInstanceType ResourceSpec_InstanceType { get; set; }
            public System.String ResourceSpec_SageMakerImageArn { get; set; }
            public System.String ResourceSpec_SageMakerImageVersionArn { get; set; }
            public List<Amazon.SageMaker.Model.Tag> Tag { get; set; }
            public System.String UserProfileName { get; set; }
            public System.Func<Amazon.SageMaker.Model.CreateAppResponse, NewSMAppCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.AppArn;
        }
        
    }
}
