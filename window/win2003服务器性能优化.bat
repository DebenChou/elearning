cd c:\Inetpub\AdminScripts\
adsutil.vbs set w3svc/AspRequestQueueMax 65525

reg add HKLM\System\CurrentControlSet\Services\HTTP\Parameters /v MaxConnections /t REG_DWORD /d 100000

echo �޸�Ӧ�ó���ض��г���Ϊ65525
c:\windows\system32\inetsrv\inetmgr.exe

echo �޸�processModel�ڵ���ӣ� requestQueueLimit="100000"
notepad %systemroot%\Microsoft.Net\Framework\v2.0.50727\CONFIG\machine.config

pause
