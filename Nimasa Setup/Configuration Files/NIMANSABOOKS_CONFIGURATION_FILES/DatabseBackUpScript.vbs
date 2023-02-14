Dim adoCommand
Dim strConnectionstring
Dim strBackupFile
Dim strServreName
Dim strDatabaseName
Dim strfileName

' Specify backup path to save the .bak file.
strBackupFile = "C:\NIMANSABOOKS_BACKUP\"

'Specify the name of server and instance if present to which backup file need to be created .
strServreName ="DESKTOP-2A05F4R"

'Specify the database name to which backup file need to be generated.
strDatabaseName ="nimansaDB"

' Specify connection string to Master Database on SQL server as best practise.
strConnectionstring= "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MASTER;Data Source=" & strServreName


' Backup the database .
Set adoCommand = CreateObject("ADODB.Command")
On Error Resume Next
adoCommand.ActiveConnection = strConnectionstring
If (Err.Number <> 0) Then
Wscript.Echo "Unable to connect to SQL database."
Wscript.Echo Err.Description
Wscript.Quit
End If
On Error GoTo 0
strfileName = strBackupFile & replace(replace(now,"/","_"),":","_") & "_" & strDatabaseName & ".bak"
adoCommand.CommandText = " Create database " & strDatabaseName
adoCommand.CommandText = "BackUp DATABASE "& strDatabaseName &" to disk='" & strfileName & "'"
adoCommand.Execute
MsgBox "BackUp Completed Successfully"
Set adoCommand = Nothing