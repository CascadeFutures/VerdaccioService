# Verdaccio

## On Server

- install [node and npm](https://nodejs.org/en/download/)
- copy the verdaccioservice.exe and config.yaml to a folder
- cd to that folder on elevated cmd
- install the service
- open the port 4873 on firewall.

### Install service

C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe  .\VerdaccioService.exe

### Unistall service

C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe -u .\VerdaccioService.exe

## On Users Machines

npm config set @cascade:registry http://172.27.74.150:4873

npm adduser --scope @cascade
