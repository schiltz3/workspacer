$workspacer = Get-Process -Name workspacer -ErrorAction SilentlyContinue
if($workspacer){
    $workspacer | Stop-Process
    Sleep 1 
    if(!$firefox.HasExited){
    $workspacer | Stop-Process -Force
    }
}
Remove-Variable workspacer

Copy-Item -Path 'D:\git\workspacer\src\workspacer\bin\Release\net5.0-windows\win10-x64\*' -Destination 'C:\Program Files\workspacer' -Recurse -Force

$workspacer = Get-Process -Name workspacer -ErrorAction SilentlyContinue
if(!$workspacer){
    Start-Process -FilePath "C:\Program Files\workspacer\workspacer.exe"
}
Remove-Variable workspacer