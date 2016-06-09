
MsgBox "calm"

SysGet, MonitWh, Monitor
Width := MonitWhRight
Height := MonitWhBottom

!L::
Return

!,::
GoSub, ActWinUnderMouse
X := Floor(Width/2)
Y := Floor(7*Height/8)
Click %X%, %Y%							; Space is important. 활성창xy로부터 새로계산-_-
return

^7::
send ^x
vars:=clipboard
clipboard='
send ^v
clipboard:=vars
send ^v
clipboard='
send ^v
return

