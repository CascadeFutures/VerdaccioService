On Server
-- install node and npm 

-- copy the verdaccioservice.exe and config.yaml to a folder
-- install the service
-- open the port 4873 on firewall.

install service
C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe  .\VerdaccioService.exe
Unistall service
C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe -u .\VerdaccioService.exe


On users machines
npm config set @cascade:registry http://localhost:4873
npm adduser --scope @cascade





