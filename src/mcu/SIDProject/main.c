/*
 * SIDProject.c
 *
 * Created: 2016.09.05. 22:42:28
 * Author : Norbert Laszlo
 
   ATmega2560 wiring:
   PA0..PA7   = SID D0..D7
   PC0..PC4   = SID A0..A4
   PC5        = SID !CS
   PC6        = SID R/W
   PC7        = SID RES
   PB5 (OC1A) = SID CLK
 
 */ 

#ifndef F_CPU
#define F_CPU 16000000UL
#endif

#include <avr/io.h>
#include <stdio.h>
#include <util/delay.h>
#include "NorSID.h"
#include "uart.h"

#define MAX_INPUT_BUFFER_SIZE 63

void PlayStartupSound();
void ReadNextToken(char* buffer, char separator);
short GetByteFromHex(char d1, char d2);
char IsHexaDigit(char d);
char GetHexaDigitValue(char d);

int main(void)
{
	// Initializes serial communication via stdio
	uart_init();
	stdout = &uart_output;
	stdin = &uart_input;
	
	InitSID();

	ResetSID();
		
	SetVolume(MAX_VOLUME);
	
	PlayStartupSound();
	
	char input;
	char buffer[MAX_INPUT_BUFFER_SIZE + 1];
	BYTE addr;
	BYTE data;
	BYTE voice = SID_VOICE_1;
	
	/* Replace with your application code */
    while (1) 
    {
		char ch = getchar();
		switch (ch)
		{
			case 'i': // get version
				puts("NorSID.v1.0.0.0");
				break;
			case 'r': // reset SID
				ResetSID();
				break;
			case 'd': // play demo sound
				PlayStartupSound();
				break;
			case 'w': // write SID reg.
				{
					buffer[0] = getchar();
					buffer[1] = getchar();
					addr = GetByteFromHex(buffer[0], buffer[1]);
					if (addr > 28 || addr < 0)
						break;
					buffer[0] = getchar();
					buffer[1] = getchar();
					data = GetByteFromHex(buffer[0], buffer[1]);
					if (addr < 0)
						break;
					WriteSID(addr, data);
				}
				break;
			case 'm': // set master volume
				{
					buffer[0] = getchar();
					data = GetByteFromHex('0', buffer[0]);
					SetVolume(data);
				}
				break;
			case 'v': // select voice 1, 2 or 3
				{
					ch = getchar();
					switch (ch)
					{
						case '1':
							voice = SID_VOICE_1;
							break;
						case '2':
							voice = SID_VOICE_2;
							break;
						case '3':
							voice = SID_VOICE_3;
							break;
					}
				}
				break;
			case '0': // gate off
				GateOff(voice);
				break;
			case '1': // gate on
				GateOn(voice);
				break;
			case 'f': // set frequency: f####.## (number)
				{
					addr = 0;
					do { ch = getchar(); buffer[addr++] = ch; } while (ch != '.');
					buffer[addr] = '\0';
					SetFrequency(voice, SID_FQ_HZ(atoi(buffer)));
				}
				break;
			case 'a': // set adsr: a#### (4 hexa digit)
				{
					buffer[0] = getchar();
					buffer[1] = getchar();
					buffer[2] = getchar();
					buffer[3] = getchar();
					addr = GetByteFromHex(buffer[0], buffer[1]);
					data = GetByteFromHex(buffer[2], buffer[3]);
					WriteSID(VOICE_REG(voice, REG_ATT_DEC), addr);
					WriteSID(VOICE_REG(voice, REG_SUS_REL), data);
				}
				break;
			case 't': // set waveform t[0][1][2][3], 0 = mute, 1 = noise, 1 = saw, 2 = triangle, 3 = square
				{
					ch = getchar();
					switch (ch)
					{
						case '0':
							SetWaveform(voice, 0);
							break;
						case '1':
							SetWaveform(voice, BIT_CTRL_NOISE);
							break;
						case '2':
							SetWaveform(voice, BIT_CTRL_SAW);
							break;
						case '3':
							SetWaveform(voice, BIT_CTRL_TRIANGLE);
							break;
						case '4':
							SetWaveform(voice, BIT_CTRL_SQUARE);
							break;
					}
				}
				break;
			case 'T': // set multi waveform Tnnnn, noise, square, saw, triangle  e.g.: T0101
				{
					data = 0;
					ch = getchar();
					if (ch != '0') data |= BIT_CTRL_NOISE;
					ch = getchar();
					if (ch != '0') data |= BIT_CTRL_SQUARE;
					ch = getchar();
					if (ch != '0') data |= BIT_CTRL_SAW;
					ch = getchar();
					if (ch != '0') data |= BIT_CTRL_TRIANGLE;
					SetWaveform(voice, data);
				}
				break;
			case 'p': // set pulsewidth: p### (3 hexa digit)
				{
					buffer[0] = getchar();
					buffer[1] = getchar();
					buffer[2] = getchar();
					SetPulseWidth(voice, GetByteFromHex('0', buffer[0]) * 256 + GetByteFromHex(buffer[1], buffer[2]));
				}
				break;
			case 'F': // set filter mode: F[l,h,b,0,c###,r#,e###,f###]
				{
					ch = getchar();
					switch (ch)
					{
						case 'l':
							SetFilterMode(BIT_MODE_LP);
							EnableFilters(BIT_FILT_1 | BIT_FILT_2 | BIT_FILT_3);
							break;
						case 'h':
							SetFilterMode(BIT_MODE_HP);
							EnableFilters(BIT_FILT_1 | BIT_FILT_2 | BIT_FILT_3);
							break;
						case 'b':
							SetFilterMode(BIT_MODE_BP);
							EnableFilters(BIT_FILT_1 | BIT_FILT_2 | BIT_FILT_3);
							break;
						case '0':
							EnableFilters(0);
							break;
						case 'c':
							buffer[0] = getchar();
							buffer[1] = getchar();
							buffer[2] = getchar();
							SetFilterCutoff(GetByteFromHex('0', buffer[0]) * 256 + GetByteFromHex(buffer[1], buffer[2]));
							break;
						case 'r':
							buffer[0] = getchar();
							SetFilterResonance(GetByteFromHex('0', buffer[0]));
							break;
						case 'e':
							buffer[0] = getchar();
							buffer[1] = getchar();
							buffer[2] = getchar();
							EnableFilters(
								(buffer[0] != '0' ? BIT_FILT_1 : 0) |
								(buffer[1] != '0' ? BIT_FILT_2 : 0) |
								(buffer[2] != '0' ? BIT_FILT_3 : 0)
								);
							break;
						case 'f':
							buffer[0] = getchar();
							buffer[1] = getchar();
							buffer[2] = getchar();
							SetFilterMode(
								(buffer[0] != '0' ? BIT_MODE_LP : 0) |
								(buffer[1] != '0' ? BIT_MODE_BP : 0) |
								(buffer[2] != '0' ? BIT_MODE_HP : 0)
							);
							break;
					}
					
				}
				break;
			case 'c': // set control registers: c#
				ch = getchar();
				data = GetByteFromHex('0', ch);
				SetControlRegisters(voice, data);
				break;
			case '*': // all voice off
				GateOff(SID_VOICE_1);
				GateOff(SID_VOICE_2);
				GateOff(SID_VOICE_3);
				break;
			case 'n': // set note frequency: nNN9TTFF, NN=note (e.g. F$, A.); 9=octave 0..7; TT=transpose -6..+6 in hex; FF=fine tune -24...+24 in hex
				buffer[0] = getchar();
				buffer[1] = getchar();
				buffer[2] = getchar();
				
				buffer[3] = getchar();
				buffer[4] = getchar();
				addr = GetByteFromHex(buffer[3], buffer[4]);
				
				buffer[3] = getchar();
				buffer[4] = getchar();
				data = GetByteFromHex(buffer[3], buffer[4]);
				
				SetFrequencyByNote(voice, buffer, (char)addr, (char)data);
				break;
		}
	}
}


void PlayStartupSound()
{
	SetVolume(15);
	SetAdsr(SID_VOICE_1, 0, 0, 15, 10);
	SetWaveform(SID_VOICE_1, BIT_CTRL_TRIANGLE);

	for (int i = 300; i < 2000; i += 200)
	{
		SetFrequency(SID_VOICE_1, SID_FQ_HZ(i));
		GateOn(SID_VOICE_1);
		_delay_ms(30);
		GateOff(SID_VOICE_1);
		_delay_ms(50);	
	}

	SetAdsr(SID_VOICE_2, 0, 0, 15, 10);
	SetWaveform(SID_VOICE_2, BIT_CTRL_SAW);

	for (int i = 2000; i > 300; i -= 200)
	{
		SetFrequency(SID_VOICE_2, SID_FQ_HZ(i));
		GateOn(SID_VOICE_2);
		_delay_ms(30);
		GateOff(SID_VOICE_2);
		_delay_ms(50);
	}
	
	SetAdsr(SID_VOICE_3, 0, 0, 15, 12);
	SetWaveform(SID_VOICE_3, BIT_CTRL_NOISE);
	SetFrequency(SID_VOICE_3, SID_FQ_HZ(500));
	GateOn(SID_VOICE_3);
	_delay_ms(300);
	GateOff(SID_VOICE_3);
}


void ReadNextToken(char* buffer, char separator)
{
	int i = 0;
	
	do
	{
		buffer[i++] = getchar();
	}
	while (buffer[i - 1] != separator && i < MAX_INPUT_BUFFER_SIZE);
	
	buffer[i - 1] = '\0';
}

short GetByteFromHex(char d1, char d2)
{
	if (!IsHexaDigit(d1) || !IsHexaDigit(d2))
	return -1;
	
	return GetHexaDigitValue(d1) * 16 + GetHexaDigitValue(d2);
}

char IsHexaDigit(char d)
{
	return (d >= 48 && d <= 57) || (d >= 97 && d <= 102) ? 1 : 0;
}

char GetHexaDigitValue(char d)
{
	if (d >= 48 && d <= 57)
	return d - 48;
	if (d >= 97 && d <= 102)
	return d - 87;
}
