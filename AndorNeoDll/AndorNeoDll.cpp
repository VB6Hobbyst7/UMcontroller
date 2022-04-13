// AndorNeoDll.cpp : Definiert die exportierten Funktionen für die DLL-Anwendung.
//
#include "stdafx.h"
#include "atcore.h"
#include <fstream>
#include <time.h>

using namespace std;

#define EXTRACTMONO16(SourcePtr) ( (SourcePtr[0] ) + ( SourcePtr[1] << 8 ) )
#define EXTRACTLOWPACKED(SourcePtr) ( (SourcePtr[0] << 4) + (SourcePtr[1] & 0xF) )
#define EXTRACTHIGHPACKED(SourcePtr) ( (SourcePtr[2] << 4) + (SourcePtr[1] >> 4) )

//Camera handle
AT_H Hndl;

//allocate image buffer
int BufferSize;
unsigned char* UserBuffer;
bool buffer_assigned = false;
int CAMMODE = 0;

extern "C" __declspec(dllexport) int __stdcall close_cam();

//write errorcode to logfile.
int handle_error(int errmsg, int errpos)
{
	ofstream logfile;
	logfile.open("AndorNeoCamera.log", ios::app);

	char dateStr[9]; _strdate_s(dateStr);
	char timeStr[9]; _strtime_s(timeStr);

	logfile << "Date: " << dateStr << " Time: " << timeStr << " Err Code: " << errmsg << " position: " << errpos << endl;
	logfile.close();

	close_cam();
	return errmsg;
}

//initializing the camera in mode "mode"
extern "C" __declspec(dllexport) int __stdcall init_cam(int mode)
{
	int err = AT_SUCCESS;

	if ((mode > 0) && (mode <= 8))CAMMODE = mode;
	else return -999; //copy to global variable

//initialize driver
	err = AT_InitialiseLibrary();
	if (err != AT_SUCCESS) return(handle_error(err, 1));

	//detect0 camera
	AT_64 iNumberDevices = 0;
	err = AT_GetInt(AT_HANDLE_SYSTEM, L"Device Count", &iNumberDevices);
	if (iNumberDevices <= 0)
		if (err != AT_SUCCESS)return(handle_error(err, 2));

	//get handle and open camera
	err = AT_Open(0, &Hndl);
	if (err != AT_SUCCESS)return(handle_error(err, 3));

	//set camera mode according to variable "CAMMODE"
	switch (CAMMODE)
	{
	case 1: {
		err = AT_SetEnumeratedString(Hndl, L"PreAmpGainControl", L"Gain 1 (11 bit)");
		if (err != AT_SUCCESS)return(handle_error(err, 4));
		break; }
	case 2: {
		err = AT_SetEnumeratedString(Hndl, L"PreAmpGainControl", L"Gain 2 (11 bit)");
		if (err != AT_SUCCESS) return(handle_error(err, 5));
		break; }
	case 3: {
		err = AT_SetEnumeratedString(Hndl, L"PreAmpGainControl", L"Gain 3 (11 bit)");
		if (err != AT_SUCCESS) return(handle_error(err, 6));
		break; }
	case 4: {
		err = AT_SetEnumeratedString(Hndl, L"PreAmpGainControl", L"Gain 4 (11 bit)");
		if (err != AT_SUCCESS) return(handle_error(err, 7));
		break; }
	case 5: {
		err = AT_SetEnumeratedString(Hndl, L"PreAmpGainControl", L"Gain 1 Gain 3 (16 bit)");
		if (err != AT_SUCCESS) return(handle_error(err, 8));
		break; }
	case 6: {
		err = AT_SetEnumeratedString(Hndl, L"PreAmpGainControl", L"Gain 1 Gain 4 (16 bit)");
		if (err != AT_SUCCESS) return(handle_error(err, 9));
		break; }
	case 7: {
		err = AT_SetEnumeratedString(Hndl, L"PreAmpGainControl", L"Gain 2 Gain 3 (16 bit)");
		if (err != AT_SUCCESS) return(handle_error(err, 10));
		break; }
	case 8: {
		err = AT_SetEnumeratedString(Hndl, L"PreAmpGainControl", L"Gain 2 Gain 4 (16 bit)");
		if (err != AT_SUCCESS) return(handle_error(err, 11));
		break; }
	}

	//set pixel encoding for 12 or 16 bit modes, respectively
	if (CAMMODE <= 4) // 11-bit modes selected
	{
		err = AT_SetEnumeratedString(Hndl, L"Pixel Encoding", L"Mono12Packed");
		if (err != AT_SUCCESS) return(handle_error(err, 12));
	}
	else // 16-bit modes selected
	{
		err = AT_SetEnumeratedString(Hndl, L"Pixel Encoding", L"Mono16");
		if (err != AT_SUCCESS) return(handle_error(err, 13));
	}

	//set readout rate
	err = AT_SetEnumeratedString(Hndl, L"Pixel Readout Rate", L"100 MHz");
	if (err != AT_SUCCESS) return(handle_error(err, 14));

	//enable spurious noise filter
	err = AT_SetBool(Hndl, L"SpuriousNoiseFilter", AT_TRUE);
	if (err != AT_SUCCESS) return(handle_error(err, 15));

	//Determines the number of bytes required to store a single frame
	AT_64 ImageSizeBytes;
	AT_GetInt(Hndl, L"Image Size Bytes", &ImageSizeBytes);
	BufferSize = static_cast<int>(ImageSizeBytes);

	//assign image buffer if not already assigned
	if (buffer_assigned == false)
	{
		UserBuffer = new __declspec(align(8)) unsigned char[BufferSize];
		buffer_assigned = true;
	}
	return AT_SUCCESS;
}

//Close the camera and free memory
extern "C" __declspec(dllexport) int __stdcall close_cam()
{
	if (buffer_assigned == true)
	{
		delete[] UserBuffer;
		buffer_assigned = false;
	}
	AT_Close(Hndl);
	AT_FinaliseLibrary();

	return AT_SUCCESS;
}

//grab a single image frame with exposure time 'exposure'
extern "C" __declspec(dllexport) int __stdcall grab_image(unsigned short data[], unsigned short exposure)
{
	unsigned char* Buffer;
	int stride, err;

TRY_AGAIN:
	//Set the exposure time for this camera
	err = AT_SetFloat(Hndl, L"ExposureTime", double(exposure * 0.001));
	if (err != AT_SUCCESS) return(handle_error(err, 16));

	//Pass allocated buffer to the SDK
	AT_QueueBuffer(Hndl, UserBuffer, BufferSize);

	//Start the Acquisition running
	err = AT_Command(Hndl, L"AcquisitionStart");
	if (err != AT_SUCCESS) return(handle_error(err, 17));

	int maxwait; //exposure is given in milliseconds!
	if (exposure < 500) maxwait = 1000; else maxwait = 2 * exposure;
	err = (AT_WaitBuffer(Hndl, &Buffer, &BufferSize, maxwait));
	if (err != AT_SUCCESS)
		if ((err == AT_ERR_TIMEDOUT) || (err == AT_ERR_BUFFERFULL) || (err == AT_ERR_HARDWARE_OVERFLOW))
		{
			AT_Command(Hndl, L"AcquisitionStop");
			AT_Flush(Hndl);
			handle_error(err, 18);
			init_cam(CAMMODE);
			goto TRY_AGAIN;
		}
		else return(handle_error(err, 18));

	if (CAMMODE <= 4) //read 11 bit data
	{
		int n = 0;
		for (int i = 0; i < BufferSize; i += 3)
		{
			data[n] = EXTRACTLOWPACKED(Buffer);
			data[n + 1] = EXTRACTHIGHPACKED(Buffer);
			Buffer += 3;
			n += 2;
		}
	}
	else //read 16 bit data
	{
		AT_64 stride64;
		err = AT_GetInt(Hndl, L"AOIStride", &stride64);
		if (err != AT_SUCCESS) return(handle_error(err, 19));

		stride = static_cast<int>(stride64);
		for (int i = 0; i < 2160; i++)
			for (int j = 0; j < 2560; j++)
				data[i * 2560 + (2560 - 1 - j)] = EXTRACTMONO16((Buffer + i * stride + 2 * j));
	}

	//Stop the aquisition
	err = AT_Command(Hndl, L"AcquisitionStop");
	if (err != AT_SUCCESS) return(handle_error(err, 20));

	//transfer data
	AT_Flush(Hndl);

	return AT_SUCCESS;
}

extern "C" __declspec(dllexport) int __stdcall get_res(unsigned short& xres, unsigned short& yres)
{
	int err;
	AT_64 X, Y;

	err = AT_GetInt(Hndl, L"SensorWidth", &X);
	if (err != AT_SUCCESS) return(handle_error(err, 21));

	err = AT_GetInt(Hndl, L"SensorHeight", &Y);
	if (err != AT_SUCCESS) return(handle_error(err, 22));

	xres = int(X);
	yres = int(Y);

	return AT_SUCCESS;
}