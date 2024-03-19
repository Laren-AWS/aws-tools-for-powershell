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

# Argument completions for service Amazon Managed Blockchain Query


$MBCQ_Completers = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    switch ($("$commandName/$parameterName"))
    {
        # Amazon.ManagedBlockchainQuery.ListFilteredTransactionEventsSortBy
        "Get-MBCQFilteredTransactionEventList/Sort_SortBy"
        {
            $v = "blockchainInstant"
            break
        }

        # Amazon.ManagedBlockchainQuery.ListTransactionsSortBy
        "Get-MBCQTransactionList/Sort_SortBy"
        {
            $v = "TRANSACTION_TIMESTAMP"
            break
        }

        # Amazon.ManagedBlockchainQuery.QueryNetwork
        {
            ($_ -eq "Get-MBCQAssetContractList/ContractFilter_Network") -Or
            ($_ -eq "Get-MBCQAssetContract/ContractIdentifier_Network") -Or
            ($_ -eq "Get-MBCQTransaction/Network") -Or
            ($_ -eq "Get-MBCQTransactionEventList/Network") -Or
            ($_ -eq "Get-MBCQTransactionList/Network") -Or
            ($_ -eq "Get-MBCQTokenBalanceList/TokenFilter_Network") -Or
            ($_ -eq "Get-MBCQTokenBalance/TokenIdentifier_Network")
        }
        {
            $v = "BITCOIN_MAINNET","BITCOIN_TESTNET","ETHEREUM_MAINNET","ETHEREUM_SEPOLIA_TESTNET"
            break
        }

        # Amazon.ManagedBlockchainQuery.QueryTokenStandard
        "Get-MBCQAssetContractList/ContractFilter_TokenStandard"
        {
            $v = "ERC1155","ERC20","ERC721"
            break
        }

        # Amazon.ManagedBlockchainQuery.SortOrder
        {
            ($_ -eq "Get-MBCQFilteredTransactionEventList/Sort_SortOrder") -Or
            ($_ -eq "Get-MBCQTransactionList/Sort_SortOrder")
        }
        {
            $v = "ASCENDING","DESCENDING"
            break
        }


    }

    $v |
        Where-Object { $_ -like "$wordToComplete*" } |
        ForEach-Object { New-Object System.Management.Automation.CompletionResult $_, $_, 'ParameterValue', $_ }
}

$MBCQ_map = @{
    "ContractFilter_Network"=@("Get-MBCQAssetContractList")
    "ContractFilter_TokenStandard"=@("Get-MBCQAssetContractList")
    "ContractIdentifier_Network"=@("Get-MBCQAssetContract")
    "Network"=@("Get-MBCQTransaction","Get-MBCQTransactionEventList","Get-MBCQTransactionList")
    "Sort_SortBy"=@("Get-MBCQFilteredTransactionEventList","Get-MBCQTransactionList")
    "Sort_SortOrder"=@("Get-MBCQFilteredTransactionEventList","Get-MBCQTransactionList")
    "TokenFilter_Network"=@("Get-MBCQTokenBalanceList")
    "TokenIdentifier_Network"=@("Get-MBCQTokenBalance")
}

_awsArgumentCompleterRegistration $MBCQ_Completers $MBCQ_map

$MBCQ_SelectCompleters = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    $cmdletType = Invoke-Expression "[Amazon.PowerShell.Cmdlets.MBCQ.$($commandName.Replace('-', ''))Cmdlet]"
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

$MBCQ_SelectMap = @{
    "Select"=@("Get-MBCQBatchTokenBalance",
               "Get-MBCQAssetContract",
               "Get-MBCQTokenBalance",
               "Get-MBCQTransaction",
               "Get-MBCQAssetContractList",
               "Get-MBCQFilteredTransactionEventList",
               "Get-MBCQTokenBalanceList",
               "Get-MBCQTransactionEventList",
               "Get-MBCQTransactionList")
}

_awsArgumentCompleterRegistration $MBCQ_SelectCompleters $MBCQ_SelectMap

