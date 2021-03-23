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
using Amazon.Mgn;
using Amazon.Mgn.Model;

namespace Amazon.PowerShell.Cmdlets.MGN
{
    /// <summary>
    /// Retrieves all SourceServers or multiple SourceServers by ID.
    /// </summary>
    [Cmdlet("Get", "MGNSourceServer")]
    [OutputType("Amazon.Mgn.Model.SourceServer")]
    [AWSCmdlet("Calls the Application Migration Service DescribeSourceServers API operation.", Operation = new[] {"DescribeSourceServers"}, SelectReturnType = typeof(Amazon.Mgn.Model.DescribeSourceServersResponse))]
    [AWSCmdletOutput("Amazon.Mgn.Model.SourceServer or Amazon.Mgn.Model.DescribeSourceServersResponse",
        "This cmdlet returns a collection of Amazon.Mgn.Model.SourceServer objects.",
        "The service call response (type Amazon.Mgn.Model.DescribeSourceServersResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetMGNSourceServerCmdlet : AmazonMgnClientCmdlet, IExecutor
    {
        
        #region Parameter Filters_IsArchived
        /// <summary>
        /// <para>
        /// <para>Request to filter Source Servers list by archived.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? Filters_IsArchived { get; set; }
        #endregion
        
        #region Parameter Filters_SourceServerIDs
        /// <summary>
        /// <para>
        /// <para>Request to filter Source Servers list by Source Server ID.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] Filters_SourceServerIDs { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>Request to filter Source Servers list by maximum results.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>Request to filter Source Servers list by next token.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Items'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Mgn.Model.DescribeSourceServersResponse).
        /// Specifying the name of a property of type Amazon.Mgn.Model.DescribeSourceServersResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Items";
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Mgn.Model.DescribeSourceServersResponse, GetMGNSourceServerCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.Filters_IsArchived = this.Filters_IsArchived;
            if (this.Filters_SourceServerIDs != null)
            {
                context.Filters_SourceServerIDs = new List<System.String>(this.Filters_SourceServerIDs);
            }
            context.MaxResult = this.MaxResult;
            context.NextToken = this.NextToken;
            
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
            var request = new Amazon.Mgn.Model.DescribeSourceServersRequest();
            
            
             // populate Filters
            var requestFiltersIsNull = true;
            request.Filters = new Amazon.Mgn.Model.DescribeSourceServersRequestFilters();
            System.Boolean? requestFilters_filters_IsArchived = null;
            if (cmdletContext.Filters_IsArchived != null)
            {
                requestFilters_filters_IsArchived = cmdletContext.Filters_IsArchived.Value;
            }
            if (requestFilters_filters_IsArchived != null)
            {
                request.Filters.IsArchived = requestFilters_filters_IsArchived.Value;
                requestFiltersIsNull = false;
            }
            List<System.String> requestFilters_filters_SourceServerIDs = null;
            if (cmdletContext.Filters_SourceServerIDs != null)
            {
                requestFilters_filters_SourceServerIDs = cmdletContext.Filters_SourceServerIDs;
            }
            if (requestFilters_filters_SourceServerIDs != null)
            {
                request.Filters.SourceServerIDs = requestFilters_filters_SourceServerIDs;
                requestFiltersIsNull = false;
            }
             // determine if request.Filters should be set to null
            if (requestFiltersIsNull)
            {
                request.Filters = null;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            if (cmdletContext.NextToken != null)
            {
                request.NextToken = cmdletContext.NextToken;
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
        
        private Amazon.Mgn.Model.DescribeSourceServersResponse CallAWSServiceOperation(IAmazonMgn client, Amazon.Mgn.Model.DescribeSourceServersRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Application Migration Service", "DescribeSourceServers");
            try
            {
                #if DESKTOP
                return client.DescribeSourceServers(request);
                #elif CORECLR
                return client.DescribeSourceServersAsync(request).GetAwaiter().GetResult();
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
            public System.Boolean? Filters_IsArchived { get; set; }
            public List<System.String> Filters_SourceServerIDs { get; set; }
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.Func<Amazon.Mgn.Model.DescribeSourceServersResponse, GetMGNSourceServerCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Items;
        }
        
    }
}
