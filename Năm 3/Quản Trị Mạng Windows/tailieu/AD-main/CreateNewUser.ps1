[void] [System.Reflection.Assembly]::LoadWithPartialName("System.Drawing") 
[void] [System.Reflection.Assembly]::LoadWithPartialName("System.Windows.Forms") 

$ScriptDir = $FileBrowser.FileName -replace $FileBrowser.SafeFileName ,""
$timestamp = Get-Date -Format “yyyyMMdd-HHmmss”
$logname = "CreateMultiUser-" + $timestamp + ".csv"

$FileBrowser = New-Object System.Windows.Forms.OpenFileDialog -Property @{ 
    InitialDirectory = $ScriptDir
    Filter = 'CSV (*.csv)|*.csv'
}
$null = $FileBrowser.ShowDialog()


Set-Content -Path $ScriptDir$logname -Value 'User,status'


Import-Csv $FileBrowser.FileName | ForEach-Object {
$Name = $_.Name
$GivenName = $_.GivenName
$Surname = $_.Surname
$AccountName = $_.AccountName
$UserPrincipalName = $_.UserPrincipalName
$Pathaddress = $_.Pathaddress
$Password = $_.PasswordInput
$Status = $_.Status



#Check if the user account already exists in AD
if (Get-ADUser -F {SamAccountName -eq $AccountName})
{
#If user does exist, output a warning message
Write-Warning "A user account $AccountName has already exist in Active Directory."
$Log = "Has already exist"
}
else
{
#If a user does not exist then create a new user account
New-ADUser -Name "$($Name)" -GivenName "$($GivenName)" -Surname "$($Surname)" -SamAccountName "$($AccountName)" -UserPrincipalName "$($UserPrincipalName)" -Path "$($Pathaddress)" -AccountPassword(ConvertTo-SecureString $Password -AsPlainText -Force) -Enabled $true
Get-ADUser $AccountName -Properties CanonicalName, Enabled, GivenName, Surname, Name, UserPrincipalName, samAccountName, whenCreated, PasswordLastSet  | Select CanonicalName, Enabled, GivenName, Surname, Name, UserPrincipalName, samAccountName, whenCreated, PasswordLastSet
$Log = "Success"
}



Write-output $AccountName","$Log | Out-File $ScriptDir$logname -Append -Encoding utf8
Write-Host $script
}

Write-Host "Finish Create MultiUser. Log file store at $($ScriptDir)$($logname)"
read-host "Press ENTER to continue..."