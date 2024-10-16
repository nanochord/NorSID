/*
 * NorSID.h
 *
 * Created: 2016.09.06. 23:41:19
 * Author: Norbert Laszlo
 */ 


#ifndef NORSID_H_
#define NORSID_H_

#define SID_CS PC5
#define SID_RW PC6
#define SID_RES PC7

// Relative addresse of SID voice registers
#define REG_FREQ_LO			0x00
#define REG_FREQ_HI			0x01
#define REG_PW_LO			0x02
#define REG_PW_HI			0x03
#define REG_CONTROL			0x04
#define REG_ATT_DEC			0x05
#define REG_SUS_REL			0x06

// Offset of SID voice registers
#define SID_VOICE_1			0x00
#define SID_VOICE_2			0x07
#define SID_VOICE_3			0x0E

// Calculates the physical address of a voice register
#define VOICE_REG(x, y) (x+y)

// Filter registers
#define REG_FILTER_CUTOFF_LO	0x15
#define REG_FILTER_CUTOFF_HI	0x16
#define REG_RESFILT				0x17
#define REG_MODVOL				0x18

// Voice register bits
#define BIT_CTRL_NOISE			0x80
#define BIT_CTRL_SQUARE			0x40
#define BIT_CTRL_SAW			0x20
#define BIT_CTRL_TRIANGLE		0x10
#define BIT_CTRL_TEST			0x08
#define BIT_CTRL_RINGMOD		0x04
#define BIT_CTRL_SYNC			0x02
#define BIT_CTRL_GATE			0x01

// Filter register bits
#define BIT_FILT_EX				0x08
#define BIT_FILT_3				0x04
#define BIT_FILT_2				0x02
#define BIT_FILT_1				0x01
#define BIT_MODE_3OFF			0x80
#define BIT_MODE_HP				0x40
#define BIT_MODE_BP				0x20
#define BIT_MODE_LP				0x10

// Calculates the LSB and MSB bytes of a specified voice frequency
#define SID_FQ_HZ(x)				((int)(x/.0596))
#define SID_FQ_LOBYTE(x)			(SID_FQ_HZ(x) & 0xFF)
#define SID_FQ_HIBYTE(x)			(SID_FQ_HZ(x) & 0xFF00) >> 8)

typedef unsigned char BYTE;

#define MIN_VOLUME 0
#define MAX_VOLUME 15

// Initializes the NorSID environment
void InitSID();

// Resets the SID
void ResetSID();

// Writes data into the SID
void WriteSID(BYTE addr, BYTE data);

// Filter setting functions
void SetVolume(BYTE volume);
void SetFilterMode(BYTE filterMode);
void SetFilterModeAndVolume(BYTE filterMode, BYTE volume);

void EnableFilters(BYTE filters);
void SetFilterResonance(BYTE level);
void SetFilterResonanceAndEnable(BYTE level, BYTE filters);

void SetFilterCutoff(int cutoff);

// Voice setting functions
void SetFrequency(BYTE voice, int freq);
void SetFrequencyByNote(BYTE voice, const char* note, char transp, char tune);
void SetPulseWidth(BYTE voice, int pw);
void SetAdsr(BYTE voice, BYTE attack, BYTE decay, BYTE sustain, BYTE release);
void SetWaveform(BYTE voice, BYTE waveform);
void GateOn(BYTE voice);
void GateOff(BYTE voice);
void SetControlRegisters(BYTE voice, BYTE ctrlData);


#endif /* NORSID_H_ */