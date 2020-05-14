﻿autorest --verbose --debug --v3 --input-file=mea.swagger.json --output-folder=. --namespace=Kmd.Momentum.Mea.Client --csharp --override-client-name=InternalClient --add-credentials

(Get-Content "InternalClient.cs") |
	Foreach-Object {$_ -replace 'public partial class InternalClient', 'internal partial class InternalClient'} | 
	Set-Content "InternalClient.cs"

(Get-Content "IInternalClient.cs") | 
	Foreach-Object {$_ -replace 'public partial interface IInternalClient', 'internal partial interface IInternalClient'} |
	Set-Content "IInternalClient.cs"

(Get-Content "InternalClientExtensions.cs") | 
	Foreach-Object {$_ -replace 'public static partial class InternalClientExtensions', 'internal static partial class InternalClientExtensions'} |
	Set-Content "InternalClientExtensions.cs"