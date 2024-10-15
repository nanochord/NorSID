/*
 * uart.c
 *
 * Created: 2016.06.27. 23:15:37
 * Author: Norbert Laszlo
 */ 

#include <avr/io.h>
#include <stdio.h>

#ifndef F_CPU
#define F_CPU 16000000UL
#endif

#ifndef BAUD
#define BAUD 38400
#endif
#include <util/setbaud.h>


// uart initialization
void uart_init(void) {
	UBRR0H = UBRRH_VALUE;
	UBRR0L = UBRRL_VALUE;
	
	#if USE_2X
	UCSR0A |= _BV(U2X0);
	#else
	UCSR0A &= ~(_BV(U2X0));
	#endif
	
	// 8 bit data
	UCSR0C = _BV(UCSZ01) | _BV(UCSZ00); 
	
	// enable RX and TX
	UCSR0B = _BV(RXEN0) | _BV(TXEN0);   
}

// sending characters
void uart_putchar(char c, FILE *stream) {
	if (c == '\n') {
		uart_putchar('\r', stream);
	}
	loop_until_bit_is_set(UCSR0A, UDRE0);
	UDR0 = c;
}

// reading characters
char uart_getchar(FILE *stream) {
	loop_until_bit_is_set(UCSR0A, RXC0);
	return UDR0;
}