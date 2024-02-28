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

# Argument completions for service AWS Import/Export Snowball


$SNOW_Completers = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    switch ($("$commandName/$parameterName"))
    {
        # Amazon.Snowball.AddressType
        "New-SNOWAddress/Address_Type"
        {
            $v = "AWS_SHIP","CUST_PICKUP"
            break
        }

        # Amazon.Snowball.ImpactLevel
        "New-SNOWJob/ImpactLevel"
        {
            $v = "IL2","IL4","IL5","IL6","IL99"
            break
        }

        # Amazon.Snowball.JobType
        {
            ($_ -eq "New-SNOWCluster/JobType") -Or
            ($_ -eq "New-SNOWJob/JobType")
        }
        {
            $v = "EXPORT","IMPORT","LOCAL_USE"
            break
        }

        # Amazon.Snowball.LongTermPricingType
        "New-SNOWLongTermPricing/LongTermPricingType"
        {
            $v = "OneMonth","OneYear","ThreeYear"
            break
        }

        # Amazon.Snowball.RemoteManagement
        {
            ($_ -eq "New-SNOWCluster/RemoteManagement") -Or
            ($_ -eq "New-SNOWJob/RemoteManagement")
        }
        {
            $v = "INSTALLED_AUTOSTART","INSTALLED_ONLY","NOT_INSTALLED"
            break
        }

        # Amazon.Snowball.ServiceName
        "Get-SNOWServiceVersion/ServiceName"
        {
            $v = "EKS_ANYWHERE","KUBERNETES"
            break
        }

        # Amazon.Snowball.ShipmentState
        "Update-SNOWJobShipmentState/ShipmentState"
        {
            $v = "RECEIVED","RETURNED"
            break
        }

        # Amazon.Snowball.ShippingOption
        {
            ($_ -eq "New-SNOWCluster/ShippingOption") -Or
            ($_ -eq "New-SNOWJob/ShippingOption") -Or
            ($_ -eq "New-SNOWReturnShippingLabel/ShippingOption") -Or
            ($_ -eq "Update-SNOWCluster/ShippingOption") -Or
            ($_ -eq "Update-SNOWJob/ShippingOption")
        }
        {
            $v = "EXPRESS","NEXT_DAY","SECOND_DAY","STANDARD"
            break
        }

        # Amazon.Snowball.SnowballCapacity
        {
            ($_ -eq "New-SNOWCluster/SnowballCapacityPreference") -Or
            ($_ -eq "New-SNOWJob/SnowballCapacityPreference") -Or
            ($_ -eq "Update-SNOWJob/SnowballCapacityPreference")
        }
        {
            $v = "NoPreference","T100","T13","T14","T240","T32","T42","T50","T8","T80","T98"
            break
        }

        # Amazon.Snowball.SnowballType
        {
            ($_ -eq "New-SNOWCluster/SnowballType") -Or
            ($_ -eq "New-SNOWJob/SnowballType") -Or
            ($_ -eq "New-SNOWLongTermPricing/SnowballType")
        }
        {
            $v = "EDGE","EDGE_C","EDGE_CG","EDGE_S","RACK_5U_C","SNC1_HDD","SNC1_SSD","STANDARD","V3_5C","V3_5S"
            break
        }

        # Amazon.Snowball.StorageUnit
        {
            ($_ -eq "New-SNOWCluster/NFSOnDeviceService_StorageUnit") -Or
            ($_ -eq "New-SNOWJob/NFSOnDeviceService_StorageUnit") -Or
            ($_ -eq "Update-SNOWCluster/NFSOnDeviceService_StorageUnit") -Or
            ($_ -eq "Update-SNOWJob/NFSOnDeviceService_StorageUnit") -Or
            ($_ -eq "New-SNOWCluster/S3OnDeviceService_StorageUnit") -Or
            ($_ -eq "New-SNOWJob/S3OnDeviceService_StorageUnit") -Or
            ($_ -eq "Update-SNOWCluster/S3OnDeviceService_StorageUnit") -Or
            ($_ -eq "Update-SNOWJob/S3OnDeviceService_StorageUnit") -Or
            ($_ -eq "New-SNOWCluster/TGWOnDeviceService_StorageUnit") -Or
            ($_ -eq "New-SNOWJob/TGWOnDeviceService_StorageUnit") -Or
            ($_ -eq "Update-SNOWCluster/TGWOnDeviceService_StorageUnit") -Or
            ($_ -eq "Update-SNOWJob/TGWOnDeviceService_StorageUnit")
        }
        {
            $v = "TB"
            break
        }


    }

    $v |
        Where-Object { $_ -like "$wordToComplete*" } |
        ForEach-Object { New-Object System.Management.Automation.CompletionResult $_, $_, 'ParameterValue', $_ }
}

$SNOW_map = @{
    "Address_Type"=@("New-SNOWAddress")
    "ImpactLevel"=@("New-SNOWJob")
    "JobType"=@("New-SNOWCluster","New-SNOWJob")
    "LongTermPricingType"=@("New-SNOWLongTermPricing")
    "NFSOnDeviceService_StorageUnit"=@("New-SNOWCluster","New-SNOWJob","Update-SNOWCluster","Update-SNOWJob")
    "RemoteManagement"=@("New-SNOWCluster","New-SNOWJob")
    "S3OnDeviceService_StorageUnit"=@("New-SNOWCluster","New-SNOWJob","Update-SNOWCluster","Update-SNOWJob")
    "ServiceName"=@("Get-SNOWServiceVersion")
    "ShipmentState"=@("Update-SNOWJobShipmentState")
    "ShippingOption"=@("New-SNOWCluster","New-SNOWJob","New-SNOWReturnShippingLabel","Update-SNOWCluster","Update-SNOWJob")
    "SnowballCapacityPreference"=@("New-SNOWCluster","New-SNOWJob","Update-SNOWJob")
    "SnowballType"=@("New-SNOWCluster","New-SNOWJob","New-SNOWLongTermPricing")
    "TGWOnDeviceService_StorageUnit"=@("New-SNOWCluster","New-SNOWJob","Update-SNOWCluster","Update-SNOWJob")
}

_awsArgumentCompleterRegistration $SNOW_Completers $SNOW_map

$SNOW_SelectCompleters = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    $cmdletType = Invoke-Expression "[Amazon.PowerShell.Cmdlets.SNOW.$($commandName.Replace('-', ''))Cmdlet]"
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

$SNOW_SelectMap = @{
    "Select"=@("Stop-SNOWCluster",
               "Stop-SNOWJob",
               "New-SNOWAddress",
               "New-SNOWCluster",
               "New-SNOWJob",
               "New-SNOWLongTermPricing",
               "New-SNOWReturnShippingLabel",
               "Get-SNOWAddress",
               "Get-SNOWAddressList",
               "Get-SNOWCluster",
               "Get-SNOWJob",
               "Get-SNOWReturnShippingLabel",
               "Get-SNOWJobManifest",
               "Get-SNOWJobUnlockCode",
               "Get-SNOWSnowballUsage",
               "Get-SNOWSoftwareUpdate",
               "Get-SNOWClusterJobList",
               "Get-SNOWClusterList",
               "Get-SNOWCompatibleImageList",
               "Get-SNOWJobList",
               "Get-SNOWLongTermPricing",
               "Get-SNOWPickupLocation",
               "Get-SNOWServiceVersion",
               "Update-SNOWCluster",
               "Update-SNOWJob",
               "Update-SNOWJobShipmentState",
               "Update-SNOWLongTermPricing")
}

_awsArgumentCompleterRegistration $SNOW_SelectCompleters $SNOW_SelectMap

