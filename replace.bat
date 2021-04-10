@echo off

echo "Killing"
TASKKILL /IM VirtualDesktopGridSwitcher.exe /F

echo "Waiting"
ping 127.0.0.1 -n 2 > nul

echo "Copying"
copy /Y bin\Release\VirtualDesktopGridSwitcher.exe D:\Apps\VirtualDesktopGridSwitcher

D:
cd \Apps\VirtualDesktopGridSwitcher

echo "Starting"
start /B VirtualDesktopGridSwitcher.exe

echo "Complete"
