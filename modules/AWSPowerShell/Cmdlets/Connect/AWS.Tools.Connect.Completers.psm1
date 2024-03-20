# Auto-generated argument completers for parameters of SDK ConstantClass-derived type used in cmdlets.
# Do not modify this file; it may be overwritten during version upgrades.

$psMajorVersion = $PSVersionTable.PSVersion.Major
if ($psMajorVersion -eq 2) 
{ 
	Write-Verbose "Dynamic argument completion not supported in PowerShell version 2; skipping load."
	return 
}

# PowerShell's native Register-ArgumentCompleter cmdlet is available on v5.0 or higher. For lower
# version, we can use the version in the TabExpansion++ module if installed.
$registrationCmdletAvailable = ($psMajorVersion -ge 5) -Or !((Get-Command Register-ArgumentCompleter -ea Ignore) -eq $null)

# internal function to perform the registration using either cmdlet or manipulation
# of the options table
function _awsArgumentCompleterRegistration()
{
    param
    (
        [scriptblock]$scriptBlock,
        [hashtable]$param2CmdletsMap
    )

    if ($registrationCmdletAvailable)
    {
        foreach ($paramName in $param2CmdletsMap.Keys)
        {
             $args = @{
                "ScriptBlock" = $scriptBlock
                "Parameter" = $paramName
            }

            $cmdletNames = $param2CmdletsMap[$paramName]
            if ($cmdletNames -And $cmdletNames.Length -gt 0)
            {
                $args["Command"] = $cmdletNames
            }

            Register-ArgumentCompleter @args
        }
    }
    else
    {
        if (-not $global:options) { $global:options = @{ CustomArgumentCompleters = @{ }; NativeArgumentCompleters = @{ } } }

        foreach ($paramName in $param2CmdletsMap.Keys)
        {
            $cmdletNames = $param2CmdletsMap[$paramName]

            if ($cmdletNames -And $cmdletNames.Length -gt 0)
            {
                foreach ($cn in $cmdletNames)
                {
                    $fqn =  [string]::Concat($cn, ":", $paramName)
                    $global:options['CustomArgumentCompleters'][$fqn] = $scriptBlock
                }
            }
            else
            {
                $global:options['CustomArgumentCompleters'][$paramName] = $scriptBlock
            }
        }

        $function:tabexpansion2 = $function:tabexpansion2 -replace 'End\r\n{', 'End { if ($null -ne $options) { $options += $global:options} else {$options = $global:options}'
    }
}

# To allow for same-name parameters of different ConstantClass-derived types 
# each completer function checks on command name concatenated with parameter name.
# Additionally, the standard code pattern for completers is to pipe through 
# sort-object after filtering against $wordToComplete but we omit this as our members 
# are already sorted.

# Argument completions for service Amazon Connect Service


$CONN_Completers = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    switch ($("$commandName/$parameterName"))
    {
        # Amazon.Connect.AgentAvailabilityTimer
        {
            ($_ -eq "New-CONNRoutingProfile/AgentAvailabilityTimer") -Or
            ($_ -eq "Update-CONNRoutingProfileAgentAvailabilityTimer/AgentAvailabilityTimer")
        }
        {
            $v = "TIME_SINCE_LAST_ACTIVITY","TIME_SINCE_LAST_INBOUND"
            break
        }

        # Amazon.Connect.AgentStatusState
        {
            ($_ -eq "New-CONNAgentStatus/State") -Or
            ($_ -eq "Update-CONNAgentStatus/State")
        }
        {
            $v = "DISABLED","ENABLED"
            break
        }

        # Amazon.Connect.ChatEventType
        "Send-CONNChatIntegrationEvent/Event_Type"
        {
            $v = "DISCONNECT","EVENT","MESSAGE"
            break
        }

        # Amazon.Connect.ContactFlowModuleState
        {
            ($_ -eq "Get-CONNContactFlowModuleList/ContactFlowModuleState") -Or
            ($_ -eq "Update-CONNContactFlowModuleMetadata/State")
        }
        {
            $v = "ACTIVE","ARCHIVED"
            break
        }

        # Amazon.Connect.ContactFlowState
        "Update-CONNContactFlowMetadata/ContactFlowState"
        {
            $v = "ACTIVE","ARCHIVED"
            break
        }

        # Amazon.Connect.ContactFlowType
        "New-CONNContactFlow/Type"
        {
            $v = "AGENT_HOLD","AGENT_TRANSFER","AGENT_WHISPER","CONTACT_FLOW","CUSTOMER_HOLD","CUSTOMER_QUEUE","CUSTOMER_WHISPER","OUTBOUND_WHISPER","QUEUE_TRANSFER"
            break
        }

        # Amazon.Connect.DirectoryType
        "New-CONNInstance/IdentityManagementType"
        {
            $v = "CONNECT_MANAGED","EXISTING_DIRECTORY","SAML"
            break
        }

        # Amazon.Connect.EncryptionType
        {
            ($_ -eq "Add-CONNInstanceStorageConfig/StorageConfigKinesisVideoStreamConfigEncryptionConfigEncryptionType") -Or
            ($_ -eq "Update-CONNInstanceStorageConfig/StorageConfigKinesisVideoStreamConfigEncryptionConfigEncryptionType") -Or
            ($_ -eq "Add-CONNInstanceStorageConfig/StorageConfigS3ConfigEncryptionConfigEncryptionType") -Or
            ($_ -eq "Update-CONNInstanceStorageConfig/StorageConfigS3ConfigEncryptionConfigEncryptionType")
        }
        {
            $v = "KMS"
            break
        }

        # Amazon.Connect.EvaluationFormScoringMode
        {
            ($_ -eq "New-CONNEvaluationForm/ScoringStrategy_Mode") -Or
            ($_ -eq "Update-CONNEvaluationForm/ScoringStrategy_Mode")
        }
        {
            $v = "QUESTION_ONLY","SECTION_ONLY"
            break
        }

        # Amazon.Connect.EvaluationFormScoringStatus
        {
            ($_ -eq "New-CONNEvaluationForm/ScoringStrategy_Status") -Or
            ($_ -eq "Update-CONNEvaluationForm/ScoringStrategy_Status")
        }
        {
            $v = "DISABLED","ENABLED"
            break
        }

        # Amazon.Connect.EventSourceName
        {
            ($_ -eq "Get-CONNRuleList/EventSourceName") -Or
            ($_ -eq "New-CONNRule/TriggerEventSource_EventSourceName")
        }
        {
            $v = "OnCaseCreate","OnCaseUpdate","OnContactEvaluationSubmit","OnMetricDataUpdate","OnPostCallAnalysisAvailable","OnPostChatAnalysisAvailable","OnRealTimeCallAnalysisAvailable","OnRealTimeChatAnalysisAvailable","OnSalesforceCaseCreate","OnZendeskTicketCreate","OnZendeskTicketStatusUpdate"
            break
        }

        # Amazon.Connect.FlowAssociationResourceType
        {
            ($_ -eq "Add-CONNFlow/ResourceType") -Or
            ($_ -eq "Get-CONNFlowAssociation/ResourceType") -Or
            ($_ -eq "Remove-CONNFlow/ResourceType")
        }
        {
            $v = "SMS_PHONE_NUMBER"
            break
        }

        # Amazon.Connect.HierarchyGroupMatchType
        {
            ($_ -eq "Search-CONNUser/HierarchyGroupCondition_HierarchyGroupMatchType") -Or
            ($_ -eq "Search-CONNUser/SearchFilter_UserAttributeFilter_AndCondition_HierarchyGroupCondition_HierarchyGroupMatchType") -Or
            ($_ -eq "Search-CONNUser/SearchFilter_UserAttributeFilter_HierarchyGroupCondition_HierarchyGroupMatchType")
        }
        {
            $v = "EXACT","WITH_CHILD_GROUPS"
            break
        }

        # Amazon.Connect.InstanceAttributeType
        {
            ($_ -eq "Get-CONNInstanceAttribute/AttributeType") -Or
            ($_ -eq "Update-CONNInstanceAttribute/AttributeType")
        }
        {
            $v = "AUTO_RESOLVE_BEST_VOICES","CONTACTFLOW_LOGS","CONTACT_LENS","EARLY_MEDIA","ENHANCED_CHAT_MONITORING","ENHANCED_CONTACT_MONITORING","HIGH_VOLUME_OUTBOUND","INBOUND_CALLS","MULTI_PARTY_CONFERENCE","OUTBOUND_CALLS","USE_CUSTOM_TTS_VOICES"
            break
        }

        # Amazon.Connect.InstanceStorageResourceType
        {
            ($_ -eq "Add-CONNInstanceStorageConfig/ResourceType") -Or
            ($_ -eq "Get-CONNInstanceStorageConfig/ResourceType") -Or
            ($_ -eq "Get-CONNInstanceStorageConfigList/ResourceType") -Or
            ($_ -eq "Remove-CONNInstanceStorageConfig/ResourceType") -Or
            ($_ -eq "Update-CONNInstanceStorageConfig/ResourceType")
        }
        {
            $v = "AGENT_EVENTS","ATTACHMENTS","CALL_RECORDINGS","CHAT_TRANSCRIPTS","CONTACT_EVALUATIONS","CONTACT_TRACE_RECORDS","MEDIA_STREAMS","REAL_TIME_CONTACT_ANALYSIS_CHAT_SEGMENTS","REAL_TIME_CONTACT_ANALYSIS_SEGMENTS","REAL_TIME_CONTACT_ANALYSIS_VOICE_SEGMENTS","SCHEDULED_REPORTS","SCREEN_RECORDINGS"
            break
        }

        # Amazon.Connect.IntegrationType
        {
            ($_ -eq "Get-CONNIntegrationAssociationList/IntegrationType") -Or
            ($_ -eq "New-CONNIntegrationAssociation/IntegrationType")
        }
        {
            $v = "APPLICATION","CASES_DOMAIN","EVENT","FILE_SCANNER","PINPOINT_APP","VOICE_ID","WISDOM_ASSISTANT","WISDOM_KNOWLEDGE_BASE","WISDOM_QUICK_RESPONSES"
            break
        }

        # Amazon.Connect.IntervalPeriod
        "Get-CONNMetricDataV2/Interval_IntervalPeriod"
        {
            $v = "DAY","FIFTEEN_MIN","HOUR","THIRTY_MIN","TOTAL","WEEK"
            break
        }

        # Amazon.Connect.LexVersion
        "Get-CONNBotList/LexVersion"
        {
            $v = "V1","V2"
            break
        }

        # Amazon.Connect.ListFlowAssociationResourceType
        {
            ($_ -eq "Get-CONNFlowAssociationBatch/ResourceType") -Or
            ($_ -eq "Get-CONNFlowAssociationList/ResourceType")
        }
        {
            $v = "VOICE_PHONE_NUMBER"
            break
        }

        # Amazon.Connect.ParticipantRole
        "New-CONNParticipant/ParticipantDetails_ParticipantRole"
        {
            $v = "AGENT","CUSTOMER","CUSTOM_BOT","SUPERVISOR","SYSTEM"
            break
        }

        # Amazon.Connect.PhoneNumberCountryCode
        "Search-CONNAvailablePhoneNumber/PhoneNumberCountryCode"
        {
            $v = "AD","AE","AF","AG","AI","AL","AM","AN","AO","AQ","AR","AS","AT","AU","AW","AZ","BA","BB","BD","BE","BF","BG","BH","BI","BJ","BL","BM","BN","BO","BR","BS","BT","BW","BY","BZ","CA","CC","CD","CF","CG","CH","CI","CK","CL","CM","CN","CO","CR","CU","CV","CW","CX","CY","CZ","DE","DJ","DK","DM","DO","DZ","EC","EE","EG","EH","ER","ES","ET","FI","FJ","FK","FM","FO","FR","GA","GB","GD","GE","GG","GH","GI","GL","GM","GN","GQ","GR","GT","GU","GW","GY","HK","HN","HR","HT","HU","ID","IE","IL","IM","IN","IO","IQ","IR","IS","IT","JE","JM","JO","JP","KE","KG","KH","KI","KM","KN","KP","KR","KW","KY","KZ","LA","LB","LC","LI","LK","LR","LS","LT","LU","LV","LY","MA","MC","MD","ME","MF","MG","MH","MK","ML","MM","MN","MO","MP","MR","MS","MT","MU","MV","MW","MX","MY","MZ","NA","NC","NE","NG","NI","NL","NO","NP","NR","NU","NZ","OM","PA","PE","PF","PG","PH","PK","PL","PM","PN","PR","PT","PW","PY","QA","RE","RO","RS","RU","RW","SA","SB","SC","SD","SE","SG","SH","SI","SJ","SK","SL","SM","SN","SO","SR","ST","SV","SX","SY","SZ","TC","TD","TG","TH","TJ","TK","TL","TM","TN","TO","TR","TT","TV","TW","TZ","UA","UG","US","UY","UZ","VA","VC","VE","VG","VI","VN","VU","WF","WS","YE","YT","ZA","ZM","ZW"
            break
        }

        # Amazon.Connect.PhoneNumberType
        "Search-CONNAvailablePhoneNumber/PhoneNumberType"
        {
            $v = "DID","SHARED","SHORT_CODE","THIRD_PARTY_DID","THIRD_PARTY_TF","TOLL_FREE","UIFN"
            break
        }

        # Amazon.Connect.QueueStatus
        "Update-CONNQueueStatus/Status"
        {
            $v = "DISABLED","ENABLED"
            break
        }

        # Amazon.Connect.QuickConnectType
        {
            ($_ -eq "New-CONNQuickConnect/QuickConnectConfig_QuickConnectType") -Or
            ($_ -eq "Update-CONNQuickConnectConfig/QuickConnectConfig_QuickConnectType")
        }
        {
            $v = "PHONE_NUMBER","QUEUE","USER"
            break
        }

        # Amazon.Connect.RealTimeContactAnalysisOutputType
        "Get-CONNRealtimeContactAnalysisSegmentsV2List/OutputType"
        {
            $v = "Raw","Redacted"
            break
        }

        # Amazon.Connect.RehydrationType
        {
            ($_ -eq "Start-CONNChatContact/PersistentChat_RehydrationType") -Or
            ($_ -eq "New-CONNPersistentContactAssociation/RehydrationType")
        }
        {
            $v = "ENTIRE_PAST_SESSION","FROM_SEGMENT"
            break
        }

        # Amazon.Connect.RulePublishStatus
        {
            ($_ -eq "Get-CONNRuleList/PublishStatus") -Or
            ($_ -eq "New-CONNRule/PublishStatus") -Or
            ($_ -eq "Update-CONNRule/PublishStatus")
        }
        {
            $v = "DRAFT","PUBLISHED"
            break
        }

        # Amazon.Connect.SearchableQueueType
        "Search-CONNQueue/SearchCriteria_QueueTypeCondition"
        {
            $v = "STANDARD"
            break
        }

        # Amazon.Connect.SearchContactsMatchType
        {
            ($_ -eq "Search-CONNContact/SearchableContactAttributes_MatchType") -Or
            ($_ -eq "Search-CONNContact/Transcript_MatchType")
        }
        {
            $v = "MATCH_ALL","MATCH_ANY"
            break
        }

        # Amazon.Connect.SearchContactsTimeRangeType
        "Search-CONNContact/TimeRange_Type"
        {
            $v = "CONNECTED_TO_AGENT_TIMESTAMP","DISCONNECT_TIMESTAMP","INITIATION_TIMESTAMP","SCHEDULED_TIMESTAMP"
            break
        }

        # Amazon.Connect.SortableFieldName
        "Search-CONNContact/Sort_FieldName"
        {
            $v = "CHANNEL","CONNECTED_TO_AGENT_TIMESTAMP","DISCONNECT_TIMESTAMP","INITIATION_METHOD","INITIATION_TIMESTAMP","SCHEDULED_TIMESTAMP"
            break
        }

        # Amazon.Connect.SortOrder
        "Search-CONNContact/Sort_Order"
        {
            $v = "ASCENDING","DESCENDING"
            break
        }

        # Amazon.Connect.SourceType
        "New-CONNIntegrationAssociation/SourceType"
        {
            $v = "CASES","SALESFORCE","ZENDESK"
            break
        }

        # Amazon.Connect.StorageType
        {
            ($_ -eq "Add-CONNInstanceStorageConfig/StorageConfig_StorageType") -Or
            ($_ -eq "Update-CONNInstanceStorageConfig/StorageConfig_StorageType")
        }
        {
            $v = "KINESIS_FIREHOSE","KINESIS_STREAM","KINESIS_VIDEO_STREAM","S3"
            break
        }

        # Amazon.Connect.StringComparisonType
        {
            ($_ -eq "Search-CONNHoursOfOperation/StringCondition_ComparisonType") -Or
            ($_ -eq "Search-CONNPredefinedAttribute/StringCondition_ComparisonType") -Or
            ($_ -eq "Search-CONNPrompt/StringCondition_ComparisonType") -Or
            ($_ -eq "Search-CONNQueue/StringCondition_ComparisonType") -Or
            ($_ -eq "Search-CONNQuickConnect/StringCondition_ComparisonType") -Or
            ($_ -eq "Search-CONNRoutingProfile/StringCondition_ComparisonType") -Or
            ($_ -eq "Search-CONNSecurityProfile/StringCondition_ComparisonType") -Or
            ($_ -eq "Search-CONNUser/StringCondition_ComparisonType") -Or
            ($_ -eq "Search-CONNResourceTag/TagSearchCondition_TagKeyComparisonType") -Or
            ($_ -eq "Search-CONNResourceTag/TagSearchCondition_TagValueComparisonType")
        }
        {
            $v = "CONTAINS","EXACT","STARTS_WITH"
            break
        }

        # Amazon.Connect.TaskTemplateStatus
        {
            ($_ -eq "Get-CONNTaskTemplateList/Status") -Or
            ($_ -eq "New-CONNTaskTemplate/Status") -Or
            ($_ -eq "Update-CONNTaskTemplate/Status")
        }
        {
            $v = "ACTIVE","INACTIVE"
            break
        }

        # Amazon.Connect.TrafficType
        "Start-CONNOutboundVoiceContact/TrafficType"
        {
            $v = "CAMPAIGN","GENERAL"
            break
        }

        # Amazon.Connect.UseCaseType
        "New-CONNUseCase/UseCaseType"
        {
            $v = "CONNECT_CAMPAIGNS","RULES_EVALUATION"
            break
        }

        # Amazon.Connect.VideoCapability
        {
            ($_ -eq "Start-CONNWebRTCContact/Agent_Video") -Or
            ($_ -eq "Start-CONNWebRTCContact/Customer_Video")
        }
        {
            $v = "SEND"
            break
        }

        # Amazon.Connect.ViewStatus
        {
            ($_ -eq "New-CONNView/Status") -Or
            ($_ -eq "Update-CONNViewContent/Status")
        }
        {
            $v = "PUBLISHED","SAVED"
            break
        }

        # Amazon.Connect.ViewType
        "Get-CONNViewList/Type"
        {
            $v = "AWS_MANAGED","CUSTOMER_MANAGED"
            break
        }

        # Amazon.Connect.VocabularyLanguageCode
        {
            ($_ -eq "Add-CONNDefaultVocabulary/LanguageCode") -Or
            ($_ -eq "Get-CONNDefaultVocabularyList/LanguageCode") -Or
            ($_ -eq "New-CONNVocabulary/LanguageCode") -Or
            ($_ -eq "Search-CONNVocabulary/LanguageCode")
        }
        {
            $v = "ar-AE","de-CH","de-DE","en-AB","en-AU","en-GB","en-IE","en-IN","en-NZ","en-US","en-WL","en-ZA","es-ES","es-US","fr-CA","fr-FR","hi-IN","it-IT","ja-JP","ko-KR","pt-BR","pt-PT","zh-CN"
            break
        }

        # Amazon.Connect.VocabularyState
        "Search-CONNVocabulary/State"
        {
            $v = "ACTIVE","CREATION_FAILED","CREATION_IN_PROGRESS","DELETE_IN_PROGRESS"
            break
        }

        # Amazon.Connect.VoiceRecordingTrack
        "Start-CONNContactRecording/VoiceRecordingConfiguration_VoiceRecordingTrack"
        {
            $v = "ALL","FROM_AGENT","TO_AGENT"
            break
        }


    }

    $v |
        Where-Object { $_ -like "$wordToComplete*" } |
        ForEach-Object { New-Object System.Management.Automation.CompletionResult $_, $_, 'ParameterValue', $_ }
}

$CONN_map = @{
    "Agent_Video"=@("Start-CONNWebRTCContact")
    "AgentAvailabilityTimer"=@("New-CONNRoutingProfile","Update-CONNRoutingProfileAgentAvailabilityTimer")
    "AttributeType"=@("Get-CONNInstanceAttribute","Update-CONNInstanceAttribute")
    "ContactFlowModuleState"=@("Get-CONNContactFlowModuleList")
    "ContactFlowState"=@("Update-CONNContactFlowMetadata")
    "Customer_Video"=@("Start-CONNWebRTCContact")
    "Event_Type"=@("Send-CONNChatIntegrationEvent")
    "EventSourceName"=@("Get-CONNRuleList")
    "HierarchyGroupCondition_HierarchyGroupMatchType"=@("Search-CONNUser")
    "IdentityManagementType"=@("New-CONNInstance")
    "IntegrationType"=@("Get-CONNIntegrationAssociationList","New-CONNIntegrationAssociation")
    "Interval_IntervalPeriod"=@("Get-CONNMetricDataV2")
    "LanguageCode"=@("Add-CONNDefaultVocabulary","Get-CONNDefaultVocabularyList","New-CONNVocabulary","Search-CONNVocabulary")
    "LexVersion"=@("Get-CONNBotList")
    "OutputType"=@("Get-CONNRealtimeContactAnalysisSegmentsV2List")
    "ParticipantDetails_ParticipantRole"=@("New-CONNParticipant")
    "PersistentChat_RehydrationType"=@("Start-CONNChatContact")
    "PhoneNumberCountryCode"=@("Search-CONNAvailablePhoneNumber")
    "PhoneNumberType"=@("Search-CONNAvailablePhoneNumber")
    "PublishStatus"=@("Get-CONNRuleList","New-CONNRule","Update-CONNRule")
    "QuickConnectConfig_QuickConnectType"=@("New-CONNQuickConnect","Update-CONNQuickConnectConfig")
    "RehydrationType"=@("New-CONNPersistentContactAssociation")
    "ResourceType"=@("Add-CONNFlow","Add-CONNInstanceStorageConfig","Get-CONNFlowAssociation","Get-CONNFlowAssociationBatch","Get-CONNFlowAssociationList","Get-CONNInstanceStorageConfig","Get-CONNInstanceStorageConfigList","Remove-CONNFlow","Remove-CONNInstanceStorageConfig","Update-CONNInstanceStorageConfig")
    "ScoringStrategy_Mode"=@("New-CONNEvaluationForm","Update-CONNEvaluationForm")
    "ScoringStrategy_Status"=@("New-CONNEvaluationForm","Update-CONNEvaluationForm")
    "SearchableContactAttributes_MatchType"=@("Search-CONNContact")
    "SearchCriteria_QueueTypeCondition"=@("Search-CONNQueue")
    "SearchFilter_UserAttributeFilter_AndCondition_HierarchyGroupCondition_HierarchyGroupMatchType"=@("Search-CONNUser")
    "SearchFilter_UserAttributeFilter_HierarchyGroupCondition_HierarchyGroupMatchType"=@("Search-CONNUser")
    "Sort_FieldName"=@("Search-CONNContact")
    "Sort_Order"=@("Search-CONNContact")
    "SourceType"=@("New-CONNIntegrationAssociation")
    "State"=@("New-CONNAgentStatus","Search-CONNVocabulary","Update-CONNAgentStatus","Update-CONNContactFlowModuleMetadata")
    "Status"=@("Get-CONNTaskTemplateList","New-CONNTaskTemplate","New-CONNView","Update-CONNQueueStatus","Update-CONNTaskTemplate","Update-CONNViewContent")
    "StorageConfig_StorageType"=@("Add-CONNInstanceStorageConfig","Update-CONNInstanceStorageConfig")
    "StorageConfigKinesisVideoStreamConfigEncryptionConfigEncryptionType"=@("Add-CONNInstanceStorageConfig","Update-CONNInstanceStorageConfig")
    "StorageConfigS3ConfigEncryptionConfigEncryptionType"=@("Add-CONNInstanceStorageConfig","Update-CONNInstanceStorageConfig")
    "StringCondition_ComparisonType"=@("Search-CONNHoursOfOperation","Search-CONNPredefinedAttribute","Search-CONNPrompt","Search-CONNQueue","Search-CONNQuickConnect","Search-CONNRoutingProfile","Search-CONNSecurityProfile","Search-CONNUser")
    "TagSearchCondition_TagKeyComparisonType"=@("Search-CONNResourceTag")
    "TagSearchCondition_TagValueComparisonType"=@("Search-CONNResourceTag")
    "TimeRange_Type"=@("Search-CONNContact")
    "TrafficType"=@("Start-CONNOutboundVoiceContact")
    "Transcript_MatchType"=@("Search-CONNContact")
    "TriggerEventSource_EventSourceName"=@("New-CONNRule")
    "Type"=@("Get-CONNViewList","New-CONNContactFlow")
    "UseCaseType"=@("New-CONNUseCase")
    "VoiceRecordingConfiguration_VoiceRecordingTrack"=@("Start-CONNContactRecording")
}

_awsArgumentCompleterRegistration $CONN_Completers $CONN_map

$CONN_SelectCompleters = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    $cmdletType = Invoke-Expression "[Amazon.PowerShell.Cmdlets.CONN.$($commandName.Replace('-', ''))Cmdlet]"
    if (-not $cmdletType) {
        return
    }
    $awsCmdletAttribute = $cmdletType.GetCustomAttributes([Amazon.PowerShell.Common.AWSCmdletAttribute], $false)
    if (-not $awsCmdletAttribute) {
        return
    }
    $type = $awsCmdletAttribute.SelectReturnType
    if (-not $type) {
        return
    }

    $splitSelect = $wordToComplete -Split '\.'
    $splitSelect | Select-Object -First ($splitSelect.Length - 1) | ForEach-Object {
        $propertyName = $_
        $properties = $type.GetProperties(('Instance', 'Public', 'DeclaredOnly')) | Where-Object { $_.Name -ieq $propertyName }
        if ($properties.Length -ne 1) {
            break
        }
        $type = $properties.PropertyType
        $prefix += "$($properties.Name)."

        $asEnumerableType = $type.GetInterface('System.Collections.Generic.IEnumerable`1')
        if ($asEnumerableType -and $type -ne [System.String]) {
            $type =  $asEnumerableType.GetGenericArguments()[0]
        }
    }

    $v = @( '*' )
    $properties = $type.GetProperties(('Instance', 'Public', 'DeclaredOnly')).Name | Sort-Object
    if ($properties) {
        $v += ($properties | ForEach-Object { $prefix + $_ })
    }
    $parameters = $cmdletType.GetProperties(('Instance', 'Public')) | Where-Object { $_.GetCustomAttributes([System.Management.Automation.ParameterAttribute], $true) } | Select-Object -ExpandProperty Name | Sort-Object
    if ($parameters) {
        $v += ($parameters | ForEach-Object { "^$_" })
    }

    $v |
        Where-Object { $_ -match "^$([System.Text.RegularExpressions.Regex]::Escape($wordToComplete)).*" } |
        ForEach-Object { New-Object System.Management.Automation.CompletionResult $_, $_, 'ParameterValue', $_ }
}

$CONN_SelectMap = @{
    "Select"=@("Enable-CONNEvaluationForm",
               "Register-CONNAnalyticsDataSet",
               "Add-CONNApprovedOrigin",
               "Add-CONNBot",
               "Add-CONNDefaultVocabulary",
               "Add-CONNFlow",
               "Add-CONNInstanceStorageConfig",
               "Add-CONNLambdaFunction",
               "Add-CONNLexBot",
               "Add-CONNPhoneNumberContactFlow",
               "Add-CONNQueueQuickConnect",
               "Join-CONNRoutingProfileQueue",
               "Add-CONNSecurityKey",
               "Add-CONNTrafficDistributionGroupUser",
               "Add-CONNUserProficiency",
               "Register-CONNBatchAnalyticsDataSet",
               "Unregister-CONNBatchAnalyticsDataSet",
               "Get-CONNFlowAssociationBatch",
               "Set-CONNBatchPutContact",
               "Request-CONNPhoneNumber",
               "New-CONNAgentStatus",
               "New-CONNContactFlow",
               "New-CONNContactFlowModule",
               "New-CONNEvaluationForm",
               "New-CONNHoursOfOperation",
               "New-CONNInstance",
               "New-CONNIntegrationAssociation",
               "New-CONNParticipant",
               "New-CONNPersistentContactAssociation",
               "New-CONNPredefinedAttribute",
               "New-CONNPrompt",
               "New-CONNQueue",
               "New-CONNQuickConnect",
               "New-CONNRoutingProfile",
               "New-CONNRule",
               "New-CONNSecurityProfile",
               "New-CONNTaskTemplate",
               "New-CONNTrafficDistributionGroup",
               "New-CONNUseCase",
               "New-CONNUser",
               "New-CONNUserHierarchyGroup",
               "New-CONNView",
               "New-CONNViewVersion",
               "New-CONNVocabulary",
               "Disable-CONNEvaluationForm",
               "Remove-CONNContactEvaluation",
               "Remove-CONNContactFlow",
               "Remove-CONNContactFlowModule",
               "Remove-CONNEvaluationForm",
               "Remove-CONNHoursOfOperation",
               "Remove-CONNInstance",
               "Remove-CONNIntegrationAssociation",
               "Remove-CONNPredefinedAttribute",
               "Remove-CONNPrompt",
               "Remove-CONNQueue",
               "Remove-CONNQuickConnect",
               "Remove-CONNRoutingProfile",
               "Remove-CONNRule",
               "Remove-CONNSecurityProfile",
               "Remove-CONNTaskTemplate",
               "Remove-CONNTrafficDistributionGroup",
               "Remove-CONNUseCase",
               "Remove-CONNUser",
               "Remove-CONNUserHierarchyGroup",
               "Remove-CONNView",
               "Remove-CONNViewVersion",
               "Remove-CONNVocabulary",
               "Get-CONNAgentStatus",
               "Get-CONNContact",
               "Get-CONNContactEvaluation",
               "Get-CONNContactFlow",
               "Get-CONNContactFlowModule",
               "Get-CONNEvaluationForm",
               "Get-CONNHoursOfOperation",
               "Get-CONNInstance",
               "Get-CONNInstanceAttribute",
               "Get-CONNInstanceStorageConfig",
               "Get-CONNPhoneNumber",
               "Get-CONNPredefinedAttribute",
               "Get-CONNPrompt",
               "Get-CONNQueue",
               "Get-CONNQuickConnect",
               "Get-CONNRoutingProfile",
               "Get-CONNRule",
               "Get-CONNSecurityProfile",
               "Get-CONNTrafficDistributionGroup",
               "Get-CONNUser",
               "Get-CONNUserHierarchyGroup",
               "Get-CONNUserHierarchyStructure",
               "Get-CONNView",
               "Get-CONNVocabulary",
               "Unregister-CONNAnalyticsDataSet",
               "Remove-CONNApprovedOrigin",
               "Remove-CONNBot",
               "Remove-CONNFlow",
               "Remove-CONNInstanceStorageConfig",
               "Remove-CONNLambdaFunction",
               "Remove-CONNLexBot",
               "Remove-CONNPhoneNumberContactFlow",
               "Remove-CONNQueueQuickConnect",
               "Disconnect-CONNRoutingProfileQueue",
               "Remove-CONNSecurityKey",
               "Remove-CONNTrafficDistributionGroupUser",
               "Remove-CONNUserProficiency",
               "Write-CONNUserContact",
               "Get-CONNContactAttribute",
               "Get-CONNCurrentMetricData",
               "Get-CONNCurrentUserData",
               "Get-CONNFederationToken",
               "Get-CONNFlowAssociation",
               "Get-CONNMetricData",
               "Get-CONNMetricDataV2",
               "Get-CONNPromptFile",
               "Get-CONNTaskTemplate",
               "Get-CONNTrafficDistribution",
               "Import-CONNPhoneNumber",
               "Get-CONNAgentStatusList",
               "Get-CONNAnalyticsDataAssociationList",
               "Get-CONNApprovedOriginList",
               "Get-CONNBotList",
               "Get-CONNContactEvaluationList",
               "Get-CONNContactFlowModuleList",
               "Get-CONNContactFlowList",
               "Get-CONNContactReferenceList",
               "Get-CONNDefaultVocabularyList",
               "Get-CONNEvaluationFormList",
               "Get-CONNEvaluationFormVersionList",
               "Get-CONNFlowAssociationList",
               "Get-CONNHoursOfOperationList",
               "Get-CONNInstanceAttributeList",
               "Get-CONNInstanceList",
               "Get-CONNInstanceStorageConfigList",
               "Get-CONNIntegrationAssociationList",
               "Get-CONNLambdaFunctionList",
               "Get-CONNLexBotList",
               "Get-CONNPhoneNumberList",
               "Get-CONNPhoneNumbersV2List",
               "Get-CONNPredefinedAttributeList",
               "Get-CONNPromptList",
               "Get-CONNQueueQuickConnectList",
               "Get-CONNQueueList",
               "Get-CONNQuickConnectList",
               "Get-CONNRealtimeContactAnalysisSegmentsV2List",
               "Get-CONNRoutingProfileQueueList",
               "Get-CONNRoutingProfileList",
               "Get-CONNRuleList",
               "Get-CONNSecurityKeyList",
               "Get-CONNSecurityProfileApplicationList",
               "Get-CONNSecurityProfilePermissionList",
               "Get-CONNSecurityProfileList",
               "Get-CONNResourceTag",
               "Get-CONNTaskTemplateList",
               "Get-CONNTrafficDistributionGroupList",
               "Get-CONNTrafficDistributionGroupUserList",
               "Get-CONNUseCaseList",
               "Get-CONNUserHierarchyGroupList",
               "Get-CONNUserProficiencyList",
               "Get-CONNUserList",
               "Get-CONNViewList",
               "Get-CONNViewVersionList",
               "Start-CONNContactMonitoring",
               "Invoke-CONNPauseContact",
               "Write-CONNUserStatus",
               "Remove-CONNPhoneNumber",
               "Copy-CONNInstance",
               "Invoke-CONNResumeContact",
               "Resume-CONNContactRecording",
               "Search-CONNAvailablePhoneNumber",
               "Search-CONNContact",
               "Search-CONNHoursOfOperation",
               "Search-CONNPredefinedAttribute",
               "Search-CONNPrompt",
               "Search-CONNQueue",
               "Search-CONNQuickConnect",
               "Search-CONNResourceTag",
               "Search-CONNRoutingProfile",
               "Search-CONNSecurityProfile",
               "Search-CONNUser",
               "Search-CONNVocabulary",
               "Send-CONNChatIntegrationEvent",
               "Start-CONNChatContact",
               "Start-CONNContactEvaluation",
               "Start-CONNContactRecording",
               "Start-CONNContactStreaming",
               "Start-CONNOutboundVoiceContact",
               "Start-CONNTaskContact",
               "Start-CONNWebRTCContact",
               "Stop-CONNContact",
               "Stop-CONNContactRecording",
               "Stop-CONNContactStreaming",
               "Submit-CONNContactEvaluation",
               "Suspend-CONNContactRecording",
               "Add-CONNContactTag",
               "Add-CONNResourceTag",
               "Move-CONNContact",
               "Remove-CONNContactTag",
               "Remove-CONNResourceTag",
               "Update-CONNAgentStatus",
               "Update-CONNContact",
               "Update-CONNContactAttribute",
               "Update-CONNContactEvaluation",
               "Update-CONNContactFlowContent",
               "Update-CONNContactFlowMetadata",
               "Update-CONNContactFlowModuleContent",
               "Update-CONNContactFlowModuleMetadata",
               "Update-CONNContactFlowName",
               "Update-CONNContactRoutingData",
               "Update-CONNContactSchedule",
               "Update-CONNEvaluationForm",
               "Update-CONNHoursOfOperation",
               "Update-CONNInstanceAttribute",
               "Update-CONNInstanceStorageConfig",
               "Update-CONNParticipantRoleConfig",
               "Update-CONNPhoneNumber",
               "Update-CONNPhoneNumberMetadata",
               "Update-CONNPredefinedAttribute",
               "Update-CONNPrompt",
               "Update-CONNQueueHoursOfOperation",
               "Update-CONNQueueMaxContact",
               "Update-CONNQueueName",
               "Update-CONNQueueOutboundCallerConfig",
               "Update-CONNQueueStatus",
               "Update-CONNQuickConnectConfig",
               "Update-CONNQuickConnectName",
               "Update-CONNRoutingProfileAgentAvailabilityTimer",
               "Update-CONNRoutingProfileConcurrency",
               "Update-CONNRoutingProfileDefaultOutboundQueue",
               "Update-CONNRoutingProfileName",
               "Update-CONNRoutingProfileQueue",
               "Update-CONNRule",
               "Update-CONNSecurityProfile",
               "Update-CONNTaskTemplate",
               "Update-CONNTrafficDistribution",
               "Update-CONNUserHierarchy",
               "Update-CONNUserHierarchyGroupName",
               "Update-CONNUserHierarchyStructure",
               "Update-CONNUserIdentityInfo",
               "Update-CONNUserPhoneConfig",
               "Update-CONNUserProficiency",
               "Update-CONNUserRoutingProfile",
               "Update-CONNUserSecurityProfile",
               "Update-CONNViewContent",
               "Update-CONNViewMetadata")
}

_awsArgumentCompleterRegistration $CONN_SelectCompleters $CONN_SelectMap

