for /d /r . %%d in (bin,obj,packages,TestResults) do @if exist "%%d" rd /s/q "%%d"
