@echo off
c:
IF EXIST "Figura.jpg" (goto borrar) else (goto crear)
:borrar
del C:\Users\DELL\Downloads\CarpetsJosue\RepositorioPractico-main\PruebaABB\bin\Debug\Figura.jpg
C:\"Program Files\Graphviz"\bin\DOT -Tjpg -O Figura
break

:crear

C:\"Program Files\Graphviz"\bin\DOT -Tjpg -O Figura
break