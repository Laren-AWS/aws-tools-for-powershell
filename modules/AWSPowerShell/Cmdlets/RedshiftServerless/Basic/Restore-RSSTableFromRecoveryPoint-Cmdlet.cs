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
using Amazon.RedshiftServerless;
using Amazon.RedshiftServerless.Model;

namespace Amazon.PowerShell.Cmdlets.RSS
{
    /// <summary>
    /// Restores a table from a recovery point to your Amazon Redshift Serverless instance.
    /// You can't use this operation to restore tables with interleaved sort keys.
    /// </summary>
    [Cmdlet("Restore", "RSSTableFromRecoveryPoint", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.RedshiftServerless.Model.TableRestoreStatus")]
    [AWSCmdlet("Calls the Redshift Serverless RestoreTableFromRecoveryPoint API operation.", Operation = new[] {"RestoreTableFromRecoveryPoint"}, SelectReturnType = typeof(Amazon.RedshiftServerless.Model.RestoreTableFromRecoveryPointResponse))]
    [AWSCmdletOutput("Amazon.RedshiftServerless.Model.TableRestoreStatus or Amazon.RedshiftServerless.Model.RestoreTableFromRecoveryPointResponse",
        "This cmdlet returns an Amazon.RedshiftServerless.Model.TableRestoreStatus object.",
        "The service call response (type Amazon.RedshiftServerless.Model.RestoreTableFromRecoveryPointResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class RestoreRSSTableFromRecoveryPointCmdlet : AmazonRedshiftServerlessClientCmdlet, IExecutor
    {
        
        protected override bool IsGeneratedCmdlet { get; set; } = true;
        
        #region Parameter ActivateCaseSensitiveIdentifier
        /// <summary>
        /// <para>
        /// <para>Indicates whether name identifiers for database, schema, and table are case sensitive.
        /// If true, the names are case sensitive. If false, the names are not case sensitive.
        /// The default is false.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? ActivateCaseSensitiveIdentifier { get; set; }
        #endregion
        
        #region Parameter NamespaceName
        /// <summary>
        /// <para>
        /// <para>Namespace of the recovery point to restore from.</para>
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
        public System.String NamespaceName { get; set; }
        #endregion
        
        #region Parameter NewTableName
        /// <summary>
        /// <para>
        /// <para>The name of the table to create from the restore operation.</para>
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
        public System.String NewTableName { get; set; }
        #endregion
        
        #region Parameter RecoveryPointId
        /// <summary>
        /// <para>
        /// <para>The ID of the recovery point to restore the table from.</para>
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
        public System.String RecoveryPointId { get; set; }
        #endregion
        
        #region Parameter SourceDatabaseName
        /// <summary>
        /// <para>
        /// <para>The name of the source database that contains the table being restored.</para>
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
        public System.String SourceDatabaseName { get; set; }
        #endregion
        
        #region Parameter SourceSchemaName
        /// <summary>
        /// <para>
        /// <para>The name of the source schema that contains the table being restored.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SourceSchemaName { get; set; }
        #endregion
        
        #region Parameter SourceTableName
        /// <summary>
        /// <para>
        /// <para>The name of the source table being restored.</para>
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
        public System.String SourceTableName { get; set; }
        #endregion
        
        #region Parameter TargetDatabaseName
        /// <summary>
        /// <para>
        /// <para>The name of the database to restore the table to.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String TargetDatabaseName { get; set; }
        #endregion
        
        #region Parameter TargetSchemaName
        /// <summary>
        /// <para>
        /// <para>The name of the schema to restore the table to.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String TargetSchemaName { get; set; }
        #endregion
        
        #region Parameter WorkgroupName
        /// <summary>
        /// <para>
        /// <para>The workgroup to restore the table to.</para>
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
        public System.String WorkgroupName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'TableRestoreStatus'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.RedshiftServerless.Model.RestoreTableFromRecoveryPointResponse).
        /// Specifying the name of a property of type Amazon.RedshiftServerless.Model.RestoreTableFromRecoveryPointResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "TableRestoreStatus";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the RecoveryPointId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^RecoveryPointId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^RecoveryPointId' instead. This parameter will be removed in a future version.")]
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
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.RecoveryPointId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Restore-RSSTableFromRecoveryPoint (RestoreTableFromRecoveryPoint)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.RedshiftServerless.Model.RestoreTableFromRecoveryPointResponse, RestoreRSSTableFromRecoveryPointCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.RecoveryPointId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ActivateCaseSensitiveIdentifier = this.ActivateCaseSensitiveIdentifier;
            context.NamespaceName = this.NamespaceName;
            #if MODULAR
            if (this.NamespaceName == null && ParameterWasBound(nameof(this.NamespaceName)))
            {
                WriteWarning("You are passing $null as a value for parameter NamespaceName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.NewTableName = this.NewTableName;
            #if MODULAR
            if (this.NewTableName == null && ParameterWasBound(nameof(this.NewTableName)))
            {
                WriteWarning("You are passing $null as a value for parameter NewTableName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RecoveryPointId = this.RecoveryPointId;
            #if MODULAR
            if (this.RecoveryPointId == null && ParameterWasBound(nameof(this.RecoveryPointId)))
            {
                WriteWarning("You are passing $null as a value for parameter RecoveryPointId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SourceDatabaseName = this.SourceDatabaseName;
            #if MODULAR
            if (this.SourceDatabaseName == null && ParameterWasBound(nameof(this.SourceDatabaseName)))
            {
                WriteWarning("You are passing $null as a value for parameter SourceDatabaseName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.SourceSchemaName = this.SourceSchemaName;
            context.SourceTableName = this.SourceTableName;
            #if MODULAR
            if (this.SourceTableName == null && ParameterWasBound(nameof(this.SourceTableName)))
            {
                WriteWarning("You are passing $null as a value for parameter SourceTableName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.TargetDatabaseName = this.TargetDatabaseName;
            context.TargetSchemaName = this.TargetSchemaName;
            context.WorkgroupName = this.WorkgroupName;
            #if MODULAR
            if (this.WorkgroupName == null && ParameterWasBound(nameof(this.WorkgroupName)))
            {
                WriteWarning("You are passing $null as a value for parameter WorkgroupName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.RedshiftServerless.Model.RestoreTableFromRecoveryPointRequest();
            
            if (cmdletContext.ActivateCaseSensitiveIdentifier != null)
            {
                request.ActivateCaseSensitiveIdentifier = cmdletContext.ActivateCaseSensitiveIdentifier.Value;
            }
            if (cmdletContext.NamespaceName != null)
            {
                request.NamespaceName = cmdletContext.NamespaceName;
            }
            if (cmdletContext.NewTableName != null)
            {
                request.NewTableName = cmdletContext.NewTableName;
            }
            if (cmdletContext.RecoveryPointId != null)
            {
                request.RecoveryPointId = cmdletContext.RecoveryPointId;
            }
            if (cmdletContext.SourceDatabaseName != null)
            {
                request.SourceDatabaseName = cmdletContext.SourceDatabaseName;
            }
            if (cmdletContext.SourceSchemaName != null)
            {
                request.SourceSchemaName = cmdletContext.SourceSchemaName;
            }
            if (cmdletContext.SourceTableName != null)
            {
                request.SourceTableName = cmdletContext.SourceTableName;
            }
            if (cmdletContext.TargetDatabaseName != null)
            {
                request.TargetDatabaseName = cmdletContext.TargetDatabaseName;
            }
            if (cmdletContext.TargetSchemaName != null)
            {
                request.TargetSchemaName = cmdletContext.TargetSchemaName;
            }
            if (cmdletContext.WorkgroupName != null)
            {
                request.WorkgroupName = cmdletContext.WorkgroupName;
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
        
        private Amazon.RedshiftServerless.Model.RestoreTableFromRecoveryPointResponse CallAWSServiceOperation(IAmazonRedshiftServerless client, Amazon.RedshiftServerless.Model.RestoreTableFromRecoveryPointRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Redshift Serverless", "RestoreTableFromRecoveryPoint");
            try
            {
                #if DESKTOP
                return client.RestoreTableFromRecoveryPoint(request);
                #elif CORECLR
                return client.RestoreTableFromRecoveryPointAsync(request).GetAwaiter().GetResult();
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
            public System.Boolean? ActivateCaseSensitiveIdentifier { get; set; }
            public System.String NamespaceName { get; set; }
            public System.String NewTableName { get; set; }
            public System.String RecoveryPointId { get; set; }
            public System.String SourceDatabaseName { get; set; }
            public System.String SourceSchemaName { get; set; }
            public System.String SourceTableName { get; set; }
            public System.String TargetDatabaseName { get; set; }
            public System.String TargetSchemaName { get; set; }
            public System.String WorkgroupName { get; set; }
            public System.Func<Amazon.RedshiftServerless.Model.RestoreTableFromRecoveryPointResponse, RestoreRSSTableFromRecoveryPointCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.TableRestoreStatus;
        }
        
    }
}
