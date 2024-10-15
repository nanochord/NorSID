# NorSID
NorSID is a simple SID chip based serial port synthesizer.
It was one of my hobby projects. I had found a couple of 6581 and 8580 SID
chips in my drawer and decided to come them to life again. An Arduino Mega
2560 board is used to drive the SID. The NorSID device can be controlled through
serial port using a custom protocol. A windows desktop client has
also been made which can be used to access the features of the connected SID
device.

The Arduino project can be built using AtmelStudio.
The desktop client application can be built using VisualStudio.

![image](./images/NOR-SID.jpg "NorSID desktop client application")
<br />

## Wiring
| AT Mega | SID |
| ------- | --- |
| PA0..PA7 | D0..D7 |
| PC0..PC4 | A0..A4 |
| PC5 | CS |
| PC6 | R/W |
| PC7 | RES |
| PB5 (OC1A) | CLK |

![image](./images/WP_20160911_23_54_41_Pro.jpg "NorSID prototype")

## NorSID serial protocol

| Command | Description | Example |
| ------- | ----------- | ------- |
| i | Gets the version of the NorSID firmware | i |
| r | Resets the SID chip | r |
| d | Plays demo sound | d |
| w##$$ | Writes value into SID register. ##=hexadecimal address 00-1B, $$=hexadecimal value | w03A1 |
| m# | Sets the master volume. #=hexadecimal volume 0-F | mA |
| v# | Selects voice channel. All sound operations uses the selected channel. #=1, 2 or 3 | v2 |
| 0 | Gate off | 0 |
| 1 | Gate on | 1 |
| f####.## | Set frequency in Hz | f404.24 |
| a#### | Set ADSR | a23AF |
| t# | Set waveform. 0=mute, 1=noise, 2=saw, 3=triangle, 4=square | t4 |
| Tnnnn | Set multi waveform. | T0101 |
| p### | Set pulse width. (3 hexa digits) | p1C4 |
| Fl | Set low pass filter mode. | Fl |
| Fh | Set high pass filter mode. | Fh |
| Fb | Set high bypass filter mode. | Fb |
| F0 | Disable filters. | F0 |
| Fc### | Set filter cutoff frequency. (3 hexa digits) | FcAA8 |
| Fr# | Set filter resonance. (1 hexa digit) | Fr7 |
| Fe@@@ | Enable multiple filters. Filter1, Filter2, Filter3, @=0-1 | Fe001 |
| Ff@@@ | Set multiple filter mode. LP, BP, HP, @=0-1 | Ff111 |
| c# | Set control registers. | c2 |
| * | All voice off. | * |
| nNN9TTFF | Set frequency by note. NN=note (e.g. F$, A.); 9=octave 0..7; TT=transpose -6..+6 in hex, FF=fine tune -24..+24 in hex | nC.30000 |