Module Globals

    Public __BrCorrClip16 As Boolean = False

    Public __BrCorrEnabled As Boolean = False

    Public __BrightnessCorrDirection As Byte = 1

    Public __BrightnessCorrFactors() As Double

    Public __BrightnessCorrFactorsMax As Double

    Public __CameraBackground As UShort

    Public __CameraIsRotated As Boolean = False

    Public __CameraMode As Integer

    Public __CameraType As Integer

    Public __CurrentExposure As UShort

    Public __HDRIclip As Integer

    Public __HDRIon As Boolean

    Public __HRratio As UInteger

    Public __LeicaPort As New IO.Ports.SerialPort("COM2", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.Two)

    Public __MicosPort As New IO.Ports.SerialPort("COM1", 19200, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One)

    Public __MotorFocusPresent As Boolean = True

    Public __NumLienarStages As Integer = 2

    Public __OverExoposureLimit As Integer

    Public __ScalebarLength As Integer

    Public __ShowOverExposed As Boolean = False

    Public __ShowUnderExposed As Boolean = False

    Public __StagesAcc As Integer = 50

    Public __StagesVel As Integer = 50

    Public __StepperPresent As Boolean = True

    Public __UnderExposureLimit As Integer

    Public __WaitForStages As Integer = 0

    Public __xyVoxelsize As Double

    Public __zVoxelsize As Double

End Module