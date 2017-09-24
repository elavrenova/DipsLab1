#!/bin/bash
mes=`ls -a`
echo $mes
dotnet test ./TestsDipsLab1/TestsDipsLab1.csproj
