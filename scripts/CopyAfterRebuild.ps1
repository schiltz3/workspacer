$workspacer = Get-Process -Name workspacer -ErrorAction SilentlyContinue
if($workspacer){
    $workspacer | Stop-Process
    Sleep 1 
    if(!$workspacer.HasExited){
    $workspacer | Stop-Process -Force
    }
}

$workspacerwatcher = Get-Process -Name workspacer.Watcher -ErrorAction SilentlyContinue
if($workspacerwatcher){
    $workspacerwatcher | Stop-Process
    Sleep 1 
    if(!$workspacerwatcher.HasExited){
    $workspacerwatcher | Stop-Process -Force
    }
}
Remove-Variable workspacerwatcher
Remove-Variable workspacer

Copy-Item -Path 'D:\git\workspacer\src\workspacer\bin\Release\net5.0-windows\win10-x64\*' -Destination 'C:\Program Files\workspacer' -Recurse -Force

$workspacer = Get-Process -Name workspacer -ErrorAction SilentlyContinue
if(!$workspacer){
    Start-Process -FilePath "C:\Program Files\workspacer\workspacer.exe"
}
Remove-Variable workspacer