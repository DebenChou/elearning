c:\windows\system32\inetsrv\appcmd.exe set config /section:serverRuntime /appConcurrentRequestLimit:100000

reg add HKLM\System\CurrentControlSet\Services\HTTP\Parameters /v MaxConnections /t REG_DWORD /d 100000

echo �޸�Ӧ�ó���ض��г���Ϊ65525
c:\windows\system32\inetsrv\inetmgr.exe

echo �޸�processModel�ڵ���ӣ� requestQueueLimit="100000"
notepad %systemroot%\Microsoft.Net\Framework64\v2.0.50727\CONFIG\machine.config

pause