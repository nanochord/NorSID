/*
 * NorSID.c
 *
 * Created: 2016.09.06. 23:40:19
 * Author : Norbert Laszlo
 */ 

#ifndef F_CPU
#define F_CPU 16000000UL // 16 MHz clock speed
#endif

#include <avr/io.h>
#include <util/delay.h>
#include "NorSID.h"

#define MAX4BIT(n) (n > 15 ? 15 : n)

BYTE G_SID_RegMap[25] = { 0 };

// SID Note Frequency Table, assumed SID clock is 1MHz
unsigned int SID_Frq_Table[] = {
	274, 291, 308, 326, 346, 366, 388, 411, 435, 461, 489, 518,							// C0 (16.35 Hz)
	549, 581, 616, 652, 691, 732, 776, 822, 871, 923, 978, 1036,						// C1
	1097, 1163, 1232, 1305, 1383, 1465, 1552, 1644, 1742, 1845, 1955, 2071,				// C2
	2195, 2325, 2463, 2610, 2765, 2930, 3104, 3288, 3484, 3691, 3910, 4143,				// C3
	4650, 4927, 5220, 5530, 5859, 6207, 6577, 6968, 7382, 7821, 8286, 8779,				// C4
	9301, 9854, 10440, 11060, 11718, 12415, 13153, 13935, 14764, 15642, 16572, 17557,	// C5
	18601, 19709, 20897, 22121, 23436, 24830, 26306, 27871, 29528, 31234, 33144, 35115,	// C6
	37203, 39415, 41759, 44242, 46873, 49660, 52613, 55741, 59056, 62567				// C7...A7# (3729.31 Hz)
};


// Initializes the Nor SID environment
void InitSID()
{
	DDRC = 0xff;
	DDRA = 0xff;
	DDRB |= (1 << PB5);
	//DDRB = 0b10100000;

	// Set output compare register
	OCR1A = 7;

	// Set compare output mode Toggle (COM=01)
	TCCR1A = (1 << COM1A0);
	
	TCCR1B =
	// Set CTC mode (WGM=0100)
	(1 << WGM12) |
	// Set clock select f=fclk_io/2*N*(1+OCR)
	// 1 MHz = 16 MHz / 2*1*(1+0) -> N=1, OCR=7 --->>> CS=010
	(1 << CS10);
}

// Resets the SID
void ResetSID()
{
	PORTC &= ~(1 << SID_RES);
	_delay_us(100);
	PORTC |= (1 << SID_RES);
	
	/*
	for(int i=0; i < 25; i++)
	{
		WriteSID(i, 0);
		G_SID_RegMap[i] = 0;
	}*/
}

// Writes data into the SID
void WriteSID(BYTE addr, BYTE data)
{
	addr &= 0x1F;
	PORTC = addr | (1 << SID_CS) | (1 << SID_RW) | (1 << SID_RES);
	_delay_us(2);
	
	PORTA = data;
	_delay_us(2);
	
	PORTC &= ~((1 << SID_CS) | (1 << SID_RW));
	PORTC = addr | (1 << SID_RES);
	_delay_us(2);
	
	PORTC = addr | (1 << SID_CS) | (1 << SID_RW) | (1 << SID_RES);
	_delay_us(2);
	
	G_SID_RegMap[addr] = data;
}

void SetVolume(BYTE volume)
{
	WriteSID(REG_MODVOL, (G_SID_RegMap[REG_MODVOL] & 0xf0) | MAX4BIT(volume));
}

void SetFilterMode(BYTE filterMode)
{
	WriteSID(REG_MODVOL, (G_SID_RegMap[REG_MODVOL] & 0x0f) | (filterMode & 0xf0));
}

void SetFilterModeAndVolume(BYTE filterMode, BYTE volume)
{
	WriteSID(REG_MODVOL, (filterMode & 0xf0) | MAX4BIT(volume));
}

void EnableFilters(BYTE filters)
{
	WriteSID(REG_RESFILT, (G_SID_RegMap[REG_RESFILT] & 0xf0) | (filters & 0x0f));
}

void SetFilterResonance(BYTE level)
{
	WriteSID(REG_RESFILT, (G_SID_RegMap[REG_RESFILT] & 0x0f) | (MAX4BIT(level) << 4));
}

void SetFilterResonanceAndEnable(BYTE level, BYTE filters)
{
	WriteSID(REG_RESFILT, (MAX4BIT(level) << 4) | (filters & 0x0f));
}

void SetFilterCutoff(int cutoff)
{
	WriteSID(REG_FILTER_CUTOFF_HI, (cutoff >> 3) & 0xff);
	WriteSID(REG_FILTER_CUTOFF_LO, cutoff & 0x07);
}

void SetFrequency(BYTE voice, int freq)
{
	WriteSID(VOICE_REG(voice, REG_FREQ_LO), freq & 0xff);
	WriteSID(VOICE_REG(voice, REG_FREQ_HI), (freq & 0xff00) >> 8);
}

void SetPulseWidth(BYTE voice, int pw)
{
	WriteSID(VOICE_REG(voice, REG_PW_LO), pw & 0xff);
	WriteSID(VOICE_REG(voice, REG_PW_HI), (pw & 0xf00) >> 4);
}

void SetAdsr(BYTE voice, BYTE attack, BYTE decay, BYTE sustain, BYTE release)
{
	WriteSID(VOICE_REG(voice, REG_ATT_DEC), (MAX4BIT(attack) << 4) | MAX4BIT(decay));
	WriteSID(VOICE_REG(voice, REG_SUS_REL), (MAX4BIT(sustain) << 4) | MAX4BIT(release));
}

void SetWaveform(BYTE voice, BYTE waveform)
{
	WriteSID(VOICE_REG(voice, REG_CONTROL), (G_SID_RegMap[VOICE_REG(voice, REG_CONTROL)] & 0xf) | (waveform & 0xf0));
}

void GateOn(BYTE voice)
{
	WriteSID(VOICE_REG(voice, REG_CONTROL), G_SID_RegMap[VOICE_REG(voice, REG_CONTROL)] | 1);
}

void GateOff(BYTE voice)
{
	WriteSID(VOICE_REG(voice, REG_CONTROL), G_SID_RegMap[VOICE_REG(voice, REG_CONTROL)] & 0xfe);
}

void SetControlRegisters(BYTE voice, BYTE ctrlData)
{
	WriteSID(VOICE_REG(voice, REG_CONTROL), (G_SID_RegMap[VOICE_REG(voice, REG_CONTROL)] & 0xf0) | (ctrlData & 0x0f));
}

void SetFrequencyByNote(BYTE voice, const char* note, char transp, char tune)
{
	char offs = 0;
	char oct = 0;
	
	switch (note[0])
	{
		case 'C':
			offs = 0;
			if (note[1] == '$') offs++;
			break;
		case 'D':
			offs = 2;
			if (note[1] == '$') offs++;
			break;
		case 'E':
			offs = 4;
			break;
		case 'F':
			offs = 5;
			if (note[1] == '$') offs++;
			break;
		case 'G':
			offs = 7;
			if (note[1] == '$') offs++;
			break;
		case 'A':
			offs = 9;
			if (note[1] == '$') offs++;
			break;
		case 'B':
			offs = 11;
			break;
	}
	
	oct = note[2] - '0';
	
	if (transp != 0)
	{
		if (transp > 6)
			transp = 6;
		else if (transp < 6)
			transp = -6;
		
		oct += transp;
	}

	if (oct < 0) oct = 0;
	else if (oct > 7) oct = 7;
	else if (oct == 7 && offs == 11) offs--;

	int diff = 0;
	unsigned int freq = SID_Frq_Table[oct * 12 + offs];
	unsigned int freq2;

	if (tune < 0)
	{		
		oct--;
		if (oct < 0)
			diff = freq;
		else
		{
			freq2 = SID_Frq_Table[oct * 12 + offs];
			diff = freq - freq2;
		}
	}
	else if (tune > 0)
	{
		oct++;
		if (oct > 7)
			diff = 65535 - freq;
		else
		{
			freq2 = SID_Frq_Table[oct * 12 + offs];
			diff = freq2 - freq;
		}
	}
	
	if (diff != 0)
	{
		if (tune > 24)
			tune = 24;
		else if (tune < -24)
			tune = -24;
		
		diff /= 2 * tune;
		freq += diff;
	}
	
	WriteSID(VOICE_REG(voice, REG_FREQ_LO), freq & 0xff);
	WriteSID(VOICE_REG(voice, REG_FREQ_HI), (freq & 0xff00) >> 8);
}