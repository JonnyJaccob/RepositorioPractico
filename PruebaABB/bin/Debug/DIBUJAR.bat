@echo off
c:
IF EXIST "Figura.jpg" (goto borrar) else (goto crear)
:borrar
del C:\Users\jacco\source\repos\PruebaABB\bin\Debug\Figura.jpg
C:\"Program Files (x86)\Graphviz"\bin\DOT -Tjpg -O Figura
break

:crear

C:\"Program Files (x86)\Graphviz"\bin\DOT -Tjpg -O Figura
break