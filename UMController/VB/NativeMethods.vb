Imports System.Runtime.InteropServices

Class NativeMethods

    Public Declare Function GetAsyncKeyState Lib "user32.dll" Alias "GetAsyncKeyState" (ByVal vkey As Integer) As Short

    Public Shared Function CloseCam() As Integer

        Select Case __CameraType
            Case ImageProcessing.Cameras.AndorNeo
                Return ANDORclose_cam()
            Case ImageProcessing.Cameras.AndorZyla
                Return ZYLAclose_cam()
        End Select
    End Function

    Public Shared Function GetRes(ByRef xresolution As UShort, ByRef yresolution As UShort) As Integer

        Select Case __CameraType
            Case ImageProcessing.Cameras.AndorNeo
                Return ANDORget_res(xresolution, yresolution)
            Case ImageProcessing.Cameras.AndorZyla
                Return ZYLAget_res(xresolution, yresolution)
        End Select
    End Function

    Public Shared Function GrabImage(ByVal image As UShort(), ByVal exposure As UShort) As Integer

        Select Case __CameraType
            Case ImageProcessing.Cameras.AndorNeo
                Return ANDORgrab_image(image, exposure)
            Case ImageProcessing.Cameras.AndorZyla
                Return ZYLAgrab_image(image, exposure)
        End Select
    End Function

    Public Shared Function InitCam(ByVal mode As Integer) As Integer

        Select Case __CameraType
            Case ImageProcessing.Cameras.AndorNeo
                Return ANDORinit_cam(mode)
            Case ImageProcessing.Cameras.AndorZyla
                Return ZYLAinit_cam(mode)
        End Select
    End Function

    <DllImport("AndorNeo.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="_close_cam@0")>
    Private Shared Function ANDORclose_cam() As Integer
    End Function

    <DllImport("AndorNeo.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="_get_res@8")>
    Private Shared Function ANDORget_res(ByRef xresolution As UShort, ByRef yresolution As UShort) As Integer
    End Function

    <DllImport("AndorNeo.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="_grab_image@8")>
    Private Shared Function ANDORgrab_image(ByVal image As UShort(), ByVal exposure As UShort) As Integer
    End Function

    'SDK calls for Andor Camera
    <DllImport("AndorNeo.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="_init_cam@4")>
    Private Shared Function ANDORinit_cam(ByVal mode As Integer) As Integer
    End Function

    <DllImport("AndorZyla.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="_close_cam@0")>
    Private Shared Function ZYLAclose_cam() As Integer
    End Function

    <DllImport("AndorZyla.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="_get_res@8")>
    Private Shared Function ZYLAget_res(ByRef xresolution As UShort, ByRef yresolution As UShort) As Integer
    End Function

    <DllImport("AndorZyla.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="_grab_image@8")>
    Private Shared Function ZYLAgrab_image(ByVal image As UShort(), ByVal exposure As UShort) As Integer
    End Function

    'SDK calls for Andor Zyla Camera
    <DllImport("AndorZyla.dll", CallingConvention:=CallingConvention.StdCall, EntryPoint:="_init_cam@4")>
    Private Shared Function ZYLAinit_cam(ByVal mode As Integer) As Integer
    End Function

End Class